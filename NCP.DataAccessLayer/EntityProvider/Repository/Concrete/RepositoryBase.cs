using Microsoft.EntityFrameworkCore;
using NCP.DataAccessLayer.EntityProvider.Repository.Interfaces;
using NCP.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace NCP.DataAccessLayer.EntityProvider.Repository.Concrete
{
    public class RepositoryBase<TContext, TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        TContext db;
        public RepositoryBase()
        {
            db = db ?? new TContext();
        }

        public int Add(TEntity entity)
        {
            try
            {
                var e = db.Entry(entity);
                e.State = EntityState.Added;
                return db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> whereCond = null, int start = 0, int take = 0)
        {
            try
            {
                var query = db.Set<TEntity>().AsQueryable();
                if (whereCond != null)
                    query = query.Where(whereCond);
                if (take > 0)
                    query.Skip(start).Take(take);
                return query.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public TEntity GetSingle(Expression<Func<TEntity, bool>> whereCond)
        {
            try
            {
                return whereCond == null ? db.Set<TEntity>().FirstOrDefault() : db.Set<TEntity>().FirstOrDefault(whereCond);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
