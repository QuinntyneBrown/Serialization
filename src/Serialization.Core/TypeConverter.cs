// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Extensions.Logging;

namespace Serialization.Core;

public class TypeConverter : ITypeConverter
{
    private readonly ILogger<TypeConverter> _logger;

    public TypeConverter(ILogger<TypeConverter> logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public bool ReadBool(byte[] buffer) => Convert.ToBoolean(buffer);

    public void WriteBool(Span<byte> destination, bool value)
    {
        destination[0] = (byte)(value ? 1 : 0);
    }
}


