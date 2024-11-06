using Lecture12_3.Core.Contracts;
using Lecture12_3.Core.Models;
using System;
using System.Reflection.Metadata.Ecma335;

namespace Lecture12_3;

public class Program
{
    public static void Main(string[] args)
    {
        IShape rectangle = new Rectangle();
        IShape circle = new Circle();

        Console.WriteLine($"Select shape:");
        Console.WriteLine("1. Rectangle");
        Console.WriteLine("2. Circle");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (choice)
        {
            case 1:
                Console.WriteLine("Please indicate width:");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine("Please indicate height:");
                double height = double.Parse(Console.ReadLine());
                rectangle = new Rectangle(width, height);
                Console.WriteLine();
                Console.WriteLine($"Circle radius is {rectangle.CalculateArea()}");
                break;

            case 2:
                Console.WriteLine("Please indicate radius:");
                double radius = double.Parse(Console.ReadLine());
                circle = new Circle(radius);
                Console.WriteLine();
                Console.WriteLine($"Circle radius is {circle.CalculateArea()}");
                break;

        }
    }
}