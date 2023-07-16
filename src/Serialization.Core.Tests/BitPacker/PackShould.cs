// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Serialization.Core.Extensions;
using System.Collections;
using Xunit;

namespace Serialization.Core.Tests.BitPacker;

using BitPacker = BitPacking.BitPacker;

public class PackShould
{
    [Fact]
    public void AddExpectedBitsToBuffer()
    {
        byte @byte = 0b0100;
        
        @byte = (byte)(@byte >> 2);

    }

}


