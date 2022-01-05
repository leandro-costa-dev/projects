using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CursoBruno
{
    public partial class frm_tabControl : Form
    {
        public frm_tabControl()
        {
            InitializeComponent();
        }

        private void frm_tabControl_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(txt_ficha.Text);



        }
    }
}
