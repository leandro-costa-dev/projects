using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Academia
{
    class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection(@"Data Source= C:\Projetos\C#\Academia\Academia\data\bd_academia.db");
            conexao.Open();
            return conexao;
        }

        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter adaptador = null;
            DataTable tabela = new DataTable();
            

            try
            {
                using(var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tb_usuarios";
                    adaptador = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    adaptador.Fill(tabela);
                    ConexaoBanco().Close();
                    return tabela;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Consulta SQL geral
        public static DataTable consultaSQL(string sql)
        {
            SQLiteDataAdapter adaptador = null;
            DataTable tabela = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    adaptador = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    adaptador.Fill(tabela);
                    ConexaoBanco().Close();
                    return tabela;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Início das funções formulário usuário

        public static void NovoUsuario(Usuario u)
        {
            if(existeUsername(u))
            {
                MessageBox.Show("Username já existe");
                return;
            }


        }


        //Fim das funções formulário usuário

        //Funções Gerais

        public static bool existeUsername(Usuario u)
        {
            bool res;

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT LOGIN_USUARIO FROM USUARIOS WHERE LOGIN_USUARIO='"+u.LOGIN_USUARIO+"'";

            da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
            da.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }


    }
}
