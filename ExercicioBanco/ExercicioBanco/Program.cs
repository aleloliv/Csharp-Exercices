using System;
using System.Globalization;

namespace ExercicioBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Entre com o número da conta: ");
            int numerodaconta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char depositoInicial = char.Parse(Console.ReadLine());

            double valorInicial;

            if (depositoInicial == 's')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            else if (depositoInicial == 'n')
            {
                valorInicial = 0;
            }
            else
            {
                Console.Write("Você digitou um valor inválido, o saldo inicial será 0.\r\n");
                valorInicial = 0;
            }
            ContaBancaria contaBancaria = new ContaBancaria(nome, numerodaconta, valorInicial);
            
            
            Console.WriteLine("Dados da conta: \r\n" + contaBancaria);

            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            contaBancaria.Deposito(deposito);

            Console.WriteLine(contaBancaria + "\r\n");

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            contaBancaria.Saque(saque);

            Console.WriteLine("Dados da conta atualizados: \r\n" + contaBancaria);
        }
    }
}