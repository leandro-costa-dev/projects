using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CursoBruno
{
    public partial class frm_veiculo : Form
    {
        string texto;
        
        public static int codigo;

        public frm_veiculo(string texto)
        {
            InitializeComponent();
            this.texto = texto;
        }

        private void frm_veiculo_Load(object sender, EventArgs e)
        {
            label1.Text = texto;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(textBox1.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
