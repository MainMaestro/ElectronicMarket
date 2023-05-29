using ElectronicMarket.Mvc.Data;
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



        public IActionResult Index(int id)
        {
            var Products = context.Products.Where(c => c.CategoryId == id).ToArray();
            return View(Products);
        }
    }
}



