using ExerciciosClasses;
using System;
using System.Globalization;

namespace ExerciciosClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Exercício 1");

            Retangulo x = new Retangulo();
            
            Console.WriteLine("Entre a largura e a altura do retângulo: ");
            x.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double perimetroX = x.Perimetro();
            double diagonalX = x.Diagonal();
            
            Console.WriteLine("ÁREA = {0}", areaX.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = {0}", perimetroX.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("DIAGONAL = {0}", diagonalX.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Exercício 2");

            Funcionario funcX = new Funcionario();

            Console.Write("Nome: " );
            funcX.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            funcX.SalarioBruto = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcX.Imposto = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioLiquido = funcX.SalarioLiquido();

            Console.WriteLine("Funcionário: {0}", funcX);

            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture);

            funcX.AumentarSalario(porcentagem);

            Console.WriteLine("Dados atualizados: {0}", funcX);
            Console.WriteLine(); */

            Console.WriteLine("Exercício 3");

            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double notaFinal = aluno.NotaFinal();

            Console.WriteLine("NOTA FINAL = {0}", notaFinal.ToString("F2", CultureInfo.InvariantCulture));
            
            double situacao = aluno.SituacaoAluno();

            if (situacao == 0.0)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO\r\nFALTARAM {0} PONTOS", situacao.ToString("F2"), CultureInfo.InvariantCulture);
            }
        }
    }
}