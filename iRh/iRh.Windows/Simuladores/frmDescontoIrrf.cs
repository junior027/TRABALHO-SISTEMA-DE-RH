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
    public partial class frmDescontoIrrf : Form
    {
        public frmDescontoIrrf()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalario.Text))
            {

                MessageBox.Show("Informe seu salário base por favor!!!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }

            try
            {
                const double descontoSimplificado = 528.00;
                var salarioLiquido = double.Parse(txtSalario.Text);
                var salario = salarioLiquido - Inss.Calcula(salarioLiquido);
                var desconto = Irpf.Calcula(salario);
                lblResultado.Text = desconto.ToString("C");
            }

            catch (Exception)
            {
                MessageBox.Show("Informe um valor valido por favor!!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void frmDescontoIrrf_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
