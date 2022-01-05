
namespace EditorTexto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.negritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itálicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sublinhadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.alinhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centralizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diretaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNovo = new System.Windows.Forms.ToolStripButton();
            this.tsbAbrir = new System.Windows.Forms.ToolStripButton();
            this.tsbSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCopiar = new System.Windows.Forms.ToolStripButton();
            this.tsbRecortar = new System.Windows.Forms.ToolStripButton();
            this.tsbColar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNegrito = new System.Windows.Forms.ToolStripButton();
            this.tsbItalico = new System.Windows.Forms.ToolStripButton();
            this.tsbSublinhado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFonte = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(695, 575);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatarToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(695, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(117, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItem1.Text = "Imprimir";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(117, 6);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.colarToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.desfazerToolStripMenuItem,
            this.refazerToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.colarToolStripMenuItem.Text = "Recortar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.colarToolStripMenuItem_Click);
            // 
            // colarToolStripMenuItem1
            // 
            this.colarToolStripMenuItem1.Name = "colarToolStripMenuItem1";
            this.colarToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.colarToolStripMenuItem1.Text = "Colar";
            this.colarToolStripMenuItem1.Click += new System.EventHandler(this.colarToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(115, 6);
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.desfazerToolStripMenuItem.Text = "Desfazer";
            // 
            // refazerToolStripMenuItem
            // 
            this.refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            this.refazerToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.refazerToolStripMenuItem.Text = "Refazer";
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fonteToolStripMenuItem,
            this.toolStripSeparator1,
            this.negritoToolStripMenuItem,
            this.itálicoToolStripMenuItem,
            this.sublinhadoToolStripMenuItem,
            this.toolStripSeparator2,
            this.alinhamentoToolStripMenuItem});
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.formatarToolStripMenuItem.Text = "Formatar";
            // 
            // fonteToolStripMenuItem
            // 
            this.fonteToolStripMenuItem.Name = "fonteToolStripMenuItem";
            this.fonteToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.fonteToolStripMenuItem.Text = "Fonte";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // negritoToolStripMenuItem
            // 
            this.negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            this.negritoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.negritoToolStripMenuItem.Text = "Negrito";
            this.negritoToolStripMenuItem.Click += new System.EventHandler(this.negritoToolStripMenuItem_Click);
            // 
            // itálicoToolStripMenuItem
            // 
            this.itálicoToolStripMenuItem.Name = "itálicoToolStripMenuItem";
            this.itálicoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.itálicoToolStripMenuItem.Text = "Itálico";
            this.itálicoToolStripMenuItem.Click += new System.EventHandler(this.itálicoToolStripMenuItem_Click);
            // 
            // sublinhadoToolStripMenuItem
            // 
            this.sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
            this.sublinhadoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.sublinhadoToolStripMenuItem.Text = "Sublinhado";
            this.sublinhadoToolStripMenuItem.Click += new System.EventHandler(this.sublinhadoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(140, 6);
            // 
            // alinhamentoToolStripMenuItem
            // 
            this.alinhamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esquerdaToolStripMenuItem,
            this.centralizarToolStripMenuItem,
            this.diretaToolStripMenuItem});
            this.alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            this.alinhamentoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // esquerdaToolStripMenuItem
            // 
            this.esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            this.esquerdaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.esquerdaToolStripMenuItem.Text = "Esquerda";
            this.esquerdaToolStripMenuItem.Click += new System.EventHandler(this.esquerdaToolStripMenuItem_Click);
            // 
            // centralizarToolStripMenuItem
            // 
            this.centralizarToolStripMenuItem.Name = "centralizarToolStripMenuItem";
            this.centralizarToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.centralizarToolStripMenuItem.Text = "Centralizar";
            this.centralizarToolStripMenuItem.Click += new System.EventHandler(this.centralizarToolStripMenuItem_Click);
            // 
            // diretaToolStripMenuItem
            // 
            this.diretaToolStripMenuItem.Name = "diretaToolStripMenuItem";
            this.diretaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.diretaToolStripMenuItem.Text = "Direita";
            this.diretaToolStripMenuItem.Click += new System.EventHandler(this.diretaToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovo,
            this.tsbAbrir,
            this.tsbSalvar,
            this.toolStripSeparator3,
            this.tsbImprimir,
            this.toolStripSeparator4,
            this.tsbCopiar,
            this.tsbRecortar,
            this.tsbColar,
            this.toolStripSeparator5,
            this.tsbNegrito,
            this.tsbItalico,
            this.tsbSublinhado,
            this.toolStripSeparator6,
            this.tsbFonte});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(695, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNovo
            // 
            this.tsbNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNovo.Image = global::EditorTexto.Properties.Resources.novo_arquivo;
            this.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovo.Name = "tsbNovo";
            this.tsbNovo.Size = new System.Drawing.Size(23, 22);
            this.tsbNovo.Text = "Novo";
            this.tsbNovo.Click += new System.EventHandler(this.tsbNovo_Click);
            // 
            // tsbAbrir
            // 
            this.tsbAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAbrir.Image = global::EditorTexto.Properties.Resources.abrir_pasta_com_documento;
            this.tsbAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbrir.Name = "tsbAbrir";
            this.tsbAbrir.Size = new System.Drawing.Size(23, 22);
            this.tsbAbrir.Text = "Abrir";
            this.tsbAbrir.Click += new System.EventHandler(this.tsbAbrir_Click);
            // 
            // tsbSalvar
            // 
            this.tsbSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalvar.Image = global::EditorTexto.Properties.Resources.salve_;
            this.tsbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalvar.Name = "tsbSalvar";
            this.tsbSalvar.Size = new System.Drawing.Size(23, 22);
            this.tsbSalvar.Text = "Salvar";
            this.tsbSalvar.Click += new System.EventHandler(this.tsbSalvar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbImprimir
            // 
            this.tsbImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImprimir.Image = global::EditorTexto.Properties.Resources.imprimir;
            this.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImprimir.Name = "tsbImprimir";
            this.tsbImprimir.Size = new System.Drawing.Size(23, 22);
            this.tsbImprimir.Text = "Imprimir";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbCopiar
            // 
            this.tsbCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCopiar.Image = global::EditorTexto.Properties.Resources.copie_o_simbolo_de_interface_de_duas_folhas_de_papel;
            this.tsbCopiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopiar.Name = "tsbCopiar";
            this.tsbCopiar.Size = new System.Drawing.Size(23, 22);
            this.tsbCopiar.Text = "Copiar";
            this.tsbCopiar.Click += new System.EventHandler(this.tsbCopiar_Click);
            // 
            // tsbRecortar
            // 
            this.tsbRecortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRecortar.Image = global::EditorTexto.Properties.Resources.tesouras_e_linhas_de_recorte;
            this.tsbRecortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRecortar.Name = "tsbRecortar";
            this.tsbRecortar.Size = new System.Drawing.Size(23, 22);
            this.tsbRecortar.Text = "Recortar";
            this.tsbRecortar.Click += new System.EventHandler(this.tsbRecortar_Click);
            // 
            // tsbColar
            // 
            this.tsbColar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbColar.Image = global::EditorTexto.Properties.Resources.colar;
            this.tsbColar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbColar.Name = "tsbColar";
            this.tsbColar.Size = new System.Drawing.Size(23, 22);
            this.tsbColar.Text = "Colar";
            this.tsbColar.Click += new System.EventHandler(this.tsbColar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbNegrito
            // 
            this.tsbNegrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNegrito.Image = global::EditorTexto.Properties.Resources.texto_em_negrito;
            this.tsbNegrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNegrito.Name = "tsbNegrito";
            this.tsbNegrito.Size = new System.Drawing.Size(23, 22);
            this.tsbNegrito.Text = "Negrito";
            this.tsbNegrito.Click += new System.EventHandler(this.tsbNegrito_Click);
            // 
            // tsbItalico
            // 
            this.tsbItalico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbItalico.Image = global::EditorTexto.Properties.Resources.letra_i;
            this.tsbItalico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbItalico.Name = "tsbItalico";
            this.tsbItalico.Size = new System.Drawing.Size(23, 22);
            this.tsbItalico.Text = "Itálico";
            this.tsbItalico.Click += new System.EventHandler(this.tsbItalico_Click);
            // 
            // tsbSublinhado
            // 
            this.tsbSublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSublinhado.Image = global::EditorTexto.Properties.Resources.sublinhado;
            this.tsbSublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSublinhado.Name = "tsbSublinhado";
            this.tsbSublinhado.Size = new System.Drawing.Size(23, 22);
            this.tsbSublinhado.Text = "Sublinhado";
            this.tsbSublinhado.Click += new System.EventHandler(this.tsbSublinhado_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbFonte
            // 
            this.tsbFonte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFonte.Image = global::EditorTexto.Properties.Resources.fonte;
            this.tsbFonte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFonte.Name = "tsbFonte";
            this.tsbFonte.Size = new System.Drawing.Size(23, 22);
            this.tsbFonte.Text = "Fonte";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Arquivo de Texto (*.txt)|*.txt";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 629);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Texto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem desfazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem negritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itálicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sublinhadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem alinhamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esquerdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centralizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diretaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbNovo;
        private System.Windows.Forms.ToolStripButton tsbAbrir;
        private System.Windows.Forms.ToolStripButton tsbSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbCopiar;
        private System.Windows.Forms.ToolStripButton tsbRecortar;
        private System.Windows.Forms.ToolStripButton tsbColar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbNegrito;
        private System.Windows.Forms.ToolStripButton tsbItalico;
        private System.Windows.Forms.ToolStripButton tsbSublinhado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbFonte;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

