using Lecture12_1.Core.Contracts;
using Lecture12_1.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lecture12_1.Core.Services
{
    public class MenuService
    {
        private readonly IShoppingCart _shoppingCart;

        public MenuService(IShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }
        public void ShowCart()
        {
            List<Product> AllProducts = _shoppingCart.GetProducts();
            while (true)
            {
                Console.WriteLine("1. Add product to cart");
                Console.WriteLine("2. Remove product from cart");
                Console.WriteLine("3. Show cart");
                Console.WriteLine("4. Quit");
                Console.WriteLine();

                if (!int.TryParse(Console.ReadLine(), out int selection))
                {
                    Console.WriteLine("Bad input, try again");
                    continue;
                }

                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Enter product name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter product price:");
                        double price = double.Parse(Console.ReadLine());

                        _shoppingCart.AddProduct(new Product(name, price));
                        Console.WriteLine("Product added!");
                        Console.WriteLine("");
                        break;

                    case 2:
                        Console.WriteLine("Enter product name:");
                        string nameRemove = Console.ReadLine();

                        Product x = new Product();
                        foreach (Product a in AllProducts)
                        {
                            if (a.Name == nameRemove)
                            {
                                x = a;
                            }
                        }
                        _shoppingCart.RemoveProduct(x);
                        break;

                    case 3:
                        foreach (Product a in AllProducts)
                        {
                            Console.WriteLine($"Name: {a.Name}; Price: {a.Price}eur");
                        }
                        break;

                    case 4:
                        return;
                }
            }
        }
    }
}
