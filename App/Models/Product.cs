using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace App.Models
{
    public class Product
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public string Description { get; set; }
       public decimal Price { get; set; }
    }

    public class ProductContext: DbContext
    {
        public ProductContext(): base("DefaultConnection")
    { }
        public DbSet<Product> Products { get; set; }
    }
}