using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Agenda
{
    public static class cl_principal
    {
        public static String versao = "V. 1.0.0";

        //Lista de contatos
        public static List<cl_contato> lista_contato;

        //-------------------------------------------------------------------------
        public static void CriarListaContatos()
        {
            String diretorio_arquivo = @"D:\Projetos\Agenda";
            String nome_arquivo = diretorio_arquivo + @"\Contatos.txt";

            //Cria a lista vazia
            lista_contato = new List<cl_contato>();

            if (File.Exists(nome_arquivo))
            {
                StreamReader arquivo = new StreamReader(nome_arquivo, Encoding.Default);
                                
                //Carregar os contatos do arquivo
                while(!arquivo.EndOfStream)
                {
                    //Carrega nome
                    String nome = arquivo.ReadLine();
                    //Carrega numero
                    String numero = arquivo.ReadLine();

                    //Adicionar a lista de contatos o novo contato
                    cl_contato novo_contato = new cl_contato();

                    novo_contato.nome = nome;
                    novo_contato.numero = numero;

                    lista_contato.Add(novo_contato);
                }

                arquivo.Dispose();
            }
        }
        
        //-------------------------------------------------------------------------
        public static void GravarNovoRegistro(String _nome, String _numero)
        {

            //grava novo registro ma lista
            lista_contato.Add(new cl_contato() { nome = _nome, numero = _numero });

            //atualiza informações no arquivo
            GravarArquivo();
        }

        //-------------------------------------------------------------------------
        public static void GravarArquivo()
        {
            String diretorio_arquivo = @"D:\Projetos\Agenda";
            String nome_arquivo = diretorio_arquivo + @"\Contatos.txt";

            StreamWriter arquivo = new StreamWriter(nome_arquivo, false, Encoding.Default);
            foreach(cl_contato contato in lista_contato)
            {
                arquivo.WriteLine(contato.nome);
                arquivo.WriteLine(contato.numero);
            }

            arquivo.Dispose();
        }

    }
}
