using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CursoBruno
{
    public partial class frm_radioButton : Form
    {
        public frm_radioButton()
        {
            InitializeComponent();
        }

        private void frm_radioButton_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach(RadioButton rb in groupBox1.Controls)
            {
                if(rb.Checked)
                {
                    txt = rb.Text;
                }
            }
            MessageBox.Show("O RadioButton selecionado foi: " + txt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach (RadioButton rb in groupBox2.Controls)
            {
                if (rb.Checked)
                {
                    txt = rb.Text;
                }
            }
            MessageBox.Show("O RadioButton selecionado foi: " + txt);
        }
    }
}
