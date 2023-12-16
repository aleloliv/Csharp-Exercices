using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioBanco
{
    internal class ContaBancaria
    {
        private string _nome;
        public int NumeroDaConta { get; private set; }
        public double Valor { get; private set; }

        public ContaBancaria()
        {
            
        }

        public ContaBancaria(string nome, int numeroDaConta) : this () 
        {
            _nome = nome;
            NumeroDaConta = numeroDaConta;
        }

        public ContaBancaria(string nome, int numeroDaConta, double valor) : this (nome, numeroDaConta)
        {
            Valor = valor;
        }
        public string Nome
        {
            get { return _nome; }
            set { if (value != null && value.Length > 1)
                    _nome = value;
            else
                {
                    Console.WriteLine("Nome Inválido");
                    _nome = Console.ReadLine();
                }
            }
        }

        public void Deposito(double quantia)
        {
            Valor += quantia;
        }

        public void Saque(double quantia)
        {
            Valor -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta: " + NumeroDaConta + ", Titular: " + _nome  + ", Saldo: R$ " + Valor.ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}