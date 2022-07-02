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
    public partial class FormConsultaVeiculo : Form
    {
        Veiculo veiculoEdicao = new Veiculo();
        internal Veiculo VeiculoEdicao { get => veiculoEdicao; set => veiculoEdicao = value; }

        public FormConsultaVeiculo()
        {
            InitializeComponent();
            buscarVeiculos();
        }

        #region sistema
        public void buscarVeiculos()
        {
            VeiculoDao dao = new VeiculoDao();
            string filtro = txtFiltro.Texts;
            string registro = cbRegistro.SelectedIndex.ToString();
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

            dgPesquisaVeiculos.DataSource = dao.listaVeiculos(filtro, registro);

            this.dgPesquisaVeiculos.Columns["id"].Visible = false;
        }
        private void setarDadosEdicao()
        {
            DataGridViewRow linhaAtual = dgPesquisaVeiculos.CurrentRow;
            int indice = linhaAtual.Index;
            string[] campos = new string[7];
            for (int i = 0; i < 7; i++)
            {
                campos[i] = dgPesquisaVeiculos.Rows[indice].Cells[i].Value.ToString();
            }
            veiculoEdicao.Id = int.Parse(campos[0]);
            veiculoEdicao.Modelo = campos[1];
            veiculoEdicao.Marca = campos[2];
            veiculoEdicao.Cor = campos[3];
            veiculoEdicao.Placa = campos[4];
            veiculoEdicao.Ano = campos[5];
            veiculoEdicao.Ativo = Convert.ToBoolean(campos[6]);
        }

        private void dgPesquisaVeiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setarDadosEdicao();
        }

        #endregion

        #region buscas

        private void cbRegistro_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            buscarVeiculos();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            buscarVeiculos();
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            buscarVeiculos();
        }

        #endregion

        #region controle
        private void btNovo_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja cadastrar um novo Veiculo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                veiculoEdicao = new Veiculo();
                FormCadastroVeiculo formCadastroVeiculo = new FormCadastroVeiculo(this);
                formCadastroVeiculo.ShowDialog();
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja editar esse veiculo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                setarDadosEdicao();
                FormCadastroVeiculo formCadastroVeiculo = new FormCadastroVeiculo(this);
                formCadastroVeiculo.ShowDialog();
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            VeiculoDao dao = new VeiculoDao();
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja desativar esse veiculo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                if (veiculoEdicao.Id > 0)
                {
                    Veiculo veiculo = new Veiculo();
                    veiculo.Id = veiculoEdicao.Id;
                    veiculo.Ativo = false;
                    dao.inativarVeiculo(veiculo);
                    buscarVeiculos();
                }
                else
                {
                    MessageBox.Show("selecione um motorista na lista antes");
                }
            }
        }
        #endregion

        private void FormControleVeiculo_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show(this, "Você tem certeza que deseja fechar essa tela?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}