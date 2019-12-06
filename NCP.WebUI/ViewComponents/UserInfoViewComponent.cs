using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using NCP.WebUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NCP.WebUI.ViewComponents
{
    public class UserInfoViewComponent : ViewComponent
    {
        IWebUserService _webUserService;
        public UserInfoViewComponent(IWebUserService webUserService)
        {
            _webUserService = webUserService;
        }

        public ViewViewComponentResult Invoke()
        {
            return View(_webUserService.GetSession());
        }
    }
}
