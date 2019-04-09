using System.Collections.Generic;

namespace FullStak.Lotfi.Shop.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public List<Product> Products { get; set; }
    }
}
