// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;

namespace Serialization.Core;

public interface ISerializationStrategy<T> { 

    byte[] Deserialize(T model);
}

