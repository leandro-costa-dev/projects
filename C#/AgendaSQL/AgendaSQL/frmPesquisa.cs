using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaSQL
{
    public partial class frmPesquisa : Form
    {
        public frmPesquisa()
        {
            InitializeComponent();
        }

        //------------------------------------------------------------------
        public string texto_pesquisa { get; set; }
        public bool cancelado { get; set; }

        //------------------------------------------------------------------

        private void frmPesquisa_Load(object sender, EventArgs e)
        {


        }

        //------------------------------------------------------------------
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelado = true;
            this.Close();

        }

        //------------------------------------------------------------------
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Executa a pesquisa, se existir texto informado
            if (String.IsNullOrWhiteSpace(txtPesquisa.Text))
            {
                cancelado = true;
                MessageBox.Show("Informe um texto para pesquisar.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                texto_pesquisa = txtPesquisa.Text;
            }           
            
            this.Close();
        }
    }
}
