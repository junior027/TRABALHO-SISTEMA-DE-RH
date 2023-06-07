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
    public partial class frmBeneficioPis : Form
    {
        public frmBeneficioPis()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                if (string.IsNullOrEmpty(txtMeses.Text))
                {
                    MessageBox.Show("Informe seu salário base por favor!!!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSalario.Focus();
                    return;
                }
            }
            try
            {
              double primeiroValor = 1100; double porcentagem1 = 0.075;
              double segundoValor = 2100; double porcentagem2 = 0.09;
              double terceiroValor = 3200; double porcentagem3 = 0.1;
              double quartoValor = 4300; double porcentagem4 = 0.11;
              double mesesNescessarios = 12;
              double valorPis = 0;
              var salario = double.Parse(txtSalario.Text);
              var meses = double.Parse(txtMeses.Text);

              if (meses > mesesNescessarios)
              {
                 if (salario <= primeiroValor)
                 {
                     valorPis = salario * porcentagem1;
                 }
                 else if (salario <= segundoValor)
                 {
                     valorPis = salario * porcentagem2;
                 }
                 else if (salario <= terceiroValor)
                 {
                      valorPis = salario * porcentagem3;
                 }
                 else if (salario <= quartoValor)
                 {
                     valorPis = salario * porcentagem4;
                 }
                 else
                 {
                     valorPis = 474.07;
                 }
                 lblResultado.Text = valorPis.ToString("C");
                 panelResultado.Visible = true;
              }
              else
              {
                  lblResultado.Text = "não terá direito ao PIS.";
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
