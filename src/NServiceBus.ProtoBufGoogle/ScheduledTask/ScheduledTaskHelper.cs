using System;
using NServiceBus;
using NServiceBus.ProtoBufGoogle;

static class ScheduledTaskHelper
{
    static Type scheduledTaskType = typeof(ScheduledTask);

    public static bool IsScheduleTask(this Type messageType)
    {
        return messageType == scheduledTaskType;
    }

    public static ScheduledTaskWrapper ToWrapper(ScheduledTask target)
    {
        return new ScheduledTaskWrapper
        {
            TaskId = target.TaskId.ToString(),
            Name = target.Name,
            Every = target.Every.ToString()
        };
    }

    public static object FromWrapper(ScheduledTaskWrapper target)
    {
        return new ScheduledTask
        {
            TaskId = Guid.Parse(target.TaskId),
            Name = target.Name,
            Every = TimeSpan.Parse(target.Every)
        };
    }
}