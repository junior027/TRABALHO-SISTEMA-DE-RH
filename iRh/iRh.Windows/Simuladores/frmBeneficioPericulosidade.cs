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
    public partial class frmBeneficioPericulosidade : Form
    {
        public frmBeneficioPericulosidade()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Informe as horaspor favor!!!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }

            try
            {
                var salario = double.Parse(txtSalario.Text);
                var receberPericulosidade = salario * 0.03;
                var inss = Inss.Calcula(salario);
                var irrf = Irpf.Calcula(salario);
                var adicionalNoturno = AdicionalNoturno.Calcula(salario, receberPericulosidade);
                var totalReceber = receberPericulosidade + inss + irrf + adicionalNoturno;

                lblResultado.Text = ("o total que irá receber é: ") + totalReceber.ToString("C");
                panelResultado.Visible = true;
            }

            catch (Exception)
            {
                MessageBox.Show("Informe um valor valido por favor!!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
