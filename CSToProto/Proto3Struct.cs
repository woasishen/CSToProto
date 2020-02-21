using System;
using System.Collections.Generic;
using Google.Protobuf;
using Proto.Interfaces.Entities;

namespace Proto
{
    public static class Proto3Struct
    {
        public static readonly Dictionary<Type, string> AllProto3Struct = 
            new Dictionary<Type, string>
            {
                {typeof(Int16),"sint32" },
                {typeof(Int32),"sint32" },
                {typeof(Int64),"sint64" },
                {typeof(UInt16),"uint32" },
                {typeof(UInt32),"uint32" },
                {typeof(UInt64),"uint64" },
                {typeof(bool),"bool" },
                {typeof(double),"double" },
                {typeof(float),"float" },
                {typeof(string),"string" },
                {typeof(ByteString),"bytes" },
            };
        public static readonly List<Type> GeneAddTypesEx = new List<Type>
        {
//            typeof(User[]),
        };
    }
}
