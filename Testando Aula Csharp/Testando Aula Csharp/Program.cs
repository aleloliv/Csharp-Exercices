using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma;
            int valor1;
            int valor2;
            string operacao;

            Console.WriteLine("Escolha uma operação s ou q");
            operacao = Console.ReadLine();
            Console.WriteLine("Digite um número:");
            valor1 = int.Parse(Console.ReadLine());
            
            if (operacao == "q")
            {
                valor2 = 0;
            }
            else
            {
                Console.WriteLine("Digite outro número");
                valor2 = int.Parse(Console.ReadLine());
            }
            switch (operacao)
            {
                case "s":
                    soma = somaNumeros(valor1, valor2);
                    Console.WriteLine("A soma é: {0}", soma.ToString());
                    break;

                case "q":
                    quadrado(valor1);
                    break;

            }

            
        }

        static int somaNumeros(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }
        public static void quadrado(int num1)
        {
            int quad = num1 * num1;
            Console.WriteLine(quad.ToString());
        }
            
    }
}