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

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {

        string pasta_aplicacao = @"D:\Projetos\C#\Arquivos\";
        string arquivo_ini = "config.ini";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gravarConfiguracoes();
            MessageBox.Show("As configurações foram gravadas com sucesso!");                      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(pasta_aplicacao + arquivo_ini))
            {
                MessageBox.Show("Arquivo de configuração não encontrado");
                return;
            }


            StreamReader arquivo = new StreamReader(pasta_aplicacao + arquivo_ini, Encoding.Default);

            textBox1.Text = arquivo.ReadLine();
            dateTimePicker1.Value = Convert.ToDateTime(arquivo.ReadLine());

            arquivo.Dispose();
        }

        private void gravarConfiguracoes ()
        {
            //Verifica se o diretorio existe
            if (!Directory.Exists(pasta_aplicacao))
                Directory.CreateDirectory(pasta_aplicacao);

            //Cria arquivo de configuração e grava as informações
            StreamWriter arquivo = new StreamWriter(pasta_aplicacao + arquivo_ini, false, Encoding.Default);

            arquivo.WriteLine(textBox1.Text);
            arquivo.WriteLine(dateTimePicker1.Value.ToShortDateString());

            arquivo.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }
    }

}
