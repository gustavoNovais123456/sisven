using Correios.Net;
using SISVEN.control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISVEN.view.clientes
{
    public partial class FormCadastroCliente : Form
    {
        public FormCadastroCliente()
        {
            InitializeComponent();
        }

        public static string FormatarCpfCnpj(string strCpfCnpj)

        {
            if (strCpfCnpj.Length <= 11)
            {
                MaskedTextProvider mtpCpf = new MaskedTextProvider(@"000\.000\.000-00");
                mtpCpf.Set(ZerosEsquerda(strCpfCnpj, 11));
                return mtpCpf.ToString();
            }
            else
            {
                MaskedTextProvider mtpCnpj = new MaskedTextProvider(@"00\.000\.000/0000-00");
                mtpCnpj.Set(ZerosEsquerda(strCpfCnpj, 11));
                return mtpCnpj.ToString();
            }
        }

        private static string FormatarCPF(string cpf)
        {
            if (cpf.Length <= 11)
            {
                MaskedTextProvider mtpCpf = new MaskedTextProvider(@"000\.000\.000-00");
                mtpCpf.Set(ZerosEsquerda(cpf, 11));
                return mtpCpf.ToString();
            }
            return null;
        }

        private static string FormatarCell(string cell)
        {
            if (cell.Length <= 11)
            {
                MaskedTextProvider mtpCpf = new MaskedTextProvider(@"(00)00000-0000");
                mtpCpf.Set(cell);
                return mtpCpf.ToString();
            }
            return null;
        }

        private static string FormatarFone(string fone)
        {
            if (fone.Length <= 10)
            {
                MaskedTextProvider mtpCpf = new MaskedTextProvider(@"(00)0000-0000");
                mtpCpf.Set(fone);
                return mtpCpf.ToString();
            }
            return null;
        }

        public static string ZerosEsquerda(string strString, int intTamanho)
        {
            string strResult = "";
            for (int intCont = 1; intCont <= (intTamanho - strString.Length); intCont++)
            {
                strResult += "0";
            }
            return strResult + strString;
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

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCPF.Text.Length == 11)
            {
                txtCPF.Text = FormatarCPF(txtCPF.Text);
            }
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCelu.Text.Length == 11)
            {
                txtCelu.Text = FormatarCell(txtCelu.Text);
            }
            
        }

        private void txtFone_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtFone.Text.Length == 10)
            {
                txtFone.Text = FormatarFone(txtFone.Text);
            }
        }
        private void LocalizarCEP()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + txtCEP.Text + "/json/");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

            if (ChecaServidor.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Erro na requisição: " + ChecaServidor.StatusCode.ToString());
                return; // Encerra o código
            }

            using (Stream webStream = ChecaServidor.GetResponseStream())
            {
                if (webStream != null)
                {
                    using (StreamReader responseReader = new StreamReader(webStream))
                    {
                        String response = responseReader.ReadToEnd();
                        response = Regex.Replace(response, "[{},]", string.Empty);
                        response = response.Replace("\"", "");
                        String[] substrings = response.Split('\n');
                        int cont = 0;
                        foreach (var substring in substrings)
                        {
                            // CEP
                            if (cont == 1)
                            {
                                string[] valor = substring.Split(':');
                                txtCEP.Text = valor[1].ToString();
                            }
                            // Logradouro
                            if (cont == 2)
                            {
                                string[] valor = substring.Split(':');
                                txtRua.Text = valor[1].ToString();
                            }
                            // Bairro
                            if (cont == 4)
                            {
                                string[] valor = substring.Split(':');
                                txtBairro.Text = valor[1].ToString();
                            }
                            // Cidade
                            if (cont == 5)
                            {
                                string[] valor = substring.Split(':');
                                txtCidade.Text = valor[1].ToString();
                            }
                            // UF
                            if (cont == 6)
                            {
                                string[] valor = substring.Split(':');
                                txtUF.Text = valor[1].ToString();
                            }
                            cont++;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LocalizarCEP();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            ClienteDao dao = new ClienteDao();
            try
            {
                DataTable dt = new DataTable();
                string filtro = txtFiltro.Text;

                dt = dao.PesquisaCliente(filtro);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }
    }
}
