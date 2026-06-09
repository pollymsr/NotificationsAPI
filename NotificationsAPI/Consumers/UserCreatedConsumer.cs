using System;
using System.Threading.Tasks;
using MassTransit;
using FiapCloudGames.Events;

namespace FiapCloudGames.Consumers;

public class UserCreatedConsumer : IConsumer<UserCreatedEvent>
{
    public Task Consume(ConsumeContext<UserCreatedEvent> context)
    {
        Console.WriteLine($"E-mail enviado para {context.Message.Email}...");
        return Task.CompletedTask;
    }
}
