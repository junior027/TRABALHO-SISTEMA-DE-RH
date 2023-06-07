using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    internal class AdicionalNoturno
    {
        const double cargaHoraria = 220;
        const double porcentagemAdicionalNoturno = 0.2;      
        public static double Calcula(double salario, double horas)
        {
            double valorAdicionalNoturno = 0;

            var valorHora = salario / cargaHoraria;

            var valorHoraTrabalhada = valorHora * porcentagemAdicionalNoturno;
            valorAdicionalNoturno = valorHoraTrabalhada * horas;

            return valorAdicionalNoturno;
        }
    }
}
