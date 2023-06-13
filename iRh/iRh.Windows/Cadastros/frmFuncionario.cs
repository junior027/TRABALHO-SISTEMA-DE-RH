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

namespace iRh.Windows.Cadastros
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private CarregarEstados()
        {
            var estado = new Estados();
            var listaEstados = estado.ObterTodosEstados();

            cmbEstados.Items.Clear();
            cmbEstados.DataSource = listaEstados;
            cmbEstados.DisplayMember = "Sigla";
            cmbEstados.ValueMember = "Id";
               
        }

        public object CarregarEstados { get; private set; }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            CarregarEstados 

        }
    }
}
