using System;

namespace ConsoleApp3
{
    class Program
    {
        private class Fibonacci
        {
            internal static long fibo(int n)
            {
                if (n < 2)
                {
                    return n;
                }
                else
                {
                    return fibo(n - 1) + fibo(n - 2);
                }
            }

        }

        static void Main(string[] args)
        {
            for(int i = 1; i < 10; i++)
            {
                Console.WriteLine("[" + i + "] =" + Fibonacci.fibo(i) + "\t");
            }
           
        }

       
    }
}
