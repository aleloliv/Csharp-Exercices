using System;
using System.Globalization;

namespace ExerciciosCondicionaisProva
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("EXERCÍCIO 1");
            Console.WriteLine("Digite um número inteiro");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0 )
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }
            Console.WriteLine();

            Console.WriteLine("EXERCÍCIO 2");
            Console.WriteLine("Digite um número inteiro");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) 
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
            Console.WriteLine();

            Console.WriteLine("EXERCÍCIO 3");
            Console.WriteLine("Digite dois números inteiros na mesma linha");
            string[] numeros = Console.ReadLine().Split(' ');
            int A = int.Parse(numeros[0]);
            int B = int.Parse(numeros[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("SÃO MÚLTIPLOS");
            }
            else
            {
                Console.WriteLine("NÃO SÃO MÚLTIPLOS");
            }
            Console.WriteLine();

            Console.WriteLine("EXERCÍCIO 4");
            Console.WriteLine("Digite a hora inicial e a hora final do jogo, nessa ordem.");
            string[] horas = Console.ReadLine().Split(' ');
            int hora1 = int.Parse(horas[0]);
            int hora2 = int.Parse(horas[1]);
            int horaDia = 24;

            if (hora1 > hora2)
            {
                Console.WriteLine("O JOGO DUROU {0} HORA(S).", horaDia - hora1 + hora2);
            }
            else if (hora2 > hora1) 
            {
                Console.WriteLine("O JOGO DUROU {0} HORA(S).", hora2 - hora1);
            }
            else if (hora2 == 0)
            {
                hora2 = horaDia;
                Console.WriteLine("O JOGO DUROU {0} HORA(S).", hora2 - hora1);
            }
            else
            {
                Console.WriteLine("O JOGO DUROU {0} HORA(S).", hora2 + horaDia - hora1);
            }
            Console.WriteLine();

            Console.WriteLine("EXERCÍCIO 5");
            Console.WriteLine("Digite o código e a quantidade de itens: ");
            string[] lanche = Console.ReadLine().Split(' ');
            int codigo = int.Parse(lanche[0]);
            double quantidade = double.Parse(lanche[1], CultureInfo.InvariantCulture);
            switch (codigo)
            {
                case 1:
                    Console.WriteLine("Total: R$ {0}", (quantidade * 4.00).ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 2:
                    Console.WriteLine("Total: R$ {0}", (quantidade * 4.50).ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 3:
                    Console.WriteLine("Total: R$ {0}", (quantidade * 5.00).ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 4:
                    Console.WriteLine("Total: R$ {0}", (quantidade * 2.00).ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 5:
                    Console.WriteLine("Total: R$ {0}", (quantidade * 1.50).ToString("F2", CultureInfo.InvariantCulture));
                    break;
            }
            Console.WriteLine();

            Console.WriteLine("EXERCÍCIO 6");
            Console.WriteLine("Digite um número real qualquer para verificar em qual intervalo ele se encontra.");
            decimal numeroReal = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numeroReal >= 0 && numeroReal <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numeroReal > 25 && numeroReal <= 50)
            {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if (numeroReal > 50 && numeroReal <= 75) 
            {
                Console.WriteLine("Intervalo [50,75]");
            }
            else if (numeroReal > 75 && numeroReal <= 100)
            {
                Console.WriteLine("Intervalo [75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
            Console.WriteLine();

            Console.WriteLine("EXERCÍCIO 7");
            Console.WriteLine("Digite dois valores com uma casa decimal, na mesma linha");
            string[] numQuadran = Console.ReadLine().Split(' ');
            double numQuad1 = double.Parse(numQuadran[0], CultureInfo.InvariantCulture);
            double numQuad2 = double.Parse(numQuadran[1], CultureInfo.InvariantCulture);

            if (numQuad1 == 0 && numQuad2 == 0)
            {
                Console.WriteLine("Origuem");
            }
            else if (numQuad1 == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (numQuad2 == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (numQuad1 > 0 && numQuad2 > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (numQuad1 < 0 && numQuad2 > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (numQuad1 < 0 && numQuad2 < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
            Console.WriteLine();

            Console.WriteLine("EXERCÍCIO 8");
            Console.WriteLine("Digite o salário");
            double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double min = 2000.00;
            double resto1 = 0;
            double resto2 = 0;
            double faixa1 = 1000.00;
            double faixa2 = 1500.00;

            if (renda == min)
            {
                Console.WriteLine("Isento");
            }
            else if (renda > min && renda <= 3000.00)
            {
                renda -= min;
                Console.WriteLine("R$ {0}", (renda * 0.08).ToString("F2"), CultureInfo.InvariantCulture);
            }
            else if (renda > 3000.00 && renda <= 4500.00)
            {
                renda -= min + faixa1;
                Console.WriteLine("R$ {0}", (faixa1 * 0.08 + renda * 0.18).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (renda > 4500.00)
            {
                renda -= min + faixa1 + faixa2;
                Console.WriteLine("R$ {0}", (faixa1 * 0.08 + faixa2 * 0.18 + renda * 0.28).ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine();
        }
    }
}