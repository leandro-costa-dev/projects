
namespace CursoBruno
{
    partial class frm_menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_textBox = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_checkBox = new System.Windows.Forms.ToolStripMenuItem();
            this.checkdListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimerPickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskedTextBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuNotificacoes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_restaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mensagem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_fechar = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.sQLiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aula01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.MenuNotificacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.exibirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(320, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_cadastro,
            this.mnu_sair});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // mnu_cadastro
            // 
            this.mnu_cadastro.Name = "mnu_cadastro";
            this.mnu_cadastro.Size = new System.Drawing.Size(180, 22);
            this.mnu_cadastro.Text = "&Cadastro";
            this.mnu_cadastro.Click += new System.EventHandler(this.mnu_cadastro_Click);
            // 
            // mnu_sair
            // 
            this.mnu_sair.Name = "mnu_sair";
            this.mnu_sair.Size = new System.Drawing.Size(180, 22);
            this.mnu_sair.Text = "&Sair";
            this.mnu_sair.Click += new System.EventHandler(this.mnu_sair_Click);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem,
            this.sQLiteToolStripMenuItem});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.exibirToolStripMenuItem.Text = "&Exibir";
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_textBox,
            this.mnu_checkBox,
            this.checkdListBoxToolStripMenuItem,
            this.comboBoxToolStripMenuItem,
            this.dateTimerPickerToolStripMenuItem,
            this.linkLabelToolStripMenuItem,
            this.listBoxToolStripMenuItem,
            this.listViewToolStripMenuItem,
            this.maskedTextBoxToolStripMenuItem,
            this.monthCalendarToolStripMenuItem,
            this.numericUpDownToolStripMenuItem,
            this.pictureBoxToolStripMenuItem,
            this.progressBarToolStripMenuItem,
            this.radioButonToolStripMenuItem,
            this.trackBarToolStripMenuItem,
            this.treeViewToolStripMenuItem,
            this.webToolStripMenuItem,
            this.tabControlToolStripMenuItem});
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.componentesToolStripMenuItem.Text = "Componentes";
            // 
            // mnu_textBox
            // 
            this.mnu_textBox.Name = "mnu_textBox";
            this.mnu_textBox.Size = new System.Drawing.Size(180, 22);
            this.mnu_textBox.Text = "TextBox";
            this.mnu_textBox.Click += new System.EventHandler(this.mnu_textBox_Click);
            // 
            // mnu_checkBox
            // 
            this.mnu_checkBox.Name = "mnu_checkBox";
            this.mnu_checkBox.Size = new System.Drawing.Size(180, 22);
            this.mnu_checkBox.Text = "CheckBox";
            this.mnu_checkBox.Click += new System.EventHandler(this.mnu_checkBox_Click);
            // 
            // checkdListBoxToolStripMenuItem
            // 
            this.checkdListBoxToolStripMenuItem.Name = "checkdListBoxToolStripMenuItem";
            this.checkdListBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkdListBoxToolStripMenuItem.Text = "CheckdListBox";
            this.checkdListBoxToolStripMenuItem.Click += new System.EventHandler(this.checkdListBoxToolStripMenuItem_Click);
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comboBoxToolStripMenuItem.Text = "ComboBox";
            this.comboBoxToolStripMenuItem.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click);
            // 
            // dateTimerPickerToolStripMenuItem
            // 
            this.dateTimerPickerToolStripMenuItem.Name = "dateTimerPickerToolStripMenuItem";
            this.dateTimerPickerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dateTimerPickerToolStripMenuItem.Text = "DateTimerPicker";
            this.dateTimerPickerToolStripMenuItem.Click += new System.EventHandler(this.dateTimerPickerToolStripMenuItem_Click);
            // 
            // linkLabelToolStripMenuItem
            // 
            this.linkLabelToolStripMenuItem.Name = "linkLabelToolStripMenuItem";
            this.linkLabelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.linkLabelToolStripMenuItem.Text = "LinkLabel";
            this.linkLabelToolStripMenuItem.Click += new System.EventHandler(this.linkLabelToolStripMenuItem_Click);
            // 
            // listBoxToolStripMenuItem
            // 
            this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listBoxToolStripMenuItem.Text = "ListBox";
            this.listBoxToolStripMenuItem.Click += new System.EventHandler(this.listBoxToolStripMenuItem_Click);
            // 
            // listViewToolStripMenuItem
            // 
            this.listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            this.listViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listViewToolStripMenuItem.Text = "ListView";
            this.listViewToolStripMenuItem.Click += new System.EventHandler(this.listViewToolStripMenuItem_Click);
            // 
            // maskedTextBoxToolStripMenuItem
            // 
            this.maskedTextBoxToolStripMenuItem.Name = "maskedTextBoxToolStripMenuItem";
            this.maskedTextBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maskedTextBoxToolStripMenuItem.Text = "MaskedTextBox";
            this.maskedTextBoxToolStripMenuItem.Click += new System.EventHandler(this.maskedTextBoxToolStripMenuItem_Click);
            // 
            // monthCalendarToolStripMenuItem
            // 
            this.monthCalendarToolStripMenuItem.Name = "monthCalendarToolStripMenuItem";
            this.monthCalendarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.monthCalendarToolStripMenuItem.Text = "MonthCalendar";
            this.monthCalendarToolStripMenuItem.Click += new System.EventHandler(this.monthCalendarToolStripMenuItem_Click);
            // 
            // numericUpDownToolStripMenuItem
            // 
            this.numericUpDownToolStripMenuItem.Name = "numericUpDownToolStripMenuItem";
            this.numericUpDownToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.numericUpDownToolStripMenuItem.Text = "NumericUpDown";
            this.numericUpDownToolStripMenuItem.Click += new System.EventHandler(this.numericUpDownToolStripMenuItem_Click);
            // 
            // pictureBoxToolStripMenuItem
            // 
            this.pictureBoxToolStripMenuItem.Name = "pictureBoxToolStripMenuItem";
            this.pictureBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pictureBoxToolStripMenuItem.Text = "PictureBox";
            this.pictureBoxToolStripMenuItem.Click += new System.EventHandler(this.pictureBoxToolStripMenuItem_Click);
            // 
            // progressBarToolStripMenuItem
            // 
            this.progressBarToolStripMenuItem.Name = "progressBarToolStripMenuItem";
            this.progressBarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.progressBarToolStripMenuItem.Text = "ProgressBar";
            this.progressBarToolStripMenuItem.Click += new System.EventHandler(this.progressBarToolStripMenuItem_Click);
            // 
            // radioButonToolStripMenuItem
            // 
            this.radioButonToolStripMenuItem.Name = "radioButonToolStripMenuItem";
            this.radioButonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.radioButonToolStripMenuItem.Text = "RadioButton";
            this.radioButonToolStripMenuItem.Click += new System.EventHandler(this.radioButonToolStripMenuItem_Click);
            // 
            // trackBarToolStripMenuItem
            // 
            this.trackBarToolStripMenuItem.Name = "trackBarToolStripMenuItem";
            this.trackBarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trackBarToolStripMenuItem.Text = "TrackBar";
            this.trackBarToolStripMenuItem.Click += new System.EventHandler(this.trackBarToolStripMenuItem_Click);
            // 
            // treeViewToolStripMenuItem
            // 
            this.treeViewToolStripMenuItem.Name = "treeViewToolStripMenuItem";
            this.treeViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.treeViewToolStripMenuItem.Text = "TreeView";
            this.treeViewToolStripMenuItem.Click += new System.EventHandler(this.treeViewToolStripMenuItem_Click);
            // 
            // webToolStripMenuItem
            // 
            this.webToolStripMenuItem.Name = "webToolStripMenuItem";
            this.webToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.webToolStripMenuItem.Text = "SplitContainer";
            this.webToolStripMenuItem.Click += new System.EventHandler(this.webToolStripMenuItem_Click);
            // 
            // tabControlToolStripMenuItem
            // 
            this.tabControlToolStripMenuItem.Name = "tabControlToolStripMenuItem";
            this.tabControlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tabControlToolStripMenuItem.Text = "TabControl";
            this.tabControlToolStripMenuItem.Click += new System.EventHandler(this.tabControlToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(43, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 138);
            this.label1.TabIndex = 3;
            this.label1.Text = "Curso C# Professor Bruno";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.MenuNotificacoes;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // MenuNotificacoes
            // 
            this.MenuNotificacoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_restaurar,
            this.tsmi_mensagem,
            this.tsmi_fechar});
            this.MenuNotificacoes.Name = "contextMenuStrip1";
            this.MenuNotificacoes.Size = new System.Drawing.Size(134, 70);
            // 
            // tsmi_restaurar
            // 
            this.tsmi_restaurar.Name = "tsmi_restaurar";
            this.tsmi_restaurar.Size = new System.Drawing.Size(133, 22);
            this.tsmi_restaurar.Text = "Restaurar";
            this.tsmi_restaurar.Click += new System.EventHandler(this.tsmi_restaurar_Click);
            // 
            // tsmi_mensagem
            // 
            this.tsmi_mensagem.Name = "tsmi_mensagem";
            this.tsmi_mensagem.Size = new System.Drawing.Size(133, 22);
            this.tsmi_mensagem.Text = "Mensagem";
            this.tsmi_mensagem.Click += new System.EventHandler(this.tsmi_mensagem_Click);
            // 
            // tsmi_fechar
            // 
            this.tsmi_fechar.Name = "tsmi_fechar";
            this.tsmi_fechar.Size = new System.Drawing.Size(133, 22);
            this.tsmi_fechar.Text = "Fechar";
            this.tsmi_fechar.Click += new System.EventHandler(this.tsmi_fechar_Click);
            // 
            // sQLiteToolStripMenuItem
            // 
            this.sQLiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aula01ToolStripMenuItem});
            this.sQLiteToolStripMenuItem.Name = "sQLiteToolStripMenuItem";
            this.sQLiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sQLiteToolStripMenuItem.Text = "SQLite";
            // 
            // aula01ToolStripMenuItem
            // 
            this.aula01ToolStripMenuItem.Name = "aula01ToolStripMenuItem";
            this.aula01ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aula01ToolStripMenuItem.Text = "Aula 01";
            this.aula01ToolStripMenuItem.Click += new System.EventHandler(this.aula01ToolStripMenuItem_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 408);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frm_menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MenuNotificacoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_sair;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_textBox;
        private System.Windows.Forms.ToolStripMenuItem mnu_cadastro;
        private System.Windows.Forms.ToolStripMenuItem mnu_checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem checkdListBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateTimerPickerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkLabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maskedTextBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthCalendarToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip MenuNotificacoes;
        private System.Windows.Forms.ToolStripMenuItem tsmi_restaurar;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mensagem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_fechar;
        private System.Windows.Forms.ToolStripMenuItem numericUpDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pictureBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progressBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radioButonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trackBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treeViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem tabControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aula01ToolStripMenuItem;
    }
}