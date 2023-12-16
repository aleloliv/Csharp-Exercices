using System;
using System.Globalization;

namespace ExercicioFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 4");
            Console.WriteLine("Digite a quantidade de operações a serem realizadas, pressione enter e então digite os números a serem divididos na mesma linha.");
            int qntd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qntd; i++)
            {
                string[] nmrs = Console.ReadLine().Split(' ');
                double a = double.Parse(nmrs[0]);
                double b = double.Parse(nmrs[1]);
                if (b == 0)
                {
                    Console.WriteLine("Inpossível Dividir");
                }
                else
                {
                    double rstd = a / b;
                    Console.WriteLine(rstd);
                }

            }
            Console.WriteLine();

            Console.WriteLine("Exercício 5");
            Console.WriteLine("Digite um número para descobrir seu fatorial.");
            int ftrl = 1;
            int n = int.Parse(Console.ReadLine());
            int m = n;
            if (n == 0)
            {
                Console.WriteLine("O fatornial de {0} é 1", m);
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    ftrl = ftrl * i;
                }
                Console.WriteLine("O fatornial de {0} é {1}", m, ftrl);
            }
            Console.WriteLine();

            Console.WriteLine("Exercício 6");
            Console.WriteLine("Digite um número para descobrir todos os seus divisores");
            int _N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= _N; i++)
            {
                if (_N % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Exercício 7");
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                int qdd = i * i;
                int cub = i * i * i;
                Console.WriteLine("Número {0}, Quadrado {1}, Cubo {2}", i, qdd, cub);
            }
            Console.WriteLine();
        }
    }
}