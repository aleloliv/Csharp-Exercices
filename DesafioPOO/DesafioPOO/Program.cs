using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto x; 
            x = new Produto();

            int qte;

            Console.Write("Digite o nome do produto: ");
            x.Nome = Console.ReadLine();
            Console.Write("Digite o preço do produto: ");
            x.Preço = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a quantidade em estoque: ");
            x.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            double valorTotal = x.ValorTotalEmEstoque();

            Console.WriteLine(x);

            Console.Write("Remover (r) ou adicionar (a) um produto ou sair (s): ");
            char alteracao = char.Parse(Console.ReadLine());

            while (alteracao != 's')
            {
                if (alteracao == 'r')
                {
                    Console.Write("Digite o valor a ser removido: ");
                    qte = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    x.RemoverProduto(qte);

                    if (x.Quantidade < 0)
                    {
                        x.Quantidade += qte;
                        Console.WriteLine("Produtos insuficientes!\r\n");
                        Console.Write("Remover (r) ou adicionar (a) um produto: ");
                        alteracao = char.Parse(Console.ReadLine()); ;
                    }
                    else
                    {
                        Console.WriteLine(x);

                        Console.Write("Remover (r) ou adicionar (a) um produto: ");
                        alteracao = char.Parse(Console.ReadLine());
                    }
                    Console.WriteLine();

                }
                else if (alteracao == 'a')
                {
                    Console.WriteLine();

                    Console.Write("Digite o valor a ser adicionado: ");
                    qte = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    x.AdicionarProduto(qte);

                    Console.WriteLine(x);

                    Console.Write("Remover (r) ou adicionar (a) um produto: ");
                    alteracao = char.Parse(Console.ReadLine());

                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Valor inválido. \r\nDigite a para adicionar, r para remover ou s para sair: ");
                    alteracao = char.Parse(Console.ReadLine());
                }
            }
            
            Console.WriteLine();
        }
    }
}