using NCP.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NCP.WebUI.Services
{
    public interface IWebUserService : IBaseSessionService<AppUser>
    {
        //AppUser GetBalance();
        //void SetLoginedUser(AppUser entity);
    }
}
