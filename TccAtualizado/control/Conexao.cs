using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TccAtualizado.control
{
    class Conexao
    {
        private static MySqlConnection conexao;
        public static MySqlConnection getConexaoBD()
        {
            if (conexao == null)
            {
                String host = "localhost";
                int porta = 3306;
                String usuario = "root";
                String senha = "";
                String bancoDados = "womsBD";
                String connString = $"server={host};port={porta};User Id={usuario};database={bancoDados};password={senha}";
                conexao = new MySqlConnection(connString);
                conexao.Open();
            }
            return conexao;
        }

        public static MySqlConnection getConexao()
        {
            if (conexao == null)
            {
                String host = "localhost";
                int porta = 3306;
                String usuario = "root";
                String senha = "";
                String connString = $"server={host};port={porta};User Id={usuario};password={senha}";
                conexao = new MySqlConnection(connString);
                conexao.Open();
            }
            return conexao;
        }
    }
}
