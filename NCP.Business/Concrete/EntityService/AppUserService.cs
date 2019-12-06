using NCP.Business.Interfaces;
using NCP.DataAccessLayer.EntityProvider.Repository.Interfaces;
using NCP.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace NCP.Business.Concrete.EntityService
{
    public class AppUserService : IAppUserService
    {
        IAppUserRepository dbModel;
        public AppUserService(IAppUserRepository appUserRepository)
        {
            dbModel = appUserRepository;
        }

        public AppUser Login(string UserName, string Pass)
        {
            return dbModel.GetSingle(x => x.UserName == UserName && x.Password == Pass);
        }

        public int Create(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public int Edit(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> GetAll(Expression<Func<AppUser, bool>> whereCond = null, int start = 0, int take = 0)
        {
            throw new NotImplementedException();
        }

        public AppUser GetSingle(Expression<Func<AppUser, bool>> whereCond)
        {
            throw new NotImplementedException();
        }

        public AppUser GetSingle(int entityID)
        {
            throw new NotImplementedException();
        }

        public int Remove(AppUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
