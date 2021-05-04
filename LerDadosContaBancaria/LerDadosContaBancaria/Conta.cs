using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace LerDadosContaBancaria
{
    class Conta
    {

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }


        //ConstrutorSaldoZero
        public Conta(int numero, string titular) 
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0.00; //Não precisa colocar o "Saldo", pois se eu não declará-lo, automaticamente o programa irá colocar que ele recebe o valor zero. Declarei só por questões didáticas; 
        }

        //Construtor 3 argumentos
        public Conta(int numero, string titular, double depositoInicial) : this(numero, titular) //Aqui estou reaproveitando os construtores de "ConstrutorSaldoZero" 
        {
            Deposito(depositoInicial);
        }

        public void Deposito (double quantia)
        {
            Saldo += quantia; 
        }

        public void Saque (double quantia)
        {
            Saldo -= quantia + 5.0; //A taxa de saque é de 5 reais.
        }




        public override string ToString()
        {
            return "Conta: "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
