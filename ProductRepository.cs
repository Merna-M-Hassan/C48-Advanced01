using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_10_C__Advanced
{
    internal class ProductRepository : IRepository<Product>
    {
        private readonly List<Product> products = new List<Product>();
        public void Add(Product item)
        {
            products.Add(item);
        }

        public void Delete(int id)
        {
            Product product = products.Find(p => p.Id == id);
            products.Remove(product);
        }

        public List<Product> GetAll()
        {
           return products;
        }

        public Product? GetById(int id)
        {
            Product product = products.Find(p => p.Id == id);
            return product;
        }
    }
}
