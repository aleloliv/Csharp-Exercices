using ExercicioHeranEPoli.Entities;
using System;
using System.Globalization;

namespace ExercicioHeranEPoli
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char isOutsourced = char.Parse(Console.ReadLine());
                while (isOutsourced != 'n' || isOutsourced != 'y') 
                {
                    if (isOutsourced == 'n')
                    {
                        Console.Write("Name: ");
                        string empName = Console.ReadLine();
                        Console.Write("Hours: ");
                        int hours = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Value per hour: ");
                        double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Employee emp = new Employee(empName, hours, valuePerHour);
                        employees.Add(emp);
                        break;
                    }
                    else if (isOutsourced == 'y')
                    {
                        Console.Write("Name: ");
                        string empName = Console.ReadLine();
                        Console.Write("Hours: ");
                        int hours = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Value per hour: ");
                        double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Additional charge: ");
                        double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Employee outEmp = new OutsourcedEmployee(empName, hours, valuePerHour, additionalCharge);
                        employees.Add(outEmp);
                        break;
                    }
                    else
                    {
                        Console.Write("Please insert 'y' or 'n': ");
                        isOutsourced = char.Parse(Console.ReadLine());
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2"), CultureInfo.InvariantCulture);
            }
        }
    }
}