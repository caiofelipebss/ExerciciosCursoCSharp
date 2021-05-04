using System;

namespace ExercicioClasse_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa a, b;

            a = new Pessoa();
            b = new Pessoa();

            Console.WriteLine("Digite o nome da primeira pessoa: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Agora digite a idade da primeira pessoa: ");
            a.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa: ");
            b.Nome = Console.ReadLine();
            Console.WriteLine("Agora digite a idade da segunda pessoa: ");
            b.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.WriteLine("Nome: " + a.Nome);
            Console.WriteLine("Idade: " + a.Idade);

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.WriteLine("Nome: " + b.Nome);
            Console.WriteLine("Idade: " + b.Idade);

            if (a.Idade > b.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + a.Nome);
            } else
            {
                Console.WriteLine(b.Nome);
            }
        }
    }
}
