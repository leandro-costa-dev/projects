using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class frm_Login : Form
    {
        frm_Principal frm_Principal;
        DataTable tabela = new DataTable();
        public frm_Login(frm_Principal f)
        {
            InitializeComponent();
            frm_Principal = f;
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string senha = txt_senha.Text;

            if(string.IsNullOrWhiteSpace(txt_usuario.Text) || 
               string.IsNullOrWhiteSpace(txt_senha.Text))
            {
                MessageBox.Show("Usuário ou senha inválidos!");
                txt_usuario.Focus();
                return;
            }

            string sql = "SELECT * FROM USUARIOS WHERE LOGIN_USUARIO='" + usuario + "' AND SENHA_USUARIO='" + senha + "'";

            tabela = Banco.consultaSQL(sql);

            if(tabela.Rows.Count==1)
            {
                frm_Principal.lbl_acesso.Text = tabela.Rows[0].ItemArray[5].ToString();
                frm_Principal.lbl_usuario.Text = tabela.Rows[0].Field<string>("NOME_USUARIO");

                frm_Principal.pbx_ledlogado.Image = Properties.Resources.led_verde;

                Globais.nivel = Convert.ToInt32(tabela.Rows[0].ItemArray[5]);

                this.Close();
            }else
            {
                MessageBox.Show("Usuário ou senha inválido!");
            }
        }
    }
}
