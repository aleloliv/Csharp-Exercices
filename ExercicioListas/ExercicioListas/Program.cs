using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

namespace ExercicioListas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Emplyoee #" + (i + 1));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));

            }

           

            Employee idSearchReplicate = list.FindAll(x => x._id == y._id);

            Console.Write("Enter the employee id that will have salary increase : ");
            int idSearch = int.Parse(Console.ReadLine());

            Employee idEmp = list.Find(x => x.Id == idSearch);
            if (idEmp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                idEmp.increaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("\r\nUpdated list of employees:\r\n");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}