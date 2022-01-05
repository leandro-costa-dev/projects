
namespace CursoBruno
{
    partial class frm_listView
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Mouse",
            "10",
            "15,25"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Teclado",
            "25",
            "18,90"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Monitor",
            "15",
            "524,60"}, -1);
            this.ltv_produtos = new System.Windows.Forms.ListView();
            this.col_id = new System.Windows.Forms.ColumnHeader();
            this.col_produto = new System.Windows.Forms.ColumnHeader();
            this.col_qtde = new System.Windows.Forms.ColumnHeader();
            this.col_preco = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.txt_qtde = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ltv_produtos
            // 
            this.ltv_produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_produto,
            this.col_qtde,
            this.col_preco});
            this.ltv_produtos.FullRowSelect = true;
            this.ltv_produtos.HideSelection = false;
            this.ltv_produtos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.ltv_produtos.Location = new System.Drawing.Point(12, 36);
            this.ltv_produtos.MultiSelect = false;
            this.ltv_produtos.Name = "ltv_produtos";
            this.ltv_produtos.Size = new System.Drawing.Size(551, 113);
            this.ltv_produtos.TabIndex = 0;
            this.ltv_produtos.UseCompatibleStateImageBehavior = false;
            this.ltv_produtos.View = System.Windows.Forms.View.Details;
            this.ltv_produtos.DoubleClick += new System.EventHandler(this.ltv_produtos_DoubleClick);
            // 
            // col_id
            // 
            this.col_id.Text = "ID";
            // 
            // col_produto
            // 
            this.col_produto.Text = "Produto";
            this.col_produto.Width = 300;
            // 
            // col_qtde
            // 
            this.col_qtde.Text = "Quantidade";
            this.col_qtde.Width = 80;
            // 
            // col_preco
            // 
            this.col_preco.Text = "Preço";
            this.col_preco.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ListView Manual";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(14, 182);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(47, 23);
            this.txt_id.TabIndex = 3;
            // 
            // txt_produto
            // 
            this.txt_produto.Location = new System.Drawing.Point(67, 182);
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(309, 23);
            this.txt_produto.TabIndex = 4;
            // 
            // txt_qtde
            // 
            this.txt_qtde.Location = new System.Drawing.Point(382, 182);
            this.txt_qtde.Name = "txt_qtde";
            this.txt_qtde.Size = new System.Drawing.Size(78, 23);
            this.txt_qtde.TabIndex = 5;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(466, 182);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(78, 23);
            this.txt_valor.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor";
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(12, 220);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(170, 23);
            this.btn_adicionar.TabIndex = 11;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(12, 249);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(170, 23);
            this.btn_remover.TabIndex = 12;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.Location = new System.Drawing.Point(14, 278);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(170, 23);
            this.btn_visualizar.TabIndex = 13;
            this.btn_visualizar.Text = "Visualizar";
            this.btn_visualizar.UseVisualStyleBackColor = true;
            this.btn_visualizar.Click += new System.EventHandler(this.btn_visualizar_Click);
            // 
            // frm_listView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 561);
            this.Controls.Add(this.btn_visualizar);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_qtde);
            this.Controls.Add(this.txt_produto);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ltv_produtos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_listView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListView";
            this.Load += new System.EventHandler(this.frm_listView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ltv_produtos;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_produto;
        private System.Windows.Forms.ColumnHeader col_qtde;
        private System.Windows.Forms.ColumnHeader col_preco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_produto;
        private System.Windows.Forms.TextBox txt_qtde;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_visualizar;
    }
}