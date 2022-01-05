
namespace AgendaSQL
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(138, 230);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(153, 60);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(138, 296);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(153, 60);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(138, 164);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(153, 60);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(138, 98);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(153, 60);
            this.btnVisualizar.TabIndex = 0;
            this.btnVisualizar.Text = "Agenda";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Agenda SQL";
            // 
            // lblVersao
            // 
            this.lblVersao.Location = new System.Drawing.Point(138, 377);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(153, 23);
            this.lblVersao.TabIndex = 5;
            this.lblVersao.Text = "Versão 1.0";
            this.lblVersao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.Image = ((System.Drawing.Image)(resources.GetObject("btnConfiguracoes.Image")));
            this.btnConfiguracoes.Location = new System.Drawing.Point(12, 395);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(53, 45);
            this.btnConfiguracoes.TabIndex = 6;
            this.btnConfiguracoes.UseVisualStyleBackColor = true;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 452);
            this.ControlBox = false;
            this.Controls.Add(this.btnConfiguracoes);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgendaSQL";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Button btnConfiguracoes;
    }
}

