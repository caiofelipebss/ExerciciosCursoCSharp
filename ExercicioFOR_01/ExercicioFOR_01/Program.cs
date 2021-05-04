using System;

namespace ExercicioFOR_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um número inteiro (de 1 a 1000): ");
            int x = int.Parse(Console.ReadLine());

            int soma = 0;
            int N;

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

/*
  Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.
*/