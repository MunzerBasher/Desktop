using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btPrintDate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToShortDateString());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Value.ToString("dd-MMM-yyyy") + Environment.NewLine;  
            label2.Text = dateTimePicker1.Value.ToString("ddd-MMM-yyyy") + Environment.NewLine;
            label3.Text = dateTimePicker1.Value.ToString("MM-dd-yyyy") + Environment.NewLine;
            label4.Text = dateTimePicker1.Value.ToString("dd/MM/yy") + Environment.NewLine;
            label5.Text = dateTimePicker1.Value.ToString("dddd,dd-MMM-yyyy") + Environment.NewLine;
        }

        private void btsel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.ToString());

        }

        private void btstart_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.Start.ToString());
        }

        private void btend_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.End.ToString());
        }
    }
}
