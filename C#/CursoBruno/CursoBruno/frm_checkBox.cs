using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CursoBruno
{
    public partial class frm_checkBox : Form
    {
        List<CheckBox> transp = new List<CheckBox>();
                
        public frm_checkBox()
        {
            InitializeComponent();
            transp.Add(cbx_carro);
            transp.Add(cbx_aviao);
            transp.Add(cbx_navio);
            transp.Add(cbx_onibus);
        }

        private void frm_checkBox_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = "";

            //if (cbx_carro.Checked)
            //{
            //    texto += cbx_carro.Text + ", ";
            //}

            //if (cbx_aviao.Checked)
            //{
            //    texto += cbx_aviao.Text + ", ";
            //}

            //if (cbx_navio.Checked)
            //{
            //    texto += cbx_navio.Text + ", ";
            //}

            //if (cbx_onibus.Checked)
            //{
            //    texto += cbx_onibus.Text + ", ";
            //}

            foreach(CheckBox t in transp)
            {
                if (t.Checked)
                    texto += t.Text + ", ";
            }

            MessageBox.Show("Os transportes selecionados foram: " + texto);
        }
    }
}
