
namespace BaseDados
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_CriarTabela = new System.Windows.Forms.Button();
            this.btn_InserirDados = new System.Windows.Forms.Button();
            this.btn_LerDados = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_CriarTabela
            // 
            this.btn_CriarTabela.Location = new System.Drawing.Point(12, 12);
            this.btn_CriarTabela.Name = "btn_CriarTabela";
            this.btn_CriarTabela.Size = new System.Drawing.Size(186, 62);
            this.btn_CriarTabela.TabIndex = 2;
            this.btn_CriarTabela.Text = "Criar Tabela";
            this.btn_CriarTabela.UseVisualStyleBackColor = true;
            this.btn_CriarTabela.Click += new System.EventHandler(this.btn_CriarTabela_Click);
            // 
            // btn_InserirDados
            // 
            this.btn_InserirDados.Location = new System.Drawing.Point(12, 80);
            this.btn_InserirDados.Name = "btn_InserirDados";
            this.btn_InserirDados.Size = new System.Drawing.Size(186, 62);
            this.btn_InserirDados.TabIndex = 3;
            this.btn_InserirDados.Text = "Iserir Dados";
            this.btn_InserirDados.UseVisualStyleBackColor = true;
            this.btn_InserirDados.Click += new System.EventHandler(this.btn_InserirDados_Click);
            // 
            // btn_LerDados
            // 
            this.btn_LerDados.Location = new System.Drawing.Point(12, 148);
            this.btn_LerDados.Name = "btn_LerDados";
            this.btn_LerDados.Size = new System.Drawing.Size(186, 62);
            this.btn_LerDados.TabIndex = 4;
            this.btn_LerDados.Text = "Ler Dados";
            this.btn_LerDados.UseVisualStyleBackColor = true;
            this.btn_LerDados.Click += new System.EventHandler(this.btn_LerDados_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(232, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(217, 199);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 249);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_LerDados);
            this.Controls.Add(this.btn_InserirDados);
            this.Controls.Add(this.btn_CriarTabela);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_CriarTabela;
        private System.Windows.Forms.Button btn_InserirDados;
        private System.Windows.Forms.Button btn_LerDados;
        private System.Windows.Forms.ListBox listBox1;
    }
}

