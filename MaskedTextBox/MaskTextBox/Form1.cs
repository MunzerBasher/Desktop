using MaskTextBox.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(maskedTextBox1.MaskFull)
            {
                MessageBox.Show("Hello", "It Ok");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "p1")
                pictureBox1.Image = Resources.Gaza;
            if (comboBox1.Text == "p2")
                pictureBox1.Image = Resources.AboAb;
            if (comboBox1.Text == "p3")
                pictureBox1.Image = Resources.Q;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
