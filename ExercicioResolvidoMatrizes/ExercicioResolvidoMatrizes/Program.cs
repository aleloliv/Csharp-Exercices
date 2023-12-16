using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioResolvidoMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n,n];

            Console.WriteLine("Digite o conteúdo da matriz por linha: ");

            for (int i = 0; i < n; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i,j] = int.Parse(linha[j]);
                }
            }

            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + ", ");
            }
            Console.WriteLine();

            Console.WriteLine("Negative numbers: ");
            int neg = 0;
            foreach (int obj in mat)
            {
                if (obj < 0)
                {
                    neg++;
                }
            }
            Console.WriteLine(neg);
        }
    }
}