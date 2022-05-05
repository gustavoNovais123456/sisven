using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SISVEN.control
{
    class Conexao
    {
        private static SQLiteConnection sqliteConnection;

        public static SQLiteConnection Conexaobd()
        {
            sqliteConnection = new SQLiteConnection(@"Data Source=D:\GitHub\sisven\SISVEN\control\banco.db; Version=3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }
    }
}
