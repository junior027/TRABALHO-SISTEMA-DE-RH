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
    public partial class frmBeneficioFgts : Form
    {
        public frmBeneficioFgts()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Informe seu salário base por favor!!!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }

            try
            {
                var salario = double.Parse(txtSalario.Text);
                var deconto = Fgts.calcula(salario);

                lblResultado.Text = deconto.ToString("C");
                panelResultado.Visible = true;
            }

            catch (Exception)
            {
                MessageBox.Show("Informe um valor valido por favor!!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
