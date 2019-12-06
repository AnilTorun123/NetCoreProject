using Microsoft.AspNetCore.Http;
using NCP.WebUI.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NCP.WebUI.Services
{
    public class BaseSessionService<T> : IBaseSessionService<T> where T : class, new()
    {
        protected IHttpContextAccessor _httpContextAccessor;
        protected string key;
        public BaseSessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void ClearSession()
        {
            _httpContextAccessor.HttpContext.Session.Remove(key);
        }

        public T GetSession()
        {
            T model = _httpContextAccessor.HttpContext.Session.GetObject<T>(key);
            if (model == null)
            {
                _httpContextAccessor.HttpContext.Session.SetObject(key, new T());
                model = _httpContextAccessor.HttpContext.Session.GetObject<T>(key);
            }
            return model;

        }

        public void SetSession(T entity)
        {
            _httpContextAccessor.HttpContext.Session.SetObject(key, entity);
        }

    }
}
