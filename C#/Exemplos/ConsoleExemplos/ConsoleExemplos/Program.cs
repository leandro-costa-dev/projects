using System;
using System.Collections.Generic;

namespace ConsoleExemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = 0;

            try
            {
                area = Calculos.AreaQuadrado(10, 20);
                Console.WriteLine("O valor da area é {0}", area);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO: {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("Fim do programa!");
            }

            //-----------------------------------------------

            Colecoes c = new Colecoes();

            c.teste();

        }
    }

    class Calculos
    {
        public static double AreaQuadrado(double bas, double alt)
        {
            if (bas == 0 || alt == 0)
            {
                throw new Exception("Base ou altura não pode ser zero!");
            }

            return bas * alt;
        }
    }

    class Colecoes
    {
        List<string> lista = new List<string>();

        public void teste ()
        {
            lista.Add("Carro1");
            lista.Add("Carro2");
            lista.Add("Carro3");
            lista.Add("Carro4");
            lista.Add("Carro5");
            lista.Add("Carro6");
            lista.Add("Carro7");

            foreach (string l in lista)
            {
                Console.WriteLine("{0}", l);
            }
        }        
      
    }
    
}