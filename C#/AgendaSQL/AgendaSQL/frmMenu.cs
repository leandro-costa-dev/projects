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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            
            //Versão do sistema
            lblVersao.Text = ClParametros.versao;

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da Aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            Application.Exit();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAdicionarEditar f = new frmAdicionarEditar();
            f.ShowDialog();            
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            frmResultado f = new frmResultado();
            f.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Abrir tela de pesquisa do contato
            frmPesquisa f = new frmPesquisa();
            f.ShowDialog();

            //Executa a pesquisa se não foi cancelado
            if (f.cancelado)
            {
                f.Dispose();
                return;
            }

            //Executar a pesquisa
            frmResultado r = new frmResultado(f.texto_pesquisa);
            r.ShowDialog();

        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {

        }

    }
}
