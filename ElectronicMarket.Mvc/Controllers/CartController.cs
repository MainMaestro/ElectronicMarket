using ElectronicMarket.Mvc.Managers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicMarket.Mvc.Controllers
{
    public class CartController : Controller
    {
        private readonly CartManager manager;

        [Authorize]
        public IActionResult Index()
        {
            var cart = manager.GetCart(User);
            return View(cart);
        }
        public CartController(CartManager manager)
        {
            this.manager = manager;
        }
    }
}
