using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForms
{
    public partial class MainPag : Form
    {
        public MainPag()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            clsShowForm.ShowForm(frm,pnlContainer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            clsShowForm.ShowForm(frm, pnlContainer);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainPag frm = new MainPag();
            clsShowForm.ShowForm(frm, pnlContainer);
        }
    }
}
