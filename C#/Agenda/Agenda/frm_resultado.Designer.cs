
namespace Agenda
{
    partial class frm_resultado
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
            this.btn_nova = new System.Windows.Forms.Button();
            this.lst_resultados = new System.Windows.Forms.ListBox();
            this.lbl_registro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(415, 212);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(119, 32);
            this.btn_fechar.TabIndex = 0;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_nova
            // 
            this.btn_nova.Location = new System.Drawing.Point(290, 212);
            this.btn_nova.Name = "btn_nova";
            this.btn_nova.Size = new System.Drawing.Size(119, 32);
            this.btn_nova.TabIndex = 1;
            this.btn_nova.Text = "Nova Pesquisa";
            this.btn_nova.UseVisualStyleBackColor = true;
            this.btn_nova.Click += new System.EventHandler(this.btn_nova_Click);
            // 
            // lst_resultados
            // 
            this.lst_resultados.FormattingEnabled = true;
            this.lst_resultados.ItemHeight = 15;
            this.lst_resultados.Location = new System.Drawing.Point(12, 12);
            this.lst_resultados.Name = "lst_resultados";
            this.lst_resultados.Size = new System.Drawing.Size(522, 184);
            this.lst_resultados.TabIndex = 2;
            // 
            // lbl_registro
            // 
            this.lbl_registro.Location = new System.Drawing.Point(12, 209);
            this.lbl_registro.Name = "lbl_registro";
            this.lbl_registro.Size = new System.Drawing.Size(122, 23);
            this.lbl_registro.TabIndex = 9;
            this.lbl_registro.Text = "Registros: 0";
            this.lbl_registro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frm_resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 257);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_registro);
            this.Controls.Add(this.lst_resultados);
            this.Controls.Add(this.btn_nova);
            this.Controls.Add(this.btn_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_resultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado";
            this.Load += new System.EventHandler(this.frm_resultado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_nova;
        private System.Windows.Forms.ListBox lst_resultados;
        private System.Windows.Forms.Label lbl_registro;
    }
}