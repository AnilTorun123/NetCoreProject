using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NCP.Business.Interfaces;
using NCP.WebUI.Services;

namespace NCP.WebUI.Controllers
{
    public class CartController : Controller
    {
        ICartService _cartService;
        IProductService _productService;
        ICartSessionService _cartSessionService;
        public CartController(IProductService productService, ICartSessionService cartSessionService, ICartService cartService)
        {
            _productService = productService;
            _cartSessionService = cartSessionService;
            _cartService = cartService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult AddToCart(int id)
        {
            var product = _productService.GetSingle(id);
            var cart = _cartSessionService.GetSession();
            _cartService.AddToCart(cart, product);
            _cartSessionService.SetSession(cart);
            TempData.Add("message", string.Format("{0} was successfully added to cart",product.Name));
            return RedirectToAction("Index", "Home");

        }

        public ActionResult Remove(int id)
        {
            var product = _productService.GetSingle(id);
            var cart = _cartSessionService.GetSession();
            _cartService.RemoveFromCart(cart, product);
            _cartSessionService.SetSession(cart);
            TempData.Add("message", string.Format("{0} was successfully deleted from cart", product.Name));
            return RedirectToAction("Index", "Home");

        }
    }
}