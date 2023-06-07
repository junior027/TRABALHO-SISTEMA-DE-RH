namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioSeguroDesemprego
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
            this.btnSimular = new System.Windows.Forms.Button();
            this.lblJustaCausa = new System.Windows.Forms.Label();
            this.checkBoxJustaCausa = new System.Windows.Forms.CheckBox();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblDesemprengo = new System.Windows.Forms.Label();
            this.checkBoxDesemprego = new System.Windows.Forms.CheckBox();
            this.lblRendaPropria = new System.Windows.Forms.Label();
            this.checkBoxRendaPropria = new System.Windows.Forms.CheckBox();
            this.lblPrevidenciaSocial = new System.Windows.Forms.Label();
            this.checkBoxPrevidenciaSocial = new System.Windows.Forms.CheckBox();
            this.lblMesesTrabalhados = new System.Windows.Forms.Label();
            this.txtMesesTrabalhados = new System.Windows.Forms.TextBox();
            this.lblSolicitacao = new System.Windows.Forms.Label();
            this.checkBoxSolicitacao1 = new System.Windows.Forms.CheckBox();
            this.checkBoxSolicitacao3 = new System.Windows.Forms.CheckBox();
            this.checkBoxSolicitacao2 = new System.Windows.Forms.CheckBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(615, 223);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 0;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // lblJustaCausa
            // 
            this.lblJustaCausa.AutoSize = true;
            this.lblJustaCausa.Location = new System.Drawing.Point(12, 23);
            this.lblJustaCausa.Name = "lblJustaCausa";
            this.lblJustaCausa.Size = new System.Drawing.Size(220, 13);
            this.lblJustaCausa.TabIndex = 1;
            this.lblJustaCausa.Text = "Trabalhador foi despensado por justa causa?";
            // 
            // checkBoxJustaCausa
            // 
            this.checkBoxJustaCausa.AutoSize = true;
            this.checkBoxJustaCausa.Location = new System.Drawing.Point(15, 55);
            this.checkBoxJustaCausa.Name = "checkBoxJustaCausa";
            this.checkBoxJustaCausa.Size = new System.Drawing.Size(15, 14);
            this.checkBoxJustaCausa.TabIndex = 2;
            this.checkBoxJustaCausa.UseVisualStyleBackColor = true;
            // 
            // panelResultado
            // 
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(336, 343);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(200, 100);
            this.panelResultado.TabIndex = 3;
            // 
            // lblDesemprengo
            // 
            this.lblDesemprengo.AutoSize = true;
            this.lblDesemprengo.Location = new System.Drawing.Point(12, 90);
            this.lblDesemprengo.Name = "lblDesemprengo";
            this.lblDesemprengo.Size = new System.Drawing.Size(237, 13);
            this.lblDesemprengo.TabIndex = 4;
            this.lblDesemprengo.Text = "o colaborador está em situação de desemprego?";
            // 
            // checkBoxDesemprego
            // 
            this.checkBoxDesemprego.AutoSize = true;
            this.checkBoxDesemprego.Location = new System.Drawing.Point(15, 119);
            this.checkBoxDesemprego.Name = "checkBoxDesemprego";
            this.checkBoxDesemprego.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDesemprego.TabIndex = 5;
            this.checkBoxDesemprego.UseVisualStyleBackColor = true;
            // 
            // lblRendaPropria
            // 
            this.lblRendaPropria.AutoSize = true;
            this.lblRendaPropria.Location = new System.Drawing.Point(12, 157);
            this.lblRendaPropria.Name = "lblRendaPropria";
            this.lblRendaPropria.Size = new System.Drawing.Size(184, 13);
            this.lblRendaPropria.TabIndex = 6;
            this.lblRendaPropria.Text = "\"o colaborador possui renda propria? ";
            // 
            // checkBoxRendaPropria
            // 
            this.checkBoxRendaPropria.AutoSize = true;
            this.checkBoxRendaPropria.Location = new System.Drawing.Point(15, 188);
            this.checkBoxRendaPropria.Name = "checkBoxRendaPropria";
            this.checkBoxRendaPropria.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRendaPropria.TabIndex = 7;
            this.checkBoxRendaPropria.UseVisualStyleBackColor = true;
            // 
            // lblPrevidenciaSocial
            // 
            this.lblPrevidenciaSocial.AutoSize = true;
            this.lblPrevidenciaSocial.Location = new System.Drawing.Point(12, 223);
            this.lblPrevidenciaSocial.Name = "lblPrevidenciaSocial";
            this.lblPrevidenciaSocial.Size = new System.Drawing.Size(407, 13);
            this.lblPrevidenciaSocial.TabIndex = 8;
            this.lblPrevidenciaSocial.Text = "o colaborador está recebendo beneficio de prestação continua da previdência socia" +
    "l";
            // 
            // checkBoxPrevidenciaSocial
            // 
            this.checkBoxPrevidenciaSocial.AutoSize = true;
            this.checkBoxPrevidenciaSocial.Location = new System.Drawing.Point(15, 253);
            this.checkBoxPrevidenciaSocial.Name = "checkBoxPrevidenciaSocial";
            this.checkBoxPrevidenciaSocial.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPrevidenciaSocial.TabIndex = 9;
            this.checkBoxPrevidenciaSocial.UseVisualStyleBackColor = true;
            
            // 
            // lblMesesTrabalhados
            // 
            this.lblMesesTrabalhados.AutoSize = true;
            this.lblMesesTrabalhados.Location = new System.Drawing.Point(612, 150);
            this.lblMesesTrabalhados.Name = "lblMesesTrabalhados";
            this.lblMesesTrabalhados.Size = new System.Drawing.Size(370, 13);
            this.lblMesesTrabalhados.TabIndex = 10;
            this.lblMesesTrabalhados.Text = "informe a quantidade de tempo do colaborador está na empresa (em meses): ";
            
            // 
            // txtMesesTrabalhados
            // 
            this.txtMesesTrabalhados.Location = new System.Drawing.Point(615, 182);
            this.txtMesesTrabalhados.Name = "txtMesesTrabalhados";
            this.txtMesesTrabalhados.Size = new System.Drawing.Size(100, 20);
            this.txtMesesTrabalhados.TabIndex = 11;
            // 
            // lblSolicitacao
            // 
            this.lblSolicitacao.AutoSize = true;
            this.lblSolicitacao.Location = new System.Drawing.Point(612, 35);
            this.lblSolicitacao.Name = "lblSolicitacao";
            this.lblSolicitacao.Size = new System.Drawing.Size(204, 13);
            this.lblSolicitacao.TabIndex = 12;
            this.lblSolicitacao.Text = "informe qual solicitação o funcionario está";
            // 
            // checkBoxSolicitacao1
            // 
            this.checkBoxSolicitacao1.AutoSize = true;
            this.checkBoxSolicitacao1.Location = new System.Drawing.Point(615, 74);
            this.checkBoxSolicitacao1.Name = "checkBoxSolicitacao1";
            this.checkBoxSolicitacao1.Size = new System.Drawing.Size(241, 17);
            this.checkBoxSolicitacao1.TabIndex = 13;
            this.checkBoxSolicitacao1.Text = "Caso seja primeira solicitação do colaborador ";
            this.checkBoxSolicitacao1.UseVisualStyleBackColor = true;
            
            // 
            // checkBoxSolicitacao3
            // 
            this.checkBoxSolicitacao3.AutoSize = true;
            this.checkBoxSolicitacao3.Location = new System.Drawing.Point(615, 114);
            this.checkBoxSolicitacao3.Name = "checkBoxSolicitacao3";
            this.checkBoxSolicitacao3.Size = new System.Drawing.Size(296, 17);
            this.checkBoxSolicitacao3.TabIndex = 14;
            this.checkBoxSolicitacao3.Text = "Caso seja terceira ou mais solicitação do colabolaborador";
            this.checkBoxSolicitacao3.UseVisualStyleBackColor = true;
            // 
            // checkBoxSolicitacao2
            // 
            this.checkBoxSolicitacao2.AutoSize = true;
            this.checkBoxSolicitacao2.Location = new System.Drawing.Point(615, 94);
            this.checkBoxSolicitacao2.Name = "checkBoxSolicitacao2";
            this.checkBoxSolicitacao2.Size = new System.Drawing.Size(241, 17);
            this.checkBoxSolicitacao2.TabIndex = 15;
            this.checkBoxSolicitacao2.Text = "Caso seja primeira solicitação do colaborador ";
            this.checkBoxSolicitacao2.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(3, 12);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 16;
            this.lblResultado.Text = "Resultado";
            // 
            // frmBeneficioSeguroDesemprego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 450);
            this.Controls.Add(this.checkBoxSolicitacao2);
            this.Controls.Add(this.checkBoxSolicitacao3);
            this.Controls.Add(this.checkBoxSolicitacao1);
            this.Controls.Add(this.lblSolicitacao);
            this.Controls.Add(this.txtMesesTrabalhados);
            this.Controls.Add(this.lblMesesTrabalhados);
            this.Controls.Add(this.checkBoxPrevidenciaSocial);
            this.Controls.Add(this.lblPrevidenciaSocial);
            this.Controls.Add(this.checkBoxRendaPropria);
            this.Controls.Add(this.lblRendaPropria);
            this.Controls.Add(this.checkBoxDesemprego);
            this.Controls.Add(this.lblDesemprengo);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.checkBoxJustaCausa);
            this.Controls.Add(this.lblJustaCausa);
            this.Controls.Add(this.btnSimular);
            this.Name = "frmBeneficioSeguroDesemprego";
            this.Text = "frmBeneficioSeguroDesemprego";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Label lblJustaCausa;
        private System.Windows.Forms.CheckBox checkBoxJustaCausa;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblDesemprengo;
        private System.Windows.Forms.CheckBox checkBoxDesemprego;
        private System.Windows.Forms.Label lblRendaPropria;
        private System.Windows.Forms.CheckBox checkBoxRendaPropria;
        private System.Windows.Forms.Label lblPrevidenciaSocial;
        private System.Windows.Forms.CheckBox checkBoxPrevidenciaSocial;
        private System.Windows.Forms.Label lblMesesTrabalhados;
        private System.Windows.Forms.TextBox txtMesesTrabalhados;
        private System.Windows.Forms.Label lblSolicitacao;
        private System.Windows.Forms.CheckBox checkBoxSolicitacao1;
        private System.Windows.Forms.CheckBox checkBoxSolicitacao3;
        private System.Windows.Forms.CheckBox checkBoxSolicitacao2;
        private System.Windows.Forms.Label lblResultado;
    }
}