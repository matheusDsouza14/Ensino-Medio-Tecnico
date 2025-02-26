using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExercicio8_12Apostila
{
    public partial class FrmExercicio8 : Form
    {
        public FrmExercicio8()
        {
            InitializeComponent();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
			int data_atual = int.Parse(txtData_Atual.Text);
			int mes = int.Parse(txtMes.Text);
            int dia = int.Parse(txtDia.Text);
            int ano = int.Parse(txtAno.Text);
            string data = dia + "/" + mes + "/" + ano;
			lblData.Text = data;
			if (data_atual - ano == 18){
				MessageBox.Show = "Você foi cadastrado(a) para o programa";
			}
			else{
				MessageBox.Show = "Você precisa ter mais de 18 para cadastrar nesse programa";
			}
        }
    }
}
