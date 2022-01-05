using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CursoBruno
{
    public partial class frm_trackBar : Form
    {
        public frm_trackBar()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
        }

        private void frm_trackBar_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(int.Parse(textBox1.Text) < trackBar1.Minimum || int.Parse(textBox1.Text) > trackBar1.Maximum)
            {
                MessageBox.Show("Valor informado é inválido!");
                return;
            }
            else
            {
                trackBar1.Value = int.Parse(textBox1.Text);
            }

        }
    }
}
