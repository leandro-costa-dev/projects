using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Copiar arquivos entre diretórios
            //File.Copy(@"D:\Projetos\C#\Arquivos\config.ini", @"D:\config.ini");

            string[] lista_arquivos = Directory.GetFiles(@"D:\Projetos\C#\Arquivos\", "*.txt");

            //Listar os arquivos no ListBox
            foreach (string item in lista_arquivos)
            {
                listBox1.Items.Add(item);
            }

            foreach (string item in lista_arquivos)
            {
                //Para cada item do array move o arquivo para o novo caminho com o mesmo nome
                File.Move(item, @"D:\Projetos\C#\Arquivos\temp\" + Path.GetFileName(item));

            }
        }
    }
}
