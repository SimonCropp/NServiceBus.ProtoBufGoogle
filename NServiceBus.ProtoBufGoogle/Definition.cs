using System;
using NServiceBus.MessageInterfaces;
using NServiceBus.Serialization;
using NServiceBus.Settings;

namespace NServiceBus.ProtoBufGoogle
{

    /// <summary>
    /// Defines the capabilities of the ProtoBuf serializer
    /// </summary>
    public class ProtoBufGoogleSerializer : SerializationDefinition
    {
        /// <summary>
        /// <see cref="SerializationDefinition.Configure"/>
        /// </summary>
        public override Func<IMessageMapper, IMessageSerializer> Configure(ReadOnlySettings settings)
        {
            Guard.AgainstNull(settings, nameof(settings));
            return mapper =>
            {
                var contentTypeKey = settings.GetContentTypeKey();
                return new MessageSerializer(contentTypeKey);
            };
        }
    }
}