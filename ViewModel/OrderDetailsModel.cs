using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrocerySotre.ViewModel
{
    public class OrderDetailsModel
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public Guid ItemId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total { get; set; }
    }
}