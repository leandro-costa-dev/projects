using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaseDados
{
    class ConexaoBD
    {
        //Criar conexão com base de dados
        SqlConnection conexao = new SqlConnection();

        public ConexaoBD()
        {
            //Conecta ao banco de dados ao chamar a classe
            conexao.ConnectionString = @"Server = LEANDRO-PC\MSSQLSERVER2019; Database = AGENDA; Uid=leandro; Pwd=123456;";
            
        }

        public void CriarTabela()
        {
            //Conectar com banco de dados
            conexao.Open();

            //Testa se a conexão foi aberta
            if (conexao.State == 0) return;

            //Novo comando SQL para criação da base de dados
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "CREATE TABLE contatos(" +
                                "id_contato              int not null primary key, " +
                                "nome                    nvarchar(50), " +
                                "telefone                nvarchar(20), " +
                                "dt_atualizacao          datetime)";

            comando.ExecuteNonQuery();
            
            //Encerrar comando
            comando.Dispose();

            //Desconectar do banco de dados
            conexao.Dispose();

            MessageBox.Show("Tabela contatos criada com sucesso!");

        }

        public void InserirDados ()
        {
            //Conectar com banco de dados
            conexao.Open();

            //Testa se a conexão foi aberta
            if (conexao.State == 0) return;

            //Estrutura para controle de erros
            try
            {
                //Novo comando SQL
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;

                //Parametros
                comando.Parameters.AddWithValue("@id_contato", 2);
                comando.Parameters.AddWithValue("@nome", "Roberto Carlos");
                comando.Parameters.AddWithValue("@telefone", "878755878");
                comando.Parameters.AddWithValue("@dt_atualizacao", DateTime.Now);

                //comando.CommandText = "UPDATE contatos SET (" + "@id_contato, @nome, @telefone, @dt_atualizacao WHERE @id_contato=1)";
                
                comando.CommandText = "INSERT INTO contatos VALUES (" + "@id_contato, @nome, @telefone, @dt_atualizacao)";

                //Executa query sem retornar valor
                comando.ExecuteNonQuery();

                //Encerrar comando
                comando.Dispose();

                //Desconectar do banco de dados
                conexao.Dispose();

                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void LerDados()
        {
            //Conectar com banco de dados
            conexao.Open();

            //Testa se a conexão foi aberta
            if (conexao.State == 0) return;

            //Estrutura para controle de erros
            try
            {
                //Cria comando para buscar dados do banco
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM contatos", conexao);

                DataTable dados = new DataTable();

                //Preencher a tabela temporária na DataTable
                adaptador.Fill(dados);

                foreach (DataRow registro in dados.Rows)
                {
                    MessageBox.Show(registro["nome"].ToString() + " " +
                                    registro["telefone"].ToString());

                }

            }
            catch
            {
                MessageBox.Show("Ocorreu um erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
