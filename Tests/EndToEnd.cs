using System.Threading;
using System.Threading.Tasks;
using NServiceBus;
using NServiceBus.ProtoBufGoogle;
using Tests;
using Xunit;

public class EndToEnd
{
    static ManualResetEvent manualResetEvent = new ManualResetEvent(false);

    [Fact]
    public async Task Write()
    {
        var configuration = new EndpointConfiguration("EndToEnd");
        configuration.UsePersistence<LearningPersistence>();
        configuration.UseTransport<LearningTransport>();
        configuration.UseSerialization<ProtoBufGoogleSerializer>();
        var typesToScan = TypeScanner.NestedTypes<EndToEnd>();
        configuration.SetTypesToScan(typesToScan);
        var endpointInstance = await Endpoint.Start(configuration)
            .ConfigureAwait(false);
        var message = new MessageToSend
        {
            Property = "PropertyValue"
        };
        await endpointInstance.SendLocal(message)
            .ConfigureAwait(false);
        manualResetEvent.WaitOne();
        await endpointInstance.Stop().ConfigureAwait(false);
    }

    class MessageHandler :
        IHandleMessages<MessageToSend>
    {
        public Task Handle(MessageToSend message, IMessageHandlerContext context)
        {
            manualResetEvent.Set();
            return Task.CompletedTask;
        }
    }
}