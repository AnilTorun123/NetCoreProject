using NCP.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace NCP.Business.Interfaces
{
    public interface IBaseService<T> where T : IEntity
    {
        List<T> GetAll(Expression<Func<T, bool>> whereCond = null, int start = 0, int take = 0);
        T GetSingle(Expression<Func<T, bool>> whereCond);
        T GetSingle(int entityID);
        int Create(T entity);
        int Edit(T entity);
        int Remove(T entity);
    }
}
