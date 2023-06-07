using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    internal class Irpf
    {

        const double faixaIrrf1 = 1903.98; const double porcentagemDescconto1 = 0.075; const double desconto1 = 142.80;
        const double faixaIrrf2 = 2826.65; const double porcentagemDescconto2 = 0.15; const double desconto2 = 354.80;
        const double faixaIrrf3 = 3751.05; const double porcentagemDescconto3 = 0.22; const double desconto3 = 636.23;
        const double faixaIrrf4 = 4664.68; const double porcentagemDescconto4 = 0.275; const double desconto4 = 869.34;
        public static double Calcula(double salario)
        {
            double valorIrrf = 0;

            if (salario < faixaIrrf1)
            {
                valorIrrf = 0;
            }
            else if (salario < faixaIrrf2)
            {
                valorIrrf = (salario * porcentagemDescconto1) - desconto1;
            }
            else if (salario < faixaIrrf2)
            {
                valorIrrf = (salario * porcentagemDescconto2) - desconto2;
            }
            else if (salario < faixaIrrf3)
            {
                valorIrrf = (salario * porcentagemDescconto3) - desconto3;
            }
            else
            {
                valorIrrf = (salario * porcentagemDescconto4) - desconto4;
            }
            return valorIrrf;
        }
    }
}
