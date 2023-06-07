using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    internal class Fgts
    {
        public static double calcula(double salario)
        {
            const double porcentagem = 0.08;

            var decontoFgts = salario * porcentagem;

            return decontoFgts;
        }
    }
}
