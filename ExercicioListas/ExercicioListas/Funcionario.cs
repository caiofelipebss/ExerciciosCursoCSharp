﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioListas
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Funcionario(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public void IncrementoSalario(double porcentagem)
        {
            Salary = Salary + (Salary * porcentagem / 100.0);
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
