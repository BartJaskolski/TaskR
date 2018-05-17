using SPA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SPA.DAL
{
    public class ProductContext : DbContext
    {
        public ProductContext() // dbcontext constructor
            : base("name=SPA.DAL.ProductContext")
            {
                   this.Configuration.LazyLoadingEnabled = false;
                   this.Configuration.ProxyCreationEnabled = false;
            }
        public DbSet<Products> product { get; set; }
        public DbSet<Order> order { get; set; }
        public DbSet<Category> category { get; set; }
        public DbSet<PositionOfOrder> positionOfOrder { get; set; }
    }
}