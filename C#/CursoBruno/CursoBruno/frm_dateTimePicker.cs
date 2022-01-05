using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CursoBruno
{
    public partial class frm_dateTimePicker : Form
    {
        public frm_dateTimePicker()
        {
            InitializeComponent();
        }

        private void frm_dateTimePicker_Load(object sender, EventArgs e)
        {

        }
        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            txt_data.Text = dtp_data.Text.ToString();

            txt_dia.Text = dtp_data.Value.Day.ToString();
            txt_mes.Text = dtp_data.Value.Month.ToString();
            txt_ano.Text = dtp_data.Value.Year.ToString();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            int ano = Convert.ToInt32(txt_ano.Text);
            int mes = Convert.ToInt32(txt_mes.Text);
            int dia = Convert.ToInt32(txt_dia.Text);

            DateTime data = new DateTime(ano, mes, dia);

            dtp_data.Value = data;

        }

        private void btn_hoje_Click(object sender, EventArgs e)
        {
            dtp_data.Value = DateTime.Today;
        }

    }
}
