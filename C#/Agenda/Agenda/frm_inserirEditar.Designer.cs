
namespace Agenda
{
    partial class frm_inserirEditar
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
            this.btn_fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.lst_contatos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_registro = new System.Windows.Forms.Label();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(358, 448);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(95, 32);
            this.btn_fechar.TabIndex = 0;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(79, 24);
            this.txt_nome.MaxLength = 50;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(374, 23);
            this.txt_nome.TabIndex = 2;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(79, 53);
            this.txt_numero.MaxLength = 20;
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(177, 23);
            this.txt_numero.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(358, 86);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(95, 33);
            this.btn_gravar.TabIndex = 5;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // lst_contatos
            // 
            this.lst_contatos.FormattingEnabled = true;
            this.lst_contatos.ItemHeight = 15;
            this.lst_contatos.Location = new System.Drawing.Point(12, 143);
            this.lst_contatos.Name = "lst_contatos";
            this.lst_contatos.Size = new System.Drawing.Size(441, 289);
            this.lst_contatos.TabIndex = 6;
            this.lst_contatos.SelectedIndexChanged += new System.EventHandler(this.lst_contatos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lista de Contatos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_registro
            // 
            this.lbl_registro.Location = new System.Drawing.Point(12, 435);
            this.lbl_registro.Name = "lbl_registro";
            this.lbl_registro.Size = new System.Drawing.Size(122, 23);
            this.lbl_registro.TabIndex = 8;
            this.lbl_registro.Text = "Registros: 0";
            this.lbl_registro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_apagar
            // 
            this.btn_apagar.Location = new System.Drawing.Point(257, 448);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(95, 32);
            this.btn_apagar.TabIndex = 9;
            this.btn_apagar.Text = "Excluir";
            this.btn_apagar.UseVisualStyleBackColor = true;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(156, 448);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(95, 32);
            this.btn_editar.TabIndex = 10;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // frm_inserirEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 490);
            this.ControlBox = false;
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.lbl_registro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lst_contatos);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_inserirEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda - Inserir/Editar";
            this.Load += new System.EventHandler(this.frm_inserirEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.ListBox lst_contatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_registro;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Button btn_editar;
    }
}