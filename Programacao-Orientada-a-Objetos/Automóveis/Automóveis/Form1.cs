using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automóveis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnInserir_Click(object sender, EventArgs e)
        {
            Carro vei = new Carro();
            int id_carro = int.Parse(txtIdCarro.Text);
            string marca_carro = txtMarca.Text;
            string modelo_carro = txtModelo.Text;
            int ano_carro = int.Parse(txtAno.Text);
            string cor_carro = txtCor.Text;
            int valor_carro = int.Parse(txtValor.Text);
            MessageBox.Show($"\n Codigo: {vei.Id} \n Modelo: {vei.Modelo} \n Marca : {vei.Marca} \n Ano : {vei.Ano} \n Cor : {vei.Cor} \n Valor : {vei.Valor}");
        }

        private void btnInserirMotos_Click(object sender, EventArgs e)
        {
            Moto vei = new Moto();
            int id_moto = int.Parse(txtIdMoto.Text);
            string marca_moto= txtMarccaMoto.Text;
            string modelo_moto = txtModeloMoto.Text;
            int ano_moto = int.Parse(txtAnoMoto.Text);
            string cor_moto = txtCorMoto.Text;
            int valor_moto = int.Parse(txtValorMoto.Text);
            MessageBox.Show($"\n Codigo: {vei.Id} \n Modelo: {vei.Modelo} \n Marca : {vei.Marca} \n Ano : {vei.Ano} \n Cor : {vei.Cor} \n Valor : {vei.Valor}");
        }

        private void btnInserirOnibus_Click(object sender, EventArgs e)
        {
            Onibus vei = new Onibus();
            int id_onibus = int.Parse(txtIdOnibus.Text);
            string marca_onibus = txtMarcaOnibus.Text;
            string modelo_onibus = txtModeloOnibus.Text;
            int ano_onibus = int.Parse(txtAnoOnibus.Text);
            string cor_onibus = txtCorOnibus.Text;
            int valor_onibus = int.Parse(txtValorOnibus.Text);
            MessageBox.Show($"\n Codigo: {vei.Id} \n Modelo: {vei.Modelo} \n Marca : {vei.Marca} \n Ano : {vei.Ano} \n Cor : {vei.Cor} \n Valor : {vei.Valor}");
        }

        private void btnInserirCaminhao_Click(object sender, EventArgs e)
        {
            Caminhao vei = new Caminhao();
            int id_caminhao = int.Parse(txtIdCaminhao.Text);
            string marca_caminhao = txtMarcaCaminhao.Text;
            string modelo_caminhao = txtModeloCaminhao.Text;
            int ano_caminhao = int.Parse(txtAnoCaminhao.Text);
            string cor_caminhao = txtCorCaminhao.Text;
            int valor_caminhao = int.Parse(txtValorCaminhao.Text);
            MessageBox.Show($"\n Codigo: {vei.Id} \n Modelo: {vei.Modelo} \n Marca : {vei.Marca} \n Ano : {vei.Ano} \n Cor : {vei.Cor} \n Valor : {vei.Valor}");
        }
    }
}
