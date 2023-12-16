using System.Globalization;

namespace Equacaodosegundograu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de a, b e c na mesma linha e separados por espaço");
            string[] valores = Console.ReadLine().Split(' ');
            double a = double.Parse(valores[0]);
            double b = double.Parse(valores[1]);
            double c = double.Parse(valores[2]);

            double delta = b * b - 4 * a * c;

            if (a != 0 && delta >= 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("X1 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("X2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }
        }
    }
}