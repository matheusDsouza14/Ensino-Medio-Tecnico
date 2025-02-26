using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Aula_12_05_23
{
    class Aluno
    {
        private int Id;
        private string nome;
        private string cpf;
        private string matricula;
        private string email;
        private string telefone;
        public void setId(int Id)
        {
            this.Id = Id;
        }
        public int getId()
        {
            return Id;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return nome;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public string getCpf()
        {
            return cpf;
        }
        public void setMatricula(string matricula)
        {
            this.matricula = matricula;
        }
        public string getMatricula()
        {
            return matricula;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getEmail()
        {
            return email;
        }
        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }
        public string getTelefone()
        {
            return telefone;
        }
    }
    class Professor
    {
        private int Id;
        private string nome;
        private string cpf;
        private string matricula;
        private string email;
        private string telefone;
        public void setId(int Id)
        {
            this.Id = Id;
        }
        public int getId()
        {
            return Id;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return nome;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public string getCpf()
        {
            return cpf;
        }
        public void setMatricula(string matricula)
        {
            this.matricula = matricula;
        }
        public string getMatricula()
        {
            return matricula;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getEmail()
        {
            return email;
        }
        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }
        public string getTelefone()
        {
            return telefone;
        }
    }
    class Curso
    {
        private int Id;
        private string descricao;
        private int carga_horaria;
        private string turno;
        public void setId(int Id)
        {
            this.Id = Id;
        }
        public int getId()
        {
            return Id;
        }
        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }
        public string getDescricao()
        {
            return descricao;
        }
        public void setCargaHoraria(int carga_horaria)
        {
            this.carga_horaria = carga_horaria;
        }
        public int getCargaHoraria()
        {
            return carga_horaria;
        }
        public void setTurno(string turno)
        {
            this.turno = turno;
        }
        public string getTurno()
        {
            return turno;
        }
    }
    class Disciplinas
    {
        private int Id;
        private string nome;
        private int carga_horaria;
        private string turno;
        public void setId(int Id)
        {
            this.Id = Id;
        }
        public int getId()
        {
            return Id;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return nome;
        }
        public void setCargaHoraria(int carga_horaria)
        {
            this.carga_horaria = carga_horaria;
        }
        public int getCargaHoraria()
        {
            return carga_horaria;
        }
        public void setTurno(string turno)
        {
            this.turno = turno;
        }
        public string getTurno()
        {
            return turno;
        }
    }
}
