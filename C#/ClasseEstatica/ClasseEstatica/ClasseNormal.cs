using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ClasseEstatica
{
    class ClasseNormal
    {
        public string _nome { get; set; }
        public int _idade { get; set; }

        public void Apresentar()
        {
            MessageBox.Show("Meu nome é " + _nome + " e tenho " + _idade + " anos");

        }
    }
}
