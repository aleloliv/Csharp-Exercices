using System;
using System.Globalization;

namespace ExercicioVetores
{
    class Program
    {
        static void Main(string[] args)
        {

            Estudante[] vect = new Estudante[10];

            Console.Write("How many rooms will be rented? (1 - 10) ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Rent #{0}", i + 1);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room (0 - 9): ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante ( name, email );
            }

            Console.WriteLine();
            Console.WriteLine("Busy rooms:");

            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }

            

        }

    }
}