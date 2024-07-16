namespace Dialogs
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btChangeBackColor = new System.Windows.Forms.Button();
            this.btChangeForeColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btChangeFontColor = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(380, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "I am Just Try";
            // 
            // btChangeBackColor
            // 
            this.btChangeBackColor.Location = new System.Drawing.Point(200, 177);
            this.btChangeBackColor.Name = "btChangeBackColor";
            this.btChangeBackColor.Size = new System.Drawing.Size(181, 46);
            this.btChangeBackColor.TabIndex = 1;
            this.btChangeBackColor.Text = "Change Back Color";
            this.btChangeBackColor.UseVisualStyleBackColor = true;
            this.btChangeBackColor.Click += new System.EventHandler(this.btChangeBackColor_Click);
            // 
            // btChangeForeColor
            // 
            this.btChangeForeColor.Location = new System.Drawing.Point(399, 177);
            this.btChangeForeColor.Name = "btChangeForeColor";
            this.btChangeForeColor.Size = new System.Drawing.Size(181, 46);
            this.btChangeForeColor.TabIndex = 2;
            this.btChangeForeColor.Text = "Change Fore Color";
            this.btChangeForeColor.UseVisualStyleBackColor = true;
            this.btChangeForeColor.Click += new System.EventHandler(this.btChangeFontColor_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.IndianRed;
            // 
            // btChangeFontColor
            // 
            this.btChangeFontColor.Location = new System.Drawing.Point(200, 272);
            this.btChangeFontColor.Name = "btChangeFontColor";
            this.btChangeFontColor.Size = new System.Drawing.Size(181, 46);
            this.btChangeFontColor.TabIndex = 3;
            this.btChangeFontColor.Text = "Change Font Color";
            this.btChangeFontColor.UseVisualStyleBackColor = true;
            this.btChangeFontColor.Click += new System.EventHandler(this.btChangeFontColor_Click_1);
            // 
            // fontDialog1
            // 
            this.fontDialog1.MaxSize = 10;
            this.fontDialog1.ShowApply = true;
            this.fontDialog1.ShowColor = true;
            this.fontDialog1.ShowHelp = true;
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btChangeFontColor);
            this.Controls.Add(this.btChangeForeColor);
            this.Controls.Add(this.btChangeBackColor);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btChangeBackColor;
        private System.Windows.Forms.Button btChangeForeColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btChangeFontColor;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

