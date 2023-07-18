using System;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Digite o nome da primeria pessoa:");
            p1.nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da primeria pessoa:");
            p1.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome da segunda pessoa:");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da segunda pessoa:");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                Console.WriteLine("Pessoa mais velha:" + p1.nome);
            }
            else
            {

                Console.WriteLine("Pessoa mais velha:" + p2.nome);
            }


        }
    }
}
