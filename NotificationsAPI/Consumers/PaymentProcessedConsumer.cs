using System;
using System.Threading.Tasks;
using MassTransit;
using FiapCloudGames.Events;

namespace FiapCloudGames.Consumers;

public class PaymentProcessedConsumer : IConsumer<PaymentProcessedEvent>
{
    public Task Consume(ConsumeContext<PaymentProcessedEvent> context)
    {
        if (context.Message.Status == "Approved")
        {
            Console.WriteLine($"Purchase confirmation email sent for User {context.Message.UserId} and Game {context.Message.GameId}");
        }
        return Task.CompletedTask;
    }
}
