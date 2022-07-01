using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TccAtualizado.model;

namespace TccAtualizado.control.dao
{
    class EnderecoDao
    {

        public bool inserirEndereco(Endereco endereco)
        {
            String SQL = "INSERT INTO womsbd.enderecos (cep, endereco, numero, cidade, estado, bairro, complemento, pessoa_id) " +
                "VALUES (@cep, @rua ,@numero, @cidade, @estado, @bairro, @complemento, @pessoa)";

            MySqlCommand comando = new MySqlCommand(SQL, Conexao.getConexaoBD());
            try
            {
                comando.Parameters.AddWithValue("@cep", endereco.Cep);
                comando.Parameters.AddWithValue("@estado", endereco.Estado);
                comando.Parameters.AddWithValue("@cidade", endereco.Cidade);
                comando.Parameters.AddWithValue("@bairro", endereco.Bairro);
                comando.Parameters.AddWithValue("@rua", endereco.Rua);
                comando.Parameters.AddWithValue("@numero", endereco.Numero);
                comando.Parameters.AddWithValue("@complemento", endereco.Complemento);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                comando.Dispose();
            }
            return true;
        }

        public List<Endereco> listaCliente(string id)
        {
            List<Endereco> ende = new List<Endereco>();

            string sql = "";

            sql = "select * from endereco where pessoa_id = @id";

            MySqlCommand comando = null;
            MySqlDataReader reader = null;
            try
            {
                comando = new MySqlCommand(sql, Conexao.getConexaoBD());
                comando.Parameters.AddWithValue("@id",id);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Endereco end = new Endereco();
                    end.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    end.Cep = reader.GetString(reader.GetOrdinal("cep"));
                    end.Estado = reader.GetString(reader.GetOrdinal("estado"));
                    end.Cidade = reader.GetString(reader.GetOrdinal("cidade"));
                    end.Bairro = reader.GetString(reader.GetOrdinal("bairro"));
                    end.Rua = reader.GetString(reader.GetOrdinal("endereco"));
                    end.Numero = reader.GetString(reader.GetOrdinal("numero"));
                    end.Complemento = reader.GetString(reader.GetOrdinal("complemento"));
                    ende.Add(end);
                }

                return ende;
            }
            finally
            {
                reader.Close();
                comando.Dispose();
            }
        }
    }
}
