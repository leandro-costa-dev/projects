using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CursoBruno
{
    public partial class frm_linkLabel : Form
    {
        public frm_linkLabel()
        {
            InitializeComponent();
            llb_multiplos.Links.Add(0, 6, "www.google.com.br");
            llb_multiplos.Links.Add(9, 7, "www.youtube.com.br");
            llb_multiplos.Links.Add(19, 5, "www.gmail.com");

        }

        private void frm_linkLabel_Load(object sender, EventArgs e)
        {

        }

        private void llb_site_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com.br");
        }

        private void llb_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void llb_multiplos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString()); 
        }
    }
}
