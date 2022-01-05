
namespace Agenda
{
    partial class frm_menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lbl_versao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "AGENDA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(91, 89);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(249, 72);
            this.btn_inserir.TabIndex = 1;
            this.btn_inserir.Text = "Inserir/Alterar";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(91, 179);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(249, 72);
            this.btn_pesquisar.TabIndex = 2;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(91, 268);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(249, 72);
            this.btn_sair.TabIndex = 3;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lbl_versao
            // 
            this.lbl_versao.Location = new System.Drawing.Point(12, 366);
            this.lbl_versao.Name = "lbl_versao";
            this.lbl_versao.Size = new System.Drawing.Size(406, 23);
            this.lbl_versao.TabIndex = 4;
            this.lbl_versao.Text = "Versão";
            this.lbl_versao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 398);
            this.Controls.Add(this.lbl_versao);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label lbl_versao;
    }
}

