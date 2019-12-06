using NCP.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace NCP.Business.Interfaces
{
    public interface ICartService : IBaseService<Cart>
    {
        Cart GetByUser(int userID);
        void AddToCart(Cart cart, Product product);
        void RemoveFromCart(Cart cart, Product product);
    }
}
