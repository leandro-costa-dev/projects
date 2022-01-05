using System;
using System.Collections.Generic;
using System.Text;

namespace Enumeracoes
{
    class ClasseTeste
    {
        public enum DiasDaSemana
        {
            segunda, terca, quarta, quinta, sexta, sabado, domingo
        }

        public void Apresentar (DiasDaSemana dia)
        {
            Console.WriteLine("O dia selecionado foi " + dia);
        }
    }
}
