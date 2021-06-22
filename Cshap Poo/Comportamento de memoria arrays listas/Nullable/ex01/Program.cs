using System;
using System.Globalization;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            int[] rent = new int[n];
            Room[] vect = new Room[9];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.Write("Digite o número do quarto ");
                int room = int.Parse(Console.ReadLine());
                Console.Write("Digite o nome do estudante ");
                string name = Console.ReadLine();
                Console.Write("Digite o Email do estudante ");
                string email = Console.ReadLine();
                               
                vect[room] = new Room { Name = name, Email = email };
            }

            Console.WriteLine("Busy rooms: ");

            for(int i = 0; i < vect.Length; i++)
            {
               if(vect[i] != null) Console.WriteLine(i + " : " + vect[i].Name + ", " + vect[i].Email);

            }
            Console.WriteLine();

        }
    }
}
