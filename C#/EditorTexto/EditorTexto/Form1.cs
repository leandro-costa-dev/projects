using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorTexto
{
    public partial class Form1 : Form
    {
        StringReader leitura = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void novo()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            novo();
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            novo();
        }

        private void salvar()
        {
            try
            {
                if(this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter gravador = new StreamWriter(arquivo);

                    gravador.Flush();
                    gravador.BaseStream.Seek(0, SeekOrigin.Begin);
                    gravador.Write(this.richTextBox1.Text);
                    gravador.Flush();
                    gravador.Close();

                }
            }
            catch (Exception ex)    
            {
                MessageBox.Show("Erro ao gravar o arquivo!" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void tsbSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void abrir()
        {
            this.openFileDialog1.Title = ("Abrir Arquivo");
            openFileDialog1.InitialDirectory=(@"C:\");
            openFileDialog1.Filter = "Arquivo de texto (*.txt)|*.txt";

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream arquivo = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader leitor = new StreamReader(arquivo);

                    leitor.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.richTextBox1.Clear();

                    string linha = leitor.ReadLine();

                    while(linha != null)
                    {
                        this.richTextBox1.Text += linha + "\n";
                        linha = leitor.ReadLine();
                    }

                    leitor.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de leitura" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsbAbrir_Click(object sender, EventArgs e)
        {
            abrir();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir(); 
        }

        private void copiar()
        {
            if(richTextBox1.SelectionLength > 0 )
            {
                richTextBox1.Copy();
            }
        }

        private void recortar()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Cut();
            }
        }
        private void colar()
        {
            richTextBox1.Paste();
        }

        private void tsbCopiar_Click(object sender, EventArgs e)
        {
            copiar();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copiar();
        }

        private void tsbRecortar_Click(object sender, EventArgs e)
        {
            recortar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recortar();
        }

        private void tsbColar_Click(object sender, EventArgs e)
        {
            colar();
        }

        private void colarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colar();
        }

        private void negrito()
        {
            string nome_fonte = richTextBox1.Font.Name;
            float tamanho_fonte = richTextBox1.Font.Size;
            bool n = richTextBox1.SelectionFont.Bold;
            bool i = richTextBox1.SelectionFont.Italic;
            bool s = richTextBox1.SelectionFont.Underline;

            richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Regular);

            if (n == false)
            {
                if (i == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (i == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (i == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold);
                }
            }else
            {
                if (i == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Underline);
                }
                else if (i == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic);
                }
            }
        }

        private void italico()
        {
            string nome_fonte = richTextBox1.Font.Name;
            float tamanho_fonte = richTextBox1.Font.Size;
            bool n = richTextBox1.SelectionFont.Bold;
            bool i = richTextBox1.SelectionFont.Italic;
            bool s = richTextBox1.SelectionFont.Underline;

            richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Regular);

            if (i == false)
            {
                if (n == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic | FontStyle.Bold | FontStyle.Underline);
                }
                else if (n == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic | FontStyle.Bold);
                }
                else if (n == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic);
                }
            }
            else
            {
                if (n == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (n == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Underline);
                }
                else if (n == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold);
                }
            }
        }

        private void sublinhado()
        {
            string nome_fonte = richTextBox1.Font.Name;
            float tamanho_fonte = richTextBox1.Font.Size;
            bool n = richTextBox1.SelectionFont.Bold;
            bool i = richTextBox1.SelectionFont.Italic;
            bool s = richTextBox1.SelectionFont.Underline;

            richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Regular);

            if (s == false)
            {
                if (n == true & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Underline | FontStyle.Bold | FontStyle.Italic);
                }
                else if (n == false & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Underline | FontStyle.Italic);
                }
                else if (n == true & i == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Underline | FontStyle.Bold);
                }
                else if (n == false & i == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Underline);
                }
            }
            else
            {
                if (n == true & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (n == false & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic);
                }
                else if (n == true & i == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold);
                }
            }
        }

        private void tsbNegrito_Click(object sender, EventArgs e)
        {
            negrito();
        }

        private void tsbItalico_Click(object sender, EventArgs e)
        {
            italico();
        }

        private void tsbSublinhado_Click(object sender, EventArgs e)
        {
            sublinhado();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            negrito();
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            italico();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sublinhado();
        }

        private void alinharEsquerda()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void alinharDireita()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void alinharCentro()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alinharEsquerda();
        }

        private void centralizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alinharCentro();
        }

        private void diretaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alinharDireita();
        }

        private void imprimir()
        {
            printDialog1.Document = printDocument1;

            string texto = this.richTextBox1.Text;
            leitura = new StringReader(texto);

            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
