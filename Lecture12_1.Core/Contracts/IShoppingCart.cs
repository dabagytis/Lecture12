using Lecture12_1.Core.Models;

namespace Lecture12_1.Core.Contracts
{
    public interface IShoppingCart
    {
        void AddProduct(Product product);
        void RemoveProduct(Product product);
        List<Product> GetProducts();
    }
}
