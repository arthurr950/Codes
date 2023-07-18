using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    internal class Aluno
    {
        public string Nome, Situacao;
        public double N1, N2, N3;

        public  double NotaFinal()
        {
            return N1 + N2 + N3;
    
        }
        public bool Aprovado()
        {
            if(NotaFinal() >= 60.00) {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double NotaFalta()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.00 - NotaFinal();
            }
        }

    }
}
