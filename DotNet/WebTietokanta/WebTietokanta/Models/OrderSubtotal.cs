using System;
using System.Collections.Generic;

namespace WebTietokanta.Models
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
