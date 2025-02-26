using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resumo_Herança_e_Polimorfismo
{
    internal class Pessoa
    {
        private string nome;
        // Get (extrai valor) e Set(envia valor)
        public string Nome
        {
            get { return nome; }
            set { nome = value; } //Value --> valor que o usuário informara em outra classe
        }
    }
}
