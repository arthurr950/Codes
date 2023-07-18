using Execicios;
using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Entre o número da conta: ");
            int NrConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string NmTitular = Console.ReadLine();
            Conta conta = new Conta(NrConta, NmTitular);
            Console.Write("Haverá depósito inicial (s/n)? ");
            string DepInicial = Console.ReadLine();
            conta.SetDepInicial(DepInicial);

            if (DepInicial == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double VlDepInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                conta.Depositar(VlDepInicial);
            }

            Console.WriteLine("");
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine("");
            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Depositar(deposito);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine("");
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);


        }
    }


}