// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Serialization.Core;

public interface IBitPacker
{
    void PackIntoBuffer(BitDescriptor[] bitDescriptors, byte[] buffer);

    byte[] Unpack(byte[] source, int vLength, int index = 0, int bitIndex = 0);
}

