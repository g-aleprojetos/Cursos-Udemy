using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int func1 = 25;
            int func2 = 1;
            int func3 = 6;

            int horasFunc1 = 100;
            int horasFunc2 = 200;
            int horasFunc3 = 145;

            float valorHoraFunc1 = 5.50f;
            float valorHoraFunc2 = 20.50f;
            float valorHoraFunc3 = 15.55f;

            float salaryFunc1 = horasFunc1 * valorHoraFunc1;
            float salaryFunc2 = horasFunc2 * valorHoraFunc2;
            float salaryFunc3 = horasFunc3 * valorHoraFunc3;

            Console.WriteLine(" Number = {0} \n Salary = {1:F2} \n", func1, salaryFunc1);
            Console.WriteLine(" Number = {0} \n Salary = {1:F2} \n", func2, salaryFunc2);
            Console.WriteLine(" Number = {0} \n Salary = {1:F2} \n", func3, salaryFunc3);
        }
    }
}
