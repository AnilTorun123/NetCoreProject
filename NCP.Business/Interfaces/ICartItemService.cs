using NCP.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace NCP.Business.Interfaces
{
    public interface ICartItemService : IBaseService<CartItem>
    {
        List<CartItem> GetByCart(int cartID);
    }
}
