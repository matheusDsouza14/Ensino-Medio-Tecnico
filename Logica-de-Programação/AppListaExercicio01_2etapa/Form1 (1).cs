using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteDeSwicht
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (txtArea.Text) {
                case "3" :
                    MessageBox.Show("triangulo");
                    break;
                case "4":
                    MessageBox.Show("Quadrado");
                    break ;
                    default : MessageBox.Show("Invalido");
                    break;
            }
        }
    }
}
