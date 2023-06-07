namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioPis
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
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblMeses = new System.Windows.Forms.Label();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(23, 245);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(20, 24);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(154, 13);
            this.lblSalario.TabIndex = 1;
            this.lblSalario.Text = "Informe o salário do funcionário";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(23, 53);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 2;
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Location = new System.Drawing.Point(20, 129);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(225, 13);
            this.lblMeses.TabIndex = 3;
            this.lblMeses.Text = "Informe a quantidade de meses do funcionário";
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(23, 159);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(100, 20);
            this.txtMeses.TabIndex = 4;
            // 
            // panelResultado
            // 
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(23, 338);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(200, 100);
            this.panelResultado.TabIndex = 5;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(20, 19);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado";
            // 
            // frmBeneficioPis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.txtMeses);
            this.Controls.Add(this.lblMeses);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frmBeneficioPis";
            this.Text = "frmBeneficioPis";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}