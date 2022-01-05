using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frm_inserirEditar : Form
    {
        int indice = 0;
        public frm_inserirEditar()
        {
            InitializeComponent();
            ConstroiLista();
        }

        //-------------------------------------------------------------------------
        private void frm_inserirEditar_Load(object sender, EventArgs e)
        {

        }
        
        //-------------------------------------------------------------------------
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            //Fecha o formulario aberto
            this.Close();
        }

        //-------------------------------------------------------------------------
        private void ConstroiLista()
        {
            //Limpar lista
            lst_contatos.Items.Clear();

            //Adiciona a list box de contatos os contatos do arquivo
            foreach (cl_contato contato in cl_principal.lista_contato)
            {
                lst_contatos.Items.Add(contato.nome + " (" + contato.numero + ")");
            }
            
            //Atualizar contador de numero de registros
            lbl_registro.Text = "Registros: " + lst_contatos.Items.Count;

            btn_editar.Enabled = false;
            btn_apagar.Enabled = false;

        }

        //-------------------------------------------------------------------------
        private void btn_gravar_Click(object sender, EventArgs e)
        {
            if(txt_nome.Text=="" || txt_numero.Text=="")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos para gravar !");
                return;
            }

            //Verifica se existe registro 
            foreach(cl_contato contato in cl_principal.lista_contato)
            {
                if(contato.nome == txt_nome.Text && contato.numero == txt_numero.Text)
                {
                    MessageBox.Show("O registro já existe!");
                    return;
                }
            }

            //Grava o novo registro
            cl_principal.GravarNovoRegistro(txt_nome.Text, txt_numero.Text);

            //Atualizar lista de contatos
            ConstroiLista();

            //Limpar campos para novo registro
            txt_nome.Text = "";
            txt_numero.Text = "";
            txt_nome.Focus();

        }

        //-------------------------------------------------------------------------
        private void lst_contatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selecionar um contato na lista

            //verificar indice -1 
            if (lst_contatos.SelectedIndex == -1) return;

            //seleciona  um indice da lista
            indice = lst_contatos.SelectedIndex;

            btn_editar.Enabled = true;
            btn_apagar.Enabled = true;

        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            //apagar registro selecionado

            //1º eliminar o registro da lista
            cl_principal.lista_contato.RemoveAt(indice);

            //2º atualizar o arquivo
            cl_principal.GravarArquivo();

            //3º reconstruir a lista
            ConstroiLista();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

        }
    }
}
