using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CamposPropriedades
{
    class ClasseTeste
    {
        //Definição de um campo privado
        String _nome;
        int _idade;

        //Definição de uma propriedade
        public String Nome
        {
            set
            {
                _nome = value;
            }
            get
            {
                return _nome;
            }
        }

        public String Apresentar (String texto)
        {
            MessageBox.Show("Meu nome é " + texto);
            return texto;
        }
    }
}
