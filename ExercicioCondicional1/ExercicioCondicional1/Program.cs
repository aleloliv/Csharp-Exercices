using System;
using System.Globalization;

namespace ExercicioCondicional1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            int x = int.Parse(Console.ReadLine());
            int y = x % 2;
            if (y != 0)
            {
                Console.WriteLine("Impar!");
            }
            else
            {
                Console.WriteLine("Par!");
            }

        }
    }
}