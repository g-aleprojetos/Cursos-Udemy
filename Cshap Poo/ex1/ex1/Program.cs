using System;

namespace ex1
{
    class Program
    {

        static void Main(string[] args)
        {


            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("[" + i + "] =" + teste.func(i) + "\t");
            }

        }
    }
    public class teste
    {
        internal static int func(int n)
        {
            int x = 1;
            int k;

            if (n == 1) return x;

            for (k = 1; k < n; ++k)
            {
                x = x + func(k) * func(n - k);
            }

            return x;
        }
    }
}

