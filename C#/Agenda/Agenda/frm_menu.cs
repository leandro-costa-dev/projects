using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();

            //Carrega contatos
            cl_principal.CriarListaContatos();

            //Apresenta versão do programa
            lbl_versao.Text = cl_principal.versao;
                        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            //Pergunta se deseja sair da aplicação
            if (MessageBox.Show("Deseja sair da Aplicação?", "Sair", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            //Encerra a aplicação
            Application.Exit();
            
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            //Apresentar o formulário para Inserir ou Editar contatos
            frm_inserirEditar formulario = new frm_inserirEditar();
            formulario.ShowDialog();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            //Abrir tela de pesquisa
            frm_pesquisa pesquisa = new frm_pesquisa();
            pesquisa.ShowDialog();

            //quando fecha o quadro verifica se foi cancelado
            if (pesquisa.cancelado) return;

            //abrir tela com resultados da pesquisa
            frm_resultado resultado = new frm_resultado(pesquisa.texto);
            resultado.ShowDialog();

            
        }
    }
}
