using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NCP.Model.Concrete
{
    public class Product : BaseModel
    {
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N}")]
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public bool Discontinued { get; set; }
        public Category Category { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N}")]
        public decimal Tax { get; set; }

    }
}
