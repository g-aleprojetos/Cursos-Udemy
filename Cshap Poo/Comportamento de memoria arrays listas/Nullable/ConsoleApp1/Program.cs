using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            int opcaoUsuario;

            do{
                //menu
                Console.WriteLine();
                Console.WriteLine("1 - adicionar");
                Console.WriteLine("2 - ler");
                Console.WriteLine("3 - modificar");
                Console.WriteLine("4 - remover");
                Console.WriteLine("5 - sair");
                Console.WriteLine();

                Console.Write("Digite a opção desejada: ");
                opcaoUsuario = int.Parse(Console.ReadLine());

                //1 - adicionar nome
                if (opcaoUsuario == 1)
                {
                    Console.WriteLine();
                    Console.Write("Digite o nome do usuario: ");


                    string nome = Console.ReadLine();
                    string s1 = names.Find(x => x == nome);
                    if (s1 != nome) names.Add(nome); 
                }

                //1 - ler
                else if (opcaoUsuario == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Nomes cadastrados:");
                    foreach (string obj in names)
                    {
                        Console.WriteLine(obj);
                    }
                }

                //3 - modificar
                else if(opcaoUsuario == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Nomes cadastrados:");
                    foreach (string obj in names)
                    {
                        Console.WriteLine(obj);
                    }
                    Console.WriteLine();
                    Console.Write("Digite o nome a ser modificado: ");
                    string nomeModificado = Console.ReadLine();
                    string s1 = names.Find(x => x == nomeModificado);
                    if(s1 == nomeModificado)
                    {
                        Console.Write("Digite o novo nome: ");
                        string novoNome = Console.ReadLine();
                        int posicao = names.FindIndex(x => x == nomeModificado);
                        names.Insert(posicao, novoNome);
                        names.Remove(nomeModificado);

                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Esse nome não esta na lista!");
                    }
                }

                //remover
                else if(opcaoUsuario == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Nomes cadastrados:");
                    foreach (string obj in names)
                    {
                        Console.WriteLine(obj);
                    }
                    Console.WriteLine();
                    Console.Write("Digite o nome a ser removido: ");
                    string nomeRemovido = Console.ReadLine();
                    string s1 = names.Find(x => x == nomeRemovido);

                    if(s1 == nomeRemovido)
                    {
                        names.Remove(nomeRemovido);
                    }
                    else
                    {
                        Console.WriteLine("Esse nome não esta na lista!");
                    }
                }
             
            } while (opcaoUsuario != 5);
        }
    }
}
