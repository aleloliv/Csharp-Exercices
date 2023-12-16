using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvadeProgramação2
{
    class Program
    {
        public static void Main(string[] args)
        {
            double raio;
            double pi = 3.14159;
            double area;

            Console.WriteLine("Digite o raio do círculo");
            raio = double.Parse(Console.ReadLine());

            area = pi * (raio * raio);

            Console.WriteLine("A área do círculo é: " + area.ToString("N4"));
        }
    }
}