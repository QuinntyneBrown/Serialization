// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Xunit;
using Serialization.Core;
using Microsoft.Extensions.DependencyInjection;

namespace Serialization.Core.Tests.Binary;

using Binary = Serialization.Core.Binary;

public class WriteBoolShould
{
    [Fact]
    public void ReturnExpectedBytes()
    {
        // ARRANGE

        var services = new ServiceCollection();

        services.AddLogging();

        var serviceProvider = services.BuildServiceProvider();

        var sut = ActivatorUtilities.CreateInstance<Binary>(serviceProvider);


        // ACT

        Span<byte> bytes = new byte[1];

        sut.WriteBool(bytes, true);

        // ASSERT

        Assert.False(bytes.IsEmpty);

    }

}


