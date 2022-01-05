using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ClasseEstatica
{
    public static class ClasseEstatitca
    {
        public static String senha { get; set; }
        public static void Mostrar()
        {
            MessageBox.Show("A senha cadastrada é " + senha);
        }
    }
}
