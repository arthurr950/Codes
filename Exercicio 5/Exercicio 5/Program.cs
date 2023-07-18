using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        public static void Main(string[] args)
        {
            Aluno aluno = new Aluno();  

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Nota Final = " + aluno.NotaFinal().ToString("F2",CultureInfo.InvariantCulture));
            if (aluno.Aprovado()){
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + aluno.NotaFalta().ToString("F2",CultureInfo.InvariantCulture) + " Pontos");
            }
            
        }
    }
}