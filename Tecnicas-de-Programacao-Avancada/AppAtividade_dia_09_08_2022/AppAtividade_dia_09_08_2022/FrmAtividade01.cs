using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAtividade_dia_09_08_2022
{
    public partial class FrmAtividade01 : Form
    {
        public FrmAtividade01()
        {
            InitializeComponent();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int matricula = int.Parse(txtMatricula.Text);
            string nome = txtNome.Text;
            string sexo = cmbSexo.Text;
            string turma = txtTurma.Text;
            string descrição = txtDescricao.Text;
            //Fiquei em duvida de qual usar então to te mandando os dois 
            //Versão com switch case
            switch{
                case (matricula = "")
                MessageBox.Show("Não é possivel deixaer campos em branco");
                    break
            case (nome = "")
                MessageBox.Show("Não é possivel deixaer campos em branco");
            break
            case (sexo = "")
                MessageBox.Show("Não é possivel deixaer campos em branco");
            break
            case (turma = "")
                MessageBox.Show("Não é possivel deixaer campos em branco");
            break
            case (descrição = "")
                MessageBox.Show("Não é possivel deixaer campos em branco");
            break
            case
                if (matricula < 1000 & matricula < 9999)
                {
                    MessageBox.Show("Digite um valor valido");

                }
                else
                {
                    MessageBox.Show("Cadastro realizado");
                }
            break
            }
            //Versão com if e else
        }
        private void limpar_campos(object sender, EventArgs e)
        {
            int matricula = int.Parse(txtMatricula.Text);
            string nome = txtNome.Text;
            string sexo = cmbSexo.Text;
            string turma = txtTurma.Text;
            string descrição = txtDescricao.Text;
        }
    }
}