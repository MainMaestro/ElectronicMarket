using ElectronicMarket.Domain.Models.Shop;

namespace ElectronicMarket.Mvc.Models
{
    public class CatalogViewModel
    {
        
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public Category CurrentCategory { get; set; }
    }
}
