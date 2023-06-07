namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioAdicionalNoturno
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
            this.btnCacular = new System.Windows.Forms.Button();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblHoras = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCacular
            // 
            this.btnCacular.Location = new System.Drawing.Point(12, 181);
            this.btnCacular.Name = "btnCacular";
            this.btnCacular.Size = new System.Drawing.Size(87, 41);
            this.btnCacular.TabIndex = 0;
            this.btnCacular.Text = "Cacular";
            this.btnCacular.UseVisualStyleBackColor = true;
            this.btnCacular.Click += new System.EventHandler(this.btnCacular_Click);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(12, 19);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(154, 13);
            this.lblSalario.TabIndex = 1;
            this.lblSalario.Text = "Informe o salário do funcionário";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(15, 55);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 2;
            // 
            // panelResultado
            // 
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(12, 338);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(200, 100);
            this.panelResultado.TabIndex = 3;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(9, 119);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(216, 13);
            this.lblHoras.TabIndex = 4;
            this.lblHoras.Text = "Informe as horas  trabalhadas do funcionário";
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(12, 135);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(100, 20);
            this.txtHoras.TabIndex = 5;
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
            // frmBeneficioAdicionalNoturno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.btnCacular);
            this.Name = "frmBeneficioAdicionalNoturno";
            this.Text = "frmBeneficioAdicionalNoturno";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCacular;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Label lblResultado;
    }
}