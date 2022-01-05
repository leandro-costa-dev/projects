using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ConstrutoresOverload
{
    class teste
    {
        String _nome;
        int _idade;

        //Construtor da classe
        public teste (String nome, int idade)
        {
            _nome = nome;
            _idade = idade;
        }

        //Overload (vários métodos com mesmo nome e parâmetros distintos
        public void Apresentar()
        {
            MessageBox.Show(_nome + " -> " + _idade);
        }

        public void Apresentar(String separador)
        {
            MessageBox.Show(_nome + separador + _idade);
        }

        public String Apresentar (String texto, int numero)
        {
            return texto;
        }
    }

}
