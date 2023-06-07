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
    public partial class frmBeneficioAdicionalNoturno : Form
    {
        public frmBeneficioAdicionalNoturno()
        {
            InitializeComponent();
        }

        private void btnCacular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalario.Text))
            {

                MessageBox.Show("Informe seu salário base por favor!!!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtHoras.Text))
            {

                MessageBox.Show("Informe as horaspor favor!!!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoras.Focus();
                return;
            }

            try
            {
                var salario = double.Parse(txtSalario.Text);
                var horas = double.Parse(txtHoras.Text);
                var desconto = AdicionalNoturno.Calcula(salario, horas);

                lblResultado.Text = desconto.ToString("C");
                panelResultado.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um valor valido por favor!!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
