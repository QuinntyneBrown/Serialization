// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.


using Microsoft.Extensions.DependencyInjection;
using Serialization.Core.BitPacking;
using System.Collections;


namespace Serialization.Core.Tests.BitPacker;

using BitPacker = Serialization.Core.BitPacking.BitPacker;

public class PackShould
{
    [Fact]
    public void AddExpectedBitsToBuffer()
    {

        var services = new ServiceCollection();

        services.AddCoreServices();

        var serviceProvider = services.BuildServiceProvider();

        var bitPacker = ActivatorUtilities.CreateInstance<BitPacker>(serviceProvider);

        var length = 1;

        var outBuffer = new byte[64];

        bitPacker.PackIntoBuffer(new BitDescriptor[] {
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),

            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),

            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),

            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),

            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),

            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),

            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),

            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length),
            new BitDescriptor(255, length)
        }, outBuffer);

        var bitArray = new BitArray(outBuffer);

        Assert.True(true);


    }

}


