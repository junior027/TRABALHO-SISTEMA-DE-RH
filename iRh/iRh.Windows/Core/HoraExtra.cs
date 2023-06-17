using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    internal class HoraExtra
    {
        public static double Calcula(double salario, double hora100, double hora50)
        {
            double valorHora = salario / 220;

            var valorHoraExtra100 = valorHora * 2;
            var valorTotal100 = valorHoraExtra100 * hora100;

            var valorHora50 = valorHora * 0.5;
            var valorTotalHora50 = valorHora50 * hora50;

            var horaExtra = valorTotal100 + valorTotalHora50;
            return horaExtra;

        }
    }
}
