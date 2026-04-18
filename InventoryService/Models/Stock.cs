namespace InventoryService.Models
{
    public class Stock
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid ProductId { get; set; }
        public int AvailableQuantity { get; set; }
        public int ReservedQuantity { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
