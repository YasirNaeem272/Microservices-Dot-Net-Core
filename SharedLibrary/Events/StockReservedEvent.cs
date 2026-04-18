using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Events
{
    public class StockReservedEvent
    {
        public Guid OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsReserved { get; set; }
    }
}
