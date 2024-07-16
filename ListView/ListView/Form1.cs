using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbSmallIcco_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void rbLargeIco_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void rbDetails_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void rbTile_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void rbList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text)) 
                return;
            
            ListViewItem item = new ListViewItem(txtID.Text);
            if(rbmale.Checked)
                item.ImageIndex = 0;
            else
                item.ImageIndex = 1;
            item.SubItems.Add(txtName.Text.Trim());
            listView1.Items.Add(item);
            txtID.Clear();
            txtName.Clear();
            txtID.Focus();
        }

        private void btremove_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count > 0)
            {
                listView1.Items.RemoveAt(0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int N = random.Next(2, 20);
            ListViewItem item = new ListViewItem(N.ToString());
            if(N % 2 == 0)
            {
                rbmale.Checked = true;
            }
            else
            {
                rbfemale.Checked = true;
            }
            if (rbmale.Checked)
                item.ImageIndex = 0;
            else
                item.ImageIndex = 1;
            item.SubItems.Add(N.ToString());
            item.SubItems.Add("Q");
            item.SubItems.Add("L");
            item.SubItems.Add("m");
            listView1.Items.Add(item);
            txtID.Focus();
        }
    }
}
