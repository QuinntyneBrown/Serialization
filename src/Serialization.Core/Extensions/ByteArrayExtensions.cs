// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections;

namespace Serialization.Core.Extensions;

public static class ByteArrayExtensions
{
    public static BitArray ToBitArray(this byte value) => new BitArray(new[] { value });

}

