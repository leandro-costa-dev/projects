using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CursoBruno
{
    public partial class frm_listView : Form
    {
        public frm_listView()
        {
            InitializeComponent();
        }

        private void frm_listView_Load(object sender, EventArgs e)
        {

        }

        private void limpar ()
        {
            txt_id.Clear();
            txt_produto.Clear();
            txt_qtde.Clear();
            txt_valor.Clear();

            txt_id.Focus();
        }
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_id.Text))
            {
                MessageBox.Show("O Campo ID deve ser preenchido");
                txt_id.Focus();
                return;
            }else if(string.IsNullOrWhiteSpace(txt_produto.Text))
            {
                MessageBox.Show("O Campo produto deve ser preenchido");
                txt_produto.Focus();
                return;
            }else if(string.IsNullOrWhiteSpace(txt_qtde.Text))
            {
                MessageBox.Show("O Campo quantidade deve ser preenchido");
                txt_qtde.Focus();
                return;
            }else if(string.IsNullOrWhiteSpace(txt_valor.Text))
            {
                MessageBox.Show("O Campo valor deve ser preenchido");
                txt_valor.Focus();
                return;
            }
            else
            {
                string[] produtos = new string[4];
                produtos[0] = txt_id.Text;
                produtos[1] = txt_produto.Text;
                produtos[2] = txt_qtde.Text;
                produtos[3] = txt_valor.Text;

                ListViewItem list = new ListViewItem(produtos);
                ltv_produtos.Items.Add(list);

                limpar();

            }                       
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {


            ltv_produtos.Items.RemoveAt(ltv_produtos.SelectedIndices[0]);
        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            txt_id.Text = ltv_produtos.SelectedItems[0].SubItems[0].Text;
            txt_produto.Text = ltv_produtos.SelectedItems[0].SubItems[1].Text;
            txt_qtde.Text = ltv_produtos.SelectedItems[0].SubItems[2].Text;
            txt_valor.Text = ltv_produtos.SelectedItems[0].SubItems[3].Text;

        }

        private void ltv_produtos_DoubleClick(object sender, EventArgs e)
        {
            txt_id.Text = ltv_produtos.SelectedItems[0].SubItems[0].Text;
            txt_produto.Text = ltv_produtos.SelectedItems[0].SubItems[1].Text;
            txt_qtde.Text = ltv_produtos.SelectedItems[0].SubItems[2].Text;
            txt_valor.Text = ltv_produtos.SelectedItems[0].SubItems[3].Text;
        }
    }
}
