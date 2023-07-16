// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections;
using Serialization.Core.Extensions;

namespace Serialization.Core.BitPacking;

public class BitPacker : IBitPacker
{
    public void Pack(byte[] buffer, ByteDescriptor[] byteDescriptors)
    {
        foreach (var byteDescriptor in byteDescriptors)
        {
            foreach (var bitDescriptor in byteDescriptor.Value)
            {

                Pack(buffer, bitDescriptor);
            }
        }
    }

    public void Pack(byte[] buffer, ByteDescriptor byteDescriptor)
    {
        foreach (var bitDescriptor in byteDescriptor.Value)
        {
            Pack(buffer, bitDescriptor);
        }
    }

    internal void Pack(byte[] buffer, BitDescriptor bitDescriptor)
    {
        var currentValue = buffer[bitDescriptor.ByteStartIndex].ToBitArray();

        if (bitDescriptor.BitStartIndex == 0 && bitDescriptor.Value.Length <= 8)
        {
            bitDescriptor.Value.CopyTo(buffer, bitDescriptor.ByteStartIndex);
        }

        if (bitDescriptor.Value.Length + bitDescriptor.BitStartIndex <= 8)
        {
            currentValue.MergeAt(bitDescriptor.Value, bitDescriptor.BitStartIndex);

            currentValue.CopyTo(buffer, bitDescriptor.ByteStartIndex);
        }

        if (bitDescriptor.Value.Length + bitDescriptor.BitStartIndex > 8)
        {
            currentValue.MergeAt(bitDescriptor.Value, bitDescriptor.BitStartIndex, 8);

            currentValue.CopyTo(buffer, bitDescriptor.ByteStartIndex);

            var remainder = new BitArray(8 - bitDescriptor.BitStartIndex);

            remainder.MergeAt(bitDescriptor.Value, 0, 8 - bitDescriptor.BitStartIndex);

            Pack(buffer, new BitDescriptor(bitDescriptor.ByteStartIndex + 1, 0, remainder));
        }
    }

    public void Unpack(byte[] buffer, BitDescriptor bitDescriptor)
    {

        var startIndex = bitDescriptor.ByteStartIndex * 8 + bitDescriptor.BitStartIndex;

        bitDescriptor.Value.ExtractAt(new BitArray(buffer), startIndex);
    }
}

