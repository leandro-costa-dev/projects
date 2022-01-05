using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Exibe mensagem com ícone, titulo e botões e testa o resultado
            if(MessageBox.Show("Deseja sair da aplicação", "Sair", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog caixa = new OpenFileDialog();

            caixa.Title = "Abrir arquivo";
            caixa.Filter = "Imagens JPEG (*.jpg)|*.jpg" + "|" + "Imagens BMP (*.bmp)|*.bmp";

            //Testa se foi selecionado o botão cancelar
            if (caixa.ShowDialog() == DialogResult.Cancel) return;

            //Carregar imagem selecionada na PctureBox
            pictureBox1.BackgroundImage = Image.FromFile(caixa.FileName);
            
            //Descarrega da memoria a caixa
            caixa.Dispose();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog caixa = new SaveFileDialog();

            //Salvar arquivo 

            caixa.Title = "Salvar arquivo";
            caixa.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            caixa.Filter = "Arquivo TXT (*.txt)|*.txt";

            if (caixa.ShowDialog() == DialogResult.Cancel) return;

            //Gravar arquivo
            string arquivo = caixa.FileName;

            StreamWriter file = new StreamWriter(arquivo, false, Encoding.Default);

            file.WriteLine("Teste");
            file.Dispose();           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Abrir e selcionar uma pasta

            FolderBrowserDialog caixa = new FolderBrowserDialog();

            caixa.SelectedPath = @"C:\";

            if (caixa.ShowDialog() == DialogResult.Cancel) return;

            MessageBox.Show("A pasta selecionada foi " + caixa.SelectedPath);
                     
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Abrir caixa para selecionar cor

            ColorDialog caixa = new ColorDialog();

            caixa.Color = pictureBox1.BackColor;

            if (caixa.ShowDialog() == DialogResult.Cancel) return;

            pictureBox1.BackColor = caixa.Color;

        }
    }
}
