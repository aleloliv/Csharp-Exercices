using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVetores
{
    internal class Estudante
    {
        private string _nome;
        public string Email { get; set; }

        public Estudante()
        {

        }

        public Estudante(string nome, string email) : this()
        {
            _nome = nome;
            Email = email;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public override string ToString()
        {
            return _nome + ", " + Email;
        }
    }
}
