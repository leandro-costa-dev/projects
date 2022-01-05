using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseEstatica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClasseNormal normal = new ClasseNormal();
            normal._nome = "Leandro Costa";
            normal._idade = 34;
            normal.Apresentar();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClasseNormal normal = new ClasseNormal();
            normal._nome = "Jose Silva";
            normal._idade = 30;
            normal.Apresentar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClasseEstatitca.senha = "Senha";
            ClasseEstatitca.Mostrar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClasseEstatitca.Mostrar();
        }
    }
}
