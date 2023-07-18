using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
     class ConversorDeMoeda
    {
        public static double IOF = 6.0;
        public static double DolarParaReal(double dolar, double quantidade)
        {
           double total = dolar * quantidade;
            return total + total * IOF / 100.0;
            
        }

    }
}
