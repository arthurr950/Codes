using System;
using System.Globalization;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Digite o nome do primeiro funcionario:");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário do primeiro funcionario:");
            f1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o nome do segundo funcionario:");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário do segundo funcionario:");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalario = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine("Salário médio: " +  mediaSalario.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
