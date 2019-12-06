using NCP.Business.Interfaces;
using NCP.DataAccessLayer.EntityProvider.Repository.Interfaces;
using NCP.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace NCP.Business.Concrete.EntityService
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepository dbModel;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            dbModel = categoryRepository;
        }
        public int Create(Category entity)
        {
            return dbModel.Add(entity);
        }

        public int Edit(Category entity)
        {
            return dbModel.Update(entity);
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> whereCond = null, int start = 0, int take = 0)
        {
            return dbModel.GetList(whereCond, start, take);
        }

        public Category GetSingle(Expression<Func<Category, bool>> whereCond)
        {
            return dbModel.GetSingle(whereCond);
        }

        public Category GetSingle(int entityID)
        {
            return dbModel.GetSingle(x => x.ID == entityID);
        }

        public int Remove(Category entity)
        {
            return dbModel.Delete(entity);
        }
    }
}
