using NCP.Business.Interfaces;
using NCP.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Text;

namespace NCP.Business.Concrete.SqlService
{
    public class CategoryService : BaseService, ICategoryService
    {
        public int Create(Category entity)
        {
            dbModel.AddParameter("@name", entity.Name);
            return dbModel.ExecuteMethod("Insert Into Categories (Name) values (@name)", false, false);
        }

        public int Edit(Category entity)
        {
            dbModel.AddParameter("@id", entity.ID);
            dbModel.AddParameter("@name", entity.Name);
            return dbModel.ExecuteMethod("Update Categories set Name=@name Where ID=@id", false, false);
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> whereCond = null, int start = 0, int take = 0)
        {
            DataTable dt = dbModel.ReaderMethod("Select * from Categories", false);
            List<Category> result = null;
            if (dt != null && dt.Rows.Count > 0)
            {
                result = new List<Category>();
                foreach (DataRow item in dt.Rows)
                {
                    result.Add(new Category()
                    {
                        ID = (int)item["ID"],
                        Name = (string)item["Name"],
                    });
                }
            }
            return result;
        }

        public Category GetSingle(Expression<Func<Category, bool>> whereCond)
        {
            throw new NotImplementedException();
        }

        public Category GetSingle(int entityID)
        {
            dbModel.AddParameter("@id", entityID);
            DataTable dt = dbModel.ReaderMethod("Select * from Categories where ID=@id", false);
            Category result = null;
            if (dt != null && dt.Rows.Count > 0)
            {
                result = new Category()
                {
                    ID = (int)dt.Rows[0]["ID"],
                    Name = (string)dt.Rows[0]["Name"],
                };
            }
            return result;
        }

        public int Remove(Category entity)
        {
            dbModel.AddParameter("@id", entity.ID);
            return dbModel.ExecuteMethod("delete from Categories where ID=@id", false, false);
        }
    }
}
