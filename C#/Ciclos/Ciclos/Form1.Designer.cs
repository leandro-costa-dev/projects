
namespace Ciclos
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
            this.listBox_texto = new System.Windows.Forms.ListBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_texto
            // 
            this.listBox_texto.FormattingEnabled = true;
            this.listBox_texto.ItemHeight = 15;
            this.listBox_texto.Location = new System.Drawing.Point(32, 12);
            this.listBox_texto.Name = "listBox_texto";
            this.listBox_texto.Size = new System.Drawing.Size(180, 319);
            this.listBox_texto.TabIndex = 0;
            this.listBox_texto.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(88, 349);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 415);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.listBox_texto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_texto;
        private System.Windows.Forms.Button btn_ok;
    }
}

