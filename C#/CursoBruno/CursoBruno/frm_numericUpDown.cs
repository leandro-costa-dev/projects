using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CursoBruno
{
    public partial class frm_numericUpDown : Form
    {
        public frm_numericUpDown()
        {
            InitializeComponent();
        }

        private void frm_numericUpDown_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(Decimal.Parse(txt_valor.Text) < numericUpDown1.Minimum ||
               Decimal.Parse(txt_valor.Text) > numericUpDown1.Maximum)
            {
                MessageBox.Show("Valor inválido!");
                return;
            }
            
            numericUpDown1.Value = Decimal.Parse(txt_valor.Text);           
        }
    }
}
