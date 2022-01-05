using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraNova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

            Calculos calcular = new Calculos();

            String valor_total = calcular.calcular(textBox1.Text);

            if(valor_total == "-1")
            {              
                MessageBox.Show("O valor informado é inválido!");
            }
            else
            {
                MessageBox.Show("O valor total é " + valor_total);
            }
            

            //Limpar caixa de texto
            textBox1.Text = "";
            textBox1.Focus();

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //Ao clicar enter o sistema verifica se existir valores executa a operação
            if (textBox1.Text == "") return;

            //Analisa a tecla pressionada
            if (e.KeyCode == Keys.Return)
                btn_ok_Click(btn_ok, EventArgs.Empty);

        }
    }
}
