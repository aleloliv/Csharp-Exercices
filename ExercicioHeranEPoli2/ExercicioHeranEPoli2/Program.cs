using ExercicioHeranEPoli2.Entities;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioHeranEPoli2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1;  i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                while (ch != 'c' || ch != 'u' || ch != 'i') 
                {
                    if (ch == 'c')
                    {
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Price: ");
                        double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Product product = new Product(name, price);
                        products.Add(product);
                        break;
                    }
                    else if (ch == 'u')
                    {
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Price: ");
                        double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        Product product = new UsedProduct(name, price, manufactureDate);
                        products.Add(product);
                        break;
                    }
                    else if (ch == 'i')
                    {
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Price: ");
                        double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Product product = new ImportedProduct(name, price, customsFee);
                        products.Add(product);
                        break;
                    }
                    else
                    {
                        Console.Write("Please insert 'c', 'i' or 'u': ");
                        ch = char.Parse(Console.ReadLine());
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}