using System;
using System.Globalization;

namespace Exercicio03_NotaDoAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            
            Console.Write("Digite o nome do aluno: ");
            aluno.NomeAluno = Console.ReadLine();

            Console.WriteLine("Digite as notas: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine();
            Console.WriteLine(aluno);
        }
    }
}
