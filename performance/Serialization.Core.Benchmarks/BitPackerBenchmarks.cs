// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Serialization.Core.BitPacking;
using System.Buffers.Binary;

namespace Serialization.Core.Benchmarks;

[MemoryDiagnoser]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class BitPackerBenchmarks {

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
        var inputBuffer = new byte[8];

        var outBuffer = new byte[8];

        BinaryPrimitives.WriteUInt64BigEndian(inputBuffer, 9_223_372_036_854_775_807);

        bitPacker.Pack(outBuffer, new ByteDescriptor(0, 0, 64, inputBuffer));

    }
}

