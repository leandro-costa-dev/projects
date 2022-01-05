using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoBruno
{
    public partial class frm_cadastro : Form
    {
        public frm_cadastro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Digite um texto!");
                return;
            }

            textBox2.Text += textBox1.Text + ", ";

            textBox1.Clear();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
            textBox1.Focus();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            frm_veiculo v = new frm_veiculo(textBox2.Text);
            v.ShowDialog();
        }

        private void btn_variavel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(frm_veiculo.codigo.ToString());

        }
    }
}
