using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Market.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }

        public Product(int id, string name, string category, float price)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
        }

        public Product()
        {

        }

        public void Update(Product p)
        {
            Name = p.Name;
            Category = p.Category;
            Price = p.Price;
        }
    }
}