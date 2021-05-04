using System;
using System.Globalization;

namespace LerDadosContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta contaBancaria;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial? (s/n) ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Digite o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaBancaria = new Conta(numero, titular, depositoInicial);
            } else
            {
                contaBancaria = new Conta(numero, titular); //Este construtor vai jogar o saldo zero para a conta.
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria);
        }
    }
}
