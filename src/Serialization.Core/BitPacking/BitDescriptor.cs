// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections;

namespace Serialization.Core.BitPacking;

public record BitDescriptor(int ByteStartIndex, int BitStartIndex, BitArray Value);

