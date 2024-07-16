namespace TestForms
{
    partial class MainPag
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btclients = new System.Windows.Forms.Button();
            this.btusers = new System.Windows.Forms.Button();
            this.btmain = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btclients);
            this.panel1.Controls.Add(this.btusers);
            this.panel1.Controls.Add(this.btmain);
            this.panel1.Location = new System.Drawing.Point(919, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 643);
            this.panel1.TabIndex = 0;
            // 
            // btclients
            // 
            this.btclients.Location = new System.Drawing.Point(25, 297);
            this.btclients.Name = "btclients";
            this.btclients.Size = new System.Drawing.Size(172, 57);
            this.btclients.TabIndex = 2;
            this.btclients.Text = "clients";
            this.btclients.UseVisualStyleBackColor = true;
            this.btclients.Click += new System.EventHandler(this.button3_Click);
            // 
            // btusers
            // 
            this.btusers.Location = new System.Drawing.Point(25, 177);
            this.btusers.Name = "btusers";
            this.btusers.Size = new System.Drawing.Size(172, 57);
            this.btusers.TabIndex = 1;
            this.btusers.Text = "users";
            this.btusers.UseVisualStyleBackColor = true;
            this.btusers.Click += new System.EventHandler(this.button2_Click);
            // 
            // btmain
            // 
            this.btmain.Location = new System.Drawing.Point(25, 67);
            this.btmain.Name = "btmain";
            this.btmain.Size = new System.Drawing.Size(172, 57);
            this.btmain.TabIndex = 0;
            this.btmain.Text = "Main";
            this.btmain.UseVisualStyleBackColor = true;
            this.btmain.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Location = new System.Drawing.Point(0, -3);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(921, 643);
            this.pnlContainer.TabIndex = 1;
            // 
            // MainPag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 644);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.panel1);
            this.Name = "MainPag";
            this.Text = "MainPag";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btclients;
        private System.Windows.Forms.Button btusers;
        private System.Windows.Forms.Button btmain;
    }
}

