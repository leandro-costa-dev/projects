using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CursoBruno
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }

        private void mnu_cadastro_Click(object sender, EventArgs e)
        {
            frm_cadastro c = new frm_cadastro();
            c.ShowDialog();
        }

        private void mnu_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mnu_textBox_Click(object sender, EventArgs e)
        {

        }
        private void mnu_checkBox_Click(object sender, EventArgs e)
        {
            frm_checkBox f = new frm_checkBox();
            f.ShowDialog();
        }

        private void checkdListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_checkedListBox f = new frm_checkedListBox();
            f.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_comboBox f = new frm_comboBox();
            f.ShowDialog();
        }

        private void dateTimerPickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_dateTimePicker f = new frm_dateTimePicker();
            f.ShowDialog();
        }

        private void linkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_linkLabel f = new frm_linkLabel();
            f.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_listBox f = new frm_listBox();
            f.ShowDialog();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_listView f = new frm_listView();
            f.ShowDialog();
        }

        private void maskedTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_maskedTextBox f = new frm_maskedTextBox();
            f.ShowDialog();
        }

        private void monthCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_monthCalendar f = new frm_monthCalendar();
            f.ShowDialog();
        }

        private void tsmi_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmi_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void tsmi_mensagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Curso de C#");
        }

        private void numericUpDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_numericUpDown f = new frm_numericUpDown();
            f.ShowDialog();
        }

        private void pictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_pictureBox f = new frm_pictureBox();
            f.ShowDialog();
        }

        private void progressBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_progressBar f = new frm_progressBar();
            f.ShowDialog();
        }

        private void radioButonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_radioButton f = new frm_radioButton();
            f.ShowDialog();
        }

        private void trackBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_trackBar f = new frm_trackBar();
            f.ShowDialog();
        }

        private void treeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_treeView f = new frm_treeView();
            f.ShowDialog();
        }

        private void webToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_splitContainer f = new frm_splitContainer();
            f.ShowDialog();
        }

        private void tabControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tabControl f = new frm_tabControl();
            f.ShowDialog();
        }

        private void aula01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_sqLite f = new frm_sqLite();
            f.ShowDialog();
        }
    }
}
