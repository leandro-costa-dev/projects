using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CursoBruno
{
    public partial class frm_treeView : Form
    {
        public frm_treeView()
        {
            InitializeComponent();
        }

        private void frm_treeView_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            label1.Text = treeView1.SelectedNode.Text;
        }

        private void btn_adicionarRaiz_Click(object sender, EventArgs e)
        {
            TreeNode raiz = treeView1.Nodes.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void btn_adicionarFilho_Click(object sender, EventArgs e)
        {
            TreeNode filho = treeView1.SelectedNode.Nodes.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }
    }
}
