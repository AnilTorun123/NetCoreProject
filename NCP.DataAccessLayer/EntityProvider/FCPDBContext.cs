using Microsoft.EntityFrameworkCore;
using NCP.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace NCP.DataAccessLayer.EntityProvider
{
    public class FCPDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=127.0.0.1; DataBase=FCPDB; uid=sa; pwd=123");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

    }
}
