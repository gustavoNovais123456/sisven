using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TccAtualizado.control.dao
{
    class ContadoresDao
    {
       // SELECT COUNT(*) FROM test

        public int maxProduto()
        {
            string SQL = "SELECT COUNT(*) FROM produtos_servicos";
            MySqlCommand comando = null;

            comando = new MySqlCommand(SQL, Conexao.getConexaoBD());
            int count = Convert.ToInt32(comando.ExecuteScalar());
            return count;
        }

    }
}

