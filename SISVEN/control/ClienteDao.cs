using SISVEN.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISVEN.control
{
    class ClienteDao
    {
        EnderecoDao endDao = new EnderecoDao();
        //Cadastro De Cliente
        public bool inserirPessoa(Pessoa pessoa,Endereco end)
        {
            String SQL = "INSERT INTO pessoa (id,cpf,rg, Nome,Celular,Telefone,instagram,cliente,vendedor,ativo)" +
                "VALUES (@id,@cpf,@rg,@nome,@celular,@telefone,@instagram,@cliente,@vendedor,@ativo)";
            int ultimoid = recuperarId();
            try
            {
                using (var cmd = Conexao.Conexaobd().CreateCommand())
                {
                    cmd.CommandText = SQL;
                    cmd.Parameters.AddWithValue("@id", ultimoid);
                    cmd.Parameters.AddWithValue("@cpf", pessoa.Cpf);
                    cmd.Parameters.AddWithValue("@rg", pessoa.Rg);
                    cmd.Parameters.AddWithValue("@nome", pessoa.Nome);
                    cmd.Parameters.AddWithValue("@celular", pessoa.Celular);
                    cmd.Parameters.AddWithValue("@telefone", pessoa.Telefone);
                    cmd.Parameters.AddWithValue("@instagram", pessoa.Instagram);
                    cmd.Parameters.AddWithValue("@cliente", true);
                    cmd.Parameters.AddWithValue("@vendedor", false);
                    cmd.Parameters.AddWithValue("@ativo", true);
                    cmd.ExecuteNonQuery();
                    endDao.inserirEndereco(end);
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                Conexao.Conexaobd().Close();
            }

            return true;
        }
        
        //Pesquisa Geral de Cliente
        public DataTable PesquisaCliente()
        {
            string sql = "SELECT pessoa.nome,pessoa.cpf,pessoa.rg,pessoa.Celular,pessoa.Telefone,pessoa.instagram,pessoa.cliente,pessoa.ativo," +
                "endereco.cep,endereco.uf,endereco.cidade,endereco.bairro,endereco.logradouro,endereco.numero,endereco.complemento " +
                "from pessoa join endereco on pessoa.id = endereco.pessoa";

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = Conexao.Conexaobd().CreateCommand())
                {
                    cmd.CommandText = sql;
                    //cmd.Parameters.AddWithValue("filtro", filtro);
                    //cmd.Parameters.AddWithValue("filtro", "%" + filtro.ToLower() + "%");
                    da = new SQLiteDataAdapter(cmd);
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

        public DataTable listaEdicao(string filtro)
        {
            string sql = "";
            if (filtro.Equals(""))
            {
                 sql = "select id,nome,cpf from pessoa";
            }
            else
            {
                 sql = "select id,nome,cpf from pessoa " +
                "where lower(nome) like @filtro or lower(cpf) like @filtro" + " and ativo order by lower(nome)";
            }
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = Conexao.Conexaobd().CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@filtro", "%" + filtro.ToLower() + "%");
                    cmd.Parameters.AddWithValue("@filtro", "%" + filtro.ToLower() + "%");
                    da = new SQLiteDataAdapter(cmd);
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

        //Metodos extras
        private int recuperarId()
        {
            var cmd = Conexao.Conexaobd().CreateCommand();
            cmd.CommandText = "SELECT count(id) from pessoa";

            // The row ID is a 64-bit value - cast the Command result to an Int64.
            //
            Int64 LastRowID64 = (Int64)cmd.ExecuteScalar();

            int LastRowID = (int)LastRowID64;
            if (LastRowID == 0)
            {
                LastRowID += 1;
                return LastRowID;
            }
            return LastRowID;
        }
    }
}
