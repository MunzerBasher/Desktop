namespace MID
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
            this.btnBackForm = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewClientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.op1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.op2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.findClienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updataClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBlueForm = new System.Windows.Forms.Button();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackForm
            // 
            this.btnBackForm.Location = new System.Drawing.Point(1107, 50);
            this.btnBackForm.Name = "btnBackForm";
            this.btnBackForm.Size = new System.Drawing.Size(165, 80);
            this.btnBackForm.TabIndex = 1;
            this.btnBackForm.Text = "Back Form";
            this.btnBackForm.UseVisualStyleBackColor = true;
            this.btnBackForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewClientToolStripMenuItem1,
            this.deleteClientToolStripMenuItem1,
            this.findClienToolStripMenuItem,
            this.updataClientToolStripMenuItem,
            this.toolStripMenuItem1,
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.findToolStripMenuItem.Text = "&Filet";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // addNewClientToolStripMenuItem1
            // 
            this.addNewClientToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.op1ToolStripMenuItem,
            this.op2ToolStripMenuItem});
            this.addNewClientToolStripMenuItem1.Name = "addNewClientToolStripMenuItem1";
            this.addNewClientToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.addNewClientToolStripMenuItem1.Text = "AddNewClient";
            this.addNewClientToolStripMenuItem1.Click += new System.EventHandler(this.addNewClientToolStripMenuItem1_Click);
            // 
            // op1ToolStripMenuItem
            // 
            this.op1ToolStripMenuItem.Name = "op1ToolStripMenuItem";
            this.op1ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.op1ToolStripMenuItem.Text = "op1";
            // 
            // op2ToolStripMenuItem
            // 
            this.op2ToolStripMenuItem.Name = "op2ToolStripMenuItem";
            this.op2ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.op2ToolStripMenuItem.Text = "op2";
            // 
            // deleteClientToolStripMenuItem1
            // 
            this.deleteClientToolStripMenuItem1.Checked = true;
            this.deleteClientToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deleteClientToolStripMenuItem1.Name = "deleteClientToolStripMenuItem1";
            this.deleteClientToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.deleteClientToolStripMenuItem1.Text = "DeleteClient";
            // 
            // findClienToolStripMenuItem
            // 
            this.findClienToolStripMenuItem.Name = "findClienToolStripMenuItem";
            this.findClienToolStripMenuItem.ShowShortcutKeys = false;
            this.findClienToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.findClienToolStripMenuItem.Text = "FindClien&t";
            this.findClienToolStripMenuItem.Click += new System.EventHandler(this.findClienToolStripMenuItem_Click);
            // 
            // updataClientToolStripMenuItem
            // 
            this.updataClientToolStripMenuItem.Image = global::MID.Properties.Resources.dotnet;
            this.updataClientToolStripMenuItem.Name = "updataClientToolStripMenuItem";
            this.updataClientToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.updataClientToolStripMenuItem.Text = "Updata&Client";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(267, 6);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.loginToolStripMenuItem.Text = "Logi&n";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::MID.Properties.Resources.dotnet;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.ShowShortcutKeys = false;
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.logoutToolStripMenuItem.Text = "Log&out";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whoToolStripMenuItem,
            this.whyToolStripMenuItem,
            this.howToolStripMenuItem,
            this.toolStripMenuItem2});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "He&lp";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // whoToolStripMenuItem
            // 
            this.whoToolStripMenuItem.Checked = true;
            this.whoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.whoToolStripMenuItem.Name = "whoToolStripMenuItem";
            this.whoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.whoToolStripMenuItem.Text = "Wh&o";
            // 
            // whyToolStripMenuItem
            // 
            this.whyToolStripMenuItem.Name = "whyToolStripMenuItem";
            this.whyToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.whyToolStripMenuItem.Text = "Why";
            // 
            // howToolStripMenuItem
            // 
            this.howToolStripMenuItem.Name = "howToolStripMenuItem";
            this.howToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.howToolStripMenuItem.Text = "How";
            // 
            // btnBlueForm
            // 
            this.btnBlueForm.Location = new System.Drawing.Point(1107, 191);
            this.btnBlueForm.Name = "btnBlueForm";
            this.btnBlueForm.Size = new System.Drawing.Size(165, 80);
            this.btnBlueForm.TabIndex = 5;
            this.btnBlueForm.Text = "Blue Form";
            this.btnBlueForm.UseVisualStyleBackColor = true;
            this.btnBlueForm.Click += new System.EventHandler(this.btnBlueForm_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(267, 6);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 100);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 692);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnBlueForm);
            this.Controls.Add(this.btnBackForm);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackForm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewClientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteClientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem findClienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updataClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem op1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem op2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToolStripMenuItem;
        private System.Windows.Forms.Button btnBlueForm;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    }
}

