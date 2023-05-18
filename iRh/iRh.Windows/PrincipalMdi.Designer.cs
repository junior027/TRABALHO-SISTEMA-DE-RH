namespace iRh.Windows
{
    partial class PrincipalMdi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalMdi));
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuCadastroFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simuladoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDescontoInss = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDEscontoIrrf = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuBeneficioAdicionalNoturno = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBeneficioDepositoFgts = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBeneficioFerias = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBeneficioHoraExtra = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBeneficioPericulosidade = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBeneficioPis = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBeneficioSeguroDesemprego = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBeneficioValeTransporte = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastroFuncionario,
            this.simuladoresToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menuStripPrincipal.TabIndex = 1;
            this.menuStripPrincipal.Text = "menuStrip1";
            // 
            // MenuCadastroFuncionario
            // 
            this.MenuCadastroFuncionario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.MenuCadastroFuncionario.Name = "MenuCadastroFuncionario";
            this.MenuCadastroFuncionario.Size = new System.Drawing.Size(71, 20);
            this.MenuCadastroFuncionario.Text = "Cadastros";
            this.MenuCadastroFuncionario.Click += new System.EventHandler(this.funcionariosToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroToolStripMenuItem.Text = "Funcionarios";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // simuladoresToolStripMenuItem
            // 
            this.simuladoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDescontoInss,
            this.MenuDEscontoIrrf,
            this.toolStripSeparator1,
            this.MenuBeneficioAdicionalNoturno,
            this.MenuBeneficioDepositoFgts,
            this.MenuBeneficioFerias,
            this.MenuBeneficioHoraExtra,
            this.MenuBeneficioPericulosidade,
            this.MenuBeneficioPis,
            this.MenuBeneficioSeguroDesemprego,
            this.MenuBeneficioValeTransporte});
            this.simuladoresToolStripMenuItem.Name = "simuladoresToolStripMenuItem";
            this.simuladoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.simuladoresToolStripMenuItem.Text = "Simuladores";
            this.simuladoresToolStripMenuItem.Click += new System.EventHandler(this.simuladoresToolStripMenuItem_Click);
            // 
            // MenuDescontoInss
            // 
            this.MenuDescontoInss.Name = "MenuDescontoInss";
            this.MenuDescontoInss.Size = new System.Drawing.Size(249, 22);
            this.MenuDescontoInss.Text = "Desconto de inss";
            // 
            // MenuDEscontoIrrf
            // 
            this.MenuDEscontoIrrf.Name = "MenuDEscontoIrrf";
            this.MenuDEscontoIrrf.Size = new System.Drawing.Size(249, 22);
            this.MenuDEscontoIrrf.Text = "Desconto de IRPF";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(246, 6);
            // 
            // MenuBeneficioAdicionalNoturno
            // 
            this.MenuBeneficioAdicionalNoturno.Name = "MenuBeneficioAdicionalNoturno";
            this.MenuBeneficioAdicionalNoturno.Size = new System.Drawing.Size(249, 22);
            this.MenuBeneficioAdicionalNoturno.Text = "Beneficio  de Adicional Noturno";
            // 
            // MenuBeneficioDepositoFgts
            // 
            this.MenuBeneficioDepositoFgts.Name = "MenuBeneficioDepositoFgts";
            this.MenuBeneficioDepositoFgts.Size = new System.Drawing.Size(249, 22);
            this.MenuBeneficioDepositoFgts.Text = "Beneficio  de Depósito de FGTS";
            // 
            // MenuBeneficioFerias
            // 
            this.MenuBeneficioFerias.Name = "MenuBeneficioFerias";
            this.MenuBeneficioFerias.Size = new System.Drawing.Size(249, 22);
            this.MenuBeneficioFerias.Text = "Beneficio de Férias";
            // 
            // MenuBeneficioHoraExtra
            // 
            this.MenuBeneficioHoraExtra.Name = "MenuBeneficioHoraExtra";
            this.MenuBeneficioHoraExtra.Size = new System.Drawing.Size(249, 22);
            this.MenuBeneficioHoraExtra.Text = "Beneficio de Hora Extra";
            // 
            // MenuBeneficioPericulosidade
            // 
            this.MenuBeneficioPericulosidade.Name = "MenuBeneficioPericulosidade";
            this.MenuBeneficioPericulosidade.Size = new System.Drawing.Size(249, 22);
            this.MenuBeneficioPericulosidade.Text = "Beneficio  de Periculosidade";
            // 
            // MenuBeneficioPis
            // 
            this.MenuBeneficioPis.Name = "MenuBeneficioPis";
            this.MenuBeneficioPis.Size = new System.Drawing.Size(249, 22);
            this.MenuBeneficioPis.Text = "Beneficio  de PIS";
            // 
            // MenuBeneficioSeguroDesemprego
            // 
            this.MenuBeneficioSeguroDesemprego.Name = "MenuBeneficioSeguroDesemprego";
            this.MenuBeneficioSeguroDesemprego.Size = new System.Drawing.Size(249, 22);
            this.MenuBeneficioSeguroDesemprego.Text = "Beneficio de Seguro Desemprego";
            // 
            // MenuBeneficioValeTransporte
            // 
            this.MenuBeneficioValeTransporte.Name = "MenuBeneficioValeTransporte";
            this.MenuBeneficioValeTransporte.Size = new System.Drawing.Size(249, 22);
            this.MenuBeneficioValeTransporte.Text = "Beneficio de Vale Transporte";
            // 
            // PrincipalMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStripPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Name = "PrincipalMdi";
            this.Text = "PrincipalMdi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PrincipalMdi_Load);
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastroFuncionario;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simuladoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuDescontoInss;
        private System.Windows.Forms.ToolStripMenuItem MenuDEscontoIrrf;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuBeneficioAdicionalNoturno;
        private System.Windows.Forms.ToolStripMenuItem MenuBeneficioDepositoFgts;
        private System.Windows.Forms.ToolStripMenuItem MenuBeneficioFerias;
        private System.Windows.Forms.ToolStripMenuItem MenuBeneficioHoraExtra;
        private System.Windows.Forms.ToolStripMenuItem MenuBeneficioPericulosidade;
        private System.Windows.Forms.ToolStripMenuItem MenuBeneficioPis;
        private System.Windows.Forms.ToolStripMenuItem MenuBeneficioSeguroDesemprego;
        private System.Windows.Forms.ToolStripMenuItem MenuBeneficioValeTransporte;
    }
}