using System;
using System.Globalization;


namespace Exercicio01___triangulo
{
    class Retangulo
    {
        public double Largura;
        public double Altura;
        public double Area;
        public double Perimetro;
        public double Diagonal;

        public void AreaRetangulo(double largura, double altura)
        {
            Area = largura * altura;
        }

        public void PerimetroRetangulo(double largura, double altura)
        {
            Perimetro = (largura * 2) + (altura * 2);
        }

        public void DiagonalRetangulo(double largura, double altura)
        {
            Diagonal = Math.Sqrt(Math.Pow(largura,2) + Math.Pow(altura, 2));
        }

        public override string ToString()
        {
            return "AREA = " 
                + Area.ToString("F2", CultureInfo.InvariantCulture)
                + "\nPerimetro = "
                + Perimetro.ToString("F2", CultureInfo.InvariantCulture)
                + "\nDiagonal = "
                + Diagonal.ToString("F2", CultureInfo.InvariantCulture)
                + "\n";
        }
    }
}
