using Lecture12_1.Core.Contracts;
using Lecture12_1.Core.Services;
using System;

namespace Lecture12_1;

public class Program
{
    public static void Main(string[] args)
    {
        IShoppingCart shoppingCart = new ShoppingCart();
        MenuService menuService = new MenuService(shoppingCart);
        menuService.ShowCart();
    }
}