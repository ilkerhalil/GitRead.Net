﻿namespace GitRead.Net.Data
{
    internal enum PackFileObjectType : byte
    {
        Commit = 0b0000_0001,
        Tree = 0b0000_0010,
        Blob = 0b0000_0011,
        Tag = 0b0000_0100,
        ObjOfsDelta = 0b0000_0110, //DELTA_ENCODED object w/ offset to base
        ObjRefDelta = 0b0000_0111 //DELTA_ENCODED object w/ base BINARY_OBJ_ID */
    }
}