using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaSQL
{
    public partial class frmAdicionarEditar : Form
    {
        int id_contato = 0;
        bool editar;

        //-----------------------------------------------------------
        public frmAdicionarEditar(int id_contato = -1)
        {
            InitializeComponent();
            this.id_contato = id_contato;

            //definir se vai adicionar ou editar um regitro
            editar = id_contato == -1 ? false : true;

        }

        //-----------------------------------------------------------
        private void frmAdicionarEditar_Load(object sender, EventArgs e)
        {
            //Apresenta os dados do contato, se necessario
            if (editar)
                ApresentarContato();
        }

        //-----------------------------------------------------------
        private void ApresentarContato()
        {
            //Apresentar dados do contato que será editado
            SqlConnection conexao = new SqlConnection(ClParametros.base_dados);
            conexao.Open();

            DataTable dados = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM contatos WHERE id_contato = "+ id_contato, conexao);
            adaptador.Fill(dados);

            conexao.Dispose();

            //Carregar dados nas caixas de texto
            txtNome.Text = dados.Rows[0]["nome"].ToString();
            txtTelefone.Text = dados.Rows[0]["telefone"].ToString();

        }

        //-----------------------------------------------------------
        private void btnGravar_Click(object sender, EventArgs e)
        {
            //Gravar novo registro ou editar registro existente

            SqlConnection conexao = new SqlConnection(ClParametros.base_dados);
            conexao.Open();                  

            //Verifica se as caixas de texto estão preenchidas
            #region VERIFICACOES

            if(String.IsNullOrWhiteSpace(txtNome.Text) || String.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }          

            #endregion


            //-----------------------------------------------------------
            #region NOVO CONTATO
            if (!editar)
            {
                //Buscar o ID do contato disponível

                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT MAX(id_contato) AS maxid FROM contatos", conexao);
                DataTable dados = new DataTable();
                adaptador.Fill(dados);

                //Verificar se o valor é nulo
                if (DBNull.Value.Equals(dados.Rows[0][0]))
                    id_contato = 0;
                else
                    id_contato = Convert.ToInt32(dados.Rows[0][0]) + 1;

                //Gravar novo contato na base de dados
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;

                //Parametros
                comando.Parameters.AddWithValue("@id_contato", id_contato);
                comando.Parameters.AddWithValue("@nome", txtNome.Text);
                comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                comando.Parameters.AddWithValue("@dt_atualizacao", DateTime.Now);

                //verifica se existe contato com mesmo nome e telefone
                adaptador = new SqlDataAdapter();
                dados = new DataTable();

                comando.CommandText = "SELECT * FROM contatos WHERE nome = @nome AND telefone = @telefone";
                adaptador.SelectCommand = comando;
                adaptador.Fill(dados);

                if(dados.Rows.Count!=0)
                {
                    if (MessageBox.Show("Já existe um registro com mesmo nome e telefone." + Environment.NewLine + 
                        "Deseja continuar?", "Atenção", 
                        MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question) == DialogResult.No)
                        return;
                }

                //Texto da Query
                comando.CommandText = "INSERT INTO contatos VALUES(" +
                    "@id_contato, @nome, @telefone, @dt_atualizacao)";

                comando.ExecuteNonQuery();
                comando.Dispose();
                conexao.Dispose();

                MessageBox.Show("Contato adicionado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Limpar campos 
                txtNome.Text = "";
                txtTelefone.Text = "";

                txtNome.Focus();

            }

            #endregion

            //-----------------------------------------------------------

            #region EDITAR CONTATO
            else
            {
                //Editar contato na base de dados
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;

                //Parametros
                comando.Parameters.AddWithValue("@id_contato", id_contato);
                comando.Parameters.AddWithValue("@nome", txtNome.Text);
                comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                comando.Parameters.AddWithValue("@dt_atualizacao", DateTime.Now);

                //Verificar se ja existe outro registro com mesmo nome e telefone diferente do editado
                DataTable dados = new DataTable();

                comando.CommandText = "SELECT * FROM contatos WHERE nome = @nome AND telefone = @telefone AND id_contato <> @id_contato";
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(dados);

                if(dados.Rows.Count != 0)
                {
                    //Foi encontrado registro com mesmo nome
                    if (MessageBox.Show("Já existe um registro com mesmo nome e telefone." + Environment.NewLine +
                                        "Deseja continuar a alteração?", "Atenção",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) == DialogResult.No)
                        return;
                }

                //Editar o registro selecionado
                comando.CommandText = "UPDATE contatos SET " +
                                      "nome = @nome, " +
                                      "telefone = @telefone, " +
                                      "dt_atualizacao = @dt_atualizacao " +
                                      "WHERE id_contato = @id_contato";
                comando.ExecuteNonQuery();

                //Fecha tela aberta
                this.Close();
  
            }
            #endregion
        }

        //-----------------------------------------------------------
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
