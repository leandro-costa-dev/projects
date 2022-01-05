
namespace CursoBruno
{
    partial class frm_listBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbx_carros = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_texto = new System.Windows.Forms.TextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_carregar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbx_carros
            // 
            this.lbx_carros.FormattingEnabled = true;
            this.lbx_carros.ItemHeight = 15;
            this.lbx_carros.Location = new System.Drawing.Point(12, 73);
            this.lbx_carros.Name = "lbx_carros";
            this.lbx_carros.Size = new System.Drawing.Size(242, 274);
            this.lbx_carros.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o Texto";
            // 
            // txt_texto
            // 
            this.txt_texto.Location = new System.Drawing.Point(12, 30);
            this.txt_texto.Name = "txt_texto";
            this.txt_texto.Size = new System.Drawing.Size(371, 23);
            this.txt_texto.TabIndex = 2;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(260, 73);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(123, 23);
            this.btn_adicionar.TabIndex = 3;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(260, 102);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(123, 23);
            this.btn_remover.TabIndex = 4;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_carregar
            // 
            this.btn_carregar.Location = new System.Drawing.Point(260, 131);
            this.btn_carregar.Name = "btn_carregar";
            this.btn_carregar.Size = new System.Drawing.Size(123, 23);
            this.btn_carregar.TabIndex = 5;
            this.btn_carregar.Text = "Carregar";
            this.btn_carregar.UseVisualStyleBackColor = true;
            this.btn_carregar.Click += new System.EventHandler(this.btn_carregar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(260, 160);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(123, 23);
            this.btn_limpar.TabIndex = 6;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // frm_listBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 366);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_carregar);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.txt_texto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbx_carros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_listBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBox";
            this.Load += new System.EventHandler(this.frm_listBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_carros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_texto;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_carregar;
        private System.Windows.Forms.Button btn_limpar;
    }
}