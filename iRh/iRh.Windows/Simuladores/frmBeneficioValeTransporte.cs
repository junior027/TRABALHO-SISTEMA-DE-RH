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
    public partial class frmBeneficioValeTransporte : Form
    {
        public frmBeneficioValeTransporte()
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
                    var salario = double.Parse(txtSalario.Text);
                    var desconto = ValeTransporte.Calculo(salario);

                    lblResultado.Text = desconto.ToString("C");                     
                }
                catch (Exception)
                {
                    MessageBox.Show("Informe um valor valido por favor!!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            
        }
    }
}
