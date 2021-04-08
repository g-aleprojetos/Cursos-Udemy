using System;
using System.Globalization;

namespace exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 3.0;
            double b = 4.0;
            double c = 5.2;

            double a1 = 12.7;
            double b1 = 10.4;
            double c1 = 15.2;

            double areaTriangulo = (a * c) / 2;
            double areaCirculo = Math.PI * Math.Pow(c, 2.0);
            double areaTrapezio = ((a + b) * c) / 2;
            double areaQuadrado = b * b;
            double areaRetangulo = a * b;

            double areaTriangulo1 = (a1 * c1) / 2;
            double areaCirculo1 = Math.PI * Math.Pow(c1, 2.0);
            double areaTrapezio1 = ((a1 + b1) * c1) / 2;
            double areaQuadrado1 = b1 * b1;
            double areaRetangulo1 = a1 * b1;

            Console.WriteLine("Triangulo: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Círculo: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapezio: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retângulo: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine("");

            Console.WriteLine("Triangulo: " + areaTriangulo1.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Círculo: " + areaCirculo1.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapezio: " + areaTrapezio1.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: " + areaQuadrado1.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retângulo: " + areaRetangulo1.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
