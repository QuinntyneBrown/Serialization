// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Extensions.DependencyInjection;
using System;

namespace Serialization.Core.Tests.Serializer;

using Serializer = Serialization.Core.Serializer;

public class SerializeShould
{

    [Fact]
    public void ReturnExpectedBytes()
    {
        var services = new ServiceCollection();

        var expected = new byte[] { 1 };

        var serviceProvider = services.BuildServiceProvider();

        var sut = ActivatorUtilities.CreateInstance<Serializer>(serviceProvider);

        var result = sut.Serialize(true);

        Assert.Equal(expected, result);
    }
}

