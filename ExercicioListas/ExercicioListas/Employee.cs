using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioListas
{
    internal class Employee
    {
        public int _id;
        private string _name; 
        public double Salary { get; private set; }

        public Employee() 
        { 

        }

        public Employee(int id, string name) : this () 
        {
            _id = id;
            _name = name;
        }
        public Employee(int id, string name, double salario) : this(id, name)
        {
            Salary = salario;
        }

        public int Id
        {
            get { return _id; }
            set
            {
                if (value != null && value > 0)
                {
                    _id = value;
                }
            }
        }
        public string Nome
        {
            get { return _name; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }
        public void increaseSalary(double percentage)
        {
            Salary += Salary * (percentage / 100);
        }

        public override string ToString()
        {
            return _id + ", " + _name + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
