// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Serialization.Core.BitPacking;
using System.Collections;

namespace Serialization.Core.Extensions;

public static class BitArrayExtensions
{
    public static void MergeAt(this BitArray destination, BitArray source, int start)
    {
        for (var i = start; i < source.Length + start; i++)
        {
            destination[i] = source[i - start];
        }
    }

    public static void MergeAt(this BitArray destination, BitArray source, int start, int stop)
    {
        for (var i = start; i < stop; i++)
        {
            destination[i] = source[i - start];
        }
    }

    public static void ExtractAt(this BitArray destination, BitArray source, int offset)
    {
        for (var i = 0; i < destination.Length; i++)
        {
            destination[i] = source[i + offset];
        }
    }

    public static void ExtractAt(this byte[] buffer, BitDescriptor bitDescriptor)
    {
        int bits = 0;
        foreach(var @byte in buffer)
        {
            var b = @byte << bitDescriptor.BitStartIndex;
        }
    }

    public static BitArray RemoveLeadingZeroElements(this BitArray bitArray)
    {
        int firstNonZero = -1;
        for (int i = bitArray.Length - 1; i >= 0; i--)
        {
            if (bitArray[i])
            {
                firstNonZero = i;
                break;
            }
        }

        BitArray newBitArray = new BitArray(firstNonZero + 1);
        for (int i = 0; i <= firstNonZero; i++)
        {
            newBitArray[i] = bitArray[i];
        }

        return newBitArray;
    }
}

