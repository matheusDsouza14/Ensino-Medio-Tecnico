using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppListaExercicio01_2etapa
{
    public partial class FrmExercicio4 : Form
    {
        public FrmExercicio4()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
           //Receber valores
            int qtd_maca = int.Parse(txtQtd_maca.Text);
            float resultado;
            //Processamento 
            if (qtd_maca <= 12)
            {
                //Calculo
                resultado = qtd_maca * 0.25f;
                //Mostrar Resultado
                resultado.ToString;
                lblResultado.Text = "O valor total será: R$ " + resultado;
            }
            else
            {
                //Calculo
                resultado = qtd_maca * 0.3f;
                //Mostrar Resultado
                resultado.ToString;
                lblResultado.Text = "O valor total será: R$ " + resultado;
            }       
        }
    }
}
