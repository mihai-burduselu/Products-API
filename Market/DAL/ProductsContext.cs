using Market.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Market
{
    public class ProductsContext : DbContext
    {
       public  DbSet<Product> Products { get; set; }
    }
}