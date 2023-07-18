using Exercicio;
using System;
using System.Globalization;
using System.Numerics;

namespace Exercicio
{
    class Program{

        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Estudante[] alugados = new Estudante[10];

            

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Aluguel #" + i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                alugados[quarto] = new Estudante ( nome, email );
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (alugados[i] != null)
                {
                    Console.WriteLine(i + ": " + alugados[i]);
                }
            }
        }


    }

}