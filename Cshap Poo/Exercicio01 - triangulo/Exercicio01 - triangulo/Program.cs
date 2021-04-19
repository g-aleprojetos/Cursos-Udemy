using System;
using System.Globalization;

namespace Exercicio01___triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, altura;
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre com a largura e a altura do retângulo");
            Console.Write("Largura: ");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.AreaRetangulo(largura, altura);
            retangulo.PerimetroRetangulo(largura, altura);
            retangulo.DiagonalRetangulo(largura, altura);

            Console.WriteLine();
            Console.WriteLine(retangulo);
        }
    }
}
