using System;
using System.Globalization;

namespace DesafioSemOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();
            
            Console.WriteLine("Digite as medidas do triângulo X (a, b, c): ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double ax = x.Area();
            
            Console.WriteLine("Digite as medidas do triângulo Y (a, b, c): ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double ay = y.Area();

            Console.WriteLine("A área do triângulo X é: {0} e a área do triângulo Y é: {1}", ax, ay.ToString("F4", CultureInfo.InvariantCulture));

            if (ax > ay)
            {
                Console.WriteLine("O triângulo X tem uma área maior que o triângulo Y.");
            }
            else
            {
                Console.WriteLine("O triângulo Y tem uma área maior que o triângulo X.");
            }
        }
    }
}