using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TccAtualizado.model;

namespace TccAtualizado.control.dao
{
    class ClienteDao
    {
        private int ultimoID;

        public bool gravarPessoa(Pessoa pessoa)
        {
            return pessoa.Id > 0 ? atualizarPessoa(pessoa) : inserirPessoa(pessoa);
        }

        public int ultimoCad()
        {
            return ultimoID;
        }
        private bool inserirPessoa(Pessoa pessoa)
        {
            String SQL = "INSERT INTO pessoas (cpf, rg, nome, fone,fone2, tipo_pessoa, ativo) " +
                "VALUES(@cpf, @rg, @nome, @fone, @fone2, 'c', true)";

            MySqlCommand comando = new MySqlCommand(SQL, Conexao.getConexaoBD());
            try
            {
                comando.Parameters.AddWithValue("@cpf", pessoa.Cpf);
                comando.Parameters.AddWithValue("@rg", pessoa.Rg);
                comando.Parameters.AddWithValue("@nome", pessoa.Nome);
                comando.Parameters.AddWithValue("@fone", pessoa.Fone);
                comando.Parameters.AddWithValue("@fone2", pessoa.Fone2);
                comando.ExecuteNonQuery();
                ultimoID = (int)comando.LastInsertedId;
                EnderecoDao d = new EnderecoDao();
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

        private bool atualizarPessoa(Pessoa pessoa)
        {

            String SQL = "update pessoa set " +
                "nome = @nome, cpf = @cpf, rg = @rg, fone = @fone, fone2 = @fone2) " +
                "where id = @id";

            MySqlCommand comando = new MySqlCommand(SQL, Conexao.getConexaoBD());
            try
            {
                {
                    comando.Parameters.AddWithValue("@cpf", pessoa.Cpf);
                    comando.Parameters.AddWithValue("@rg", pessoa.Rg);
                    comando.Parameters.AddWithValue("@nome", pessoa.Nome);
                    comando.Parameters.AddWithValue("@fone", pessoa.Fone);
                    comando.Parameters.AddWithValue("@fone2", pessoa.Fone2);
                    comando.Parameters.AddWithValue("id", pessoa.Id);
                    comando.ExecuteNonQuery();
                }
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

        public List<Pessoa> listaCliente(string filtro, string cond)
        {
            List<Pessoa> pessoa = new List<Pessoa>();

            string sql = "";

            if (cond.Equals("ativos"))
            {
                sql = "select * from pessoas where lower(nome) like @filtro or cpf like @filtro and ativo = true";
            }
            else if (cond.Equals("inativos"))
            {
                sql = "select * from pessoas where lower(nome) like @filtro or cpf like @filtro and ativo = false";
            }
            else if (cond.Equals("todos"))
            {
                sql = "select * from pessoas where lower(nome) like @filtro or cpf like @filtro";
            }

            MySqlCommand comando = null;
            MySqlDataReader reader = null;
            try
            {
                comando = new MySqlCommand(sql, Conexao.getConexaoBD());
                comando.Parameters.AddWithValue("@filtro", "%" + filtro.ToLower() + "%");
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Pessoa p = new Pessoa();
                    p.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    p.Cpf = reader.GetString(reader.GetOrdinal("cpf"));
                    p.Rg = reader.GetString(reader.GetOrdinal("rg"));
                    p.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    p.Fone = reader.GetString(reader.GetOrdinal("fone"));
                    p.Fone2 = reader.GetString(reader.GetOrdinal("fone2"));
                    p.Ativo = reader.GetBoolean(reader.GetOrdinal("ativo"));
                    pessoa.Add(p);
                }

                return pessoa;
            }
            finally
            {
                reader.Close();
                comando.Dispose();
            }
        }
        public Pessoa recuperaUltimoID()
        {
            Pessoa p = new Pessoa();
            p.Id = ultimoID;
            return p;
        }
    }
}
