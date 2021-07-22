using System;
using System.Collections.Generic;

namespace Ex1_list
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("How many employees will be registered? ");
            int numberRegister = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for(int i = 0; i < numberRegister; i++)
            {
                Console.Write("Id: ");
                long id = long.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                employees.Add = (id, nome, salary);
            }

        }
    }
}
