// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;

namespace Serialization.Core.Strategies;

public class BoolSerializationStrategy : ISerializationStrategy<bool>
{
    public byte[] Deserialize(bool model)
    {
        throw new NotImplementedException();
    }
}

