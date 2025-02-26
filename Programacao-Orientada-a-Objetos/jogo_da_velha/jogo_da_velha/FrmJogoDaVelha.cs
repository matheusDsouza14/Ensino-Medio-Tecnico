using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_da_velha
{
    public partial class FrmJogoDaVelha : Form
    {
        public FrmJogoDaVelha()
        {
            InitializeComponent();
        }
        bool player = true ;
        private void btnQuadro1_Click(object sender, EventArgs e)
        {
            if (player)
            {
                btnQuadro1.Text = "X";
                player = false;
            }
            else
            {
                btnQuadro1.Text = "O";
                player = true;
            }
            btnQuadro1.Enabled = false;
        }
        private void btnQuadro2_Click(object sender, EventArgs e)
        {
            if (player)
            {
                btnQuadro2.Text = "X";
                player = false;
            }
            else
            {
                btnQuadro2.Text = "O";
                player = true;
            }
            btnQuadro2.Enabled = false;

        }
        private void btnQuadro3_Click(object sender, EventArgs e)
        {
            if (player)
            {
                btnQuadro3.Text = "X";
                player = false;
            }
            else
            {
                btnQuadro3.Text = "O";
                player = true;
            }
            btnQuadro3.Enabled = false;
        }
        private void btnQuadro4_Click(object sender, EventArgs e)
        {
            if (player)
            {
                btnQuadro4.Text = "X";
                player = false;
            }
            else
            {
                btnQuadro4.Text = "O";
                player = true;
            }
            btnQuadro4.Enabled = false;
        }
        private void btnQuadro5_Click(object sender, EventArgs e)
        {
            if (player)
            {
                btnQuadro5.Text = "X";
                player = false;
            }
            else
            {
                btnQuadro5.Text = "O";
                player = true;
            }
            btnQuadro5.Enabled = false;
        }
        private void btnQuadro6_Click(object sender, EventArgs e)
        {
            if (player)
            {
                btnQuadro6.Text = "X";
                player = false;
            }
            else
            {
                btnQuadro6.Text = "O";
                player = true;
            }
            btnQuadro6.Enabled = false;
        }
        private void btnQuadro7_Click(object sender, EventArgs e)
        {
            if (player)
            {
                btnQuadro7.Text = "X";
                player = false;
            }
            else
            {
                btnQuadro7.Text = "O";
                player = true;
            }
            btnQuadro7.Enabled = false;
        }
        private void btnQuadro8_Click(object sender, EventArgs e)
        {
            if (player)
            {
                btnQuadro8.Text = "X";
                player = false;
            }
            else
            {
                btnQuadro8.Text = "O";
                player = true;
            }
            btnQuadro8.Enabled = false;
        }
        private void btnQuadro9_Click(object sender, EventArgs e)
        {
            if (player)
            {
                btnQuadro9.Text = "X";
                player = false;
            }
            else
            {
                btnQuadro9.Text = "O";
                player = true;
            }
            btnQuadro9.Enabled = false;
        }
        private void teste (object sender, EventArgs e) 
        {
            string teste = "";
            if (player == 1)
            {
                teste = "X";
                if ((teste == btnQuadro1.Text)&&(teste == btnQuadro2.Text)&&(teste == btnQuadro3.Text))
                {
                    MessageBox.Show("A bola venceu");
                }
                else
                {
                    teste = "O";
                    if ((teste == btnQuadro1.Text)&&(teste == btnQuadro2.Text) && (teste == btnQuadro3.Text))
                    {
                        MessageBox.Show("o X venceu");
                    }   
                }
            }
        }1
        private void teste2 (object sender, EventArgs e)
        {
            string teste = "";
            if (player == 1)
            {
                teste = "X";
                if ((teste == btnQuadro1.Text) && (teste == btnQuadro2.Text) && (teste == btnQuadro3.Text))
                {
                    MessageBox.Show("A bola venceu");
                }
                else
                {
                    teste = "O";
                    if ((teste == btnQuadro1.Text) && (teste == btnQuadro2.Text) && (teste == btnQuadro3.Text))
                    {
                        MessageBox.Show("o X venceu");
                    }
                }
            }
        }
        private void teste3 (object sender, EventArgs e)
        {
            string teste = "";
            if (player == 1)
            {
                teste = "X";
                if ((teste == btnQuadro1.Text) && (teste == btnQuadro2.Text) && (teste == btnQuadro3.Text))
                {
                    MessageBox.Show("A bola venceu");
                }
                else
                {
                    teste = "O";
                    if ((teste == btnQuadro1.Text) && (teste == btnQuadro2.Text) && (teste == btnQuadro3.Text))
                    {
                        MessageBox.Show("o X venceu");
                    }
                }
            }
        }
        private void teste4(object sender, EventArgs e)
        {
            string teste = "";
            if (player == 1)
            {
                teste = "X";
                if ((teste == btnQuadro1.Text) && (teste == btnQuadro2.Text) && (teste == btnQuadro3.Text))
                {
                    MessageBox.Show("A bola venceu");
                }
                else
                {
                    teste = "O";
                    if ((teste == btnQuadro1.Text) && (teste == btnQuadro2.Text) && (teste == btnQuadro3.Text))
                    {
                        MessageBox.Show("o X venceu");
                    }
                }
            }
            private void teste5(object sender, EventArgs e)
            {
                string teste = "";
                if (player == 1)
                {
                    teste = "X";
                    if ((teste == btnQuadro1.Text) && (teste == btnQuadro2.Text) && (teste == btnQuadro3.Text))
                    {
                        MessageBox.Show("A bola venceu");
                    }
                    else
                    {
                        teste = "O";
                        if ((teste == btnQuadro1.Text) && (teste == btnQuadro2.Text) && (teste == btnQuadro3.Text))
                        {
                            MessageBox.Show("o X venceu");
                        }
                    }
                }
            }
            private void teste6(object sender, EventArgs e)
            {
                string teste = "";
                if (player == 1)
                {
                    teste = "X";
                    if ((teste == btnQuadro1.Text) && (teste == btnQuadro2.Text) && (teste == btnQuadro3.Text))
                    {
                        MessageBox.Show("A bola venceu");
                    }
                    else
                    {
                        teste = "O";
                        if ((teste == btnQuadro1.Text) && (teste == btnQuadro2.Text) && (teste == btnQuadro3.Text))
                        {
                            MessageBox.Show("o X venceu");
                        }
                    }
                }
                private void teste7(object sender, EventArgs e)
                {
                    string teste = "";
                    if (player == 1)
                    {
                        teste = "X";
                        if ((teste == btnQuadro1.Text) && (teste == btnQuadro2.Text) && (teste == btnQuadro3.Text))
                        {
                            MessageBox.Show("A bola venceu");
                        }
                        else
                        {
                            teste = "O";
                            if ((teste == btnQuadro1.Text) && (teste == btnQuadro2.Text) && (teste == btnQuadro3.Text))
                            {
                                MessageBox.Show("o X venceu");
                            }
                        }
                    }
                }
                private void teste8(object sender, EventArgs e)
                {
                    string teste = "";
                    if (player == 1)
                    {
                        teste = "X";
                        if ((teste == btnQuadro1.Text) && (teste == btnQuadro2.Text) && (teste == btnQuadro3.Text))
                        {
                            MessageBox.Show("A bola venceu");
                        }
                        else
                        {
                            teste = "O";
                            if ((teste == btnQuadro1.Text) && (teste == btnQuadro2.Text) && (teste == btnQuadro3.Text))
                            {
                                MessageBox.Show("o X venceu");
                            }
                        }
                    }
                }
            }
        } 
        }
}
