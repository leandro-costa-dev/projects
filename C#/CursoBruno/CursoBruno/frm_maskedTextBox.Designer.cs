
namespace CursoBruno
{
    partial class frm_maskedTextBox
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
            this.mtb_senha = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtb_cep = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.lbl_visualizar = new System.Windows.Forms.Label();
            this.btn_visualizaSenha = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtb_senha
            // 
            this.mtb_senha.Location = new System.Drawing.Point(29, 88);
            this.mtb_senha.Name = "mtb_senha";
            this.mtb_senha.PasswordChar = '*';
            this.mtb_senha.Size = new System.Drawing.Size(150, 23);
            this.mtb_senha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Senha";
            // 
            // mtb_cep
            // 
            this.mtb_cep.Location = new System.Drawing.Point(12, 31);
            this.mtb_cep.Mask = "00000-000";
            this.mtb_cep.Name = "mtb_cep";
            this.mtb_cep.Size = new System.Drawing.Size(75, 23);
            this.mtb_cep.TabIndex = 2;
            this.mtb_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cep";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(93, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 19);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Exibir Formatação";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.Location = new System.Drawing.Point(12, 86);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(128, 35);
            this.btn_visualizar.TabIndex = 5;
            this.btn_visualizar.Text = "Visualizar";
            this.btn_visualizar.UseVisualStyleBackColor = true;
            this.btn_visualizar.Click += new System.EventHandler(this.btn_visualizar_Click);
            // 
            // lbl_visualizar
            // 
            this.lbl_visualizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_visualizar.Location = new System.Drawing.Point(12, 57);
            this.lbl_visualizar.Name = "lbl_visualizar";
            this.lbl_visualizar.Size = new System.Drawing.Size(280, 26);
            this.lbl_visualizar.TabIndex = 6;
            this.lbl_visualizar.Text = "Texto";
            // 
            // btn_visualizaSenha
            // 
            this.btn_visualizaSenha.Location = new System.Drawing.Point(29, 117);
            this.btn_visualizaSenha.Name = "btn_visualizaSenha";
            this.btn_visualizaSenha.Size = new System.Drawing.Size(150, 26);
            this.btn_visualizaSenha.TabIndex = 7;
            this.btn_visualizaSenha.Text = "Visualizar Senha";
            this.btn_visualizaSenha.UseVisualStyleBackColor = true;
            this.btn_visualizaSenha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_visualizaSenha_MouseDown);
            this.btn_visualizaSenha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_visualizaSenha_MouseUp);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 23);
            this.textBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Login";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.btn_visualizaSenha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mtb_senha);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(376, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 176);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acesso";
            // 
            // frm_maskedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 220);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_visualizar);
            this.Controls.Add(this.btn_visualizar);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtb_cep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_maskedTextBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaskedTextBox";
            this.TextChanged += new System.EventHandler(this.v);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtb_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtb_cep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_visualizar;
        private System.Windows.Forms.Label lbl_visualizar;
        private System.Windows.Forms.Button btn_visualizaSenha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}