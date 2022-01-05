using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstantesEstruturas
{
    public partial class Form1 : Form
    {
        struct estrutura_pessoa
        {
            public string nome;
            public string sobrenome;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClasseNormal objeto1 = new ClasseNormal();
            MessageBox.Show(objeto1.nome);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            estrutura_pessoa pessoa1 = new estrutura_pessoa();

            pessoa1.nome = "Leandro";
            pessoa1.sobrenome = "Costa";

            MessageBox.Show(pessoa1.nome + " " + pessoa1.sobrenome);
        }
    }
}
