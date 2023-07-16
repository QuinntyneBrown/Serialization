// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Serialization.Core.BitPacking;
using System;
using System.Buffers.Binary;


namespace Serialization.Core.Benchmarks;

[MemoryDiagnoser]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class BitPackerBenchmarks
{

    private BitPacker bitPacker;



    [GlobalSetup]
    public void Setup()
    {
        var services = new ServiceCollection();

        services.AddCoreServices();

        var serviceProvider = services.BuildServiceProvider();

        bitPacker = ActivatorUtilities.CreateInstance<BitPacker>(serviceProvider);

    }

    [Benchmark]
    public void _1Byte()
    {
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

    }
}

