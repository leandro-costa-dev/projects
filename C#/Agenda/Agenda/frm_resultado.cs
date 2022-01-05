using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frm_resultado : Form
    {
        String texto_pesquisa;
        public frm_resultado(String texto)
        {
            InitializeComponent();

            //Define o texto da pesquisa
            texto_pesquisa = texto.ToUpper();
        }

        private void frm_resultado_Load(object sender, EventArgs e)
        {
            //Executar pesquisa
            ExecutarPesquisa();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExecutarPesquisa()
        {
            //Faz pesquisa e apresenta dados
            List<cl_contato> lista_resultados = new List<cl_contato>();

            foreach(cl_contato contato in cl_principal.lista_contato)
            {
                if(contato.nome.ToUpper().Contains(texto_pesquisa) ||
                    contato.numero.ToUpper().Contains(texto_pesquisa))
                {
                    lista_resultados.Add(contato);
                }
            }

            //Apresentar os resultados na lista
            lst_resultados.Items.Clear();

            foreach(cl_contato contato in lista_resultados)
            {
                lst_resultados.Items.Add(contato.nome + " (" + contato.numero + ")" );
            }

            lbl_registro.Text = "Resgistros: " + lst_resultados.Items.Count;
        }

        private void btn_nova_Click(object sender, EventArgs e)
        {
            frm_pesquisa pesquisa = new frm_pesquisa();
            pesquisa.ShowDialog();

            if (pesquisa.cancelado) return;

            texto_pesquisa = pesquisa.texto.ToUpper();

            ExecutarPesquisa();

        }
    }
}
