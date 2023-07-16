// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Serialization.Core.BitPacking;

public interface IBitPacker
{
    void Pack(byte[] buffer, ByteDescriptor[] byteDescriptors);
    void Unpack(byte[] buffer, BitDescriptor bitDescriptor);
    void Pack(byte[] buffer, ByteDescriptor byteDescriptor);
}

