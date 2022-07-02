using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCSV.control
{
    class Conn
    {
        private static SQLiteConnection sqliteConnection;
        private static MySqlConnection conexao;

        public static SQLiteConnection Conexaobd()
        {
            sqliteConnection = new SQLiteConnection(@"Data Source=novoBD.db; Version=3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }

        public static MySqlConnection getConexaoBD()
        {
            if (conexao == null)
            {
                String host = "localhost";
                int porta = 3306;
                String usuario = "root";
                String senha = "";
                String bancoDados = "csvbd";
                String connString = $"server={host};port={porta};User Id={usuario};database={bancoDados};password={senha}";
                conexao = new MySqlConnection(connString);
                conexao.Open();
            }
            return conexao;
        }
    }
}
