using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if(x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("x is null");

            if(y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("y is null");

/************** Operador de coalescência nula **********/

            double? t = null;
            double? s = 10;

            double a = t ?? 5;
            double b = s ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);


        }
    }
}
