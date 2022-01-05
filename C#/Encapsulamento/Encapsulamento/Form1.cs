using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClasseCalculo calculo = new ClasseCalculo();

            Double valor_inicial = Convert.ToDouble(textBox1.Text);
            int tipo = 0;

            if (radioButton1.Checked)
                tipo = 1;
            else if (radioButton2.Checked)
                tipo = 2;
            else if (radioButton3.Checked)
                tipo = 3;


            lbl_valorTotal.Text = calculo.calculoPrecoFinal(valor_inicial, tipo).ToString();

        }
    }
}

