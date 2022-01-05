using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CursoBruno
{
    public partial class frm_comboBox : Form
    {
        public frm_comboBox()
        {
            InitializeComponent();
        }

        private void frm_comboBox_Load(object sender, EventArgs e)
        {

        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmb_lista.Text))
                return;

            MessageBox.Show(cmb_lista.Text);
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            cmb_lista.Items.Clear();
            cmb_lista.Text = "";
        }

        private void btn_carregar_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            lista.Add("Aviao");
            lista.Add("Barco");
            lista.Add("Bicicleta");
            lista.Add("Patinete");

            //foreach(string t in lista)
            //{
            //    cmb_lista.Items.AddRange();
            //}
                  

            cmb_lista.Items.Add("Carro");
            cmb_lista.Items.Add("Moto");
            cmb_lista.Items.Add("Onibus");

        }

        private void cmb_lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_mostrar.Text = cmb_lista.Text;            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_mostrar.Text))
                return;

            cmb_lista.Items.Add(txt_mostrar.Text);
            txt_mostrar.Clear();
            txt_mostrar.Focus();
        }
    }
}
