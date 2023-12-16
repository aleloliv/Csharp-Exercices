using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Windows;

namespace ExercicioCursoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1.ToString("F2")}");
            Console.WriteLine("{0}, cujo preço é $ {1}", produto2, preco2.ToString("F2"));
            Console.WriteLine();
            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {medida.ToString("F8")}");
            Console.WriteLine("Arredondado (três casas decimais): {0}", medida.ToString("F3"));
            Console.WriteLine($"Separador decimal Invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
        }


    }
}
