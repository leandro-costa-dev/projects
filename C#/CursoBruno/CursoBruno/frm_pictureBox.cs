using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CursoBruno
{
    public partial class frm_pictureBox : Form
    {
        public frm_pictureBox()
        {
            InitializeComponent();
        }

        private void frm_pictureBox_Load(object sender, EventArgs e)
        {
            //Utilizando arquivos de recursos
            label1.Text = Properties.Resources.URLGoogle;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.logo_google;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.logo_google_chrome;
        }
    }
}
