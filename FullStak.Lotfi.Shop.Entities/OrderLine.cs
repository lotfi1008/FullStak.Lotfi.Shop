namespace FullStak.Lotfi.Shop.Entities
{
    public class OrderLine
    {
        public int OrderLineId { get; set; }
        public int ProductCount { get; set; }
        public decimal UnitPrice { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
