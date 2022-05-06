using SISVEN.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISVEN.control
{
    class EnderecoDao
    {
        public bool inserirEndereco(Endereco endereco)
        {
            String SQL = "INSERT INTO endereco (cep,uf,cidade,bairro,logradouro,numero,complemento,pessoa)" +
                "VALUES (@cep,@uf,@cidade,@bairro,@logradouro,@numero,@complemento,@pessoa);";
            //String SQL = "INSERT INTO endereco (cep,pessoa)VALUES (@cep,@pessoa);";
            int ultimoid = recuperarId();
            try
            {
                using (var cmd = Conexao.Conexaobd().CreateCommand())
                {
                    cmd.CommandText = SQL;
                    cmd.Parameters.AddWithValue("@cep", endereco.Cep);
                    cmd.Parameters.AddWithValue("@uf", endereco.Uf);
                    cmd.Parameters.AddWithValue("@cidade", endereco.Cidade);
                    cmd.Parameters.AddWithValue("@bairro", endereco.Bairro);
                    cmd.Parameters.AddWithValue("@logradouro", endereco.Logradouro);
                    cmd.Parameters.AddWithValue("@numero", endereco.Numero);
                    cmd.Parameters.AddWithValue("@complemento", endereco.Complemento);
                    cmd.Parameters.AddWithValue("@pessoa", ultimoid);
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
