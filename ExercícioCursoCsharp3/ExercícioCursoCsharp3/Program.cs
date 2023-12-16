using System;
using System.Formats.Asn1;
using System.Globalization;

namespace ExercicioCursoCsharp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXERCÍCIO 1");
            Console.WriteLine("Digite o primeiro valor: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("SOMA = {0}", x + y);
            Console.WriteLine();

            Console.WriteLine("EXERCÍCIO 2");
            double pi = 3.14159;
            Console.WriteLine("Digite o raio do círculo");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = pi * raio * raio;
            Console.WriteLine("A = {0}", area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.WriteLine("EXERCÍCIO 3");
            Console.WriteLine("Digite 4 valores, separados em cada linha");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            int diferenca = A * B - C * D;
            Console.WriteLine("DIFERENÇA = {0}", diferenca);
            Console.WriteLine();

            Console.WriteLine("ECERCÍCIO 4");
            Console.WriteLine("Digite o código do funcionário");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite as horas trabalhadas");
            double horas = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da hora trabalhada");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double total = horas * valor;
            Console.WriteLine("NUMBER = {0}", codigo);
            Console.WriteLine("SALARY = U$ {0}", total.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.WriteLine("EXERCÍCIO 5");
            Console.WriteLine("Digite o código do primeiro produto, o número de produtos e o valor unitário do produto");
            string[] epeca1 = Console.ReadLine().Split(' ');
            int peca1 = int.Parse(epeca1[0]);
            double numpecas1 = double.Parse(epeca1[1]);
            double valor1 = double.Parse(epeca1[2], CultureInfo.InvariantCulture);
            double preco1 = numpecas1 * valor1;
            Console.WriteLine("Digite o código do segundo produto, o número de produtos e o valor unitário do produto");
            string[] epeca2 = Console.ReadLine().Split(' ');
            int peca2 = int.Parse(epeca2[0]);
            double numpecas2 = double.Parse(epeca2[1]);
            double valor2 = double.Parse(epeca2[2], CultureInfo.InvariantCulture);
            double preco2 = numpecas2 * valor2;
            double total1 = preco1 + preco2;
            Console.WriteLine("VALOR A PAGAR: R$ " + total1.ToString("N2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.WriteLine("EXERCÍCIO 6");
            Console.WriteLine("Digite os valores de A, B e C na mesma linha");
            string[] valores = Console.ReadLine().Split(' ');
            double A1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double B1 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double C1 = double.Parse(valores[2], CultureInfo.InvariantCulture);
            double pi1 = 3.14159;
            Console.WriteLine("TRIÂNGULO: {0}", (A1 * B1 / 2).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CÍRCULO: {0}", (pi1 * C1 * C1).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPÉZIO: {0}", ((A1 + B1) * C1 / 2).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: {0}", (B1 * B1).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETÂNGULO: {0}", (A1 * B1).ToString("F3", CultureInfo.InvariantCulture)); 
            Console.WriteLine();
        }
    }
}

