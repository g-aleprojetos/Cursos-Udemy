using System;
using System.Globalization;

namespace Exercicio02_SalarioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double porcentagemAumento;

            Funcionario funcionario1 = new Funcionario();

            Console.WriteLine();
            Console.Write("Nome:");
            funcionario1.Nome = Console.ReadLine();

            Console.Write("Salário Bruto:  ");
            funcionario1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            funcionario1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario: " + funcionario1.Nome + " $ " + funcionario1.SalarioLiquido());

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            porcentagemAumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario1.AumentoSalario(porcentagemAumento);

            Console.WriteLine(funcionario1);
            Console.WriteLine();

        }
    }
}
