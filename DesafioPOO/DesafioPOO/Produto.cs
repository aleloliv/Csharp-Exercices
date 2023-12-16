using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DesafioPOO
{
    internal class Produto
    {
        public string Nome;
        public double Preço;
        public int Quantidade;
        
        public void AdicionarProduto(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return Preço * Quantidade;
        }

        public override string ToString()
        {
            return "Nome:                    " + Nome + "\r\n" +
                   "Preço:                   R$ " + Preço.ToString("F2", CultureInfo.InvariantCulture) + "\r\n" +
                   "Quantitdade em estoque:  " + Quantidade + "\r\n" +
                   "Valor total em estoque:  R$ "  + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture) + "\r\n"; 
        }
    }
}
