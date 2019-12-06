using NCP.DataAccessLayer.SqlProvider;
using System;
using System.Collections.Generic;
using System.Text;

namespace NCP.Business.Concrete.SqlService
{
    public class BaseService
    {
        protected DbHelper dbModel { get => DbHelper.CreateDBHelper("Server=127.0.0.1; Database=FCPDB; uid=sa; pwd=123"); }
    }
}
