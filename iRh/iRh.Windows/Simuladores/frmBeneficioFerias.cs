using iRh.Windows.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioFerias : Form
    {
        public frmBeneficioFerias()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var salario = double.Parse(txtSalario.Text);
            double divisor = 3;
            var inss = Inss.Calcula(salario);
            var irpf = Irpf.Calcula(salario);

            var tercoFerias = salario / divisor;
            var total = salario + tercoFerias;
            var totalReceber = total - irpf - inss;
            lblResultado.Text = totalReceber.ToString("C");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmBeneficioFerias_Load(object sender, EventArgs e)
        {

        }
    }
}
