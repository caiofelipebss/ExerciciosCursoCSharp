using System;
using System.Globalization;

namespace AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pX = (xA + xB + xC) / 2;
            double areaX = Math.Sqrt(pX * (pX - xA) * (pX - xB) * (pX - xC));

            double pY = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(pY * (pY - yA) * (pY - yB) * (pY - yC));

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            } else if (areaY > areaX)
            {
                Console.WriteLine("Maior área: Y");
            } else
            {
                Console.WriteLine("As áreas são iguais.");
            }
        }
    }
}

/*
 
Fazer um programa para ler as medidas dos lados de dois triângulos X e Y (suponha medidas
válidas). Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos
possui a maior área.

A fórmula para calcular a área de um triângulo a partir das medidas de seus lados a, b e c é a
seguinte (fórmula de Heron):
    
            area = Math.Sqrt(p * (p - A) * (p - B) * (Y - C));

*/