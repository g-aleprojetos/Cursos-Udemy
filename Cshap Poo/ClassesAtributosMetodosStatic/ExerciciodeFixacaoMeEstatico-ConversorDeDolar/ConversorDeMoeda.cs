using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciodeFixacaoMeEstatico_ConversorDeDolar
{
    class ConversorDeMoeda
    {
        public static double Iof = 0.06;


        public static double Conversor(double valorDolar, double quantDolar)
        {
            return (quantDolar * valorDolar) * (1 + Iof);
        }


    }
}
