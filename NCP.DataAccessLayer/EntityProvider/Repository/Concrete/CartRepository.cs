using NCP.DataAccessLayer.EntityProvider.Repository.Interfaces;
using NCP.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace NCP.DataAccessLayer.EntityProvider.Repository.Concrete
{
    public class CartRepository : RepositoryBase<FCPDBContext,Cart>, ICartRepository 
    {
    }
}
