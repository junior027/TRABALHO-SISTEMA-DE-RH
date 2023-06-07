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
    public partial class frmBeneficioHoraExtra : Form
    {
        public frmBeneficioHoraExtra()
        {
            InitializeComponent();
        }

        private void frmBeneficioHoraExtra_Load(object sender, EventArgs e)
        {
            rbDiasUteisNao.Checked = true;
            rbDomingosFeriadosNao.Checked = true;
        }

        private void rbDiasUteisSim_CheckedChanged(object sender, EventArgs e)
        {
            panelDiasUteis.Visible = true;
        }

        private void rbDomingosFeriadosSim_CheckedChanged(object sender, EventArgs e)
        {
            panelDomingosFeriados.Visible = true;

        }

        private void rbDomingosFeriadosNao_CheckedChanged(object sender, EventArgs e)
        {
            panelDomingosFeriados.Visible = false;
        }

        private void rbDiasUteisNao_CheckedChanged(object sender, EventArgs e)
        {
            panelDiasUteis.Visible = false;
        }     

        private void btnCalcular_Click_1(object sender, EventArgs e)
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
                
                double valorHora = salario / 220;

                if (rbDomingosFeriadosSim.Checked == true)
                {
                    if (rbDiasUteisSim.Checked == true)
                    {
                        var horasDiasUteis = double.Parse(txtDiasUteis.Text);
                        var horasDomingosFeriados = double.Parse(txtDomingosFeriados.Text);

                        var valorHoraExtra100 = valorHora * 2;
                        var valorTotal100 = valorHoraExtra100 * horasDomingosFeriados;

                        var valorHora50 = valorHora * 0.5;
                        var valorTotal50 = valorHora50 * horasDiasUteis;

                        var horaExtra = valorTotal100 + valorHora50;

                        lblResultado.Text = horaExtra.ToString("C");
                        panelResultado.Visible = true;
                    }
                    else
                    {
                        var horasDomingosFeriados = double.Parse(txtDomingosFeriados.Text);

                        var valorHoraExtra100 = valorHora * 2;
                        var valorTotal100 = valorHoraExtra100 * horasDomingosFeriados;

                        lblResultado.Text = valorTotal100.ToString("C");
                        panelResultado.Visible = true;
                    }
                }
                else
                {
                    var horasDiasUteis = double.Parse(txtDiasUteis.Text);

                    var valorHora50 = valorHora * 0.5;
                    var valorTotal50 = valorHora50 * horasDiasUteis;

                    lblResultado.Text = valorTotal50.ToString("C");
                    panelResultado.Visible = true;
                }
            }
            catch (Exception)
            {
              MessageBox.Show("Informe um valor valido por favor!!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
