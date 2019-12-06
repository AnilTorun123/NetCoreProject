using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using NCP.Model.Concrete;
using NCP.WebUI.Extensions;

namespace NCP.WebUI.Services
{
    public class CartSessionService : BaseSessionService<Cart>, ICartSessionService
    {
        public CartSessionService(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
            key = "_cart";
        }
    }
}
