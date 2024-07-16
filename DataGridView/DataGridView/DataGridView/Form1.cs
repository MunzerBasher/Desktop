using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            int col = 1;

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            dgvTest.Columns.Add("col" + col ,"col" + col);
            col++;
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnAddData_Click(object sender, EventArgs e)
        {
            string Number =  tbNumber.Text;
            string Name = tbName.Text;
            string Salary = tbSalary.Text;
            object[] Data = { Number, Name, Salary };
            dataGridView1.Rows.Add(Data);

        }

        private void btnFillData_Click(object sender, EventArgs e)
        {
            for(int i =1 ; i<= 10  ; i++) 
            {
                object [] Data = { i, "Employee "+ i , i * 1000 };
                dataGridView1 .Rows.Add(Data);  
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("ok");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null) 
            { 
                tbNumber.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                tbName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();   
                tbSalary.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString(); 
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Cells[0].Value = tbNumber.Text;
                dataGridView1.CurrentRow.Cells[1].Value = tbName.Text;
                dataGridView1.CurrentRow.Cells[2].Value = tbSalary.Text;
            }
        }


        private void deletrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }

        private void btnCol_Click(object sender, EventArgs e)
        {
            //for(int i = 0; i < dataGridView1.Columns.Count; i++) 
            //{
            //    dataGridView1.Columns[i].HeaderText += i;
            
            //}
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderText += (col.Index + 1).ToString();
            }
        }

        private void btnrow_Click(object sender, EventArgs e)
        {
            for (int i = 0;  i < dataGridView1.Rows.Count; i++) 
            {
                dataGridView1.Rows[i].Cells[0].Value +=(i).ToString();
            }
        }
    }


}
