using System.Globalization;


namespace Exercicio03_NotaDoAluno
{
    class Aluno
    {
        public string NomeAluno;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double Resultado;
        public double FaltaPontos;


        public double valorTotalNota()
        {
            Resultado = Nota1 + Nota2 + Nota3;
            return Resultado;
            
        }


        public override string ToString()
        {
            valorTotalNota();

            if (Resultado >= 60)
            {
                return "Nota Final: "
                    + Resultado.ToString("F2", CultureInfo.InvariantCulture)
                    + "\nAprovado";
            }
            else
            {
                FaltaPontos = (60 - Resultado);
                return "Nota Final: "
                    + Resultado.ToString("F2", CultureInfo.InvariantCulture)
                    + "\nReprovado"
                    + "\nFaltaram "
                    + FaltaPontos.ToString("F2", CultureInfo.InvariantCulture)
                    + " Pontos";
            }
            
        }

    }
}
