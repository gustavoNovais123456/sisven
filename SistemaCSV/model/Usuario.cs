using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCSV.model
{
    class Usuario
    {
        private int _id;
        private string _email;
        private string _login;
        private string _senha;
        private string _tipoPessoa;
        private bool _ativo;

        public int Id { get => _id; set => _id = value; }
        public string Email { get => _email; set => _email = value; }
        public string Login { get => _login; set => _login = value; }
        public string Senha { get => _senha; set => _senha = value; }
        public string TipoPessoa { get => _tipoPessoa; set => _tipoPessoa = value; }
        public bool Ativo { get => _ativo; set => _ativo = value; }
    }
}
