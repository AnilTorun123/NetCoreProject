using NCP.Business.Interfaces;
using NCP.DataAccessLayer.EntityProvider.Repository.Interfaces;
using NCP.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace NCP.Business.Concrete.EntityService
{
    public class CartItemService : ICartItemService
    {
        ICartItemRepository _cartItemRepository;
        public CartItemService(ICartItemRepository cartItemRepository)
        {
            _cartItemRepository = cartItemRepository;
        }
        public int Create(CartItem entity)
        {
            return _cartItemRepository.Add(entity);
        }

        public int Edit(CartItem entity)
        {
            return _cartItemRepository.Update(entity);
        }

        public List<CartItem> GetAll(Expression<Func<CartItem, bool>> whereCond = null, int start = 0, int take = 0)
        {
            throw new NotImplementedException();
        }

        public List<CartItem> GetByCart(int cartID)
        {
            return _cartItemRepository.GetList(x => x.CartID == cartID);
        }

        public CartItem GetSingle(Expression<Func<CartItem, bool>> whereCond)
        {
            return _cartItemRepository.GetSingle(whereCond);
        }

        public CartItem GetSingle(int entityID)
        {
            return _cartItemRepository.GetSingle(x => x.ID == entityID);
        }

        public int Remove(CartItem entity)
        {
            return _cartItemRepository.Delete(entity);
        }
    }
}
