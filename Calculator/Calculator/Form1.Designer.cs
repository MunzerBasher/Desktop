namespace Calculator
{
    partial class Calculator
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
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.btmod = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btc = new System.Windows.Forms.Button();
            this.btce = new System.Windows.Forms.Button();
            this.btPower = new System.Windows.Forms.Button();
            this.btsquar = new System.Windows.Forms.Button();
            this.btdivive = new System.Windows.Forms.Button();
            this.btAbsu = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.btmalt = new System.Windows.Forms.Button();
            this.btmian = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.btzero = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btdot = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.btequal = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btsum = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Enabled = false;
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tb1.Location = new System.Drawing.Point(12, 14);
            this.tb1.Multiline = true;
            this.tb1.Name = "tb1";
            this.tb1.ReadOnly = true;
            this.tb1.Size = new System.Drawing.Size(490, 175);
            this.tb1.TabIndex = 0;
           
            // tb2
            // 
            this.tb2.Enabled = false;
            this.tb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tb2.Location = new System.Drawing.Point(12, 70);
            this.tb2.Multiline = true;
            this.tb2.Name = "tb2";
            this.tb2.ReadOnly = true;
            this.tb2.Size = new System.Drawing.Size(490, 119);
            this.tb2.TabIndex = 0;
           
            // btmod
            // 
            this.btmod.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btmod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmod.Location = new System.Drawing.Point(12, 209);
            this.btmod.Name = "btmod";
            this.btmod.Size = new System.Drawing.Size(118, 63);
            this.btmod.TabIndex = 2;
            this.btmod.Text = "%";
            this.btmod.UseVisualStyleBackColor = false;
            this.btmod.Click += new System.EventHandler(this.ChangeOpe);
            // 
            // btdelete
            // 
            this.btdelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdelete.Location = new System.Drawing.Point(384, 209);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(118, 63);
            this.btdelete.TabIndex = 3;
            this.btdelete.Text = "del";
            this.btdelete.UseVisualStyleBackColor = false;
            this.btdelete.Click += new System.EventHandler(this.DeleteEvens);
            // 
            // btc
            // 
            this.btc.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btc.Location = new System.Drawing.Point(260, 209);
            this.btc.Name = "btc";
            this.btc.Size = new System.Drawing.Size(118, 63);
            this.btc.TabIndex = 4;
            this.btc.Text = "C";
            this.btc.UseVisualStyleBackColor = false;
            this.btc.Click += new System.EventHandler(this.ChangeOpe);
            // 
            // btce
            // 
            this.btce.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btce.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btce.Location = new System.Drawing.Point(136, 209);
            this.btce.Name = "btce";
            this.btce.Size = new System.Drawing.Size(118, 63);
            this.btce.TabIndex = 5;
            this.btce.Text = "CE";
            this.btce.UseVisualStyleBackColor = false;
            this.btce.Click += new System.EventHandler(this.ChangeOpe);
            // 
            // btPower
            // 
            this.btPower.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPower.Location = new System.Drawing.Point(136, 278);
            this.btPower.Name = "btPower";
            this.btPower.Size = new System.Drawing.Size(118, 63);
            this.btPower.TabIndex = 9;
            this.btPower.Text = "pow";
            this.btPower.UseVisualStyleBackColor = false;
            this.btPower.Click += new System.EventHandler(this.ChangeOpe);
            // 
            // btsquar
            // 
            this.btsquar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btsquar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsquar.Location = new System.Drawing.Point(260, 278);
            this.btsquar.Name = "btsquar";
            this.btsquar.Size = new System.Drawing.Size(118, 63);
            this.btsquar.TabIndex = 8;
            this.btsquar.Text = "x/";
            this.btsquar.UseVisualStyleBackColor = false;
            this.btsquar.Click += new System.EventHandler(this.ChangeOpe);
            // 
            // btdivive
            // 
            this.btdivive.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btdivive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdivive.Location = new System.Drawing.Point(384, 278);
            this.btdivive.Name = "btdivive";
            this.btdivive.Size = new System.Drawing.Size(118, 63);
            this.btdivive.TabIndex = 7;
            this.btdivive.Text = "/";
            this.btdivive.UseVisualStyleBackColor = false;
            this.btdivive.Click += new System.EventHandler(this.ChangeOpe);
            // 
            // btAbsu
            // 
            this.btAbsu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btAbsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbsu.Location = new System.Drawing.Point(12, 278);
            this.btAbsu.Name = "btAbsu";
            this.btAbsu.Size = new System.Drawing.Size(118, 63);
            this.btAbsu.TabIndex = 6;
            this.btAbsu.Text = "|x|";
            this.btAbsu.UseVisualStyleBackColor = false;
            this.btAbsu.Click += new System.EventHandler(this.ChangeOpe);
            // 
            // bt8
            // 
            this.bt8.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.Location = new System.Drawing.Point(136, 347);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(118, 63);
            this.bt8.TabIndex = 13;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = false;
            this.bt8.Click += new System.EventHandler(this.FullNumbers);
            // 
            // btmalt
            // 
            this.btmalt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btmalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmalt.Location = new System.Drawing.Point(384, 347);
            this.btmalt.Name = "btmalt";
            this.btmalt.Size = new System.Drawing.Size(118, 63);
            this.btmalt.TabIndex = 12;
            this.btmalt.Text = "x";
            this.btmalt.UseVisualStyleBackColor = false;
            this.btmalt.Click += new System.EventHandler(this.ChangeOpe);
            // 
            // btmian
            // 
            this.btmian.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btmian.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmian.Location = new System.Drawing.Point(384, 416);
            this.btmian.Name = "btmian";
            this.btmian.Size = new System.Drawing.Size(118, 63);
            this.btmian.TabIndex = 11;
            this.btmian.Text = "-";
            this.btmian.UseVisualStyleBackColor = false;
            this.btmian.Click += new System.EventHandler(this.ChangeOpe);
            // 
            // bt7
            // 
            this.bt7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.Location = new System.Drawing.Point(12, 347);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(118, 63);
            this.bt7.TabIndex = 10;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = false;
            this.bt7.Click += new System.EventHandler(this.FullNumbers);
            // 
            // btzero
            // 
            this.btzero.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btzero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btzero.Location = new System.Drawing.Point(136, 554);
            this.btzero.Name = "btzero";
            this.btzero.Size = new System.Drawing.Size(118, 63);
            this.btzero.TabIndex = 17;
            this.btzero.Text = "0";
            this.btzero.UseVisualStyleBackColor = false;
            this.btzero.Click += new System.EventHandler(this.FullNumbers);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(260, 485);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(118, 63);
            this.bt3.TabIndex = 16;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.FullNumbers);
            // 
            // btdot
            // 
            this.btdot.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btdot.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdot.Location = new System.Drawing.Point(260, 554);
            this.btdot.Name = "btdot";
            this.btdot.Size = new System.Drawing.Size(118, 63);
            this.btdot.TabIndex = 15;
            this.btdot.Text = ".";
            this.btdot.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(12, 554);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(118, 63);
            this.button16.TabIndex = 14;
            this.button16.Text = "+/-";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(136, 485);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(118, 63);
            this.bt2.TabIndex = 21;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.FullNumbers);
            // 
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.Location = new System.Drawing.Point(260, 416);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(118, 63);
            this.bt6.TabIndex = 20;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.FullNumbers);
            // 
            // btequal
            // 
            this.btequal.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btequal.Location = new System.Drawing.Point(384, 554);
            this.btequal.Name = "btequal";
            this.btequal.Size = new System.Drawing.Size(118, 63);
            this.btequal.TabIndex = 19;
            this.btequal.Text = "=";
            this.btequal.UseVisualStyleBackColor = false;
            this.btequal.Click += new System.EventHandler(this.Equal);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(12, 485);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(118, 63);
            this.bt1.TabIndex = 18;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.FullNumbers);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.Location = new System.Drawing.Point(136, 416);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(118, 63);
            this.bt5.TabIndex = 25;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.FullNumbers);
            // 
            // bt9
            // 
            this.bt9.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.Location = new System.Drawing.Point(260, 347);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(118, 63);
            this.bt9.TabIndex = 24;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = false;
            this.bt9.Click += new System.EventHandler(this.FullNumbers);
            // 
            // btsum
            // 
            this.btsum.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsum.Location = new System.Drawing.Point(384, 485);
            this.btsum.Name = "btsum";
            this.btsum.Size = new System.Drawing.Size(118, 63);
            this.btsum.TabIndex = 23;
            this.btsum.Text = "+";
            this.btsum.UseVisualStyleBackColor = false;
            this.btsum.Click += new System.EventHandler(this.ChangeOpe);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.Location = new System.Drawing.Point(12, 416);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(118, 63);
            this.bt4.TabIndex = 22;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.FullNumbers);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(513, 628);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.btsum);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.btequal);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.btzero);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.btdot);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.btmalt);
            this.Controls.Add(this.btmian);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.btPower);
            this.Controls.Add(this.btsquar);
            this.Controls.Add(this.btdivive);
            this.Controls.Add(this.btAbsu);
            this.Controls.Add(this.btce);
            this.Controls.Add(this.btc);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btmod);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Name = "Calculator";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Calculator";
            this.Click += new System.EventHandler(this.ChangeOpe);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Button btmod;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btc;
        private System.Windows.Forms.Button btce;
        private System.Windows.Forms.Button btPower;
        private System.Windows.Forms.Button btsquar;
        private System.Windows.Forms.Button btdivive;
        private System.Windows.Forms.Button btAbsu;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button btmalt;
        private System.Windows.Forms.Button btmian;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button btzero;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button btdot;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button btequal;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btsum;
        private System.Windows.Forms.Button bt4;
    }
}

