using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaSQL
{
    public partial class frmResultado : Form
    {
        int id_contato;
        string item_pesquisa;
        public frmResultado(string itemPesquisa = "")
        {
            InitializeComponent();
            this.item_pesquisa = itemPesquisa;
        }

        private void frmResultado_Load(object sender, EventArgs e)
        {
            ConstruiGrid();
        }

        private void ConstruiGrid()
        {
            SqlConnection conexao = new SqlConnection(ClParametros.base_dados);
            conexao.Open();

            string query = "SELECT * FROM contatos";

            if (item_pesquisa != "")
                query = "SELECT * FROM contatos " +
                        "WHERE nome LIKE @item OR telefone LIKE @item";

            SqlCommand comando = new SqlCommand();
            comando.Parameters.AddWithValue("@item", "%" + item_pesquisa + "%");
            comando.CommandText = query;
            comando.Connection = conexao;

            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable dados = new DataTable();
            adaptador.Fill(dados);

            grdResultado.DataSource = dados;

            lblRegistros.Text = "Total de Registros: " + grdResultado.Rows.Count;

            //Esconder colunas idesejadas (id_contato e dt_atualizacao)
            grdResultado.Columns["id_contato"].Visible = false;
            grdResultado.Columns["dt_atualizacao"].Visible = false;

            //Redimensionar colunas
            grdResultado.Columns["nome"].Width = CalcularLargura(80);
            grdResultado.Columns["telefone"].Width = CalcularLargura(20);

            //Controle de disponibilidade de botoes
            btnApagar.Enabled = false;
            btnEditar.Enabled = false;

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja eliminar o item selecionado?", "Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Eliminar a linha selecionada do banco de dados por meio do ID contato
                SqlConnection conexao = new SqlConnection(ClParametros.base_dados);
                conexao.Open();

                SqlCommand comando = new SqlCommand("DELETE FROM contatos WHERE id_contato = " + id_contato, conexao);
                comando.ExecuteNonQuery();

                comando.Dispose();
                conexao.Dispose();

                //Atualizar a lista de contatos após exclusão
                ConstruiGrid();
            }

        }

        private void grdResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_contato = Convert.ToInt32(grdResultado.Rows[e.RowIndex].Cells["id_contato"].Value);
            btnApagar.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Editar o registro selecionado
            frmAdicionarEditar f = new frmAdicionarEditar(id_contato);
            f.ShowDialog();


            //Atualizar a lista de contatos
            ConstruiGrid();

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            //Visualizar todos os registros
            item_pesquisa = "";
            ConstruiGrid();
        }

        private int CalcularLargura(int porcentagem)
        {
            int largura_grid = grdResultado.Width - 2;
            int resultado = (largura_grid * porcentagem) / 100;
            return resultado;
        }

        private void grdResultado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar_Click(sender, e);
        }
    }
}
