using NCP.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace NCP.Model.Concrete
{
   public class Cart : IEntity
    {
        public Cart()
        {
            CartItems = new List<CartItem>();
        }

        public int ID { get; set; }
        public int UserID { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0 : dd/MM/yyyy}" )]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CredationDate { get; set; }
        public List<CartItem> CartItems { get; set; }
        public bool IsSold { get; set; }

        
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N}")]
        public decimal Total { get { return CartItems.Sum(x => x.Product.UnitPrice * x.Quantity); } }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N}")]
        public decimal Amount { get { return CartItems.Sum(x => x.Product.UnitPrice * x.Quantity / (1 + x.Product.Tax)); } }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N}")]
        public decimal Tax { get { return Total - Amount; } }


    }
}
