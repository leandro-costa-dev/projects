using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraNova
{
    class Calculos
    {

        public String calcular (String algoritmo)
        {
            String operacao = null;
            String sinais = "+-*/";

            int parcela1 = 0;
            int parcela2 = 0;

            int total = -1;


            for (int c = 0; c < algoritmo.Length; c++)
            {
                for (int s = 0; s < sinais.Length; s++)
                {
                    if (sinais.Substring(s, 1) == algoritmo.Substring(c, 1))
                    {
                        //parcela 1
                        parcela1 = int.Parse(algoritmo.Substring(0, c));
                        //sinal
                        operacao = algoritmo.Substring(c, 1);
                        //parcela 2
                        parcela2 = int.Parse(algoritmo.Substring(c + 1));

                        switch (operacao)
                        {
                            case "+":
                                total = parcela1 + parcela2;
                                break;
                            case "-":
                                total = parcela1 - parcela2;
                                break;
                            case "*":
                                total = parcela1 * parcela2;
                                break;
                            case "/":
                                total = parcela1 / parcela2;
                                break;
                            default:
                                break;
                        }                  
                    }
                }
            }

            return total.ToString();


            //Ciclo para encontrar o sinal e os valores antes e depois

            //----------------------------------------------------
            //int index = 0;

            //foreach (char c in algoritmo)
            //{
            //    foreach (char s in sinais)
            //    {
            //        if (c == s)
            //        {
            //            //Define os 3 elementos da operação

            //            //parcela 1
            //            parcela1 = int.Parse(algoritmo.Substring(0, index));
            //            //sinal
            //            tipo_operacao = c.ToString();
            //            //parcela 2
            //            parcela2 = int.Parse(algoritmo.Substring(index + 1));

            //        }
            //    }

            //    index++;
            //}
            //-------------------------------------------------------

        }
    }
}
