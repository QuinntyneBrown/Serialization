// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Serialization.Core.Extensions;

namespace Serialization.Core.BitPacking;

public class ByteDescriptor
{
    public ByteDescriptor(int byteStartIndex, int bitStartIndex, int totalBitLength, byte[] value)
    {
        Value = new();

        int bits = 0;

        int bytes = 0;

        foreach (byte @byte in value)
        {
            var bitArray = @byte.ToBitArray().RemoveLeadingZeroElements();

            if (bits + 8 < totalBitLength)
            {
                Value.Add(new(byteStartIndex + bytes, bits == 0 ? bitStartIndex : 0, bitArray));

                bits += bitArray.Length;

                bytes++;
            }
            else
            {
                Value.Add(new(byteStartIndex + bytes, bits == 0 ? bitStartIndex : 0, bitArray));
            }
        }
    }

    public List<BitDescriptor> Value { get; }
}

