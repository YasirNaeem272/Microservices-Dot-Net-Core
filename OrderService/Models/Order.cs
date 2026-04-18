namespace OrderService.Models
{
    public class Order
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid CustomerId { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } = "Pending";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation
        public List<OrderItem> Items { get; set; } = new();
    }
}
