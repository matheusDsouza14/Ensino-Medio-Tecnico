using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

                // declarar variaveis

                float imc;
                float peso = float.Parse(txtPeso.Text);
                float altura = float.Parse(txtAltura.Text);
                string sexo = txtSexo.Text;

                // calcular e mostrar resultado

                switch (txtSexo.Text)
                {

                    case "m":
                        imc = (peso * altura) - 58;
                        lblResultado.Text = ("Seu peso ideal é de: " + imc);
                        break;

                    case "f":
                        imc = (peso * altura) - 44.7f;
                        lblResultado.Text = ("Seu peso ideal é de: " + imc);
                        break;

                }

                //if (sexo == "m") 
                //{
                //    imc = (peso * altura) - 58;
                //    lblResultado.Text = ("Seu peso ideal é de: " + imc);
                //}
                //else if (sexo == "f")
                //{
                //    imc = (peso * altura) - 44.7f;
                //    lblResultado.Text = ("Seu peso ideal é de: " + imc);
                //}

            }


        }
    }
}
