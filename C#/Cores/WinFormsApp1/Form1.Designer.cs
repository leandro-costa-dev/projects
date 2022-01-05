
namespace WinFormsApp1
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
            this.label_cor = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label_r = new System.Windows.Forms.Label();
            this.label_g = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // label_cor
            // 
            this.label_cor.Location = new System.Drawing.Point(24, 37);
            this.label_cor.Name = "label_cor";
            this.label_cor.Size = new System.Drawing.Size(362, 167);
            this.label_cor.TabIndex = 0;
            this.label_cor.Text = "label1";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(24, 268);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(362, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(24, 346);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(362, 45);
            this.trackBar2.TabIndex = 2;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(24, 423);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(362, 45);
            this.trackBar3.TabIndex = 3;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label_r
            // 
            this.label_r.AutoSize = true;
            this.label_r.Location = new System.Drawing.Point(421, 268);
            this.label_r.Name = "label_r";
            this.label_r.Size = new System.Drawing.Size(14, 15);
            this.label_r.TabIndex = 4;
            this.label_r.Text = "R";
            // 
            // label_g
            // 
            this.label_g.AutoSize = true;
            this.label_g.Location = new System.Drawing.Point(421, 346);
            this.label_g.Name = "label_g";
            this.label_g.Size = new System.Drawing.Size(15, 15);
            this.label_g.TabIndex = 5;
            this.label_g.Text = "G";
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Location = new System.Drawing.Point(421, 423);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(14, 15);
            this.label_b.TabIndex = 6;
            this.label_b.Text = "B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 535);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.label_g);
            this.Controls.Add(this.label_r);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label_cor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_cor;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label_r;
        private System.Windows.Forms.Label label_g;
        private System.Windows.Forms.Label label_b;
    }
}

