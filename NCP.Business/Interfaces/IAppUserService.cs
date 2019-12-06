using NCP.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace NCP.Business.Interfaces
{
    public interface IAppUserService : IBaseService<AppUser>
    {
        AppUser Login(string UserName, string Pass);
    }
}
