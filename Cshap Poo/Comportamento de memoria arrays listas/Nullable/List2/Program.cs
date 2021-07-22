using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace List2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Add("Luis");
            list.Add("Alexandre");
            list.Add("Caio");
            list.Add("Annabella");
            list.Insert(2, "Marco");

            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count);
           
            Console.WriteLine("Find");
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            Console.WriteLine("FindLast");
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            Console.WriteLine("FindIndex");
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("FirstIndex position 'A': " + pos1);

            Console.WriteLine("FindLastIndex");
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("LastIndex position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("----------------------------");
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");
            Console.WriteLine("----------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("----------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(1);
            Console.WriteLine("----------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveRange(2,2);
            Console.WriteLine("----------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
