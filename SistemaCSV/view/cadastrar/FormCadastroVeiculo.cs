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
    public partial class FormCadastroVeiculo : Form
    {
        Veiculo veiculo;
        FormConsultaVeiculo formControle;
        public FormCadastroVeiculo(FormConsultaVeiculo form)
        {
            InitializeComponent();
            formControle = form;
            veiculo = formControle.VeiculoEdicao;
            setarInformacoes();
        }

        #region sistema
        private bool validar()
        {
            if (txtModelo.Texts == String.Empty)
            {
                MessageBox.Show("O modelo do veiculo está nulo, por favor informe o modelo do veiculo");
                txtModelo.Focus();
                return false;
            }
            if (txtPlaca.Text == String.Empty)
            {
                MessageBox.Show("A Placa do veiculo está nula");
                txtPlaca.Focus();
                return false;
            }
            return true;
        }

        private void setarInformacoes()
        {
            txtModelo.Texts = veiculo.Modelo;
            txtMarca.Texts = veiculo.Marca;
            txtCor.Texts = veiculo.Cor;
            txtAno.Texts = veiculo.Ano;
            txtPlaca.Text = veiculo.Placa;
            tgbAtivo.Checked = veiculo.Ativo;
        }

        private void manterVeiculo()
        {
            VeiculoDao dao = new VeiculoDao();

            Veiculo veiculo = new Veiculo();
            veiculo.Id = this.veiculo.Id;
            veiculo.Modelo = txtModelo.Texts;
            veiculo.Marca = txtMarca.Texts;
            veiculo.Cor = txtCor.Texts;
            veiculo.Ano = txtAno.Texts;
            veiculo.Placa = txtPlaca.Text;
            veiculo.Ativo = tgbAtivo.Checked;

            try
            {
                dao.gravarVeiculo(veiculo);
                MessageBox.Show("Veiculo Salvo Com Sucesso", "Sucesso!");
            }
            catch
            {
                MessageBox.Show("Erro ao salvar Veiculo", "Erro!");
            }
        }
        #endregion

        #region validação
        private void permitirNumeros(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        #endregion

        #region validaçao aplicada
        private void rjTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAno.Texts.Length == 4)
            {
                e.Handled = true;
            }
            else
            {
                permitirNumeros(e);
            }
        }
        #endregion

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                manterVeiculo();
                formControle.buscarVeiculos();
                this.Close();
            }
        }
    }
}
