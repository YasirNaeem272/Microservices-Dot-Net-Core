using SharedLibrary.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Events
{
    public class OrderCreatedEvent
    {
        public Guid OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public List<OrderItemDto> Items { get; set; } = new();
        public decimal TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
