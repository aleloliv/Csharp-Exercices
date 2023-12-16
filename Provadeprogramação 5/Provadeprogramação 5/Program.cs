using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Senha
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha;
            senha = 0;

            while (senha != 2002)
            {
                Console.WriteLine("Digite a senha");
                senha = int.Parse(Console.ReadLine());

                if (senha != 2002)
                    Console.WriteLine("Senha Inválida");
                else
                    Console.WriteLine("Acesso Permitido");
            }
            
        }
    }
}