using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TccAtualizado.control
{
    class GerarBD
    {
        public void createBD()
        {
            string sql = @"create database IF NOT EXISTS womsBD";
            MySqlCommand criarBanco = new MySqlCommand(sql, Conexao.getConexao());
            try
            {
                criarBanco.ExecuteNonQuery();
                MessageBox.Show("Banco Criado com sucesso");
            }
            catch
            {
                MessageBox.Show("Falha ao criar banco");
            }
        }

        public void criarTabelas()
        {
            tbPessoa();
            tbCidade();
            tbCategoria();
            tbEndereco();       
            tbProduto();
            tbMovimentacaoEstoque();
            tbServicos();
            tbPecasServicos();
        }
        #region tabelas
        private void tbPessoa()
        {
            string sql = @"CREATE TABLE IF NOT EXISTS pessoas (
                    id          INTEGER      PRIMARY KEY AUTO_INCREMENT,
                    cpf         VARCHAR (15) NOT NULL,
                    rg          VARCHAR (15),
                    nome        VARCHAR (45) NOT NULL,
                    fone        VARCHAR (20),
                    tipo_pessoa CHAR (1)     NOT NULL,
                    ativo       BOOLEAN
                )";
            MySqlCommand createTable = new MySqlCommand(sql, Conexao.getConexaoBD());
            try
            {
                createTable.ExecuteNonQuery();
                MessageBox.Show("TABELA PESSOAS CRIADA OU CARREGADA COM SUCESSO!!");
            }
            catch
            {
                MessageBox.Show("FALHA AO CRIAR TABELA PESSOA");
            }
        }
        private void tbCidade()
        {
            string sql = @"CREATE TABLE IF NOT EXISTS cidades (
                            id     INTEGER      PRIMARY KEY AUTO_INCREMENT,
                            nome   VARCHAR (45),
                            estado CHAR (2) 
                        )";
            MySqlCommand createTable = new MySqlCommand(sql, Conexao.getConexaoBD());
            try
            {
                createTable.ExecuteNonQuery();
                MessageBox.Show("TABELA CIDADES CRIADA OU CARREGADA COM SUCESSO!!");
            }
            catch
            {
                MessageBox.Show("FALHA AO CRIAR TABELA CIDADES");
            }
        }
        private void tbCategoria()
        {
            string sql = @"CREATE TABLE IF NOT EXISTS categorias_produtos (
                            id        INTEGER      PRIMARY KEY AUTO_INCREMENT,
                            descricao VARCHAR (45),
                            ativo     BOOLEAN
                        )";
            MySqlCommand createTable = new MySqlCommand(sql, Conexao.getConexaoBD());
            try
            {
                createTable.ExecuteNonQuery();
                MessageBox.Show("TABELA CATEGORIA CRIADA OU CARREGADA COM SUCESSO!!");
            }
            catch
            {
                MessageBox.Show("FALHA AO CRIAR TABELA CATEGORIA");
            }
        }

        private void tbEndereco()
        {
            string sql = @"CREATE TABLE IF NOT EXISTS enderecos (
                            id        INTEGER       PRIMARY KEY AUTO_INCREMENT,
                            cep       VARCHAR (10),
                            endereco  VARCHAR (150),
                            numero    INTEGER,
                            pessoa_id INTEGER       REFERENCES pessoas (id),
                            cidade_id INTEGER       REFERENCES cidades (id) 
                        )";
            MySqlCommand createTable = new MySqlCommand(sql, Conexao.getConexaoBD());
            try
            {
                createTable.ExecuteNonQuery();
                MessageBox.Show("TABELA ENDEREÇOS CRIADA OU CARREGADA COM SUCESSO!!");
            }
            catch
            {
                MessageBox.Show("FALHA AO CRIAR TABELA ENDEREÇO");
            }
        }
        private void tbUsuario()
        {
            string sql = @"CREATE TABLE IF NOT EXISTS usuarios (
                            id           INTEGER      PRIMARY KEY AUTO_INCREMENT,
                            pessoa_id    INTEGER      REFERENCES pessoas (id),
                            login        VARCHAR (30),
                            senha        VARCHAR (30),
                            nivel_acesso INTEGER,
                            ativo        BOOLEAN
                        )";
            MySqlCommand createTable = new MySqlCommand(sql, Conexao.getConexaoBD());
            try
            {
                createTable.ExecuteNonQuery();
                MessageBox.Show("TABELA USUARIOS CRIADA OU CARREGADA COM SUCESSO!!");
            }
            catch
            {
                MessageBox.Show("FALHA AO CRIAR TABELA USUARIOS");
            }
        }

        private void tbProduto()
        {
            string sql = @"CREATE TABLE IF NOT EXISTS produtos (
                            id           INTEGER      PRIMARY KEY AUTO_INCREMENT,
                            cod          INTEGER      NOT NULL,
                            descricao    VARCHAR (45) NOT NULL,
                            categoria_id INTEGER      REFERENCES categorias_produtos (id),
                            estoque_min  INTEGER      NOT NULL,
                            ativo        BOOLEAN
                        )";
            MySqlCommand createTable = new MySqlCommand(sql, Conexao.getConexaoBD());
            try
            {
                createTable.ExecuteNonQuery();
                MessageBox.Show("TABELA PRODUTOS CRIADA OU CARREGADA COM SUCESSO!!");
            }
            catch
            {
                MessageBox.Show("FALHA AO CRIAR TABELA PRODUTOS");
            }
        }

        private void tbMovimentacaoEstoque()
        {
            string sql = @"CREATE TABLE IF NOT EXISTS movimentacao_estoque (
                            id             INTEGER  PRIMARY KEY AUTO_INCREMENT,
                            produto_id     INTEGER  REFERENCES produtos (id),
                            data_hora      DATETIME,
                            tipo_movimento CHAR (1),
                            vendedor       INTEGER  REFERENCES pessoas (id),
                            ativo          BOOLEAN
                        )";
            MySqlCommand createTable = new MySqlCommand(sql, Conexao.getConexaoBD());
            try
            {
                createTable.ExecuteNonQuery();
                MessageBox.Show("TABELA MOVIMENTAÇAO_ESTOQUE CRIADA OU CARREGADA COM SUCESSO!!");
            }
            catch
            {
                MessageBox.Show("FALHA AO CRIAR TABELA MOVIMENTAÇAO_ESTOQUE");
            }
        }

        private void tbServicos()
        {
            string sql = @"CREATE TABLE IF NOT EXISTS ordens_servicos (
                            id          INTEGER         PRIMARY KEY AUTO_INCREMENT,
                            cod         INTEGER,
                            cliente_id  INTEGER         REFERENCES pessoas (id),
                            vendedor_id INTEGER         REFERENCES pessoas (id),
                            equipamento VARCHAR (45),
                            defeito     TEXT,
                            solucao     TEXT,
                            valor_total NUMERIC (14, 2),
                            ativo       BOOLEAN
                        )";
            MySqlCommand createTable = new MySqlCommand(sql, Conexao.getConexaoBD());
            try
            {
                createTable.ExecuteNonQuery();
                MessageBox.Show("TABELA SERVICOS CRIADA OU CARREGADA COM SUCESSO!!");
            }
            catch
            {
                MessageBox.Show("FALHA AO CRIAR TABELA SERVICOS");
            }
        }

        private void tbPecasServicos()
        {
            string sql = @"CREATE TABLE IF NOT EXISTS produtos_servicos (
                        id         INTEGER         PRIMARY KEY AUTO_INCREMENT,
                        servico_id INTEGER         REFERENCES ordens_servicos (id),
                        produto_id INTEGER         REFERENCES produtos (id),
                        valor      NUMERIC (14, 2),
                        quantidade INTEGER
                        )";
            MySqlCommand createTable = new MySqlCommand(sql, Conexao.getConexaoBD());
            try
            {
                createTable.ExecuteNonQuery();
                MessageBox.Show("TABELA PEÇAS_SERVIÇOS CRIADA OU CARREGADA COM SUCESSO!!");
            }
            catch
            {
                MessageBox.Show("FALHA AO CRIAR TABELA PEÇAS_SERVIÇOS");
            }
        }
        #endregion
    }
}

    
 