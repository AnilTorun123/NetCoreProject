using NCP.Business.Interfaces;
using NCP.DataAccessLayer.EntityProvider.Repository.Interfaces;
using NCP.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace NCP.Business.Concrete.EntityService
{
    public class ProductService : IProductService
    {
        IProductRepository dbModel;
        public ProductService(IProductRepository productRepository)
        {
            dbModel = productRepository;
        }
        public int Create(Product entity)
        {
            return dbModel.Add(entity);
        }

        public int Edit(Product entity)
        {
            return dbModel.Update(entity);
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> whereCond = null, int start = 0, int take = 0)
        {
            return dbModel.GetList(whereCond, start, take);
        }

        public Product GetSingle(Expression<Func<Product, bool>> whereCond)
        {
            return dbModel.GetSingle(whereCond);
        }

        public Product GetSingle(int entityID)
        {
            return dbModel.GetSingle(x => x.ID == entityID);
        }

        public int Remove(Product entity)
        {
            return dbModel.Delete(entity);
        }
    }
}
