using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using NCP.Model.Concrete;
using NCP.WebUI.Extensions;

namespace NCP.WebUI.Services
{
    public class WebUserService : BaseSessionService<AppUser>, IWebUserService
    {
        public WebUserService(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
            key = "_user";
        }
    }
    //{
    //    IHttpContextAccessor _httpContAcc;
    //    public WebUserService(IHttpContextAccessor httpContextAccessor)
    //    {
    //        _httpContAcc = httpContextAccessor;
    //    }

    //    public AppUser GetLoginedUser()
    //    {
    //        AppUser logined = _httpContAcc.HttpContext.Session.GetObject<AppUser>("_user");
    //        if(logined==null)
    //        {
    //            _httpContAcc.HttpContext.Session.SetObject("_user", new AppUser());
    //            logined= _httpContAcc.HttpContext.Session.GetObject<AppUser>("_user");
    //        }
    //        return logined;
    //    }

    //    public void SetLoginedUser(AppUser entity)
    //    {
    //        _httpContAcc.HttpContext.Session.SetObject("_user", entity);

    //    }
    //}
}
