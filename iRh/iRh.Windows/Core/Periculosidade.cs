using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    internal class Periculosidade
    {
        public static double Calcula(double salario)
        {
            var receberPericulosidade = salario * 0.03;

            return receberPericulosidade;
        }
    }
}
