using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    internal class ValeTransporte
    {
        const double porcentagemVale = 0.06;
        public static double Calculo(double salario)
        {
            var descontoVale = salario * porcentagemVale;

            return descontoVale;
        }
    }
}
