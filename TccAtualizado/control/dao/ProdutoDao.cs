using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TccAtualizado.model;

namespace TccAtualizado.control.dao
{
    class ProdutoDao
    {
        /*public List<Produto> listaProdutos()
        {
            List<Produto> produtos = new List<Produto>();

            String SQL = "SELECT cod,descricao FROM produtos where ativo = true";

            MySqlCommand comando = null;
            MySqlDataReader reader = null;
            try
            {
                comando = new MySqlCommand(SQL, Conexao.getConexaoBD());
                //comando.Parameters.AddWithValue("cliente", clientes);
                //comando.Parameters.AddWithValue("fornecedor", fornecedores);
                //comando.Parameters.AddWithValue("filtro", "%" + filtro.ToLower() + "%");
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Produto p = new Produto();
                    p.Cod = reader.GetString(reader.GetOrdinal("cod"));
                    p.Desc = reader.GetString(reader.GetOrdinal("descricao"));
                    produtos.Add(p);
                }

                return produtos;
            }
            finally
            {
                reader.Close();
                comando.Dispose();
            }
        }*/
    }
}
