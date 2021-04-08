using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1 = 12;
            int cod2 = 16;
            int cod3 = 13;
            int cod4 = 161;
            int cod5 = 1;
            int cod6 = 2;


            int quantCod1 = 1;
            int quantCod2 = 2;
            int quantCod3 = 2;
            int quantCod4 = 4;
            int quantCod5 = 1;
            int quantCod6 = 1;

            float valorUnitCod1 = 5.30f;
            float valorUnitCod2 = 5.10f;
            float valorUnitCod3 = 15.30f;
            float valorUnitCod4 = 5.20f;
            float valorUnitCod5 = 15.10f;
            float valorUnitCod6 = 15.10f;

            float totalPagar1 = (quantCod1 * valorUnitCod1) + (quantCod2 * valorUnitCod2);
            float totalPagar2 = (quantCod3 * valorUnitCod3) + (quantCod4 * valorUnitCod4);
            float totalPagar3 = (quantCod5 * valorUnitCod5) + (quantCod6 * valorUnitCod6);

            Console.WriteLine("Codigo : {0} quantidade {1}", cod1, quantCod1);
            Console.WriteLine("Codigo : {0} quantidade {1}", cod2, quantCod2);
            Console.WriteLine("Valor total a pagar da compra = {0:F2} \n", totalPagar1);

            Console.WriteLine("Codigo :  {0} quantidade {1}", cod3, quantCod3);
            Console.WriteLine("Codigo : {0} quantidade {1}", cod4, quantCod4);
            Console.WriteLine("Valor total a pagar da compra = {0:F2} \n", totalPagar2);

            Console.WriteLine("Codigo : {0} quantidade {1}", cod5, quantCod5);
            Console.WriteLine("Codigo : {0} quantidade {1}", cod6, quantCod6);
            Console.WriteLine("Valor total a pagar da compra = {0:F2} \n", totalPagar3);
        }
    }
}
