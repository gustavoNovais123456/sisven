using SistemaCSV.control;
using SistemaCSV.control.dao;
using SistemaCSV.visao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCSV
{
    public partial class FormLogin : Form
    {
        FormMenu menu;
        public FormLogin(FormMenu formMenu)
        {
            InitializeComponent();
            menu = formMenu; 

        }

        private void logar()
        {
            PessoaDao dao = new PessoaDao();
            string login = txtUsuario.Texts.ToLower().Trim();
            string senha = txtSenha.Texts.Trim();
            if(login == String.Empty || senha == String.Empty)
            {
                MessageBox.Show("USUARIO OU SENHA INVALIDOS");
                txtUsuario.Focus();
                return;
            }
            else
            {
                DataTable dt = dao.buscarLogin(login, senha);
                if (dt.Rows.Count == 1)
                {
                    varGlobais.usuario = dt.Rows[0].ItemArray[0].ToString();
                    varGlobais.acesso = dt.Rows[0].ItemArray[4].ToString();
                    menu.lbUsuario.Text = varGlobais.usuario;
                    menu.lbFuncao.Text = varGlobais.acesso;
                    varGlobais.logado = true;
                    menu.habilitarMenus();
                    /*DataTable conf = dao.buscarConfigs();
                    ConfigGlobal.limitehoras = conf.Rows[0].ItemArray[1].ToString();
                    ConfigGlobal.valorDiaria = Convert.ToDouble(conf.Rows[0].ItemArray[2]);
                    ConfigGlobal.valorHoraExtra = Convert.ToDouble(conf.Rows[0].ItemArray[3]);*/
                    this.Close();
                }
                else
                {
                    MessageBox.Show("USUARIO OU SENHA INVALIDOS");
                }
            }
            
           
        }
        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            logar();
        }
    }
}
