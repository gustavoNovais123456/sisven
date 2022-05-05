using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISVEN.model
{
    class Cliente
    {
        private int id;
        private string cpf;
        private string rg;
        private string instagram;
        private string sexo;
        private DateTime nascimento;
        private Pessoa pessoa;

        public int Id { get => id; set => id = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Instagram { get => instagram; set => instagram = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public DateTime Nascimento { get => nascimento; set => nascimento = value; }
        internal Pessoa Pessoa { get => pessoa; set => pessoa = value; }
    }
}
