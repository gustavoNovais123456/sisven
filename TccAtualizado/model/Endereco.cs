using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TccAtualizado.model
{
    class Endereco
    {
        private int _id;
        private string _cep;
        private string _rua;
        private string _bairro;
        private string _complemento;
        private string _numero;
        private string _cidade;
        private string _estado;
        private Pessoa _pessoa;

        public int Id { get => _id; set => _id = value; }
        public string Cep { get => _cep; set => _cep = value; }
        public string Rua { get => _rua; set => _rua = value; }
        public string Bairro { get => _bairro; set => _bairro = value; }
        public string Complemento { get => _complemento; set => _complemento = value; }
        public string Numero { get => _numero; set => _numero = value; }
        public string Cidade { get => _cidade; set => _cidade = value; }
        public string Estado { get => _estado; set => _estado = value; }
        internal Pessoa Pessoa { get => _pessoa; set => _pessoa = value; }
    }
}
