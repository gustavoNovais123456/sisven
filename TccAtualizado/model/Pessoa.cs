using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TccAtualizado.model
{
    class Pessoa
    {
        private int _id;
        private string _cpf;
        private string _rg;
        private string _nome;
        private string _fone;
        private string _fone2;
        private string _tipo_pessoa;
        private bool _ativo;
        private Endereco _endereco;

        public int Id { get => _id; set => _id = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Rg { get => _rg; set => _rg = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Fone { get => _fone; set => _fone = value; }
        public string Tipo_pessoa { get => _tipo_pessoa; set => _tipo_pessoa = value; }
        public bool Ativo { get => _ativo; set => _ativo = value; }
        public string Fone2 { get => _fone2; set => _fone2 = value; }
        internal Endereco Endereco { get => _endereco; set => _endereco = value; }
    }
}
