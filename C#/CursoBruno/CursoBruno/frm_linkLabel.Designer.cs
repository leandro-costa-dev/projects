
namespace CursoBruno
{
    partial class frm_linkLabel
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
            this.llb_site = new System.Windows.Forms.LinkLabel();
            this.llb_calculadora = new System.Windows.Forms.LinkLabel();
            this.llb_multiplos = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // llb_site
            // 
            this.llb_site.AutoSize = true;
            this.llb_site.Location = new System.Drawing.Point(12, 9);
            this.llb_site.Name = "llb_site";
            this.llb_site.Size = new System.Drawing.Size(26, 15);
            this.llb_site.TabIndex = 0;
            this.llb_site.TabStop = true;
            this.llb_site.Text = "Site";
            this.llb_site.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_site_LinkClicked);
            // 
            // llb_calculadora
            // 
            this.llb_calculadora.AutoSize = true;
            this.llb_calculadora.Location = new System.Drawing.Point(12, 54);
            this.llb_calculadora.Name = "llb_calculadora";
            this.llb_calculadora.Size = new System.Drawing.Size(70, 15);
            this.llb_calculadora.TabIndex = 1;
            this.llb_calculadora.TabStop = true;
            this.llb_calculadora.Text = "Calculadora";
            this.llb_calculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_calculadora_LinkClicked);
            // 
            // llb_multiplos
            // 
            this.llb_multiplos.AutoSize = true;
            this.llb_multiplos.Location = new System.Drawing.Point(12, 97);
            this.llb_multiplos.Name = "llb_multiplos";
            this.llb_multiplos.Size = new System.Drawing.Size(142, 15);
            this.llb_multiplos.TabIndex = 2;
            this.llb_multiplos.TabStop = true;
            this.llb_multiplos.Text = "Google - Youtube - Gmail";
            this.llb_multiplos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_multiplos_LinkClicked);
            // 
            // frm_linkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 325);
            this.Controls.Add(this.llb_multiplos);
            this.Controls.Add(this.llb_calculadora);
            this.Controls.Add(this.llb_site);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_linkLabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_linkLabel";
            this.Load += new System.EventHandler(this.frm_linkLabel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llb_site;
        private System.Windows.Forms.LinkLabel llb_calculadora;
        private System.Windows.Forms.LinkLabel llb_multiplos;
    }
}