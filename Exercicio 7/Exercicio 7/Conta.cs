using System;
using System.Globalization;

namespace Execicios
{
    internal class Conta
    {
        private string _depInicial;
        public double Valor { get; private set; }
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        


        public Conta (int numeroConta, string nome)
        {
            NomeTitular = nome;
            NumeroConta = numeroConta;
        }
        
        public void SetDepInicial (string depinicial){ 
            if(depinicial != null && depinicial == "s") { 
                _depInicial = depinicial;
            }
            else
            {
                depinicial = "n";
                _depInicial = depinicial;
            }
        }

        public void Depositar(double valor)
        {
            Valor += valor;
        }

        public void Saque(double valor)
        {
            valor += 5.0 ;
            Valor -= valor;
            
        }

        public override string ToString()
        {
            return "Conta " + NumeroConta + ", Titular: " + NomeTitular + ", Saldo: R$ " + Valor.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
