namespace AppListaExercicio01_2etapa
{
    partial class FrmExercicio6
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
            System.Windows.Forms.TextBox txtNum_Lado;
            this.lblNum_Lados = new System.Windows.Forms.Label();
            this.lblResultsdo = new System.Windows.Forms.Label();
            this.btn_mostresultado = new System.Windows.Forms.Button();
            txtNum_Lado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNum_Lado
            // 
            txtNum_Lado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            txtNum_Lado.Location = new System.Drawing.Point(36, 222);
            txtNum_Lado.Name = "txtNum_Lado";
            txtNum_Lado.Size = new System.Drawing.Size(390, 44);
            txtNum_Lado.TabIndex = 2;
            // 
            // lblNum_Lados
            // 
            this.lblNum_Lados.AutoSize = true;
            this.lblNum_Lados.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum_Lados.Location = new System.Drawing.Point(29, 168);
            this.lblNum_Lados.Name = "lblNum_Lados";
            this.lblNum_Lados.Size = new System.Drawing.Size(397, 37);
            this.lblNum_Lados.TabIndex = 3;
            this.lblNum_Lados.Text = "Digite o numero de lados";
            // 
            // lblResultsdo
            // 
            this.lblResultsdo.AutoSize = true;
            this.lblResultsdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblResultsdo.Location = new System.Drawing.Point(41, 282);
            this.lblResultsdo.Name = "lblResultsdo";
            this.lblResultsdo.Size = new System.Drawing.Size(0, 37);
            this.lblResultsdo.TabIndex = 4;
            // 
            // btn_mostresultado
            // 
            this.btn_mostresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostresultado.Location = new System.Drawing.Point(36, 338);
            this.btn_mostresultado.Name = "btn_mostresultado";
            this.btn_mostresultado.Size = new System.Drawing.Size(249, 45);
            this.btn_mostresultado.TabIndex = 5;
            this.btn_mostresultado.Text = "Mostrar Resultado";
            this.btn_mostresultado.UseVisualStyleBackColor = true;
            this.btn_mostresultado.Click += new System.EventHandler(this.btn_mostresultado_Click);
            // 
            // FrmExercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 568);
            this.Controls.Add(this.btn_mostresultado);
            this.Controls.Add(this.lblResultsdo);
            this.Controls.Add(this.lblNum_Lados);
            this.Controls.Add(txtNum_Lado);
            this.Name = "FrmExercicio6";
            this.Text = "FrmExercicio6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNum_Lados;
        private System.Windows.Forms.Label lblResultsdo;
        private System.Windows.Forms.Button btn_mostresultado;
    }
}