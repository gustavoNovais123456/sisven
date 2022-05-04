using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISVEN.view.clientes
{
    public partial class FormCadastroCliente : Form
    {
        public FormCadastroCliente()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("001", "Tste");
            dataGridView1.Rows.Add("001", "Tste");
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            panelCadastro.Enabled = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void cbCliente_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
