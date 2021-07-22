using System;

namespace FuncoesInteressanteParaString
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG    ";

            string s1 = original.ToUpper();//tranforma todos em maiúsculas
            string s2 = original.ToLower();//transforma todos em minúsculos
            string s3 = original.Trim();//apaga os espaços brancos no final
            
            int n1 = original.IndexOf("bc");//mostra a primeira ocorência
            int n2 = original.LastIndexOf("bc");//mostra a ultima ocorência

            string s4 = original.Substring(3);//recorta as 3 primeiras posições
            string s5 = original.Substring(3, 5);//recota as 3 primeiras posições e as depois da 5 posição

            string s6 = original.Replace('a', 'x');//substitue a letra a pela x
            string s7 = original.Replace("abc", "xy");//substitue o abc pelo xy

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("ToUpper: -" + s3 + "-");
            Console.WriteLine();
            Console.WriteLine("IndexOf('bc'):  -" + n1 + "-");
            Console.WriteLine("LastIndexOf('bc'):  -" + n2 + "-");
            Console.WriteLine();
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine();
            Console.WriteLine("Replace('a', 'x')= -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine();
            Console.WriteLine("IsNullOrEmpty(original): " + b1);
            Console.WriteLine("IsNullOrWhiteSpace(original): " + b2);
            Console.WriteLine();
        }
    }
}
