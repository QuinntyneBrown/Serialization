// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Extensions.DependencyInjection;
using Serialization.Core.BitPacking;
using System.Buffers.Binary;

namespace Serialization.Core.Tests.BitPacker;

using BitPacker = BitPacking.BitPacker;

public class UnpackShould
{
    [Fact]
    public void AddExpectedBitsToBitDescriptor()
    {

        // ARRANGE

        byte[] buffer = new byte[1];

        var byteDescriptor = new ByteDescriptor(0, 2, 1, new byte[] { 1 });

        var bitDescriptor = new BitDescriptor(0, 2, new(1));

        var services = new ServiceCollection();

        services.AddCoreServices();

        var serviceProvider = services.BuildServiceProvider();

        var bitPacker = ActivatorUtilities.CreateInstance<BitPacker>(serviceProvider);

        // ACT

        var inputBuffer = new byte[8];

        var outBuffer = new byte[8];

        BinaryPrimitives.WriteUInt64BigEndian(inputBuffer, 9_223_372_036_854_775_807);

        bitPacker.Pack(outBuffer, new ByteDescriptor(0, 0, 64, inputBuffer));



        bitPacker.Pack(buffer, byteDescriptor);

        bitPacker.Unpack(buffer, bitDescriptor);

        // ASSERT

        Assert.True(bitDescriptor.Value[0]);
    }

}


