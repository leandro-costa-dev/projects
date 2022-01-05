using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaSQL
{
    public static class ClParametros
    {
        //----------------------------------------------------------------------------------------

        public static string versao = "Versão 1.0.0";
        public static string servidor = @"Server = LEANDRO-PC\MSSQLSERVER2019; Database = master; Uid=leandro; Pwd=123456;";
        public static string base_dados = @"Server = LEANDRO-PC\MSSQLSERVER2019; Database = AGENDASQL; Uid=leandro; Pwd=123456;";


        //----------------------------------------------------------------------------------------
        public static void Inicializar()
        {

            //Chama metodo criar base de dados
            CriarBaseDados();

            //Chama metodo criar tabelas
            //CriarTabelas();

        }

        //----------------------------------------------------------------------------------------

        public static void CriarBaseDados()
        {
            SqlConnection conexao = new SqlConnection(servidor);
            conexao.Open();

            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;

                comando.CommandText = "IF  NOT EXISTS (SELECT * FROM sys.databases WHERE name = N'AGENDASQL') " +
                                      "CREATE DATABASE [AGENDASQL]";

                comando.ExecuteNonQuery();

                comando.Dispose();

                conexao.Dispose();
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro na abertura da base de dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //----------------------------------------------------------------------------------------
        public static void CriarTabelas()
        {
            SqlConnection conexao = new SqlConnection(base_dados);
            conexao.Open();

            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;                          

                comando.CommandText = "CREATE TABLE contatos(" +
                                      "id_contato              int not null primary key, " +
                                      "nome                    nvarchar(50), " +
                                      "telefone                nvarchar(20), " +
                                      "dt_atualizacao          datetime)";

                comando.ExecuteNonQuery();

                comando.Dispose();

                conexao.Dispose();
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro na abertura das tabelas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
