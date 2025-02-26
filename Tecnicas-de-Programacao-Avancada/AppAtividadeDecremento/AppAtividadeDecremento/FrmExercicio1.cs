using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAtividadeDecremento
{
    public partial class FrmExercicio1 : Form
    {
        public FrmExercicio1()
        {
            InitializeComponent();
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int contador;
            if (num2 <= num1)
            {
                MessageBox.Show("Desculpe mas o valor 1 deve ser menor que o 2");
            }
            else
            {
                contador = num2;
                while(num2 >= num1)
                {
                    contador = contador - 1;
                    lblShow.Text += contador.ToString + "\n"; /* Possui um erro nessa linha , não mostra o fresultado. Tela trava*/
                }
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        private void limparCampos()
        {
            lblShow.Text = "";
            txtNum1.Text = "";
            txtNum2.Text = "";
        }

        
    }
}
