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
using TccAtualizado.control.dao;

namespace TccAtualizado.views
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            datas();
        }

        private void datas()
        {
            DateTime data = DateTime.Today;
            lbData.Text = data.ToString("D");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lbHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            ContadoresDao dao = new ContadoresDao();
            ProdutoDao daoProd = new ProdutoDao();
            txtTotalProdutos.Text = dao.maxProduto().ToString();

            //dataGridView1.DataSource = daoProd.listaProdutos();
            /*this.dataGridView1.Columns["id"].Visible = false;
            this.dataGridView1.Columns["categoria"].Visible = false;
            this.dataGridView1.Columns["ativo"].Visible = false;*/
        }

    }
}   
