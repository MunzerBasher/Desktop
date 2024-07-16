namespace CheckBox
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShowGaza = new System.Windows.Forms.Button();
            this.ShowAbo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AccessibleDescription = "";
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(12, 0);
            this.textBox1.MaxLength = 30;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '#';
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(260, 82);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::CheckBox.Properties.Resources.Gaza;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::CheckBox.Properties.Resources.AboAb;
            this.pictureBox1.Location = new System.Drawing.Point(233, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.pictureBox1.Size = new System.Drawing.Size(362, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ShowGaza
            // 
            this.ShowGaza.Location = new System.Drawing.Point(466, 380);
            this.ShowGaza.Name = "ShowGaza";
            this.ShowGaza.Size = new System.Drawing.Size(129, 58);
            this.ShowGaza.TabIndex = 2;
            this.ShowGaza.Text = "Gaza";
            this.ShowGaza.UseVisualStyleBackColor = true;
            this.ShowGaza.Click += new System.EventHandler(this.ShowGaza_Click);
            // 
            // ShowAbo
            // 
            this.ShowAbo.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.ShowAbo.FlatAppearance.BorderSize = 20;
            this.ShowAbo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ShowAbo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ShowAbo.Location = new System.Drawing.Point(233, 380);
            this.ShowAbo.Name = "ShowAbo";
            this.ShowAbo.Size = new System.Drawing.Size(129, 58);
            this.ShowAbo.TabIndex = 3;
            this.ShowAbo.Text = "Abo Abida";
            this.ShowAbo.UseVisualStyleBackColor = true;
            this.ShowAbo.Click += new System.EventHandler(this.ShowAbo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ShowAbo);
            this.Controls.Add(this.ShowGaza);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ShowGaza;
        private System.Windows.Forms.Button ShowAbo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

