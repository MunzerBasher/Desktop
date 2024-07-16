using PictureBox.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbTitele.Text = "Gaza";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.AboAb;
            lbTitele.Text = "Abo Obida";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.AboAb;
            lbTitele.Text = "Abo Obida";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Gaza;
            lbTitele.Text = "Gaza";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\add (1).png");

        }
    }
}
