﻿using System;
using System.IO;

namespace SimpleRpc.Serialization
{
    public interface IMessageSerializer
    {
        string ContentType { get; }

        void Serialize(object message, Stream stream, Type type);

        object Deserialize(Stream stream, Type type);
    }
}
