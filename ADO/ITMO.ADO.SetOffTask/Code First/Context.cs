using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace CodeFirst
{
    public class Context : DbContext
    {
        public Context() : base("AutoShop")
        { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductsInOrder> ProductsInOrders { get; set; }
        //public DbQuery<OrdersView> OrdersViews { get; set; }

    }
}
