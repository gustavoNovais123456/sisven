using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISVEN
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view.clientes.FormCadastroCliente cadastroCliente = new view.clientes.FormCadastroCliente();
            cadastroCliente.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
