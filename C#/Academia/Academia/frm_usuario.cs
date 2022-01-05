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
    public partial class frm_usuario : Form
    {
        public frm_usuario()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            
            usuario.NOME_USUARIO = txt_nome.Text;
            usuario.LOGIN_USUARIO = txt_username.Text;
            usuario.SENHA_USUARIO = txt_senha.Text;
            usuario.PRIVILEGIO_USUARIO = Convert.ToInt32(num_nivel);
            
            if(cbx_ativo.Checked)
            {
                usuario.SITUACAO_USUARIO = "A";
            }



        }
    }
}
