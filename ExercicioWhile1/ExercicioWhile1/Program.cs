using System;
using System.Globalization;

namespace ExercicioWhile1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero = 1.000;
            while (numero > 0)
            {
                Console.WriteLine("Digite um número: ");
                numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double resultado = Math.Sqrt(numero);
                Console.WriteLine(resultado.ToString("F3", CultureInfo.InvariantCulture));

            }
            Console.WriteLine("Número negativo!");
        }
    }
}