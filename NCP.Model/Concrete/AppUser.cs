using System;
using System.Collections.Generic;
using System.Text;

namespace NCP.Model.Concrete
{
   public class AppUser :BaseModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
    }
}
