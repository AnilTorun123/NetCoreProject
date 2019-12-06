
using Microsoft.AspNetCore.Mvc;
using NCP.Business.Interfaces;
using NCP.WebUI.Model;
using System;
using System.Linq;

namespace NCP.WebUI.Controllers
{
    public class HomeController : Controller
    {
        IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index(int page = 1, int category = 0, int pageSize = 10)
        {
            var result = category > 0 ? _productService.GetAll(x => x.Category.ID == category) : _productService.GetAll();
            ProductListViewModel model = new ProductListViewModel()
            {
                PageSize = pageSize,
                Products = result.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                CurrentPage = page,
                CurrentCategory = category,
                PageCount = (int)Math.Ceiling(result.Count / (double)pageSize)


            };
            return View(model);
        }
    }
}