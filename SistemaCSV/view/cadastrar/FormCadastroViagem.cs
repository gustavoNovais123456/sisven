using SistemaCSV.control;
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
    public partial class FormCadastroViagem : Form
    {
        #region variaveis tempo
        DateTime horaInicio;
        DateTime horaFim;
        int he = 0;
        double totalValor;
        TimeSpan tempo;
        #endregion

        #region variaveis valores
        double total;
        double aReceber;
        double troco;
        double gastos;
        #endregion

        public FormCadastroViagem()
        {
            InitializeComponent();
            //infoHoras();
        }
        private void infoHoras()
        {
            hrExtras();
            txtTotalHoras.Texts = tempo.ToString();
            txtQtdHoras.Texts = he.ToString();
            txtValorHoras.Texts = totalValor.ToString();
        }

        private void hrExtras()
        {

            horaInicio = Convert.ToDateTime(dtpHoraInicio.Text);
            horaInicio = Convert.ToDateTime(horaInicio.ToString("HH:mm"));
            horaFim = Convert.ToDateTime(dtpHoraFinal.Text);
            horaFim = Convert.ToDateTime(horaFim.ToString("HH:mm"));

            he = 0;
            totalValor = 0.0;
            var limite = TimeSpan.Parse(varGlobais.limite_horas);
            if (horaFim < horaInicio || horaInicio == horaFim)
            {
                horaFim = horaFim.AddDays(1);
            }

            tempo = horaFim - horaInicio;
            int taxa = TimeSpan.Compare(tempo, limite);
            if (taxa == -1 || taxa == 0)
            {
                totalValor = he * varGlobais.valor_hora_extra;
            }
            else
            {
                he += 1 + (int)tempo.Subtract(limite).Hours;
                totalValor = he * varGlobais.valor_hora_extra;
            }
        }

        private void dtpHoraInicio_ValueChanged(object sender, EventArgs e)
        {
            infoHoras();
        }

        private void dtpHoraFinal_ValueChanged(object sender, EventArgs e)
        {
            infoHoras();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            infoHoras();
        }
    }
}
