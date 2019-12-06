using NCP.DataAccessLayer.EntityProvider.Repository.Interfaces;
using NCP.Model.Concrete;

namespace NCP.DataAccessLayer.EntityProvider.Repository.Concrete
{
    public class CategoryRepository : RepositoryBase<FCPDBContext, Category>, ICategoryRepository
    {
    }
}
