using System.Globalization;

namespace ProvadeProgramação3
{
    class Program
    {
        public static void Main(string[] args)
        {
            double preco;
            double total;

            Console.WriteLine("Digite o código do produto e a quantidade, separados por espaço.");
            string[] lanche = Console.ReadLine().Split(' ');
            int codigo = int.Parse(lanche[0]); 
            int quantidade = int.Parse(lanche[1]);

            switch (codigo)
            {
                case 1:
                    preco = 4.00;
                    total = preco * quantidade;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture)); ;
                    break;
                    
                case 2: 
                    preco = 4.50;
                    total = preco * quantidade;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;

                case 3:
                    preco = 5.00;
                    total = preco * quantidade;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;

                case 4:
                    preco = 2.00;
                    total = preco * quantidade;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;

                case 5:
                    preco = 1.50;
                    total = preco * quantidade;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
            }
            
        }
    }
}