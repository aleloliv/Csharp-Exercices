using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExerciciosMembrosEstaticos
{
    internal class ConversorDeMoeda
    {
        static public double Dolar;
        static public double Real;
        static public double IOF = 0.06;

        static public double Conversao()
        {
            return Dolar * Real + (Dolar * Real * IOF);
        }

    }
}
