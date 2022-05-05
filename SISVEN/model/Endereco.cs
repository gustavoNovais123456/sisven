using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISVEN.model
{
    class Endereco
    {
        private int id;
        private string cep;
        private string uf;
        private string cidade;
        private string bairro;
        private string logradouro;
        private int numero;
        private string complemento;

        public int Id { get => id; set => id = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Complemento { get => complemento; set => complemento = value; }
    }
}
