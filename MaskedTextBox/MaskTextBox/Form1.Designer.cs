namespace MaskTextBox
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node11");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node12");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node13");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node14");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node15");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Node16");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Node17");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Node3", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Node18");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Node19");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Node20");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Node21");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Node22");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Node4", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22});
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BeepOnError = true;
            this.maskedTextBox1.Location = new System.Drawing.Point(92, 22);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PromptChar = '-';
            this.maskedTextBox1.Size = new System.Drawing.Size(449, 26);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "p1",
            "p2",
            "p3",
            "p4"});
            this.comboBox1.Location = new System.Drawing.Point(92, 316);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(92, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MaskTextBox.Properties.Resources.Q;
            this.pictureBox1.Location = new System.Drawing.Point(92, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(329, 99);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node5";
            treeNode1.Text = "Node5";
            treeNode2.Name = "Node6";
            treeNode2.Text = "Node6";
            treeNode3.Name = "Node7";
            treeNode3.Text = "Node7";
            treeNode4.Name = "Node8";
            treeNode4.Text = "Node8";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Node0";
            treeNode6.Name = "Node9";
            treeNode6.Text = "Node9";
            treeNode7.Name = "Node10";
            treeNode7.Text = "Node10";
            treeNode8.Name = "Node11";
            treeNode8.Text = "Node11";
            treeNode9.Name = "Node1";
            treeNode9.Text = "Node1";
            treeNode10.Name = "Node12";
            treeNode10.Text = "Node12";
            treeNode11.Name = "Node13";
            treeNode11.Text = "Node13";
            treeNode12.Name = "Node14";
            treeNode12.Text = "Node14";
            treeNode13.Name = "Node2";
            treeNode13.Text = "Node2";
            treeNode14.Name = "Node15";
            treeNode14.Text = "Node15";
            treeNode15.Name = "Node16";
            treeNode15.Text = "Node16";
            treeNode16.Name = "Node17";
            treeNode16.Text = "Node17";
            treeNode17.Name = "Node3";
            treeNode17.Text = "Node3";
            treeNode18.Name = "Node18";
            treeNode18.Text = "Node18";
            treeNode19.Name = "Node19";
            treeNode19.Text = "Node19";
            treeNode20.Name = "Node20";
            treeNode20.Text = "Node20";
            treeNode21.Name = "Node21";
            treeNode21.Text = "Node21";
            treeNode22.Name = "Node22";
            treeNode22.Text = "Node22";
            treeNode23.Name = "Node4";
            treeNode23.Text = "Node4";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode9,
            treeNode13,
            treeNode17,
            treeNode23});
            this.treeView1.Size = new System.Drawing.Size(459, 300);
            this.treeView1.TabIndex = 5;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView treeView1;
    }
}

