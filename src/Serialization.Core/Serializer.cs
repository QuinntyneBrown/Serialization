// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Extensions.Logging;

namespace Serialization.Core;

public class Serializer : ISerializer
{
    private readonly ILogger<Serializer> _logger;

    public Serializer(ILogger<Serializer> logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public byte[] Serialize<T>(T model)
    {
        _logger.LogInformation("Serialize");

        throw new NotImplementedException();
    }

}


