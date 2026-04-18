using InventoryService.Models;
using MassTransit;
using MassTransit.ConsumeConfigurators;
using MassTransit.Riders;
using SharedLibrary.Events;

namespace InventoryService
{
    public class OrderConsumer : IConsumer<OrderCreatedEvent>
    {
        //public async Task Consume(ConsumeContext<Order> context)
        //{
        //    var msg = context.Message;
        //    Console.WriteLine($"Order received for Product ID: {msg.OrderId}");
        //    await Task.CompletedTask;
        //    // await Console.Out.WriteLineAsync(msg.Details);
        //}
        public async Task Consume(ConsumeContext<OrderCreatedEvent> context)
        {
            var order = context.Message;

            Console.WriteLine($"📦 Order received: {order.OrderId}");
            Console.WriteLine($"   Customer: {order.CustomerId}");
            Console.WriteLine($"   Amount: {order.TotalAmount}");

            // TODO: Check stock in DB
            // TODO: Publish StockReservedEvent back
        }
    }
}
