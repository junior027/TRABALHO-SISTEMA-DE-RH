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
    public partial class frmSimulacaoCompleta : Form
    {
        public frmSimulacaoCompleta()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalarioBruto.Text))
            {
                MessageBox.Show("Informe seu salário base por favor!!!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioBruto.Focus();
                return;
            }
            try
            {
                if (chkvaleTransporte.Checked)
                {
                    var salarioBruto = double.Parse(txtSalarioBruto.Text);
                    var adicionalNoturno = double.Parse(txtNoturno.Text);
                    var horaExtra100 = double.Parse(txtHorasExtras100.Text);
                    var horaExtra50 = double.Parse(txtHoraExtra50.Text);
                    var periculosidade = double.Parse(txtPericulosidade.Text);

                    var inss = Inss.Calcula(salarioBruto);
                    var irpf = Irpf.Calcula(salarioBruto);
                    var fgts = Fgts.calcula(salarioBruto);
                    var valorNoturno = AdicionalNoturno.Calcula(salarioBruto, adicionalNoturno);
                    var valorHora100 = HoraExtra.Calcula(salarioBruto, horaExtra100, horaExtra50);
                    var valorHora50 = HoraExtra.Calcula(salarioBruto, horaExtra100, horaExtra50);
                    var valorValeTransporte = ValeTransporte.Calculo(salarioBruto);
                    var valorPericulosidade = Periculosidade.Calcula(salarioBruto);
                    var valorTotalHoraExtra = valorHora100 + valorHora50;
                    var salarioTotal = salarioBruto - inss;

                    lblResultadoNoturno.Text = valorNoturno.ToString("C");
                    lblResultadoIrpf.Text = irpf.ToString("C");
                    lblResultadoHoraExtra.Text = valorTotalHoraExtra.ToString("C");
                    lblResultadoInss.Text = inss.ToString("C");
                    lblResultadoFgts.Text = fgts.ToString("C");
                    lblResultadoValeTransporte.Text = valorValeTransporte.ToString("C");
                    lblResultadoPericulosidade.Text = valorPericulosidade.ToString("C");
                    lblResultadoSalario.Text = salarioTotal.ToString("C");

                    var totaisAdionais = salarioTotal + valorNoturno + valorPericulosidade + valorTotalHoraExtra;
                    var totaisDescontos = inss + irpf + fgts;
                    var resultadoLiquido = totaisAdionais - totaisDescontos;

                    lblResultadoAdicional.Text = totaisAdionais.ToString("C");
                    lbllblResultadoDesconto.Text = totaisDescontos.ToString("C");
                    lblSalarioReceber.Text = resultadoLiquido.ToString("C");
                    panelResultado.Visible = true;
                }
                else
                {
                    var salarioBruto = double.Parse(txtSalarioBruto.Text);
                    var adicionalNoturno = double.Parse(txtNoturno.Text);
                    var horaExtra100 = double.Parse(txtHorasExtras100.Text);
                    var horaExtra50 = double.Parse(txtHoraExtra50.Text);
                    var periculosidade = double.Parse(txtPericulosidade.Text);

                    var inss = Inss.Calcula(salarioBruto);
                    var irpf = Irpf.Calcula(salarioBruto);
                    var fgts = Fgts.calcula(salarioBruto);
                    var valorNoturno = AdicionalNoturno.Calcula(salarioBruto, adicionalNoturno);
                    var valorHora100 = HoraExtra.Calcula(salarioBruto, horaExtra100, horaExtra50);
                    var valorHora50 = HoraExtra.Calcula(salarioBruto, horaExtra100, horaExtra50);
                    var valorValeTransporte = 0;
                    var valorPericulosidade = Periculosidade.Calcula(salarioBruto);
                    var valorTotalHoraExtra = valorHora100 + valorHora50;
                    var salarioTotal = salarioBruto - inss;

                    lblResultadoNoturno.Text = valorNoturno.ToString("C");
                    lblResultadoIrpf.Text = irpf.ToString("C");
                    lblResultadoHoraExtra.Text = valorTotalHoraExtra.ToString("C");
                    lblResultadoInss.Text = inss.ToString("C");
                    lblResultadoFgts.Text = fgts.ToString("C");
                    lblResultadoValeTransporte.Text = valorValeTransporte.ToString("C");
                    lblResultadoPericulosidade.Text = valorPericulosidade.ToString("C");
                    lblResultadoSalario.Text = salarioTotal.ToString("C");

                    var totaisAdionais = salarioTotal + valorNoturno + valorPericulosidade + valorTotalHoraExtra;
                    var totaisDescontos = inss + irpf + fgts;
                    var resultadoLiquido = totaisAdionais - totaisDescontos;

                    lblResultadoAdicional.Text = totaisAdionais.ToString("C");
                    lbllblResultadoDesconto.Text = totaisDescontos.ToString("C");
                    lblSalarioReceber.Text = resultadoLiquido.ToString("C");
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
