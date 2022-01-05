
namespace AgendaSQL
{
    partial class frmResultado
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.grdResultado = new System.Windows.Forms.DataGridView();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(571, 400);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(119, 38);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // grdResultado
            // 
            this.grdResultado.AllowUserToAddRows = false;
            this.grdResultado.AllowUserToDeleteRows = false;
            this.grdResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResultado.Location = new System.Drawing.Point(12, 12);
            this.grdResultado.MultiSelect = false;
            this.grdResultado.Name = "grdResultado";
            this.grdResultado.ReadOnly = true;
            this.grdResultado.RowHeadersVisible = false;
            this.grdResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdResultado.Size = new System.Drawing.Size(678, 358);
            this.grdResultado.TabIndex = 1;
            this.grdResultado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdResultado_CellClick);
            this.grdResultado.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdResultado_CellContentDoubleClick);
            // 
            // lblRegistros
            // 
            this.lblRegistros.Location = new System.Drawing.Point(12, 373);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(281, 26);
            this.lblRegistros.TabIndex = 2;
            this.lblRegistros.Text = "label1";
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(446, 400);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(119, 38);
            this.btnApagar.TabIndex = 3;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(321, 400);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(119, 38);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(196, 400);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(119, 38);
            this.btnTodos.TabIndex = 5;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // frmResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.grdResultado);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmResultado";
            this.Load += new System.EventHandler(this.frmResultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView grdResultado;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnTodos;
    }
}