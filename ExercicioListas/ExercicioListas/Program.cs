using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioListas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Funcionário #{i}: ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Salário: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionario(id, name, salary));

                Console.WriteLine();

            }

            Console.WriteLine("Entre com o ID do funcionário que terá aumento de salário: ");
            int pesquisaId = int.Parse(Console.ReadLine());

            // Enconstrar na lista a primeira ocorrência de um nome que começa com o ID informado:

            Funcionario funcionario = list.Find(x => x.Id == pesquisaId); //quero o objeto X, tal que X na posição Id seja igual a pesquisaId
            if (funcionario != null)
            {
                Console.WriteLine("Entre com a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionario.IncrementoSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Esse ID não existe! ");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionários: ");
            
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
