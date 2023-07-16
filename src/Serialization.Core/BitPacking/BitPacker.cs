// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Serialization.Core.BitPacking;

public record BitDescriptor(int Value, int Length);


public class BitPacker: IBitPacker
{
    public void PackIntoBuffer(BitDescriptor[] bitDescriptors, byte[] buffer)
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
                    int mask = ((1 << bitsToPack) - 1) << (vLength - bitsToPack);

                    buffer[index] |= (byte)((value & mask) << bitIndex - 1);

                    bitIndex = 0;
                    index++;
                    vLength -= bitsToPack;
                }
            }
        }
    }
}
