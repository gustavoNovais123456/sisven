using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISVEN.model
{
    class Pessoa
    {
        private int id;
        private string nome;
        private string celular;
        private string telefone;
        private Endereco endereco;
        private bool ativo;

        public int Id { get => id; set => id = value; }
        public string Nome { get => Nome; set => Nome = value; }
        public string Celular { get => Celular; set => Celular = value; }
        public string Telefone { get => Telefone; set => Telefone = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        internal Endereco Endereco { get => endereco; set => endereco = value; }
    }
}
