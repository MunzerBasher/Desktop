namespace MID
{
    partial class Login
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
            this.ChangeColor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ChangeFont = new System.Windows.Forms.ToolStripTextBox();
            this.Clear = new System.Windows.Forms.ToolStripTextBox();
            this.changeBackColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChangeColor
            // 
            this.ChangeColor.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ChangeColor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeFont,
            this.Clear,
            this.changeBackColorToolStripMenuItem});
            this.ChangeColor.Name = "ChangeColor";
            this.ChangeColor.Size = new System.Drawing.Size(224, 106);
            this.ChangeColor.Text = "ChangeColor";
            // 
            // ChangeFont
            // 
            this.ChangeFont.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ChangeFont.Name = "ChangeFont";
            this.ChangeFont.Size = new System.Drawing.Size(100, 31);
            this.ChangeFont.Text = "ChangeFont";
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(100, 31);
            this.Clear.Text = "Clear";
            // 
            // changeBackColorToolStripMenuItem
            // 
            this.changeBackColorToolStripMenuItem.Name = "changeBackColorToolStripMenuItem";
            this.changeBackColorToolStripMenuItem.Size = new System.Drawing.Size(223, 32);
            this.changeBackColorToolStripMenuItem.Text = "ChangeBackColor";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(960, 748);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.TopMost = true;
            this.ChangeColor.ResumeLayout(false);
            this.ChangeColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip ChangeColor;
        private System.Windows.Forms.ToolStripTextBox ChangeFont;
        private System.Windows.Forms.ToolStripTextBox Clear;
        private System.Windows.Forms.ToolStripMenuItem changeBackColorToolStripMenuItem;
    }
}