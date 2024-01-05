using ExercicioMetodosAbstratos.Entities;
using System;
using System.Globalization;
using ExercicioMetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                while (ch != 'r' || ch != 'c')
                {
                    if (ch == 'r')
                    {
                        Console.Write("Width: ");
                        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Height: ");
                        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Rectangle rectangle = new Rectangle(color, width, height);
                        shapes.Add(rectangle);
                        break;
                    }
                    else if (ch == 'c')
                    {
                        Console.Write("Radius: ");
                        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Circle circle = new Circle(color, radius);
                        shapes.Add(circle);
                        break;
                    }
                    else
                    {
                        Console.Write("Please inert 'c' or 'r': ");
                        ch = char.Parse(Console.ReadLine());
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2"), CultureInfo.InvariantCulture);
            }
        }
    }
}