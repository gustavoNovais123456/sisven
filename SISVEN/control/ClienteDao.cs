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
        private bool inserirPessoa(Pessoa pessoa)
        {
            String SQL = "insert into pessoa " +
                "(nome, telefone, endereco, endereco_numero, cidade_id, cliente, fornecedor) values " +
                "(@nome, @telefone, @endereco, @endereco_numero, @cidade_id, @cliente, @fornecedor)";
            try
            {
                using (var cmd = Conexao.Conexaobd().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Clientes(Nome,endereco) values (@nome, @endereco)";
                    cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
                    cmd.Parameters.AddWithValue("@Endereco", pessoa.Endereco);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                
            }

            return true;
        }

        public DataTable PesquisaCliente(String filtro)
        {
                      string sql = "SELECT p.nome,c.cpf,c.rg,p.celular,p.telefone,c.instagram,c.sexo,c.nascimento, " +
                        "e.cep,e.uf,e.cidade,e.bairro,e.logradouro,e.numero,e.complemento,p.ativo" +
                        "from pessoa p INNER JOIN cliente c on p.id = c.pessoa INNER join endereco e on p.endereco = e.id" +
                        "WHERE c.cpf = @filtro or lower(p.nome) like @filtro";

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = Conexao.Conexaobd().CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("filtro", filtro);
                    cmd.Parameters.AddWithValue("filtro", "%" + filtro.ToLower() + "%");
                    da = new SQLiteDataAdapter(cmd.CommandText, Conexao.Conexaobd());
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
    }
}
