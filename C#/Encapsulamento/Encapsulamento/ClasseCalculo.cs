using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    class ClasseCalculo
    {
        private int aliquota1 = 5;
        private int aliquota2 = 10;
        private int aliquota3 = 15;

        public Double calculoPrecoFinal (Double preco_inicial, int tipo)
        {
            Double preco_final = 0;
            //Calculo preço final
            switch(tipo)
            {
                //Alimento
                case 1:
                    preco_final = preco_inicial + (preco_inicial * aliquota1 / 100);
                    break;
                    //Ferramenta
                case 2:
                    preco_final = preco_inicial + (preco_inicial * aliquota2 / 100);
                    break;
                    //Higiente
                case 3:
                    preco_final = preco_inicial + (preco_inicial * aliquota3 / 100);
                    break;
            }

            return preco_final;


        }
    }
}
