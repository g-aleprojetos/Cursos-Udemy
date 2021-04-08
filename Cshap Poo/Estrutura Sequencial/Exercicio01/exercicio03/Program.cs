using System;

namespace exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 5;
            int B = 6;
            int C = 7;
            int D = 8;

            int A1 = 5;
            int B1 = 6;
            int C1 = -7;
            int D1 = 8;

            int dif1 = (A * B) - (C * D);
            int dif2 = (A1 * B1) - (C1 * D1);

            Console.WriteLine($"Diferença 1 = {dif1}");
            Console.WriteLine($"Diferença 2 = {dif2}");
        }
    }
}
