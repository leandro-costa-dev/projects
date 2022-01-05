
namespace CursoBruno
{
    partial class frm_treeView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Ecosport");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Fiesta");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Ford", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Corsa");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Astra");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Chevrolet", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_adicionarRaiz = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_adicionarFilho = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView1.Location = new System.Drawing.Point(12, 20);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "ecosport";
            treeNode1.Text = "Ecosport";
            treeNode2.Name = "fiesta";
            treeNode2.Text = "Fiesta";
            treeNode3.Name = "ford";
            treeNode3.Text = "Ford";
            treeNode4.Name = "corsa";
            treeNode4.Text = "Corsa";
            treeNode5.Name = "astra";
            treeNode5.Text = "Astra";
            treeNode6.Name = "chevrolet";
            treeNode6.Text = "Chevrolet";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(268, 269);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btn_adicionarRaiz
            // 
            this.btn_adicionarRaiz.Location = new System.Drawing.Point(286, 49);
            this.btn_adicionarRaiz.Name = "btn_adicionarRaiz";
            this.btn_adicionarRaiz.Size = new System.Drawing.Size(218, 38);
            this.btn_adicionarRaiz.TabIndex = 1;
            this.btn_adicionarRaiz.Text = "Adicionar Raiz";
            this.btn_adicionarRaiz.UseVisualStyleBackColor = true;
            this.btn_adicionarRaiz.Click += new System.EventHandler(this.btn_adicionarRaiz_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(286, 137);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(218, 38);
            this.btn_remover.TabIndex = 2;
            this.btn_remover.Text = "Remover Item";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(286, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 23);
            this.textBox1.TabIndex = 3;
            // 
            // btn_adicionarFilho
            // 
            this.btn_adicionarFilho.Location = new System.Drawing.Point(286, 93);
            this.btn_adicionarFilho.Name = "btn_adicionarFilho";
            this.btn_adicionarFilho.Size = new System.Drawing.Size(218, 38);
            this.btn_adicionarFilho.TabIndex = 4;
            this.btn_adicionarFilho.Text = "Adicionar Filho";
            this.btn_adicionarFilho.UseVisualStyleBackColor = true;
            this.btn_adicionarFilho.Click += new System.EventHandler(this.btn_adicionarFilho_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // frm_treeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 536);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_adicionarFilho);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_adicionarRaiz);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_treeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TreeView";
            this.Load += new System.EventHandler(this.frm_treeView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn_adicionarRaiz;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_adicionarFilho;
        private System.Windows.Forms.Label label1;
    }
}