
namespace CursoBruno
{
    partial class frm_comboBox
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
            this.cmb_lista = new System.Windows.Forms.ComboBox();
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_carregar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_mostrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmb_lista
            // 
            this.cmb_lista.FormattingEnabled = true;
            this.cmb_lista.Items.AddRange(new object[] {
            "Carro",
            "Motocicleta",
            "Onibus",
            "Trem",
            "Barco"});
            this.cmb_lista.Location = new System.Drawing.Point(12, 12);
            this.cmb_lista.Name = "cmb_lista";
            this.cmb_lista.Size = new System.Drawing.Size(250, 23);
            this.cmb_lista.TabIndex = 0;
            this.cmb_lista.SelectedIndexChanged += new System.EventHandler(this.cmb_lista_SelectedIndexChanged);
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.Location = new System.Drawing.Point(268, 12);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(134, 49);
            this.btn_visualizar.TabIndex = 1;
            this.btn_visualizar.Text = "Visualizar";
            this.btn_visualizar.UseVisualStyleBackColor = true;
            this.btn_visualizar.Click += new System.EventHandler(this.btn_visualizar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(268, 67);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(134, 49);
            this.btn_limpar.TabIndex = 2;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_carregar
            // 
            this.btn_carregar.Location = new System.Drawing.Point(268, 122);
            this.btn_carregar.Name = "btn_carregar";
            this.btn_carregar.Size = new System.Drawing.Size(134, 54);
            this.btn_carregar.TabIndex = 3;
            this.btn_carregar.Text = "Carregar";
            this.btn_carregar.UseVisualStyleBackColor = true;
            this.btn_carregar.Click += new System.EventHandler(this.btn_carregar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 215);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 54);
            this.button4.TabIndex = 4;
            this.button4.Text = "Adicionar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt_mostrar
            // 
            this.txt_mostrar.Location = new System.Drawing.Point(12, 186);
            this.txt_mostrar.Name = "txt_mostrar";
            this.txt_mostrar.Size = new System.Drawing.Size(390, 23);
            this.txt_mostrar.TabIndex = 5;
            // 
            // frm_comboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 281);
            this.Controls.Add(this.txt_mostrar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_carregar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_visualizar);
            this.Controls.Add(this.cmb_lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_comboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox";
            this.Load += new System.EventHandler(this.frm_comboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_lista;
        private System.Windows.Forms.Button btn_visualizar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_carregar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_mostrar;
    }
}