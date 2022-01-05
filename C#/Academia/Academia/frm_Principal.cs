using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
            frm_Login f = new frm_Login(this);
            f.ShowDialog();
        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {

        }

        private void cadastroDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (Globais.nivel >= 1)
            {
                frm_usuario f = new frm_usuario();
                f.ShowDialog();
            }else
            {
                MessageBox.Show("Acesso não permitido!");
            }
            

        }
    }
}
