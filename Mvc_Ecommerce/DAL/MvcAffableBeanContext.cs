using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Mvc_Ecommerce.Models;


namespace Mvc_Ecommerce.DAL
{
    public class Mvc_EcommerceContext : DbContext

    {
        public Mvc_EcommerceContext() : base("Mvc_Ecommerce")
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<CustomerOrder> CustomerOrders { get; set; }

        public DbSet<OrderedProduct> Orderedproducts { get; set; }

        public DbSet<Cart> Carts { get; set; }


    }
    
}