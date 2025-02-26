using System.Globalization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora02
{
    public partial class FrmCalculadora : Form
    {
        decimal result = 0;
        decimal result2 = 0;
        String operacao = "";
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "0";
        }

        private void Btn01_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "1";
        }

        private void Btn02_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "2";
        }

        private void Btn03_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "3";
        }

        private void Btn04_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "4";
        }

        private void Btn05_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "5";
        }

        private void Btn06_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "6";
        }

        private void Btn07_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "7";
        }

        private void Btn08_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "8";
        }

        private void Btn09_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "9";
        }

        private void btnBtnLimpar_Click(object sender, EventArgs e)
        {
            txtTela.Text = "";
            result = 0;
            result2 = 0;
            lbl_op.Text = "";
            lbl_op2.Text = "";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + ".";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            result2 = decimal.Parse(txtTela.Text,CultureInfo.InvariantCulture);
            switch (operacao)
            {
                case "+":
                    txtTela.Text = Convert.ToString(result + result2);
                    break;
                case "-":
                    txtTela.Text = Convert.ToString(result - result2);
                    break;
                case "*":
                    txtTela.Text = Convert.ToString(result * result2);
                    break;
                case "/":
                    txtTela.Text = Convert.ToString(result / result2);
                    break;
            }
        }

        private void btnAdição_Click(object sender, EventArgs e)
        {
            result = decimal.Parse(txtTela.Text, CultureInfo.InvariantCulture);
            txtTela.Text = "";
            string valor = Convert.ToString(result);
            operacao = "+";
            lbl_op.Text = $"{valor}" + "+";
            lbl_op2.Text = "+";
        }

        private void btnSubtração_Click(object sender, EventArgs e)
        {
            result = decimal.Parse(txtTela.Text, CultureInfo.InvariantCulture);
            txtTela.Text = "";
            string valor = Convert.ToString(result);
            operacao = "-";
            lbl_op.Text = $"{valor}" + "-";
            lbl_op2.Text = "-";
        }

        private void btnDivisão_Click(object sender, EventArgs e)
        {
            result = decimal.Parse(txtTela.Text, CultureInfo.InvariantCulture);
            txtTela.Text = "";
            string valor = Convert.ToString(result);
            operacao = "+";
            lbl_op.Text = $"{valor}" + "-";
            lbl_op2.Text = "+";
        }

        private void btnMultiplicação_Click(object sender, EventArgs e)
        {
            result = decimal.Parse(txtTela.Text, CultureInfo.InvariantCulture);
            txtTela.Text = "";
            string valor = Convert.ToString(result);
            operacao = "*";
            lbl_op.Text = $"{valor}" + "*";
            lbl_op2.Text = "*";
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
