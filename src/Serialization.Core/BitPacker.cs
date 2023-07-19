// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Serialization.Core;

public record BitDescriptor(int Value, int Length);


public static class BitPacker
{
    public static void PackIntoBuffer(BitDescriptor[] bitDescriptors, byte[] buffer)
    {
        int index = 0;

        int bitIndex = 0;

        foreach (var bitDescriptor in bitDescriptors)
        {
            var value = bitDescriptor.Value;

            var vLength = bitDescriptor.Length;

            while (vLength > 0)
            {
                if (index >= buffer.Length)
                    return;

                int bitsToPack = 8 - bitIndex;

                if (vLength <= bitsToPack)
                {
                    var mask = (1 << vLength) - 1;

                    buffer[index] |= (byte)((value & mask) << bitIndex);

                    bitIndex += vLength;

                    if (bitIndex == 8)
                    {
                        bitIndex = 0;
                        index++;
                    }

                    vLength = -1;
                }
                else
                {
                    int mask = (1 << bitsToPack) - 1 << vLength - bitsToPack;

                    buffer[index] |= (byte)((value & mask) << bitIndex - 1);

                    bitIndex = 0;
                    index++;
                    vLength -= bitsToPack;
                }
            }
        }
    }

    public static byte[] Unpack(byte[] buffer, int take, int index = 0, int offset = 0)
    {
        var size = take + offset + 7 >>> 3;

        var source = new Span<byte>(buffer, index, size);

        var destination = new byte[take + 7 >>> 3];

        for (var i = 0; i < destination.Length; i++)
        {
            var leftMask = (1 << 8 - offset) - 1 << offset;

            var rightMask = (1 << offset) - 1;

            if (source.Length != i + 1)
            {
                destination[i] = (byte)((source[i] & leftMask) >> offset | (source[i + 1] & rightMask) << 0 - offset);
            }

            if (source.Length == i + 1)
            {
                destination[i] = (byte)((source[i] & leftMask) >> offset);
            }
        }

        return destination;
    }
}
