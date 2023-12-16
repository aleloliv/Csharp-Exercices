using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvadeProgramação
{
    class Program
    {
        public static void Main(string[] args)
        {
            int peca1;
            int peca2;
            decimal numpecas1;
            decimal numpecas2;
            decimal valor1;
            decimal valor2;
            decimal preco1;
            decimal preco2;
            decimal total;

            Console.WriteLine("Digite o código do primeiro produto");
            peca1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de produtos (1)");
            numpecas1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor unitário do produto (1)");
            valor1 = decimal.Parse(Console.ReadLine());

            preco1 = numpecas1 * valor1;

            Console.WriteLine("Digite o código do segundo produto");
            peca2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de produtos (2)");
            numpecas2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor unitário do produto (2)");
            valor2 = decimal.Parse(Console.ReadLine());

            preco2 = numpecas2 * valor2;

            total = preco1 + preco2;

            Console.WriteLine("O valor total é: R$ " + total.ToString("N2", CultureInfo.InvariantCulture));

        }
      
    }   
}