
namespace CursoBruno
{
    partial class frm_dateTimePicker
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
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.txt_dia = new System.Windows.Forms.TextBox();
            this.txt_mes = new System.Windows.Forms.TextBox();
            this.txt_ano = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_hoje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(11, 12);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(336, 23);
            this.dtp_data.TabIndex = 0;
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.Location = new System.Drawing.Point(353, 12);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(129, 52);
            this.btn_visualizar.TabIndex = 1;
            this.btn_visualizar.Text = "Visualizar";
            this.btn_visualizar.UseVisualStyleBackColor = true;
            this.btn_visualizar.Click += new System.EventHandler(this.btn_visualizar_Click);
            // 
            // txt_data
            // 
            this.txt_data.Location = new System.Drawing.Point(12, 41);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(335, 23);
            this.txt_data.TabIndex = 2;
            // 
            // txt_dia
            // 
            this.txt_dia.Location = new System.Drawing.Point(41, 70);
            this.txt_dia.Name = "txt_dia";
            this.txt_dia.Size = new System.Drawing.Size(38, 23);
            this.txt_dia.TabIndex = 3;
            // 
            // txt_mes
            // 
            this.txt_mes.Location = new System.Drawing.Point(41, 99);
            this.txt_mes.Name = "txt_mes";
            this.txt_mes.Size = new System.Drawing.Size(38, 23);
            this.txt_mes.TabIndex = 4;
            // 
            // txt_ano
            // 
            this.txt_ano.Location = new System.Drawing.Point(41, 128);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(69, 23);
            this.txt_ano.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mês";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ano";
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(353, 70);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(128, 52);
            this.btn_alterar.TabIndex = 9;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_hoje
            // 
            this.btn_hoje.Location = new System.Drawing.Point(353, 130);
            this.btn_hoje.Name = "btn_hoje";
            this.btn_hoje.Size = new System.Drawing.Size(128, 52);
            this.btn_hoje.TabIndex = 10;
            this.btn_hoje.Text = "Hoje";
            this.btn_hoje.UseVisualStyleBackColor = true;
            this.btn_hoje.Click += new System.EventHandler(this.btn_hoje_Click);
            // 
            // frm_dateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 422);
            this.Controls.Add(this.btn_hoje);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ano);
            this.Controls.Add(this.txt_mes);
            this.Controls.Add(this.txt_dia);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.btn_visualizar);
            this.Controls.Add(this.dtp_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_dateTimePicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DateTimePicker";
            this.Load += new System.EventHandler(this.frm_dateTimePicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.Button btn_visualizar;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.TextBox txt_dia;
        private System.Windows.Forms.TextBox txt_mes;
        private System.Windows.Forms.TextBox txt_ano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_hoje;
    }
}