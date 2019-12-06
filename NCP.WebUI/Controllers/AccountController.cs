using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NCP.Business.Interfaces;
using NCP.WebUI.Model;
using NCP.WebUI.Services;

namespace NCP.WebUI.Controllers
{
    public class AccountController : Controller
    {
        IAppUserService _userService;
        IWebUserService _webUserService;
        public AccountController(IAppUserService appUserService, IWebUserService webUserService)
        {
            _userService = appUserService;
            _webUserService = webUserService;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = _userService.Login(model.UserName, model.Password);
                if (result == null)
                {
                    ModelState.AddModelError("", "Invalid User Name or Password");
                    return View(model);
                }
                _webUserService.SetSession(result);
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        public IActionResult Logout()
        {
            _webUserService.ClearSession();
            return RedirectToAction("Login");
        }
    }
}