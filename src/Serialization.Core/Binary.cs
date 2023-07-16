// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Extensions.Logging;

namespace Serialization.Core;

public class Binary: IBinary
{
    private readonly ILogger<Binary> _logger;

    public Binary(ILogger<Binary> logger){
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public void WriteBool(Span<byte> destination, bool value)
    {
        destination[0] = (byte)(value ? 1 : 0);
    }
}


