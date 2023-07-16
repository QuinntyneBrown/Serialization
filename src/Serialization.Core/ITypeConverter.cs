// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Serialization.Core;

public interface ITypeConverter
{
    void WriteBool(Span<byte> destination, bool value);
    bool ReadBool(byte[] buffer);

}


