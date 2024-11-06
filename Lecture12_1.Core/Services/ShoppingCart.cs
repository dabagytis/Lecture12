using Lecture12_1.Core.Contracts;
using Lecture12_1.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture12_1.Core.Services
{
    public class ShoppingCart : IShoppingCart
    {
        private List<Product> AllProducts = new List<Product>();
        public void AddProduct(Product product)
        {
            AllProducts.Add(product);
        }

        public List<Product> GetProducts()
        {
            return AllProducts;
        }

        public void RemoveProduct(Product product)
        {
            AllProducts.Remove(product);
        }
    }
}
