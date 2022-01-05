
namespace Academia
{
    partial class frm_usuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.num_nivel = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_ativo = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_nivel)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(15, 35);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(425, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(15, 77);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(182, 20);
            this.txt_username.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(203, 77);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(128, 20);
            this.txt_senha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha";
            // 
            // num_nivel
            // 
            this.num_nivel.Location = new System.Drawing.Point(337, 77);
            this.num_nivel.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.num_nivel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_nivel.Name = "num_nivel";
            this.num_nivel.Size = new System.Drawing.Size(103, 20);
            this.num_nivel.TabIndex = 6;
            this.num_nivel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nível Privilégio";
            // 
            // cbx_ativo
            // 
            this.cbx_ativo.AutoSize = true;
            this.cbx_ativo.Location = new System.Drawing.Point(15, 112);
            this.cbx_ativo.Name = "cbx_ativo";
            this.cbx_ativo.Size = new System.Drawing.Size(50, 17);
            this.cbx_ativo.TabIndex = 9;
            this.cbx_ativo.Text = "Ativo";
            this.cbx_ativo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 31);
            this.panel1.TabIndex = 10;
            // 
            // btn_novo
            // 
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.Location = new System.Drawing.Point(3, 5);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(75, 23);
            this.btn_novo.TabIndex = 11;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.Location = new System.Drawing.Point(84, 5);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 12;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.Location = new System.Drawing.Point(165, 5);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // frm_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 173);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbx_ativo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.num_nivel);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.num_nivel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_nivel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbx_ativo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
    }
}