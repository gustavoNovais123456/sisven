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
        private string cpf;
        private string rg;
        private string instagram;
        private string sexo;
        private DateTime nascimento;
        private bool cliente;
        private bool vendedor;
        private bool ativo;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Instagram { get => instagram; set => instagram = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public DateTime Nascimento { get => nascimento; set => nascimento = value; }
        public bool Cliente { get => cliente; set => cliente = value; }
        public bool Vendedor { get => vendedor; set => vendedor = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
    }
}
