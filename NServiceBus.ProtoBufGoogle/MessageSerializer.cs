using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Google.Protobuf;
using NServiceBus;
using NServiceBus.ProtoBufGoogle;
using NServiceBus.Serialization;

class MessageSerializer : IMessageSerializer
{
    ConcurrentDictionary<Type, MessageParser> parsers = new ConcurrentDictionary<Type, MessageParser>();

    public MessageSerializer(string contentType)
    {
        if (contentType == null)
        {
            ContentType = "protobuf";
        }
        else
        {
            ContentType = contentType;
        }
    }

    public void Serialize(object message, Stream stream)
    {
        var messageType = message.GetType();
        if (messageType.Name.EndsWith("__impl"))
        {
            throw new Exception("Interface based message are not supported. Create a class that implements the desired interface.");
        }

        var task = message as ScheduledTask;
        if (task != null)
        {
            var wrapper = ScheduledTaskHelper.ToWrapper(task);
            wrapper.WriteTo(stream);
            return;
        }

        var protoMessage = message as Google.Protobuf.IMessage;
        if (protoMessage != null)
        {
            protoMessage.WriteTo(stream);
            return;
        }

        throw new Exception($"Can only serialize {nameof(Google.Protobuf.IMessage)}.");
    }

    public object[] Deserialize(Stream stream, IList<Type> messageTypes)
    {
        var messageType = messageTypes.First();
        if (messageType.IsScheduleTask())
        {
            var scheduledTaskWrapper = ScheduledTaskWrapper.Parser.ParseFrom(stream);
            var scheduledTask = ScheduledTaskHelper.FromWrapper(scheduledTaskWrapper);
            return new[] {scheduledTask};
        }
        var parser = parsers.GetOrAdd(messageType, type =>
        {
            var parserProperty = type.GetProperty("Parser", BindingFlags.Static| BindingFlags.Public);
            return (MessageParser) parserProperty.GetValue(null);
        });

        var message = parser.ParseFrom(stream);
        return new object[] {message};
    }

    public string ContentType { get; }
}