using System;
using System.Globalization;

namespace Exercicio
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Qual a cotação do dólar? ");
            double dol = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dólares você vai comprar? ");
            double qtd = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.DolarParaReal(dol, qtd);

            Console.WriteLine("Valor a ser pago em reais: " + result.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}