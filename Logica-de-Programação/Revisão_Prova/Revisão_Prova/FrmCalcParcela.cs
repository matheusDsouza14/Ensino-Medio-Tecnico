using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revisão_Prova
{
    public partial class FrmCalcParcela : Form
    {
        public FrmCalcParcela()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Receber valores
            float vlrProduto = float.Parse(txtVlrProduto.Text);
            float parcela1;
            float parcela2;
            float parcela3;
            float parcela4;
            float parcela5;
            float parcela6;
            float parcela7;
            float parcela8;
            float parcela9;
            float parcela10;
            float parcela11;
            float parcela12;
            //Processamento
            parcela1 = vlrProduto / 1f;
            parcela2 = vlrProduto / 2f;
            parcela3 = vlrProduto / 3f;
            parcela4 = vlrProduto / 4f;
            parcela5 = vlrProduto / 5f;
            parcela6 = vlrProduto / 6f;
            parcela7 = vlrProduto / 7f;
            parcela8 = vlrProduto / 8f;
            parcela9 = vlrProduto / 9f;
            parcela10 = vlrProduto / 10f;
            parcela11 = vlrProduto / 11f;
            parcela12 = vlrProduto / 12f;
            //Mostrar Resultado
            lblParcela1.Text = "1X de: R$ " + parcela1;
            lblParcela2.Text = "2X de: R$ " + parcela2;
            lblParcela3.Text = "3X de: R$ " + parcela3;
            lblParcela4.Text = "4X de: R$ " + parcela4;
            lblParcela5.Text = "5X de: R$ " + parcela5;
            lblParcela6.Text = "6X de: R$ " + parcela6;
            lblParcela7.Text = "7X de: R$ " + parcela7;
            lblParcela8.Text = "8X de: R$ " + parcela8;
            lblParcela9.Text = "9X de: R$ " + parcela9;
            lblParcela10.Text = "10X de: R$ " + parcela10;
            lblParcela11.Text = "11X de: R$ " + parcela11;
            lblParcela12.Text = "12X de: R$ " + parcela12;
        }
    }
}
