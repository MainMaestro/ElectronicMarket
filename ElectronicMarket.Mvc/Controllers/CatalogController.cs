using ElectronicMarket.Mvc.Data;
using ElectronicMarket.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicMarket.Mvc.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ApplicationDbContext context;

        public CatalogController(ApplicationDbContext context)
        {
            this.context = context;
        }



        public IActionResult Index(string id)
        {
            var products = context.Products.Where(c => c.CategoryId == id).ToArray();
            var categories = context.Categories.Where(c => c.Id != id).ToArray();
            var category = context.Categories.FirstOrDefault(c => c.Id == id);
            var viewModel=new CatalogViewModel{Products = products, Categories=categories, CurrentCategory= category!};
            return View(viewModel);
        }
    }
}



