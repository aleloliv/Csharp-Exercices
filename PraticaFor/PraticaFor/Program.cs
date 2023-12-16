using System;
using System.Globalization;

namespace PraticaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = 0;
            Console.Write("Digite a quantidade valores a serem somados: ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidade; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                resultado += valor;
            }
            Console.WriteLine("Soma = {0}", resultado);
        }
    }
}