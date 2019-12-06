using NCP.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NCP.Model.Concrete
{
   public class CartItem : IEntity
    {
        public int ID { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N0}")]
        public decimal Quantity { get; set; }
        public Product Product { get; set; }
        public int CartID { get; set; }

    }
}
