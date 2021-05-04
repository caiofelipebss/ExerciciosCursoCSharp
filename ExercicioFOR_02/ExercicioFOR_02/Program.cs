using System;

namespace ExercicioFOR_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int N = int.Parse(Console.ReadLine());

            
            int somaIn = 0;
            int somaOut = 0;

            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20) {
                    somaIn = somaIn + 1;
            } else
                {
                    somaOut = somaOut + 1;
                }
            }
            Console.WriteLine("{0} in", somaIn);
            Console.WriteLine("{0} out", somaOut);
        }
    }
}

/*
Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
*/