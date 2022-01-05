using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label_r.Text = trackBar1.Value.ToString();
            atualizaCor();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label_g.Text = trackBar2.Value.ToString();
            atualizaCor();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label_b.Text = trackBar3.Value.ToString();
            atualizaCor();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_cor.BackColor = Color.Black;
        }

        private void atualizaCor()
        {
            label_cor.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }
    }
}
