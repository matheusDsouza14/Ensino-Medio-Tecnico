namespace AppListaExercicio01_2etapa
{
    partial class FrmExercicio4
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
            this.lblQtd_maca = new System.Windows.Forms.Label();
            this.txtQtd_maca = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQtd_maca
            // 
            this.lblQtd_maca.AutoSize = true;
            this.lblQtd_maca.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.lblQtd_maca.Location = new System.Drawing.Point(31, 156);
            this.lblQtd_maca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtd_maca.Name = "lblQtd_maca";
            this.lblQtd_maca.Size = new System.Drawing.Size(306, 39);
            this.lblQtd_maca.TabIndex = 0;
            this.lblQtd_maca.Text = "Quantidade de maças";
            // 
            // txtQtd_maca
            // 
            this.txtQtd_maca.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.txtQtd_maca.Location = new System.Drawing.Point(39, 246);
            this.txtQtd_maca.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtd_maca.Name = "txtQtd_maca";
            this.txtQtd_maca.Size = new System.Drawing.Size(319, 46);
            this.txtQtd_maca.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.btnCalcular.Location = new System.Drawing.Point(39, 364);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(225, 83);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.lblResultado.Location = new System.Drawing.Point(43, 474);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 39);
            this.lblResultado.TabIndex = 3;
            // 
            // FrmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 626);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtQtd_maca);
            this.Controls.Add(this.lblQtd_maca);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmExercicio4";
            this.Text = "FrmExercicio04";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQtd_maca;
        private System.Windows.Forms.TextBox txtQtd_maca;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
    }
}