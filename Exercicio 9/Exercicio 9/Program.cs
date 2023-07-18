using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Empregado empregado = new Empregado();

            Console.Write("Quantos empregados serão registrados? ");
            int numFunc = int.Parse(Console.ReadLine());
            List<Empregado> list = new List<Empregado>();

            for(int i=1;i <=numFunc;i++)
            {
                Console.WriteLine("Empregado #" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                list.Add(new Empregado(id,nome,salario));
                Console.WriteLine();
            }

            Console.Write("Entre o Id do empregado que será aumentado o salário: ");
            int procurarId = int.Parse(Console.ReadLine());

            Empregado emp = list.Find(x => x.Id == procurarId);

            if(emp != null) {

                Console.Write("Entre a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AumentarSalario(porcentagem);

            }
            else
            {
                Console.WriteLine("Esse Id não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada de empregados:");
            foreach (Empregado obj in list) {
                Console.WriteLine(obj);
            }

            

        }
    }
}
