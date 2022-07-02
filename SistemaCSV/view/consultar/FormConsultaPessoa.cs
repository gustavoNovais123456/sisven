using SistemaCSV.control.dao;
using SistemaCSV.model;
using SistemaCSV.view.cadastrar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCSV.view.consultar
{
    public partial class FormConsultaPessoa : Form
    {
        Pessoa pessoaEdicao = new Pessoa();
        internal Pessoa PessoaEdicao { get => pessoaEdicao; set => pessoaEdicao = value; }

        public FormConsultaPessoa()
        {
            InitializeComponent();
            buscarPessoa();
        }

        #region sistema
        public void buscarPessoa()
        {
            PessoaDao dao = new PessoaDao();
            string filtro = txtFiltro.Texts;
            string registro = cbRegistro.SelectedIndex.ToString();
            string tipo = cbTipo.SelectedIndex.ToString();
            if (registro.Equals("-1") || registro.Equals("0"))
            {
                registro = "todos";
            }
            else if (registro.Equals("1"))
            {
                registro = "ativos";
            }
            else
            {
                registro = "inativos";
            }
            if (tipo.Equals("-1") || tipo.Equals("0"))
            {
                tipo = "todos";
            }
            else if (tipo.Equals("1"))
            {
                tipo = "gerente";
            }
            else
            {
                tipo = "motorista";
            }
            dgPesquisaPessoas.DataSource = dao.pesquisaDePessoas(filtro, registro, tipo);

            this.dgPesquisaPessoas.Columns["id_pessoa"].Visible = false;
            this.dgPesquisaPessoas.Columns["celular"].Visible = false;
            this.dgPesquisaPessoas.Columns["endereco"].Visible = false;
            this.dgPesquisaPessoas.Columns["ativa"].Visible = false;
            this.dgPesquisaPessoas.Columns["id_usuario"].Visible = false;
            this.dgPesquisaPessoas.Columns["login"].Visible = false;
            this.dgPesquisaPessoas.Columns["senha"].Visible = false;
        }

        private void setarDadosEdicao()
        {
            DataGridViewRow linhaAtual = dgPesquisaPessoas.CurrentRow;
            int indice = linhaAtual.Index;
            string[] campos = new string[13];
            for (int i = 0; i < 13; i++)
            {
                campos[i] = dgPesquisaPessoas.Rows[indice].Cells[i].Value.ToString();
            }
            pessoaEdicao.Id = int.Parse(campos[0]);
            pessoaEdicao.Cpf = campos[1];
            pessoaEdicao.Cnh = campos[2];
            pessoaEdicao.Nome = campos[3];
            pessoaEdicao.Telefone = campos[4];
            pessoaEdicao.Endereco = campos[5];
            pessoaEdicao.Ativo = Convert.ToBoolean(campos[6]);
            pessoaEdicao.Usuario = new Usuario();
            pessoaEdicao.Usuario.Id = int.Parse(campos[7]);
            pessoaEdicao.Usuario.Email = campos[8];
            pessoaEdicao.Usuario.Login = campos[9];
            pessoaEdicao.Usuario.Senha = campos[10];
            pessoaEdicao.Usuario.TipoPessoa = campos[11];
            pessoaEdicao.Usuario.Ativo = Convert.ToBoolean(campos[12]);
        }

        private void dgPesquisaPessoas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setarDadosEdicao();
        }
        #endregion

        #region buscas
        private void cbTipo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            buscarPessoa();
        }

        private void cbRegistro_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            buscarPessoa();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            buscarPessoa();
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            buscarPessoa();
        }
        #endregion

        #region Controle
        private void btNovo_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja cadastrar uma nova Pessoa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                pessoaEdicao = new Pessoa();
                pessoaEdicao.Usuario = new Usuario();
                FormCadastroPessoa cadastroPessoa = new FormCadastroPessoa(this);
                cadastroPessoa.ShowDialog();
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja editar esse Motorista?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                if (pessoaEdicao.Id > 0)
                {
                    FormCadastroPessoa cadastroPessoa = new FormCadastroPessoa(this);
                    cadastroPessoa.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Selecione um cadastro na lista para editar!", "Aviso");

                }
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            PessoaDao dao = new PessoaDao();
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja desativar esse motorista?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                if (pessoaEdicao.Id > 0 && pessoaEdicao.Usuario.Id > 0)
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.Id = pessoaEdicao.Id;
                    pessoa.Ativo = false;
                    pessoa.Usuario = new Usuario();
                    pessoa.Usuario.Id = pessoaEdicao.Usuario.Id;
                    pessoa.Usuario.Ativo = false;
                    dao.inativarPessoa(pessoa);
                    buscarPessoa();
                    setarDadosEdicao();
                }
                else
                {
                    MessageBox.Show("Selecione um cadastro na lista para inativar!", "AVISO");
                }
            }
        }
        #endregion

        private void FormConsultaPessoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show(this, "Você tem certeza que deseja fechar essa tela?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
