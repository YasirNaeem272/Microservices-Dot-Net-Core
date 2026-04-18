using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderService.Models;
using SharedLibrary.Events;

namespace OrderService.Controllers
{
    [Route("api/Order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        IPublishEndpoint _publishEndpoint;
        public OrderController(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }
        //[HttpPost]
        //public async Task<IActionResult> CreateOrder(Order order)
        //{
        //    await _publishEndpoint.Publish<Order>(order);
        //    return Ok();
        //}
        [HttpPost]
        public async Task<IActionResult> CreateOrder(OrderCreatedEvent order)
        {
            order.OrderId = Guid.NewGuid();
            order.CreatedAt = DateTime.UtcNow;

            // Publish to RabbitMQ → InventoryService will consume
            await _publishEndpoint.Publish<OrderCreatedEvent>(order);

            return Ok(new { message = "Order placed!", orderId = order.OrderId });
        }
    }
}
