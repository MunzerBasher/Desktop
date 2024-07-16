using CheckBox.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowGaza_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Gaza;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void ShowAbo_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.AboAb;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("BeCareFul", "Are Sure !");
        }
    }
}