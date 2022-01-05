using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ler_Click(object sender, EventArgs e)
        {
            StreamReader arquivo = new StreamReader(@"D:\Arquivo.txt", Encoding.Default);

            while (arquivo.EndOfStream==false)
            {
                listBox1.Items.Add(arquivo.ReadLine());
            }

            arquivo.Dispose();

        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            StreamWriter arquivo = new StreamWriter(@"D:\Arquivo.txt", true, Encoding.Default);
            arquivo.WriteLine(textBox1.Text);

            textBox1.Clear();
            textBox1.Focus();

            arquivo.Dispose();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

    }
}
