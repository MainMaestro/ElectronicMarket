using Microsoft.AspNetCore.Mvc;

namespace ElectronicMarket.Mvc.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index(int id)
        {
            return View();
        }
    }
}
