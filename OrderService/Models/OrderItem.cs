namespace OrderService.Models
{
    public class OrderItem
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid OrderId { get; set; }       // FK
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitPrice1 { get; set; }
        public decimal UnitPrice12 { get; set; }
        public decimal UnitPrice1w2 { get; set; }

        // Navigation
        public Order Order { get; set; } = null!;
    }
}
