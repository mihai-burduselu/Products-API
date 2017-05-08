using Market.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Market.Controllers
{
    public class ProductsController : ApiController
    {
        //private static List<Product> Products = new List<Product>();
        public ProductsContext Db = new ProductsContext();

        [HttpGet]
        public List<Product> GetAll()
        {
            return Db.Products.ToList();
        }

        [HttpGet]
        public Product GetByName(string name)
        {
            Product productToFind = Db.Products.FirstOrDefault(e => e.Name == name);
            return productToFind;
        }

        [HttpPost]
        public void AddProduct(Product p)
        {
            Db.Products.Add(p);
            Db.SaveChanges();
        }

        //[HttpGet]
        //public List<Product> GetAll()
        //{
        //    return Products;
        //}

        //[HttpPost]
        //public void AddProduct(Product p)
        //{
        //    Products.Add(p);
        //}
    }
}