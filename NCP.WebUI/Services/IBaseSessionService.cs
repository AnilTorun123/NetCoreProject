using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NCP.WebUI.Services
{
    public interface IBaseSessionService<T> where T : class, new ()
    {
        T GetSession();
        void SetSession(T entity);
        void ClearSession();
    }
}
