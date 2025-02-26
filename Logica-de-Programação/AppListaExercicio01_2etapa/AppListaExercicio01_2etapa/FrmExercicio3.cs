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
    public partial class FrmExercicio3 : Form
    {
        public FrmExercicio3()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            //Receive value
            string user = txtUser.Text;
            int password = int.Parse(txtPassword.Text);
            // Conditions
            if(user == "admin" && password == 1234)
            {
                MessageBox.Show("Acesso permitido");
            }
            else
            {
                MessageBox.Show("Acesso negado");
            }
        }
    }
}
