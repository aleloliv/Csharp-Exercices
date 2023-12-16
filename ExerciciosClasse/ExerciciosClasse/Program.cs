using System;
using System.Globalization;

namespace ExerciciosClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Exercício 1");
            Pessoa p1;
            Pessoa p2;
            
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.Write("Digite o nome da primeira pessoa: ");
            p1.nome = Console.ReadLine();
            Console.Write("Digite a idade da primeira pessoa: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da segunda pessoa: ");
            p2.nome = Console.ReadLine();
            Console.Write("Digite a idade da segunda pessoa: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                Console.WriteLine("Pessoa mais velha: {0}", p1.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: {0}", p2.nome);
            }
            Console.WriteLine();*/

            Console.WriteLine("Exercício 2");

            Funcionario f1;
            Funcionario f2;

            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.Write("Digite o nome do primeiro funcionário: ");
            f1.nome = Console.ReadLine();
            Console.Write("Digite o salário do primeiro funcionário: ");
            f1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o nome do segundo funcionário: ");
            f2.nome = Console.ReadLine();
            Console.Write("Digite o salário do segundo funcionário: ");
            f2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = ((f1.salario + f2.salario) / 2);

            Console.WriteLine("Salário médio: {0}", salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}