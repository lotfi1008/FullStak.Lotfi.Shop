using System;
using System.Collections.Generic;

namespace FullStak.Lotfi.Shop.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public List<OrderLine> OrderLines{ get; set; }
    }
}
