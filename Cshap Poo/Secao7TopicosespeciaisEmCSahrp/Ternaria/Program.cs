using System;
using System.Globalization;

namespace Ternaria
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto;

            if(preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }

            Console.WriteLine(desconto);


            //expressão condicional ternário
            double desconto1 = (preco < 20) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto1);
        }
    }
}
