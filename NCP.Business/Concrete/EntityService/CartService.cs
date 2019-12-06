using NCP.Business.Interfaces;
using NCP.DataAccessLayer.EntityProvider.Repository.Interfaces;
using NCP.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace NCP.Business.Concrete.EntityService
{
    public class CartService : ICartService
    {
        ICartRepository _cartRepository;
        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public void AddToCart(Cart cart, Product product)
        {
            var cartItem = cart.CartItems.FirstOrDefault(x => x.Product.ID == product.ID);
            if (cartItem == null)
            {
                cartItem = new CartItem()
                {
                    Product = product,
                    Quantity = 0
                };
                cart.CartItems.Add(cartItem);
            }
            cartItem.Quantity++;

        }

        public int Create(Cart entity)
        {
            return _cartRepository.Add(entity);
        }

        public int Edit(Cart entity)
        {
            return _cartRepository.Update(entity);
        }

        public List<Cart> GetAll(Expression<Func<Cart, bool>> whereCond = null, int start = 0, int take = 0)
        {
            throw new NotImplementedException();
        }

        public Cart GetByUser(int userID)
        {
            return _cartRepository.GetSingle(x => x.UserID == userID && !x.IsSold);
        }

        public Cart GetSingle(Expression<Func<Cart, bool>> whereCond)
        {
            return _cartRepository.GetSingle(whereCond);
        }

        public Cart GetSingle(int entityID)
        {
            return _cartRepository.GetSingle(x => x.ID == entityID);
        }

        public int Remove(Cart entity)
        {
            return _cartRepository.Delete(entity);
        }

        public void RemoveFromCart(Cart cart, Product product)
        {
            var cartItem = cart.CartItems.FirstOrDefault(x => x.Product.ID == product.ID);
            if (cartItem != null)
            {
                cart.CartItems.Remove(cartItem);
            }
        }
    }
}
