using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCSV.model
{
    class Pessoa
    {
        private int _id;
        private string _nome;
        private string _cpf;
        private string _cnh;
        private string _telefone;
        private string _endereco;
        private bool _ativo;
        private Usuario _usario;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Cnh { get => _cnh; set => _cnh = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Endereco { get => _endereco; set => _endereco = value; }
        public bool Ativo { get => _ativo; set => _ativo = value; }
        internal Usuario Usuario { get => _usario; set => _usario = value; }
    }
}
