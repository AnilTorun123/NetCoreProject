using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using NCP.WebUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NCP.WebUI.ViewComponents
{
    public class CartSummaryViewComponent : ViewComponent
    {
        ICartSessionService _cartService;
        public CartSummaryViewComponent(ICartSessionService cartService)
        {
            _cartService = cartService;
        }

        public ViewViewComponentResult Invoke()
        {
            return View(_cartService.GetSession());
        }
    }
}
