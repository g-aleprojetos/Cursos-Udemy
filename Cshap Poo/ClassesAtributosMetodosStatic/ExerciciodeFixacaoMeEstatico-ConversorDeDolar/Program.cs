using System;
using System.Globalization;

namespace ExerciciodeFixacaoMeEstatico_ConversorDeDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dolar?");
            double valorDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você vai comprar?");
            double quantDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.Conversor(valorDolar, quantDolares).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
