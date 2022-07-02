using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCSV.model
{
    class Veiculo
    {
        private int _id;
        private string _modelo;
        private string _marca;
        private string _cor;
        private string _placa;
        private string _ano;
        private bool _ativo;

        public int Id { get => _id; set => _id = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }
        public string Marca { get => _marca; set => _marca = value; }
        public string Cor { get => _cor; set => _cor = value; }
        public string Placa { get => _placa; set => _placa = value; }
        public string Ano { get => _ano; set => _ano = value; }
        public bool Ativo { get => _ativo; set => _ativo = value; }
    }
}
