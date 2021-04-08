using System;
using System.Globalization;

namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func1 = new Funcionario();
            Funcionario func2 = new Funcionario();

            Console.Write(" Digite os dados do primeiro funcionário \n Nome: ");
            func1.Nome = Console.ReadLine();
            Console.Write(" Salario: ");
            func1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(" ");

            Console.Write(" Digite os dados do segundo funcionário \n Nome: ");
            func2.Nome = Console.ReadLine();
            Console.Write(" Salario: ");
            func2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double medio = (func1.Salario + func2.Salario) / 2;

            Console.WriteLine("O salário médio : R$ " + medio.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
