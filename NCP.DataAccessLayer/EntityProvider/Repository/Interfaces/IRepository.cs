using NCP.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace NCP.DataAccessLayer.EntityProvider.Repository.Interfaces
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        List<T> GetList(Expression<Func<T, bool>> whereCond = null, int start = 0, int take = 0);
        T GetSingle(Expression<Func<T, bool>> whereCond);
        int Add(T entity);
        int Update(T entity);
        int Delete(T entity);
    }
}
