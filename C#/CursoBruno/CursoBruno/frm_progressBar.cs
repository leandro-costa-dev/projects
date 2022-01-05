using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CursoBruno
{
    public partial class frm_progressBar : Form
    {
        public frm_progressBar()
        {
            InitializeComponent();
        }

        private void frm_progressBar_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            progressBar1.Value = Convert.ToInt32(numericUpDown1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0 ; i <= progressBar1.Maximum; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(200);
            }

            MessageBox.Show("Processo concluído com sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = int.Parse(textBox1.Text);

            for (int i = 0; i <= int.Parse(textBox1.Text); i++)
            {
                progressBar1.Value = i;
                label2.Text = i.ToString();
            }
        }
    }
}
