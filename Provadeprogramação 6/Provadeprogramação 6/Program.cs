using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Leituradevalores
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = 0;
            int valor = 0;
            int In = 0;
            int Out = 0;
            
            Console.WriteLine("Digite a quantidade de valores a serem declarados");
            quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                valor = int.Parse(Console.ReadLine());

                if (valor >= 10 && valor <= 20) 
                {
                    In++;
                }
                else 
                {
                    Out++;
                }
            }
            Console.WriteLine("{0} in, {1} out", In, Out);
            

           

        }
    }
}