using System;
using System.Globalization;
using ExercicioEnumEComp.Entities;
using ExercicioEnumEComp.Entities.Enums;

namespace ExercicioEnumEComp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client's data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime clientBirthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(clientName, clientEmail, clientBirthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            string orderStatus = Console.ReadLine();
            OrderStatus status = Enum.Parse<OrderStatus>(orderStatus);

            DateTime d1 = DateTime.Now;

            Order order = new Order(d1, status, client);

            Console.Write("How many items to this order? ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1;  i <= num; i++) 
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product product = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem item = new OrderItem(quantity, productPrice, product);

                order.AddItem(item);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine("Order moment: " + order.Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            Console.WriteLine("Order status: " + orderStatus);
            Console.WriteLine(
                $"Client: " + 
                client.Name + 
                " (" + 
                client.BirthDate.ToString("dd/MM/yyyy") + 
                ") - " + 
                client.Email);
            Console.WriteLine("Order items: ");
            foreach (OrderItem item in order.Items)
            {
                Console.WriteLine(
                    item.Product.Name + 
                    ", $" + 
                    item.Price.ToString("F2") + 
                    ", Quantity: " + 
                    item.Quantity + 
                    ", Subtotal: " + 
                    item.SubTotal().ToString("F2"), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Total price: $" + order.Total().ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}