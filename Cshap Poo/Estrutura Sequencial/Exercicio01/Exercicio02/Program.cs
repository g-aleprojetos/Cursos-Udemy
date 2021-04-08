using System;
using System.Globalization;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            double PI = 3.14159;

            double n1 = 2.00;
            double n2 = 100.64;
            double n3 = 150.00;

            double area1 = PI * Math.Pow(n1, 2.0);
            double area2 = PI * Math.Pow(n2, 2.0);
            double area3 = PI * Math.Pow(n3, 2.0);

            Console.WriteLine($"Área do Circulo 1 = " + area1.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine($"Área do Circulo 2 = " + area2.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine($"Área do Circulo 3 = " + area3.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
