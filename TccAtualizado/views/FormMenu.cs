using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TccAtualizado.control;
using TccAtualizado.views;

namespace TccAtualizado
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            customDesign();
        }

        #region metodos Sistema
        public void abrirtelas(object tela)
        {
            if (this.panelConteudo.Controls.Count > 0) this.panelConteudo.Controls.RemoveAt(0);
            Form painel = tela as Form;
            painel.TopLevel = false;
            painel.Dock = DockStyle.Fill;
            this.panelConteudo.Controls.Add(painel);
            this.panelConteudo.Tag = painel;
            painel.Show();
        }
        private void customDesign()
        {
            panelSubCadastro.Visible = false;
            //panelSubServico.Visible = false;
            //panelSubOpcao.Visible = false;
            abrirtelas(new TelaInicial());
        }
        private void escondeMenu()
        {
            if (panelSubCadastro.Visible == true) panelSubCadastro.Visible = false;
            //if (panelSubServico.Visible == true) panelSubServico.Visible = false;
            //if (panelSubOpcao.Visible == true) panelSubOpcao.Visible = false;

        }

        private void mostraMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                escondeMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        #endregion

        #region botoes superior
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region botoes menu
        private void btCadastros_Click(object sender, EventArgs e)
        {
            mostraMenu(panelSubCadastro);
        }
        #endregion

        #region botoes menu Cadastro
        private void btCadPessoa_Click(object sender, EventArgs e)
        {
            SubMenuPessoa.Show(btCadPessoa, btCadPessoa.Width, 0);

        }

        private void btCadProduto_Click(object sender, EventArgs e)
        {
            SubMenuProduto.Show(btCadProduto,btCadProduto.Width, 0);
        }


        #endregion

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirtelas(new views.views_cadastros.FormCadastroCliente());
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirtelas(new views.views_cadastros.FormCadastroFuncionario());
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirtelas(new views.views_cadastros.FormCadastroUsuario());
        }
    }
}
