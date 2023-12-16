using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioArranjos
{
    internal class Product
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Product()
        {

        }

        public Product(string nome, double preco) : this() 
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
