using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 20; i++)
            {
                if (progressBar1.Value < progressBar1.Maximum)
                {
                    Thread.Sleep(100);
                    progressBar1.Value += 5;
                    label1.Text = (((float)progressBar1.Value / (float)progressBar1.Maximum) * 100) + "%";
                    progressBar1.Refresh();
                    label1.Refresh();
                }
                else
                {
                    button1.Enabled = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            label1.Text = progressBar1.Value.ToString() + "%";
            button1.Enabled = true;
        }
    }
}
