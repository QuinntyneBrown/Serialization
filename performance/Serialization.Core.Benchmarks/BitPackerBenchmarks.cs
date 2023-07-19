// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Buffers.Binary;


namespace Serialization.Core.Benchmarks;

[MemoryDiagnoser]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class BitPackerBenchmarks
{
    [GlobalSetup]
    public void Setup()
    {


    }

    [Benchmark]
    public void _1Byte()
    {
        var length = 1;

        var outBuffer = new byte[64];

        BitPacker.PackIntoBuffer(new BitDescriptor[] {
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

