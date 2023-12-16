using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExerciciosClasses
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        private double NotaTrimestre;

        public double NotaFinal()
        {
            return NotaTrimestre = (Nota1 + Nota2 + Nota3);
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60)
                return true;
            else
                return false;
        }
        public double SituacaoAluno()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60 - NotaFinal();
            }
        }
    }
}
