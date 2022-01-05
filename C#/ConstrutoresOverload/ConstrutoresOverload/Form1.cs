using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstrutoresOverload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            teste teste = new teste("Leandro", 34);
            teste.Apresentar();
            teste.Apresentar("****");
            teste.Apresentar("leandro", 20);
        }
    }
}
