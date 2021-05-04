using System;
using System.Globalization;

namespace ExercicioClasse_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario a, b;

            a = new Funcionario();
            b = new Funcionario();

            Console.WriteLine("Digite o nome do primeiro funcionário: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário do primeiro funcionário: ");
            a.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Digite o nome do segundo funcionário: ");
            b.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário do segundo funcionário: ");
            b.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioM = (a.Salario + b.Salario) / 2;

            Console.WriteLine();
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.WriteLine("Nome: " + a.Nome);
            Console.WriteLine("Salário: " + (a.Salario.ToString("F2", CultureInfo.InvariantCulture)));

            Console.WriteLine();

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.WriteLine("Nome: " + b.Nome);
            Console.WriteLine("Salário: " + (b.Salario.ToString("F2", CultureInfo.InvariantCulture)));

            Console.WriteLine();
            Console.WriteLine("Salário médio = " + salarioM);

        }
    }
}
