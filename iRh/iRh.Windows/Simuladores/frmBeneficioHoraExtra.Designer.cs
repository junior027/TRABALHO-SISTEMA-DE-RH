namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioHoraExtra
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rbDiasUteisSim = new System.Windows.Forms.RadioButton();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.panelDomingosFeriados = new System.Windows.Forms.Panel();
            this.labelDomingosFeriados = new System.Windows.Forms.Label();
            this.txtDomingosFeriados = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblHorasDiasUteis = new System.Windows.Forms.Label();
            this.txtDiasUteis = new System.Windows.Forms.TextBox();
            this.lblDiasUteis = new System.Windows.Forms.Label();
            this.rbDiasUteisNao = new System.Windows.Forms.RadioButton();
            this.gbDiasUteis = new System.Windows.Forms.GroupBox();
            this.panelDiasUteis = new System.Windows.Forms.Panel();
            this.gbDomingosFeriados = new System.Windows.Forms.GroupBox();
            this.lblDomingosFeriados = new System.Windows.Forms.Label();
            this.rbDomingosFeriadosSim = new System.Windows.Forms.RadioButton();
            this.rbDomingosFeriadosNao = new System.Windows.Forms.RadioButton();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDomingosFeriados.SuspendLayout();
            this.gbDiasUteis.SuspendLayout();
            this.panelDiasUteis.SuspendLayout();
            this.gbDomingosFeriados.SuspendLayout();
            this.panelResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(29, 352);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // rbDiasUteisSim
            // 
            this.rbDiasUteisSim.AutoSize = true;
            this.rbDiasUteisSim.Location = new System.Drawing.Point(10, 62);
            this.rbDiasUteisSim.Name = "rbDiasUteisSim";
            this.rbDiasUteisSim.Size = new System.Drawing.Size(42, 17);
            this.rbDiasUteisSim.TabIndex = 1;
            this.rbDiasUteisSim.TabStop = true;
            this.rbDiasUteisSim.Text = "Sim";
            this.rbDiasUteisSim.UseVisualStyleBackColor = true;
            this.rbDiasUteisSim.CheckedChanged += new System.EventHandler(this.rbDiasUteisSim_CheckedChanged);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(23, 56);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(107, 20);
            this.txtSalario.TabIndex = 2;
            // 
            // panelDomingosFeriados
            // 
            this.panelDomingosFeriados.Controls.Add(this.labelDomingosFeriados);
            this.panelDomingosFeriados.Controls.Add(this.txtDomingosFeriados);
            this.panelDomingosFeriados.Location = new System.Drawing.Point(312, 230);
            this.panelDomingosFeriados.Name = "panelDomingosFeriados";
            this.panelDomingosFeriados.Size = new System.Drawing.Size(200, 100);
            this.panelDomingosFeriados.TabIndex = 3;
            // 
            // labelDomingosFeriados
            // 
            this.labelDomingosFeriados.AutoSize = true;
            this.labelDomingosFeriados.Location = new System.Drawing.Point(3, 15);
            this.labelDomingosFeriados.Name = "labelDomingosFeriados";
            this.labelDomingosFeriados.Size = new System.Drawing.Size(155, 13);
            this.labelDomingosFeriados.TabIndex = 6;
            this.labelDomingosFeriados.Text = "Informe as horas do funcionario";
            // 
            // txtDomingosFeriados
            // 
            this.txtDomingosFeriados.Location = new System.Drawing.Point(6, 52);
            this.txtDomingosFeriados.Name = "txtDomingosFeriados";
            this.txtDomingosFeriados.Size = new System.Drawing.Size(107, 20);
            this.txtDomingosFeriados.TabIndex = 6;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(20, 20);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(154, 13);
            this.lblSalario.TabIndex = 5;
            this.lblSalario.Text = "Informe o salário do funcionario";
            // 
            // lblHorasDiasUteis
            // 
            this.lblHorasDiasUteis.AutoSize = true;
            this.lblHorasDiasUteis.Location = new System.Drawing.Point(3, 12);
            this.lblHorasDiasUteis.Name = "lblHorasDiasUteis";
            this.lblHorasDiasUteis.Size = new System.Drawing.Size(155, 13);
            this.lblHorasDiasUteis.TabIndex = 6;
            this.lblHorasDiasUteis.Text = "Informe as horas do funcionario";
            // 
            // txtDiasUteis
            // 
            this.txtDiasUteis.Location = new System.Drawing.Point(6, 43);
            this.txtDiasUteis.Name = "txtDiasUteis";
            this.txtDiasUteis.Size = new System.Drawing.Size(107, 20);
            this.txtDiasUteis.TabIndex = 6;
            // 
            // lblDiasUteis
            // 
            this.lblDiasUteis.AutoSize = true;
            this.lblDiasUteis.Location = new System.Drawing.Point(7, 28);
            this.lblDiasUteis.Name = "lblDiasUteis";
            this.lblDiasUteis.Size = new System.Drawing.Size(147, 13);
            this.lblDiasUteis.TabIndex = 6;
            this.lblDiasUteis.Text = "Realizou trabalhos dias uteis?";
            // 
            // rbDiasUteisNao
            // 
            this.rbDiasUteisNao.AutoSize = true;
            this.rbDiasUteisNao.Location = new System.Drawing.Point(75, 62);
            this.rbDiasUteisNao.Name = "rbDiasUteisNao";
            this.rbDiasUteisNao.Size = new System.Drawing.Size(45, 17);
            this.rbDiasUteisNao.TabIndex = 7;
            this.rbDiasUteisNao.TabStop = true;
            this.rbDiasUteisNao.Text = "Não";
            this.rbDiasUteisNao.UseVisualStyleBackColor = true;
            this.rbDiasUteisNao.CheckedChanged += new System.EventHandler(this.rbDiasUteisNao_CheckedChanged);
            // 
            // gbDiasUteis
            // 
            this.gbDiasUteis.Controls.Add(this.lblDiasUteis);
            this.gbDiasUteis.Controls.Add(this.rbDiasUteisSim);
            this.gbDiasUteis.Controls.Add(this.rbDiasUteisNao);
            this.gbDiasUteis.Location = new System.Drawing.Point(15, 110);
            this.gbDiasUteis.Name = "gbDiasUteis";
            this.gbDiasUteis.Size = new System.Drawing.Size(300, 100);
            this.gbDiasUteis.TabIndex = 7;
            this.gbDiasUteis.TabStop = false;
            // 
            // panelDiasUteis
            // 
            this.panelDiasUteis.Controls.Add(this.lblHorasDiasUteis);
            this.panelDiasUteis.Controls.Add(this.txtDiasUteis);
            this.panelDiasUteis.Location = new System.Drawing.Point(23, 230);
            this.panelDiasUteis.Name = "panelDiasUteis";
            this.panelDiasUteis.Size = new System.Drawing.Size(200, 100);
            this.panelDiasUteis.TabIndex = 4;
            // 
            // gbDomingosFeriados
            // 
            this.gbDomingosFeriados.Controls.Add(this.lblDomingosFeriados);
            this.gbDomingosFeriados.Controls.Add(this.rbDomingosFeriadosSim);
            this.gbDomingosFeriados.Controls.Add(this.rbDomingosFeriadosNao);
            this.gbDomingosFeriados.Location = new System.Drawing.Point(353, 110);
            this.gbDomingosFeriados.Name = "gbDomingosFeriados";
            this.gbDomingosFeriados.Size = new System.Drawing.Size(300, 100);
            this.gbDomingosFeriados.TabIndex = 8;
            this.gbDomingosFeriados.TabStop = false;
            // 
            // lblDomingosFeriados
            // 
            this.lblDomingosFeriados.AutoSize = true;
            this.lblDomingosFeriados.Location = new System.Drawing.Point(7, 28);
            this.lblDomingosFeriados.Name = "lblDomingosFeriados";
            this.lblDomingosFeriados.Size = new System.Drawing.Size(208, 13);
            this.lblDomingosFeriados.TabIndex = 6;
            this.lblDomingosFeriados.Text = "Realizou trabalhos em domingos e feriados";
            // 
            // rbDomingosFeriadosSim
            // 
            this.rbDomingosFeriadosSim.AutoSize = true;
            this.rbDomingosFeriadosSim.Location = new System.Drawing.Point(10, 62);
            this.rbDomingosFeriadosSim.Name = "rbDomingosFeriadosSim";
            this.rbDomingosFeriadosSim.Size = new System.Drawing.Size(42, 17);
            this.rbDomingosFeriadosSim.TabIndex = 1;
            this.rbDomingosFeriadosSim.TabStop = true;
            this.rbDomingosFeriadosSim.Text = "Sim";
            this.rbDomingosFeriadosSim.UseVisualStyleBackColor = true;
            this.rbDomingosFeriadosSim.CheckedChanged += new System.EventHandler(this.rbDomingosFeriadosSim_CheckedChanged);
            // 
            // rbDomingosFeriadosNao
            // 
            this.rbDomingosFeriadosNao.AutoSize = true;
            this.rbDomingosFeriadosNao.Location = new System.Drawing.Point(75, 62);
            this.rbDomingosFeriadosNao.Name = "rbDomingosFeriadosNao";
            this.rbDomingosFeriadosNao.Size = new System.Drawing.Size(45, 17);
            this.rbDomingosFeriadosNao.TabIndex = 7;
            this.rbDomingosFeriadosNao.TabStop = true;
            this.rbDomingosFeriadosNao.Text = "Não";
            this.rbDomingosFeriadosNao.UseVisualStyleBackColor = true;
            this.rbDomingosFeriadosNao.CheckedChanged += new System.EventHandler(this.rbDomingosFeriadosNao_CheckedChanged);
            // 
            // panelResultado
            // 
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(559, 361);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(180, 68);
            this.panelResultado.TabIndex = 7;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(3, 12);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::iRh.Windows.Properties.Resources.hora;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(806, 457);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmBeneficioHoraExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.gbDomingosFeriados);
            this.Controls.Add(this.panelDiasUteis);
            this.Controls.Add(this.gbDiasUteis);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.panelDomingosFeriados);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmBeneficioHoraExtra";
            this.Text = "frmBeneficioHoraExtra";
            this.Load += new System.EventHandler(this.frmBeneficioHoraExtra_Load);
            this.panelDomingosFeriados.ResumeLayout(false);
            this.panelDomingosFeriados.PerformLayout();
            this.gbDiasUteis.ResumeLayout(false);
            this.gbDiasUteis.PerformLayout();
            this.panelDiasUteis.ResumeLayout(false);
            this.panelDiasUteis.PerformLayout();
            this.gbDomingosFeriados.ResumeLayout(false);
            this.gbDomingosFeriados.PerformLayout();
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton rbDiasUteisSim;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Panel panelDomingosFeriados;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblHorasDiasUteis;
        private System.Windows.Forms.TextBox txtDiasUteis;
        private System.Windows.Forms.Label lblDiasUteis;
        private System.Windows.Forms.RadioButton rbDiasUteisNao;
        private System.Windows.Forms.GroupBox gbDiasUteis;
        private System.Windows.Forms.TextBox txtDomingosFeriados;
        private System.Windows.Forms.Label labelDomingosFeriados;
        private System.Windows.Forms.Panel panelDiasUteis;
        private System.Windows.Forms.GroupBox gbDomingosFeriados;
        private System.Windows.Forms.Label lblDomingosFeriados;
        private System.Windows.Forms.RadioButton rbDomingosFeriadosSim;
        private System.Windows.Forms.RadioButton rbDomingosFeriadosNao;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}