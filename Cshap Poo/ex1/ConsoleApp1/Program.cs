using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while(i < 3)
            {
                Console.Write(i);
                i = i + 1;
                Console.Write(i + 1);
            }
            Console.WriteLine(" ");
        }
    }
}
