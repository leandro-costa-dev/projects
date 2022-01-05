using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CursoBruno
{
    public partial class frm_checkedListBox : Form
    {
        public frm_checkedListBox()
        {
            InitializeComponent();
        }

        private void frm_checkedListBox_Load(object sender, EventArgs e)
        {

        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            string texto = "";


            if(checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Não há item selecionado!");
            }else
            {
                foreach (string t in checkedListBox1.CheckedItems)
                {
                    texto += t + ", ";                    
                }
                MessageBox.Show(texto);
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_adicionar.Text))
                return;

            //Adiciona item no checkedListBox e verifica se o "Selecionar Todos" está marcado.
            checkedListBox1.Items.Add(txt_adicionar.Text, checkBox1.Checked);
            txt_adicionar.Clear();
            txt_adicionar.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }                            
            }else
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }

        }
    }
}
