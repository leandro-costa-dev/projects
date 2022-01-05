using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciclos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //for ( int valor = 0; valor <=20; valor++ )
            //{
            //    listBox_texto.Items.Add(valor);
            //}

            //int valor = 0;

            //while (valor <= 10)
            //{
            //    listBox_texto.Items.Add(valor);
            //    valor++;
            //}

            //int valor = 0;

            //do
            //{
            //    listBox_texto.Items.Add(valor);
            //    valor++;
            //} while (valor <=10);


            string frase = "Este ciclo é fantastico";

            foreach (char c  in frase)
            {
                listBox_texto.Items.Add(c);
            }

            int[] valores = new int[5];

            valores[0] = 10;
            valores[1] = 20;
            valores[2] = 30;
            valores[3] = 40;
            valores[4] = 50;



        }
    }
}
