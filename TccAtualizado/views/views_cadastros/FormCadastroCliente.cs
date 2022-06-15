using Correios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TccAtualizado.control.dao;
using TccAtualizado.model;

namespace TccAtualizado.views.views_cadastros
{
    public partial class FormCadastroCliente : Form
    {
        ClienteDao daoCliente = new ClienteDao();
        EnderecoDao daoEnd = new EnderecoDao();
        int motoId = 0;
        public FormCadastroCliente()
        {
            InitializeComponent();
            start();
        }

        private void start()
        {
            carregarClientes();
            desabilitarPaineis(true);
        }
        #region metodosSistema
        private void desabilitarPaineis(bool ativo)
        {
            panelControle.Enabled = ativo;
            panelBusca.Enabled = ativo;

            panelCadastro.Enabled = !ativo;
            panelControleCad.Enabled = !ativo;
        }
        private void limpaCampo()
        {
            txtCPF.Texts = String.Empty;
            txtRG.Texts = String.Empty;
            txtNome.Texts = String.Empty;
            txtCel.Texts = String.Empty;
            txtCel2.Texts = String.Empty;
            txtCep.Texts = String.Empty;
            txtEstado.Texts = String.Empty;
            txtCidade.Texts = String.Empty;
            txtBairro.Texts = String.Empty;
            txtRua.Texts = String.Empty;
            txtComplemento.Texts = String.Empty;
            txtNum.Texts = String.Empty;
        }
        private void buscarCep()
        {
            var service = new CorreiosApi();
            try
            {
                var dados = service.consultaCEP(txtCep.Texts);

                txtEstado.Texts = dados.uf;
                txtCidade.Texts = dados.cidade;
                txtBairro.Texts = dados.bairro;
                txtRua.Texts = dados.end;
            }
            catch
            {
                MessageBox.Show("CEP Invelido");
            }
        }
        private void carregarClientes()
        {
            string filtro = txtFiltro.Texts;
            string cond = cbTipo.SelectedIndex.ToString();
            if (cond.Equals("-1") || cond.Equals("0"))
            {
                cond = "todos";
            }
            else if (cond.Equals("1"))
            {
                cond = "ativos";
            }
            else
            {
                cond = "inativos";
            }


            dgListaCliente.DataSource = daoCliente.listaCliente(filtro, cond);
            this.dgListaCliente.Columns["id"].Visible = false;
            this.dgListaCliente.Columns["rg"].Visible = false;
            this.dgListaCliente.Columns["fone2"].Visible = false;
            this.dgListaCliente.Columns["tipo_pessoa"].Visible = false;

        }
        #endregion
        #region botoes
        private void btNovo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            desabilitarPaineis(false);
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            carregarClientes();
        }

        private void manterPessoa()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Id = motoId;
            pessoa.Cpf = txtCPF.Texts.Trim();
            pessoa.Rg = txtRG.Texts.Trim();
            pessoa.Nome = txtNome.Texts.Trim();
            pessoa.Fone = txtCel.Texts.Trim();
            pessoa.Fone2 = txtCel2.Texts.Trim();
            //pessoa.Ativo = tbtAtivo.Checked;
            
            if (daoCliente.gravarPessoa(pessoa))
            {

                MessageBox.Show("Dados Salvos com Sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                manterEnd();
                limpaCampo();
                desabilitarPaineis(true);
                tabControl1.SelectedIndex = 0;
                carregarClientes();
            }
            else
            {
                MessageBox.Show("Erro ao Salvar Dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void manterEnd()
        {
            Endereco end = new Endereco();
            end.Cep = txtCep.Texts;
            end.Estado = txtEstado.Texts;
            end.Cidade = txtCidade.Texts;
            end.Bairro = txtBairro.Texts;
            end.Rua = txtRua.Texts;
            end.Numero = txtNum.Texts;
            end.Complemento = txtComplemento.Texts;
            end.Pessoa = daoCliente.recuperaUltimoID();
            if (daoEnd.inserirEndereco(end))
            {
            }
            else
            {
                MessageBox.Show("Erro ao Salvar Endereco!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void brSalvar_Click(object sender, EventArgs e)
        {
            manterPessoa();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            limpaCampo();
            desabilitarPaineis(true);
            tabControl1.SelectedIndex = 0;
        }
        private void btCep_Click(object sender, EventArgs e)
        {
            buscarCep();
        }

        #endregion

        private void btExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
