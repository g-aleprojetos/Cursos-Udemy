using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.Write("Digite o nome da primeira pessoa: ");
            p1.Nome = Console.ReadLine();

            Console.Write("Digite a idade da pessoa: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da segunda pessoa: ");
            p2.Nome = Console.ReadLine();

            Console.Write("Digite a idade da pessoa: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if(p1.Idade > p2.Idade)
            {
                Console.WriteLine($"A pessoa mais velha : {p1.Nome}");
            }
            else
            {
                Console.WriteLine($"A pessoa mais velha : {p2.Nome}");
            }
        }
    }
}
