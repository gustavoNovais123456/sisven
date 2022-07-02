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
    class VeiculoDao
    {
        #region cadastro
        public bool gravarVeiculo(Veiculo veiculo)
        {
            return veiculo.Id > 0 ? atualizarVeiculo(veiculo) : inserirVeiculo(veiculo);
        }

        private bool inserirVeiculo(Veiculo veiculo)
        {
            String SQL = "INSERT INTO veiculos (modelo,marca,cor,placa,ano,ativo)" +
                "VALUES (@modelo,@marca,@cor,@placa,@ano,true)";

            MySqlCommand cmd = new MySqlCommand(SQL, Conn.getConexaoBD());
            try
            {
                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@modelo", veiculo.Modelo);
                cmd.Parameters.AddWithValue("@marca", veiculo.Marca);
                cmd.Parameters.AddWithValue("@cor", veiculo.Cor);
                cmd.Parameters.AddWithValue("@placa", veiculo.Placa);
                cmd.Parameters.AddWithValue("@ano", veiculo.Ano);
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
        }
        #endregion

        #region update
        private bool atualizarVeiculo(Veiculo veiculo)
        {
            String SQL = "UPDATE veiculos SET modelo = @modelo,marca = @marca,cor = @cor,placa = @placa,ano = @ano,ativo = @ativo WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(SQL, Conn.getConexaoBD());

            try
            {
                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@modelo", veiculo.Modelo);
                cmd.Parameters.AddWithValue("@marca", veiculo.Marca);
                cmd.Parameters.AddWithValue("@cor", veiculo.Cor);
                cmd.Parameters.AddWithValue("@placa", veiculo.Placa);
                cmd.Parameters.AddWithValue("@ano", veiculo.Ano);
                cmd.Parameters.AddWithValue("@ativo", veiculo.Ativo);
                cmd.Parameters.AddWithValue("@id", veiculo.Id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                Conn.Conexaobd().Dispose();
            }
            return true;
        }

        public void inativarVeiculo(Veiculo veiculo)
        {
            string sql = "UPDATE veiculos SET ativo = @ativo WHERE id = @id";

            try
            {
                using (var cmd = Conn.Conexaobd().CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@ativo", veiculo.Ativo);
                    cmd.Parameters.AddWithValue("@id", veiculo.Id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Conn.Conexaobd().Close();
            }

        }
        #endregion

        #region informaçoes
        public DataTable listaVeiculos(string filtro, string cond)
        {

            string sql = @"select * from veiculos
                        where lower(placa||modelo||marca) like @filtro and
                        case when @ativos then ativo = 1 when @inativos then
                        ativo = 0 else true end";

            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, Conn.getConexaoBD());

                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@filtro", "%" + filtro.ToLower() + "%");
                cmd.Parameters.AddWithValue("@ativos", cond.ToLower().Equals("ativos"));
                cmd.Parameters.AddWithValue("@inativos", cond.ToLower().Equals("inativos"));
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
