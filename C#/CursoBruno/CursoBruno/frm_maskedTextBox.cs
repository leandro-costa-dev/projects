using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CursoBruno
{
    public partial class frm_maskedTextBox : Form
    {
        public frm_maskedTextBox()
        {
            InitializeComponent();
        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                mtb_cep.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            else
            {
                mtb_cep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }

            lbl_visualizar.Text = mtb_cep.Text;
        }

        private void btn_visualizaSenha_MouseUp(object sender, MouseEventArgs e)
        {
            mtb_senha.PasswordChar = '*';
        }

        private void btn_visualizaSenha_MouseDown(object sender, MouseEventArgs e)
        {
            mtb_senha.PasswordChar = '\0';
        }

        private void v(object sender, EventArgs e)
        {

        }
    }
}
