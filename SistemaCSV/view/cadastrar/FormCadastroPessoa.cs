using SistemaCSV.control.dao;
using SistemaCSV.model;
using SistemaCSV.view.consultar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCSV.view.cadastrar
{
    public partial class FormCadastroPessoa : Form
    {
        FormConsultaPessoa formConsulta;
        Pessoa pessoa;
        public FormCadastroPessoa(FormConsultaPessoa form)
        {
            InitializeComponent();
            formConsulta = form;
            pessoa = formConsulta.PessoaEdicao;
            iniciar();
        }
        /*private static void EnableTab(TabPage page, bool enable)
        {
            foreach (Control ctl in page.Controls) ctl.Enabled = enable;
        }*/

        #region sistema
        private void iniciar()
        {
            tabControl1.TabPages.Remove(tabAcesso);
            setarInformacoes();
        }
        private bool validar()
        {
            if (txtNome.Texts == String.Empty)
            {
                MessageBox.Show("O Nome está nulo, por favor informe o nome da pessoa");
                txtNome.Focus();
                return false;
            }
            if (txtCPF.Texts == String.Empty || txtCPF.Texts.Length < 11)
            {
                MessageBox.Show("O CPF está nulo ou faltando digitos");
                txtCPF.Focus();
                return false;
            }
            if (txtCel.Texts == String.Empty || txtCel.Texts.Length <11)
            {
                MessageBox.Show("O Celular está nulo ou faltando digitos");
                txtCel.Focus();
                return false;
            }
            return true;
        }

        private void setarInformacoes()
        {
            txtNome.Texts = pessoa.Nome;
            txtCPF.Texts = pessoa.Cpf;
            txtCNH.Texts = pessoa.Cnh;
            txtLogin.Texts = pessoa.Usuario.Login;
            txtPass.Texts = pessoa.Usuario.Senha;
            txtCel.Texts = pessoa.Telefone;
            txtEmail.Texts = pessoa.Usuario.Email;
            txtRua.Texts = pessoa.Endereco;
            cbTipoPessoa.Texts = pessoa.Usuario.TipoPessoa;
            tgbAtivo.Checked = pessoa.Ativo;
        }

        private void manterPessoa()
        {
            PessoaDao dao = new PessoaDao();

            Pessoa pessoa = new Pessoa();
            pessoa.Id = this.pessoa.Id;
            pessoa.Cpf = txtCPF.Texts;
            pessoa.Cnh = txtCNH.Texts;
            pessoa.Nome = txtNome.Texts;
            pessoa.Telefone = txtCel.Texts;
            pessoa.Endereco = txtRua.Texts;
            pessoa.Ativo = tgbAtivo.Checked;

            pessoa.Usuario = new Usuario();
            pessoa.Usuario.Id = this.pessoa.Usuario.Id;
            pessoa.Usuario.Email = txtEmail.Texts;
            pessoa.Usuario.Login = txtLogin.Texts;
            pessoa.Usuario.Senha = txtPass.Texts;
            pessoa.Usuario.TipoPessoa = cbTipoPessoa.Texts;
            pessoa.Usuario.Ativo = pessoa.Ativo;

            try
            {
                dao.gravarPessoa(pessoa);
                MessageBox.Show("Pessoa Salva Com Sucesso", "Sucesso!");
            }
            catch
            {
                MessageBox.Show("Erro ao salvar pessoa", "Erro!");
            }
        }
        #endregion

        #region validação
        private void permitirNumerosPontos(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsPunctuation(e.KeyChar));
        }
        private void permitirNumeros(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void permitirLetras(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void permitirLetrasEspaco(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        public string formatarCPF(string cpf)
        {
            string response = cpf.Trim();
            if (response.Length == 11)
            {
                response = response.Insert(3, ".");
                response = response.Insert(7, ".");
                response = response.Insert(11, "-");
            }
            return response;
        }
        public string formataCelular(string celu)
        {
            string response = celu.Trim();
            if (response.Length == 11)
            {
                response = response.Insert(0, "(");
                response = response.Insert(3, ")");
                response = response.Insert(9, "-");
            }
            return response;
        }
        #endregion

        #region buttons
        private void btSalvar_Click(object sender, EventArgs e)
        {
           if(txtPass.Texts.Length < 6)
            {
                MessageBox.Show("Senha faltando digitos, 'minimo 6 digitos'");
                txtPass.Focus();
                return;
            }
            manterPessoa();
            formConsulta.buscarPessoa();
            this.Close();
        }

        private void btAvançar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                tabControl1.TabPages.Add(tabAcesso);
                tabControl1.SelectedIndex = 1;
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabAcesso);
            tabControl1.SelectedIndex = 0;
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabDados)
            {
                tabControl1.TabPages.Remove(tabAcesso);
            }
        }
        #endregion

        #region aplicar Validação
        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCPF.Texts.Length == 11)
            {
                e.Handled = true;
            }
            else
            {
                permitirNumeros(e);
            }
        }

        private void txtCNH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCNH.Texts.Length == 10)
            {
                e.Handled = true;
            }
            else
            {
                permitirNumeros(e);
            }
        }

        private void txtCel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCel.Texts.Length == 11)
            {
                e.Handled = true;
            }
            else
            {
                permitirNumeros(e);
            }
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            txtCPF.Texts = formatarCPF(txtCPF.Texts);
        }

        private void txtCel_Leave(object sender, EventArgs e)
        {
            txtCel.Texts = formataCelular(txtCel.Texts);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            permitirLetrasEspaco(e);
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtPass.Texts.Length == 8)
            {
                e.Handled = true;
            }

        }
        #endregion

        private void FormCadastroPessoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Os dados preenchidos no formulario serao perdidos ao fechamento","Aviso!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            var result = MessageBox.Show(this, "Você tem certeza que deseja fechar essa tela?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void cbMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrar.Checked)
            {
                txtPass.PasswordChar = false;
            }
            else
            {
                txtPass.PasswordChar = true;
            }
        }
    }
}
