using MySql.Data.MySqlClient;
using SistemaCSV.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCSV.control.dao
{
    class PessoaDao
    {
        public bool gravarPessoa(Pessoa pessoa)
        {
            return pessoa.Id > 0 ? atualizarPessoa(pessoa) : inserirPessoa(pessoa);
        }
        /*public bool inserirPessoa(Pessoa pessoa)
        {
            String SQL = "INSERT INTO pessoas (cpf,cnh,nome,celular,endereco,email,login,senha,tipo_pessoa,ativo)" +
                         "VALUES (@cpf,@cnh,@nome,@celular,@endereco,@email,@login,@senha,@tipo_pessoa,true)";

            SQLiteCommand cmd = Conn.Conexaobd().CreateCommand();

            try
            {
                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@cpf", pessoa.Cpf);
                cmd.Parameters.AddWithValue("@cnh", pessoa.Cnh);
                cmd.Parameters.AddWithValue("@nome", pessoa.Nome);
                cmd.Parameters.AddWithValue("@celular", pessoa.Telefone);
                cmd.Parameters.AddWithValue("@endereco", pessoa.Endereco);
                cmd.Parameters.AddWithValue("@email", pessoa.Email);
                cmd.Parameters.AddWithValue("@login", pessoa.Login);
                cmd.Parameters.AddWithValue("@senha", pessoa.Senha);
                cmd.Parameters.AddWithValue("@tipo_pessoa", pessoa.TipoPessoa);
                cmd.ExecuteNonQuery();
            }

            catch (Exception e)
            {
                return false;
                MessageBox.Show(e.Message);
            }
            finally
            {
                Conn.Conexaobd().Close();
            }

            return true;
        }*/

        public bool inserirPessoa(Pessoa pessoa)
        {
            MySqlTransaction transaction = Conn.getConexaoBD().BeginTransaction();
            String SQLPessoa = "INSERT INTO pessoas (cpf,cnh,nome,celular,endereco,ativo)" +
                         "VALUES (@cpf,@cnh,@nome,@celular,@endereco,true)";
            MySqlCommand cmdPessoa = new MySqlCommand(SQLPessoa, Conn.getConexaoBD());

            String SQLUsuario = "INSERT INTO pessoas (email,login,senha,acesso,ativo)" +
                         "VALUES (@email,@login,@senha,@acesso,true)";
            MySqlCommand cmdUser = new MySqlCommand(SQLUsuario, Conn.getConexaoBD());
            try
            {
                cmdPessoa.CommandText = SQLPessoa;
                cmdPessoa.Parameters.AddWithValue("@cpf", pessoa.Cpf);
                cmdPessoa.Parameters.AddWithValue("@cnh", pessoa.Cnh);
                cmdPessoa.Parameters.AddWithValue("@nome", pessoa.Nome);
                cmdPessoa.Parameters.AddWithValue("@celular", pessoa.Telefone);
                cmdPessoa.Parameters.AddWithValue("@endereco", pessoa.Endereco);
                cmdPessoa.ExecuteNonQuery();

                pessoa.Id = (int)cmdPessoa.LastInsertedId;

                cmdUser.CommandText = SQLUsuario;
                cmdUser.Parameters.AddWithValue("@email", pessoa.Usuario.Email);
                cmdUser.Parameters.AddWithValue("@login", pessoa.Usuario.Login);
                cmdUser.Parameters.AddWithValue("@senha", pessoa.Usuario.Senha);
                cmdUser.Parameters.AddWithValue("@acesso", pessoa.Usuario.TipoPessoa);
                cmdUser.ExecuteNonQuery();
                transaction.Commit();

            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                transaction.Rollback();
                return false;
            }
            finally
            {
                Conn.Conexaobd().Close();
            }

            return true;
        }

        private bool atualizarPessoa(Pessoa pessoa)
        {
            MySqlTransaction transaction = Conn.getConexaoBD().BeginTransaction();
            String SQLPessoa = @"UPDATE pessoas SET cpf = @cpf, cnh = @cnh , nome = @nome , celular = @celular, endereco = @endereco,
                                 ativa = @ativo WHERE id = @id";
            MySqlCommand cmdPessoa = new MySqlCommand(SQLPessoa, Conn.getConexaoBD());
            String SQLUsuario = @"UPDATE usuarios SET email = @email, login = @login, senha = @senha, acesso = @acesso, 
                                  ativo = @ativo WHERE id = @id;";
            MySqlCommand cmdUser = new MySqlCommand(SQLUsuario, Conn.getConexaoBD());

            try
            {
                cmdPessoa.CommandText = SQLPessoa;
                cmdPessoa.Parameters.AddWithValue("@cpf", pessoa.Cpf);
                cmdPessoa.Parameters.AddWithValue("@cnh", pessoa.Cnh);
                cmdPessoa.Parameters.AddWithValue("@nome", pessoa.Nome);
                cmdPessoa.Parameters.AddWithValue("@celular", pessoa.Telefone);
                cmdPessoa.Parameters.AddWithValue("@endereco", pessoa.Endereco);
                cmdPessoa.Parameters.AddWithValue("@ativo", pessoa.Ativo);
                cmdPessoa.Parameters.AddWithValue("@id", pessoa.Id);
                cmdPessoa.ExecuteNonQuery();

                cmdUser.CommandText = SQLUsuario;
                cmdUser.Parameters.AddWithValue("@email", pessoa.Usuario.Email);
                cmdUser.Parameters.AddWithValue("@login", pessoa.Usuario.Login);
                cmdUser.Parameters.AddWithValue("@senha", pessoa.Usuario.Senha);
                cmdUser.Parameters.AddWithValue("@acesso", pessoa.Usuario.TipoPessoa);
                cmdUser.Parameters.AddWithValue("@ativo", pessoa.Ativo);
                cmdUser.Parameters.AddWithValue("@id", pessoa.Usuario.Id);
                cmdUser.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
                transaction.Rollback();
            }
            finally
            {
                Conn.Conexaobd().Dispose();
            }
            return true;
        }

        public void inativarPessoa(Pessoa pessoa)
        {
            MySqlTransaction transaction = Conn.getConexaoBD().BeginTransaction();
            String SQLPessoa = @"UPDATE pessoas SET ativa = false WHERE id = @id";
            MySqlCommand cmdPessoa = new MySqlCommand(SQLPessoa, Conn.getConexaoBD());
            String SQLUsuario = @"UPDATE usuarios SET ativo = false WHERE id = @id;";
            MySqlCommand cmdUser = new MySqlCommand(SQLUsuario, Conn.getConexaoBD());

            try
            {
                cmdPessoa.CommandText = SQLPessoa;
                cmdPessoa.Parameters.AddWithValue("@id", pessoa.Id);
                cmdPessoa.ExecuteNonQuery();

                cmdUser.CommandText = SQLUsuario;
                cmdUser.Parameters.AddWithValue("@id", pessoa.Usuario.Id);
                cmdUser.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                transaction.Rollback();
            }
            finally
            {
                Conn.Conexaobd().Dispose();
            }
        }

        #region pesquisas
        public DataTable pesquisaDePessoas(string filtro, string cond, string tipo)
        {
            string sql = @"select * from pesquisa_pessoas where lower(cpf||cnh||nome) like @filtro and
                        case when @ativos then ativa = 1 when @inativos then
                        ativa = 0 else true end and CASE WHEN @gerente THEN acesso = 'gerente' WHEN @motorista THEN acesso = 'motorista' else true END;";

            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand(sql, Conn.getConexaoBD());

            try
            {

                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@filtro", "%" + filtro.ToLower() + "%");
                cmd.Parameters.AddWithValue("@ativos", cond.ToLower().Equals("ativos"));
                cmd.Parameters.AddWithValue("@inativos", cond.ToLower().Equals("inativos"));
                cmd.Parameters.AddWithValue("@gerente", tipo.ToLower().Equals("gerente"));
                cmd.Parameters.AddWithValue("@motorista", tipo.ToLower().Equals("motorista"));
                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public DataTable buscarLogin(string login, string senha)
        {

            string sql = @"select * from pessoa_login where login = @login and senha = @senha and ativa = 1";
            MySqlCommand cmd = new MySqlCommand(sql, Conn.getConexaoBD());

            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@login", login.ToLower());
                cmd.Parameters.AddWithValue("@senha", senha.ToLower());
                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

        }
        #endregion
    }
}
