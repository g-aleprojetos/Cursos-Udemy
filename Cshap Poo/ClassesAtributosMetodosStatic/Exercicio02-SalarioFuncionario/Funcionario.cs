using System.Globalization;


namespace Exercicio02_SalarioFuncionario
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        public double NovoSalario;
       

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentoSalario(double porcentagemAumento)
        {

            NovoSalario = SalarioBruto * ( 1 + (porcentagemAumento / 100)) - Imposto;
        }

        public override string ToString()
        {
            return "Dados atualizados: "
                + Nome
                + ", $ "
                + NovoSalario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
