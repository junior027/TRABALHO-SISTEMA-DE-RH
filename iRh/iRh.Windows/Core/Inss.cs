using System.Runtime.CompilerServices;

namespace iRh.Windows.Core
{
    public static class Inss
    {
        const double Faixa01 = 1320.0;
        const double Faixa02 = 2571.29;
        const double Faixa03 = 3856.94;
        const double Faixa04 = 7507.49;
        public static double Calcula(double salario)
        {

            double valorInss = 0;
            if (salario <= Faixa01)
            {
                valorInss = 0.075 * salario;

            }else if(salario <= Faixa02)
            {
                var descontoFaixa1 = CalculaFaixa1(salario);
                valorInss = (salario - Faixa01) + descontoFaixa1;

            }else if (salario <= Faixa03)
            {
                var descontoFaixa1 = CalculaFaixa1(salario);
                var descontoFaixa2 = CalculaFaixa2(salario);
                valorInss = 12/100 * (salario - Faixa02) + descontoFaixa1 + descontoFaixa2;

            }else if(salario <= Faixa04)
            {
                var descontoFaixa1 = CalculaFaixa1(salario);
                var descontoFaixa2 = CalculaFaixa2(salario);
                var descontoFaixa3 = CalculaFaixa3(salario);

                valorInss = 0.14 * (salario - Faixa03) 
                    + descontoFaixa1 + descontoFaixa2 + descontoFaixa3;
            }else
            {
                var descontoFaixa1 = CalculaFaixa1(salario);
                var descontoFaixa2 = CalculaFaixa2(salario);
                var descontoFaixa3 = CalculaFaixa3(salario);
                valorInss = 0.14 * (Faixa04 - Faixa03)
                    + descontoFaixa1 + descontoFaixa2 + descontoFaixa3;
            }
            return valorInss;
        }
        private static double CalculaFaixa1(double salario)
        {
            return (0.075 * Faixa01);
        }
        private static double CalculaFaixa2(double salario)
        {
            return 0.09 * (Faixa02 - Faixa01);
        }
        private static double CalculaFaixa3(double salario)
        {
            return 0.12 * (Faixa03 - Faixa02);
        }
    }
}
