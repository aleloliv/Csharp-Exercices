using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioFixacaoMetAbs.Entities;

namespace ExercicioFixacaoMetAbs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (ch != 'c' || ch != 'i')
                {
                    if (ch == 'c')
                    {
                        Console.Write("Number of employees: ");
                        int numberOfEmployees = int.Parse(Console.ReadLine());
                        list.Add(new LegalPerson(name, anualIncome, numberOfEmployees));
                        break;
                    }
                    else if (ch == 'i')
                    {
                        Console.Write("Health expenditues: ");
                        double healthExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        list.Add(new PhysicalPerson(name, anualIncome, healthExpenses));
                        break;
                    }
                    else
                    {
                        Console.Write("Please select 'i' or 'c': ");
                        ch = char.Parse(Console.ReadLine());
                    }
                }
            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (Person person in list)
            {
                Console.WriteLine(person.Name + ": $ " + person.Taxes().ToString("F2", CultureInfo.InvariantCulture));
                sum += person.Taxes();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum);
        }
    }
}