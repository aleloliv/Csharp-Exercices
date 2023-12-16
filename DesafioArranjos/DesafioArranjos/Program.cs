using System;
using System.Globalization;

namespace DesafioArranjos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Quantas pessoas serão medidas? ");
            int numP = int.Parse(Console.ReadLine());

            double[] vect = new double[numP];
            double sum = 0.0;

            for (int i = 0; i < numP; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < numP; i++)
            {
                sum += vect[i];
            }

            double altMed = sum / numP;

            Console.WriteLine("AVARAGE HIGHT = {0}", altMed.ToString("F2"), CultureInfo.InvariantCulture);*/

            Console.Write("Digite a quantidade de produtos: ");

            int nProd = int.Parse(Console.ReadLine());

            Product[] vect = new Product[nProd];

            double sumP = 0.0;

            for (int i = 0; i < nProd; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Nome = nome, Preco = preco };
            }

            for (int i = 0; i < nProd; i++)
            {
                sumP += vect[i].Preco;
            }

            double medPre = sumP / nProd;

            Console.WriteLine("AVARAGE PRICE = R$ {0}", medPre.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}