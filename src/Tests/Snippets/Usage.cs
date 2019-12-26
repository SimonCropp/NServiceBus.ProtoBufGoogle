using NServiceBus;
using NServiceBus.ProtoBufGoogle;

class Usage
{
    Usage(EndpointConfiguration configuration)
    {
        #region ProtoBufSerialization

        configuration.UseSerialization<ProtoBufGoogleSerializer>();

        #endregion
    }

    void ContentTypeKey(EndpointConfiguration configuration)
    {
        #region ProtoBufContentTypeKey

        var serialization = configuration.UseSerialization<ProtoBufGoogleSerializer>();
        serialization.ContentTypeKey("custom-key");

        #endregion
    }
}