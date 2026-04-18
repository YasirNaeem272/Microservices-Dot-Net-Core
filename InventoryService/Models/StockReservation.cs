namespace InventoryService.Models
{
    public class StockReservation
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; } = "Reserved"; // Reserved / Failed
        public DateTime ReservedAt { get; set; } = DateTime.UtcNow;
    }
}
