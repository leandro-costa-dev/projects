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

        private void button1_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[5];

            nomes[0] = "Leandro";
            nomes[1] = "Joao";
            nomes[2] = "Pedro";
            nomes[3] = "Carlos";
            nomes[4] = "Antonio";

            //Carrega itens do array na listbox
            for (int i = 0; i < nomes.Length; i++)
            {
                listBox1.Items.Add(nomes[i]);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<String> pessoas = new List<string>();

            pessoas.Add("Leandro");
            pessoas.Add("Marcelo");
            pessoas.Add("Felipe");
            pessoas.Add("Tiago");
            pessoas.Add("Roberto");
            pessoas.Add("Pedro");
            pessoas.Add("Joao");
            pessoas.Add("Ana");
            pessoas.Add("Jessica");
            pessoas.Add("Maria");
            pessoas.Add("Mateus");


            //Carrega itens na listbox
            foreach (string item in pessoas)
            {
                listBox1.Items.Add(item);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<int> valores = new List<int>() { 10, 20, 30 };

            foreach (int item in valores)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Array que não permite duplicação de valores
            HashSet<string> nomes = new HashSet<string>()
            {
                "Leandro", "Marcos", "João", "Pedro"
            };

            //Testa se existe nome na lista e exibe mensagem de erro
            if(!nomes.Add("Leandro"))
            {
                MessageBox.Show("Erro! O nome ja existe");
            }

            //Carregar valores na listbox
            foreach (string item in nomes)
            {
                listBox1.Items.Add(item);
            }
                       
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> cadastro = new Dictionary<int, string>();

            cadastro.Add(10, "Leandro");
            cadastro.Add(11, "Pedro");
            cadastro.Add(12, "João");
            cadastro.Add(13, "Marcelo");

            foreach (KeyValuePair<int, string> item in cadastro)
                listBox1.Items.Add(item.Key + " - " + item.Value);

        }
    }
}
