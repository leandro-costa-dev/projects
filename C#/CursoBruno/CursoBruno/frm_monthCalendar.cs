using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CursoBruno
{
    public partial class frm_monthCalendar : Form
    {
        public frm_monthCalendar()
        {
            InitializeComponent();
        }

        private void btn_visualizarData_Click(object sender, EventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToShortDateString();
            textBox2.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            textBox3.Text = monthCalendar1.TodayDate.ToShortDateString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToShortDateString();
            textBox2.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            textBox3.Text = monthCalendar1.TodayDate.ToShortDateString();

        }
    }
}
