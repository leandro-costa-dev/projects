
namespace CursoBruno
{
    partial class frm_checkBox
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
            this.cbx_carro = new System.Windows.Forms.CheckBox();
            this.cbx_aviao = new System.Windows.Forms.CheckBox();
            this.cbx_navio = new System.Windows.Forms.CheckBox();
            this.cbx_onibus = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbx_carro
            // 
            this.cbx_carro.AutoSize = true;
            this.cbx_carro.Location = new System.Drawing.Point(12, 34);
            this.cbx_carro.Name = "cbx_carro";
            this.cbx_carro.Size = new System.Drawing.Size(55, 19);
            this.cbx_carro.TabIndex = 0;
            this.cbx_carro.Text = "Carro";
            this.cbx_carro.UseVisualStyleBackColor = true;
            // 
            // cbx_aviao
            // 
            this.cbx_aviao.AutoSize = true;
            this.cbx_aviao.Location = new System.Drawing.Point(12, 59);
            this.cbx_aviao.Name = "cbx_aviao";
            this.cbx_aviao.Size = new System.Drawing.Size(56, 19);
            this.cbx_aviao.TabIndex = 1;
            this.cbx_aviao.Text = "Avião";
            this.cbx_aviao.UseVisualStyleBackColor = true;
            // 
            // cbx_navio
            // 
            this.cbx_navio.AutoSize = true;
            this.cbx_navio.Location = new System.Drawing.Point(12, 84);
            this.cbx_navio.Name = "cbx_navio";
            this.cbx_navio.Size = new System.Drawing.Size(57, 19);
            this.cbx_navio.TabIndex = 2;
            this.cbx_navio.Text = "Navio";
            this.cbx_navio.UseVisualStyleBackColor = true;
            // 
            // cbx_onibus
            // 
            this.cbx_onibus.AutoSize = true;
            this.cbx_onibus.Location = new System.Drawing.Point(12, 109);
            this.cbx_onibus.Name = "cbx_onibus";
            this.cbx_onibus.Size = new System.Drawing.Size(64, 19);
            this.cbx_onibus.TabIndex = 3;
            this.cbx_onibus.Text = "Onibus";
            this.cbx_onibus.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_checkBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 183);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbx_onibus);
            this.Controls.Add(this.cbx_navio);
            this.Controls.Add(this.cbx_aviao);
            this.Controls.Add(this.cbx_carro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_checkBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox";
            this.Load += new System.EventHandler(this.frm_checkBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbx_carro;
        private System.Windows.Forms.CheckBox cbx_aviao;
        private System.Windows.Forms.CheckBox cbx_navio;
        private System.Windows.Forms.CheckBox cbx_onibus;
        private System.Windows.Forms.Button button1;
    }
}