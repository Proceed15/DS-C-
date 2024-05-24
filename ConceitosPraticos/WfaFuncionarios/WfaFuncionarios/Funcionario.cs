using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaFuncionarios
{
    class Funcionario
    {
        private int funcionarioId;

        public int FuncionarioId
        {
            get { return funcionarioId; }
            set { funcionarioId = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string endereco;

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        private string cidade;

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private string cep;

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private string telefone;

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        private string setor;

        public string Setor
        {
            get { return setor; }
            set { setor = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private DateTime dataNasc;

        public DateTime DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }

        //Construtores
        public Funcionario()
        {

        }

        public Funcionario(int funcionarioId, string nome, string endereco, 
            string cidade, string estado, string cep, 
            string cpf, string telefone, string setor, 
            string email, DateTime dataNasc)
        {
            FuncionarioId = funcionarioId;
            Nome = nome;
            Endereco = endereco;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
            Cpf = cpf;
            Telefone = telefone;
            Setor = setor;
            Email = email;
            DataNasc = dataNasc;
        }

        public int IdadeFuncionario()
        {
            DateTime agora = DateTime.Now;
            try
            {
                int idade = (agora.Year - DataNasc.Year);
                if (agora.Month < DataNasc.Month ||
                    (agora.Month == DataNasc.Month && agora.Day < DataNasc.Day))
                {
                    idade--;
                }
                return idade;
            }
            catch
            {

                return 0;
            }
        }

        public override string ToString()
        {
            return "Dados do funcionário: " + FuncionarioId
                + "\r\nNome: " + Nome
                + "\r\nEndereço: " + Endereco
                + "\r\nCidade: " + Cidade
                + "\r\nSetor: " + Setor
                + "\r\nEmail: " + Email
                + "\r\nEstado: " + Estado
                + "\r\nCPF: " + Cpf
                + "\r\nCEP: " + Cep
                + "\r\nTelefone: " + Telefone
                + "\r\nData de Nascimento: " + DataNasc.ToString("dd/MM/yyyy")
                + "\r\nIdade: " + IdadeFuncionario() + " anos\r\n \r\n"; 
        }
    }
}