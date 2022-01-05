using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frm_pesquisa : Form
    {
        public bool cancelado { get; set; }
        public String texto { get; set; }

        public frm_pesquisa()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            cancelado = true;
            this.Close();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            //Define o texto e fecha o quadro
            if (txt_pesquisa.Text == "") return;

            texto = txt_pesquisa.Text;
            cancelado = false;
            this.Close();
        }
    }
}
