using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaSQL
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Iniciar os parâmetros da aplicação
            ClParametros.Inicializar();

            //Apresenta o formulario menu inicial
            Application.Run(new frmMenu());
        }
    }
}
