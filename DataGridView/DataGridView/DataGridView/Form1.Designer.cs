namespace DataGridView
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClNEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTest = new System.Windows.Forms.DataGridView();
            this.btnAddColumn = new System.Windows.Forms.Button();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.Employee = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddData = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFillData = new System.Windows.Forms.Button();
            this.btnCol = new System.Windows.Forms.Button();
            this.btnrow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClEmployee,
            this.ClNEmployee,
            this.ClSalary});
            this.dataGridView1.Location = new System.Drawing.Point(42, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(805, 355);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ClEmployee
            // 
            this.ClEmployee.FillWeight = 200F;
            this.ClEmployee.HeaderText = "EmployeeNumber";
            this.ClEmployee.MinimumWidth = 8;
            this.ClEmployee.Name = "ClEmployee";
            this.ClEmployee.ReadOnly = true;
            this.ClEmployee.Width = 150;
            // 
            // ClNEmployee
            // 
            this.ClNEmployee.HeaderText = "Employee Name";
            this.ClNEmployee.MinimumWidth = 8;
            this.ClNEmployee.Name = "ClNEmployee";
            this.ClNEmployee.ReadOnly = true;
            this.ClNEmployee.Width = 150;
            // 
            // ClSalary
            // 
            this.ClSalary.HeaderText = "Salary";
            this.ClSalary.MinimumWidth = 8;
            this.ClSalary.Name = "ClSalary";
            this.ClSalary.ReadOnly = true;
            this.ClSalary.Width = 150;
            // 
            // dgvTest
            // 
            this.dgvTest.AllowUserToAddRows = false;
            this.dgvTest.AllowUserToDeleteRows = false;
            this.dgvTest.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTest.Location = new System.Drawing.Point(909, 31);
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.ReadOnly = true;
            this.dgvTest.RowHeadersWidth = 62;
            this.dgvTest.RowTemplate.Height = 28;
            this.dgvTest.Size = new System.Drawing.Size(295, 449);
            this.dgvTest.TabIndex = 1;
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.Location = new System.Drawing.Point(909, 564);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(109, 40);
            this.btnAddColumn.TabIndex = 2;
            this.btnAddColumn.Text = "Add Column";
            this.btnAddColumn.UseVisualStyleBackColor = true;
            this.btnAddColumn.Click += new System.EventHandler(this.btnAddColumn_Click);
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(1095, 564);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(109, 40);
            this.btnAddRow.TabIndex = 3;
            this.btnAddRow.Text = "Add Row";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // Employee
            // 
            this.Employee.AutoSize = true;
            this.Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Employee.Location = new System.Drawing.Point(37, 44);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(215, 29);
            this.Employee.TabIndex = 4;
            this.Employee.Text = "Employee Number";
            // 
            // tbNumber
            // 
            this.tbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbNumber.Location = new System.Drawing.Point(277, 41);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(312, 35);
            this.tbNumber.TabIndex = 5;
            // 
            // tbSalary
            // 
            this.tbSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbSalary.Location = new System.Drawing.Point(277, 170);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(312, 35);
            this.tbSalary.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(37, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employee Salary";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbName.Location = new System.Drawing.Point(277, 99);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(312, 35);
            this.tbName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(37, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Employee Name";
            // 
            // btnAddData
            // 
            this.btnAddData.Location = new System.Drawing.Point(42, 212);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(109, 40);
            this.btnAddData.TabIndex = 10;
            this.btnAddData.Text = "Add ";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deletrToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 68);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deletrToolStripMenuItem
            // 
            this.deletrToolStripMenuItem.Name = "deletrToolStripMenuItem";
            this.deletrToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.deletrToolStripMenuItem.Text = "Delete";
            this.deletrToolStripMenuItem.Click += new System.EventHandler(this.deletrToolStripMenuItem_Click);
            // 
            // btnFillData
            // 
            this.btnFillData.Location = new System.Drawing.Point(178, 212);
            this.btnFillData.Name = "btnFillData";
            this.btnFillData.Size = new System.Drawing.Size(669, 40);
            this.btnFillData.TabIndex = 12;
            this.btnFillData.Text = "Fill";
            this.btnFillData.UseVisualStyleBackColor = true;
            this.btnFillData.Click += new System.EventHandler(this.btnFillData_Click);
            // 
            // btnCol
            // 
            this.btnCol.Location = new System.Drawing.Point(663, 44);
            this.btnCol.Name = "btnCol";
            this.btnCol.Size = new System.Drawing.Size(137, 54);
            this.btnCol.TabIndex = 13;
            this.btnCol.Text = "Loop Column";
            this.btnCol.UseVisualStyleBackColor = true;
            this.btnCol.Click += new System.EventHandler(this.btnCol_Click);
            // 
            // btnrow
            // 
            this.btnrow.Location = new System.Drawing.Point(663, 135);
            this.btnrow.Name = "btnrow";
            this.btnrow.Size = new System.Drawing.Size(137, 54);
            this.btnrow.TabIndex = 14;
            this.btnrow.Text = "Loop Row";
            this.btnrow.UseVisualStyleBackColor = true;
            this.btnrow.Click += new System.EventHandler(this.btnrow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1701, 644);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnrow);
            this.Controls.Add(this.btnCol);
            this.Controls.Add(this.btnFillData);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.btnAddColumn);
            this.Controls.Add(this.dgvTest);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgvTest;
        private System.Windows.Forms.Button btnAddColumn;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Label Employee;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClSalary;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletrToolStripMenuItem;
        private System.Windows.Forms.Button btnFillData;
        private System.Windows.Forms.Button btnCol;
        private System.Windows.Forms.Button btnrow;
    }
}

