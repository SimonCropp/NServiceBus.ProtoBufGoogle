using System;
using System.Threading.Tasks;
using NServiceBus;
using NServiceBus.ProtoBufGoogle;
using Sample;

class Program
{
    static async Task Main()
    {
        var configuration = new EndpointConfiguration("ProtoBufGoogleSerializerSample");
        configuration.UseSerialization<ProtoBufGoogleSerializer>();
        configuration.UseTransport<LearningTransport>();
        configuration.UsePersistence<LearningPersistence>();

        var endpoint = await Endpoint.Start(configuration);
        var message = new MyMessage
        {
            Name = "immediate",
        };
        await endpoint.SendLocal(message);

        await endpoint.ScheduleEvery(
                timeSpan: TimeSpan.FromSeconds(5),
                task: pipelineContext =>
                {
                    var delayed = new MyMessage
                    {
                        Name = "delayed",
                    };
                    return pipelineContext.SendLocal(delayed);
                });
        Console.WriteLine("\r\nPress any key to stop program\r\n");
        Console.Read();
        await endpoint.Stop();
    }
}