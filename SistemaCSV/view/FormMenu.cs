using SistemaCSV.control;
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

namespace SistemaCSV.visao
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            FormLogin formLogin = new FormLogin(this);
            formLogin.ShowDialog();
        }

        #region sistema
        public void habilitarMenus()
        {
            if (varGlobais.acesso.Equals("motorista"))
            {
                btCadastros.Visible = false;
                configuracaoToolStripMenuItem.Visible = false;
            }
            else
            {
                btCadastros.Visible = true;
                configuracaoToolStripMenuItem.Visible = true;
            }
            if (varGlobais.logado == true)
            {
                conectarToolStripMenuItem.Visible = false;
                desconectarToolStripMenuItem1.Visible = true;
            }
        }
        #endregion

        #region botoes
        private void btCadastros_Click(object sender, EventArgs e)
        {
            if (varGlobais.logado == true)
            {
                subMenuCadastros.Show(btCadastros, btCadastros.Width, 0);
            }
            else
            {
                MessageBox.Show("Faça o login para acessar!");
            }
        }

        private void btViagens_Click(object sender, EventArgs e)
        {
            if (varGlobais.logado == true)
            {
                subMenuViagem.Show(btViagens, btViagens.Width, 0);
            }
            else
            {
                MessageBox.Show("Faça o login para acessar!");
            }
        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            subMenuOpcoes.Show(btConfig, btConfig.Width, 0);
        }
        #endregion

        #region submenu Opçoes
        private void desconectarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (varGlobais.logado == true)
            {
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja desconectar-se", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    varGlobais.logado = false;
                    configuracaoToolStripMenuItem.Visible = false;
                    desconectarToolStripMenuItem1.Visible = false;
                    lbFuncao.Text = "---";
                    lbUsuario.Text = "---";
                    conectarToolStripMenuItem.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Você ja esta desconectado");
            }
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (varGlobais.logado == false)
            {
                FormLogin formLogin = new FormLogin(this);
                formLogin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você ja esta conectado");
            }
        }
        #endregion

        #region submenu Cadastro
        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaPessoa formConsultaPessoa = new FormConsultaPessoa();
            formConsultaPessoa.ShowDialog();
        }

        private void veiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaVeiculo formConsultaVeiculo = new FormConsultaVeiculo();
            formConsultaVeiculo.ShowDialog();
        }
        #endregion

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show(this, "Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}