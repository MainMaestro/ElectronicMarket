using ElectronicMarket.Mvc.Managers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicMarket.Mvc.Controllers
{
    public class CartController : Controller
    {
        private readonly CartManager _cartManager;
        private readonly OrderManager _orderManager;

        public CartController(CartManager cartManager, OrderManager orderManager)
        {
            _cartManager = cartManager;
            _orderManager = orderManager;
        }

        [Authorize]
        public IActionResult Index()
        {
            var cart = _cartManager.GetCart(User);
            return View(cart);
        }
        [HttpPost, Authorize]
        public IActionResult CreateOrder()
        {
            _orderManager.CreateOrder(_cartManager.GetCart(User));
            return RedirectToAction("Index");
        }
        [HttpPost, Authorize]
        public IActionResult RemoveItem(string productId)
        {
            _cartManager.RemoveProduct(User, productId);
            return RedirectToAction("Index");
        }
        [HttpPost, Authorize]
        public IActionResult AddItem(string productId)
        {
            _cartManager.AddProduct(User, productId);
            return RedirectToAction("Index");
        }
    }
}
