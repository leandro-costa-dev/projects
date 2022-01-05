using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CursoBruno
{
    public partial class frm_listBox : Form
    {
        List<string> carros = new List<string>();
        public frm_listBox()
        {
            InitializeComponent();
            carros.Add("Fiesta");
            carros.Add("Gol");
            carros.Add("Corsa");
            carros.Add("Polo");
            carros.Add("March");

            atualizar();
        }

        private void frm_listBox_Load(object sender, EventArgs e)
        {

        }

        private void atualizar ()
        {
            lbx_carros.DataSource = null;
            lbx_carros.DataSource = carros;
        }
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_texto.Text))
                return;

            carros.Add(txt_texto.Text);
            txt_texto.Clear();
            txt_texto.Focus();

            atualizar();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (lbx_carros.SelectedIndex < 0)
                return;
            
            carros.RemoveAt(lbx_carros.SelectedIndex);

            atualizar();
        }

        private void btn_carregar_Click(object sender, EventArgs e)
        {
            if (lbx_carros.SelectedIndex < 0)
                return;

            txt_texto.Text = lbx_carros.SelectedItem.ToString();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            carros.Clear();

            atualizar();
        }
    }
}
