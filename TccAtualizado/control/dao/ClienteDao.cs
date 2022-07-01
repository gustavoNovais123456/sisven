using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TccAtualizado.model;

namespace TccAtualizado.control.dao
{
    class ClienteDao
    {
        public bool gravarPessoa(Pessoa pessoa)
        {
            return pessoa.Id > 0 ? atualizarPessoa(pessoa) : inserirPessoa(pessoa);
        }

        private bool inserirPessoa(Pessoa pessoa)
        {
            MySqlTransaction transaction =  Conexao.getConexaoBD().BeginTransaction();
            String SQL = "INSERT INTO pessoas (cpf, rg, nome, fone,fone2, tipo_pessoa, ativo) " +
                "VALUES(@cpf, @rg, @nome, @fone, @fone2, 'c', true)";
            MySqlCommand comando = new MySqlCommand(SQL, Conexao.getConexaoBD());

            String SQLEnd = "INSERT INTO womsbd.enderecos (cep, endereco, numero, cidade, estado, bairro, complemento, pessoa_id) " +
               "VALUES (@cep, @rua ,@numero, @cidade, @estado, @bairro, @complemento, @pessoa)";
            MySqlCommand comandoEnd = new MySqlCommand(SQLEnd, Conexao.getConexaoBD());
            try
            {
                comando.Parameters.AddWithValue("@cpf", pessoa.Cpf);
                comando.Parameters.AddWithValue("@rg", pessoa.Rg);
                comando.Parameters.AddWithValue("@nome", pessoa.Nome);
                comando.Parameters.AddWithValue("@fone", pessoa.Fone);
                comando.Parameters.AddWithValue("@fone2", pessoa.Fone2);
                comando.ExecuteNonQuery();
                pessoa.Id = (int)comando.LastInsertedId;
               
                comandoEnd.Parameters.AddWithValue("@cep", pessoa.Endereco.Cep);
                comandoEnd.Parameters.AddWithValue("@estado", pessoa.Endereco.Estado);
                comandoEnd.Parameters.AddWithValue("@cidade", pessoa.Endereco.Cidade);
                comandoEnd.Parameters.AddWithValue("@bairro", pessoa.Endereco.Bairro);
                comandoEnd.Parameters.AddWithValue("@rua", pessoa.Endereco.Rua);
                comandoEnd.Parameters.AddWithValue("@numero", pessoa.Endereco.Numero);
                comandoEnd.Parameters.AddWithValue("@complemento", pessoa.Endereco.Complemento);
                comandoEnd.Parameters.AddWithValue("@pessoa", pessoa.Id);
                comandoEnd.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                return false;
            }
            finally
            {
                comando.Dispose();
                comandoEnd.Dispose();
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

                sql = @"select p.id,p.cpf,p.rg,p.nome,p.fone,p.fone2,p.ativo,c.id as id_endereco,c.cep,c.estado,c.cidade,c.bairro,c.endereco,c.numero,c.complemento 
                        from pessoas p join enderecos c on p.id = c.pessoa_id 
                        where lower(concat(p.nome,p.cpf)) like @filtro and
                        case when @ativos then p.ativo = 1 when @inativos then
                        p.ativo = 0 else true end";

            MySqlCommand comando = null;
            MySqlDataReader reader = null;
            try
            {
                comando = new MySqlCommand(sql, Conexao.getConexaoBD());
                comando.Parameters.AddWithValue("@filtro", "%" + filtro.ToLower() + "%");
                comando.Parameters.AddWithValue("@ativos", cond.ToLower().Equals("ativos"));
                comando.Parameters.AddWithValue("@inativos", cond.ToLower().Equals("inativos"));
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

                    Endereco endereco = new Endereco();
                    endereco.Id = reader.GetInt32(reader.GetOrdinal("id_endereco"));
                    endereco.Cep = reader.GetString(reader.GetOrdinal("cep"));
                    endereco.Estado = reader.GetString(reader.GetOrdinal("estado"));
                    endereco.Cidade = reader.GetString(reader.GetOrdinal("cidade"));
                    endereco.Bairro = reader.GetString(reader.GetOrdinal("bairro"));
                    endereco.Rua = reader.GetString(reader.GetOrdinal("endereco"));
                    endereco.Numero = reader.GetString(reader.GetOrdinal("numero"));
                    endereco.Complemento = reader.GetString(reader.GetOrdinal("complemento"));

                    p.Endereco = endereco;
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

        public DataTable testeP(string filtro,string cond)
        {
            string sql = "";

            sql = @"select p.id,p.cpf,p.rg,p.nome,p.fone,p.fone2,p.ativo,c.id as id_endereco,c.cep,c.estado,c.cidade,c.bairro,c.endereco,c.numero,c.complemento 
                        from pessoas p join enderecos c on p.id = c.pessoa_id 
                        where lower(concat(p.nome,p.cpf)) like @filtro and
                        case when @ativos then p.ativo = 1 when @inativos then
                        p.ativo = 0 else true end";
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = Conexao.getConexaoBD().CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@filtro", "%" + filtro.ToLower() + "%");
                    cmd.Parameters.AddWithValue("@ativos", cond.ToLower().Equals("ativos"));
                    cmd.Parameters.AddWithValue("@inativos", cond.ToLower().Equals("inativos"));
                    da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        #region endereco

        #endregion
    }
}
