using System;
using System.Globalization;

namespace DesafioClasseEstatica
{
    class Program
    {
        static double Pi = Math.PI;
        static void Main(string[] args)
        {

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Circunferencia(raio);
            double vol = Volume(raio);

            Console.WriteLine("Circunferencia: {0}", circ.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Volume: {0}", vol.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor de Pi: {0}", Pi.ToString("F2"), CultureInfo.InvariantCulture);
        }
        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume(double ra)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(ra, 3.0);
        }
    }
}