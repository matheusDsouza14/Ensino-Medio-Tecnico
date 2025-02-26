using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automóveis
{
    internal class Carro : Veiculo
    {

    }
    internal class Moto : Veiculo
    {

    }
    internal class Onibus : Veiculo
    {

    }
    internal class Caminhao : Veiculo
    {

    }
    internal class Veiculo
    {
        private int _id;
        private string _marca;
        private string _modelo;
        private DateTime _ano;
        private string _cor;
        private double _valor;
        public int Id { get { return _id; } set { _id = value; } }
        public string Marca { get { return _marca; } set { _marca = value; } }
        public string Modelo { get { return _modelo; } set { _modelo = value; } }
        public DateTime Ano { get { return _ano; } set { _ano = value; } }
        public string Cor { get { return _cor; } set { _cor = value; } }
        public double Valor { get { return _valor; } set { _valor = value; } }
    }

}
