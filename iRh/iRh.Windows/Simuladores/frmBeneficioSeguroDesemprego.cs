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
    public partial class frmBeneficioSeguroDesemprego : Form
    {
        public frmBeneficioSeguroDesemprego()
        {
            InitializeComponent();
        }     

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMesesTrabalhados.Text))
            {
                MessageBox.Show("Informe os meses por favor!!!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMesesTrabalhados.Focus();
                return;
            }

            try
            {
                var meses = double.Parse(txtMesesTrabalhados.Text);
                double primeiraSolicitacao = 12;
                double segundaSolicitacao = 9;
                double terceiraSolicitacao = 6;
                double cincoParcelas = 24;
                double quatroPArcelas = 23;
                double tresParcelas = 11;
                if (checkBoxJustaCausa.Checked)
                {
                    if(checkBoxDesemprego.Checked)
                    {
                        if(checkBoxRendaPropria.Checked)
                        {
                            if (checkBoxPrevidenciaSocial.Checked)
                            {
                                if(checkBoxSolicitacao1.Checked == true)
                                {
                                    if(meses >= primeiraSolicitacao)
                                    {                                      
                                        if(meses >= primeiraSolicitacao & meses > cincoParcelas)
                                        {
                                            lblResultado.Text = "colaborador tem direito 5 parcelas ";
                                        }
                                        else
                                        {
                                            lblResultado.Text = "colaborador tem direito 4 parcelas";
                                        }
                                    }
                                    
                                    else
                                    {
                                        lblResultado.Text = "Nõa tem direito ao seguro";
                                    }
                                    
                                }
                                else if(checkBoxSolicitacao2.Checked == true)
                                {
                                    if(meses > segundaSolicitacao)
                                    {
                                        if(meses >= segundaSolicitacao & meses > tresParcelas)
                                        {
                                            lblResultado.Text = "colaborador tem direito 5 parcelas ";
                                        }
                                        else if(meses >= primeiraSolicitacao & meses > quatroPArcelas)
                                        {
                                            lblResultado.Text = "colaborador tem direito 4 parcelas";
                                        }
                                        else
                                        {
                                            lblResultado.Text = "colaborador tem direito 3 parcelas";
                                        }
                                    }
                                    else
                                    {
                                        lblResultado.Text = "Nõa tem direito ao seguro";
                                    }
                                }
                                else if(checkBoxSolicitacao3.Checked == true)
                                {
                                    if (meses >= terceiraSolicitacao)
                                    {
                                        if(meses > cincoParcelas)
                                        {
                                            lblResultado.Text = "colaborador tem direito 5 parcelas ";
                                        }
                                        else if(meses >= quatroPArcelas)
                                        {
                                            lblResultado.Text = "colaborador tem direito 4 parcelas ";
                                        }
                                        else
                                        {
                                            lblResultado.Text = "colaborador tem direito 3 parcelas ";
                                        }
                                    }
                                    else
                                    {
                                        lblResultado.Text = "Nõa tem direito ao seguro";
                                    }
                                }
                                else
                                {
                                    lblResultado.Text = "Nõa tem direito ao seguro";
                                }
                            }
                            else
                            {
                                lblResultado.Text = "Nõa tem direito ao seguro";
                            }
                        }
                        else
                        {
                            lblResultado.Text = "Nõa tem direito ao seguro";
                        }
                    }
                    else
                    {
                        lblResultado.Text = "Nõa tem direito ao seguro";
                    }
                }
                else
                {
                    lblResultado.Text = "Nõa tem direito ao seguro";
                }
              
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um valor valido por favor!!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmBeneficioSeguroDesemprego_Load(object sender, EventArgs e)
        {

        }
    }
}
