namespace PIZZA
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
            this.btOrderForm = new System.Windows.Forms.Button();
            this.btSetForm = new System.Windows.Forms.Button();
            this.rbsmall = new System.Windows.Forms.RadioButton();
            this.rblarge = new System.Windows.Forms.RadioButton();
            this.rbmadim = new System.Windows.Forms.RadioButton();
            this.Size = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbeatout = new System.Windows.Forms.RadioButton();
            this.rbeatin = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rctomatoes = new System.Windows.Forms.CheckBox();
            this.rcgreenpeppers = new System.Windows.Forms.CheckBox();
            this.rcolives = new System.Windows.Forms.CheckBox();
            this.rcmurshooms = new System.Windows.Forms.CheckBox();
            this.rconion = new System.Windows.Forms.CheckBox();
            this.rccheese = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbToppings = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbsize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbprice = new System.Windows.Forms.Label();
            this.TITELE = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbTrick = new System.Windows.Forms.RadioButton();
            this.rbThink = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lbcurst = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbEatPlace = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Size.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btOrderForm
            // 
            this.btOrderForm.Location = new System.Drawing.Point(254, 409);
            this.btOrderForm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btOrderForm.Name = "btOrderForm";
            this.btOrderForm.Size = new System.Drawing.Size(97, 45);
            this.btOrderForm.TabIndex = 0;
            this.btOrderForm.Text = "OrderForm";
            this.btOrderForm.UseVisualStyleBackColor = true;
            this.btOrderForm.Click += new System.EventHandler(this.btOrderForm_Click);
            // 
            // btSetForm
            // 
            this.btSetForm.Location = new System.Drawing.Point(463, 409);
            this.btSetForm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btSetForm.Name = "btSetForm";
            this.btSetForm.Size = new System.Drawing.Size(97, 45);
            this.btSetForm.TabIndex = 1;
            this.btSetForm.Text = "SetForm";
            this.btSetForm.UseVisualStyleBackColor = true;
            this.btSetForm.Click += new System.EventHandler(this.btSetForm_Click);
            // 
            // rbsmall
            // 
            this.rbsmall.AutoSize = true;
            this.rbsmall.Location = new System.Drawing.Point(52, 26);
            this.rbsmall.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbsmall.Name = "rbsmall";
            this.rbsmall.Size = new System.Drawing.Size(75, 25);
            this.rbsmall.TabIndex = 2;
            this.rbsmall.TabStop = true;
            this.rbsmall.Tag = "20";
            this.rbsmall.Text = "Small";
            this.rbsmall.UseVisualStyleBackColor = true;
            this.rbsmall.CheckedChanged += new System.EventHandler(this.rbsmall_CheckedChanged);
            // 
            // rblarge
            // 
            this.rblarge.AutoSize = true;
            this.rblarge.Location = new System.Drawing.Point(52, 117);
            this.rblarge.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rblarge.Name = "rblarge";
            this.rblarge.Size = new System.Drawing.Size(76, 25);
            this.rblarge.TabIndex = 3;
            this.rblarge.TabStop = true;
            this.rblarge.Tag = "40";
            this.rblarge.Text = "Large";
            this.rblarge.UseVisualStyleBackColor = true;
            this.rblarge.CheckedChanged += new System.EventHandler(this.rblarge_CheckedChanged);
            // 
            // rbmadim
            // 
            this.rbmadim.AutoSize = true;
            this.rbmadim.Location = new System.Drawing.Point(52, 71);
            this.rbmadim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbmadim.Name = "rbmadim";
            this.rbmadim.Size = new System.Drawing.Size(85, 25);
            this.rbmadim.TabIndex = 4;
            this.rbmadim.TabStop = true;
            this.rbmadim.Tag = "30";
            this.rbmadim.Text = "Madim";
            this.rbmadim.UseVisualStyleBackColor = true;
            this.rbmadim.CheckedChanged += new System.EventHandler(this.rbmadim_CheckedChanged);
            // 
            // Size
            // 
            this.Size.Controls.Add(this.rbsmall);
            this.Size.Controls.Add(this.rbmadim);
            this.Size.Controls.Add(this.rblarge);
            this.Size.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Size.Location = new System.Drawing.Point(11, 91);
            this.Size.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Size.Name = "Size";
            this.Size.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Size.Size = new System.Drawing.Size(200, 148);
            this.Size.TabIndex = 5;
            this.Size.TabStop = false;
            this.Size.Text = "Size";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbeatout);
            this.groupBox2.Controls.Add(this.rbeatin);
            this.groupBox2.Location = new System.Drawing.Point(254, 267);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(245, 105);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Where To Eat";
            // 
            // rbeatout
            // 
            this.rbeatout.AutoSize = true;
            this.rbeatout.Location = new System.Drawing.Point(141, 37);
            this.rbeatout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbeatout.Name = "rbeatout";
            this.rbeatout.Size = new System.Drawing.Size(97, 25);
            this.rbeatout.TabIndex = 6;
            this.rbeatout.TabStop = true;
            this.rbeatout.Text = "Eat Out";
            this.rbeatout.UseVisualStyleBackColor = true;
            this.rbeatout.CheckedChanged += new System.EventHandler(this.rbeatout_CheckedChanged);
            // 
            // rbeatin
            // 
            this.rbeatin.AutoSize = true;
            this.rbeatin.Location = new System.Drawing.Point(16, 37);
            this.rbeatin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbeatin.Name = "rbeatin";
            this.rbeatin.Size = new System.Drawing.Size(83, 25);
            this.rbeatin.TabIndex = 5;
            this.rbeatin.TabStop = true;
            this.rbeatin.Text = "Eat In";
            this.rbeatin.UseVisualStyleBackColor = true;
            this.rbeatin.CheckedChanged += new System.EventHandler(this.rbeatin_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rctomatoes);
            this.groupBox1.Controls.Add(this.rcgreenpeppers);
            this.groupBox1.Controls.Add(this.rcolives);
            this.groupBox1.Controls.Add(this.rcmurshooms);
            this.groupBox1.Controls.Add(this.rconion);
            this.groupBox1.Controls.Add(this.rccheese);
            this.groupBox1.Location = new System.Drawing.Point(254, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(306, 150);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toppings";
            // 
            // rctomatoes
            // 
            this.rctomatoes.AutoSize = true;
            this.rctomatoes.Location = new System.Drawing.Point(11, 117);
            this.rctomatoes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rctomatoes.Name = "rctomatoes";
            this.rctomatoes.Size = new System.Drawing.Size(107, 25);
            this.rctomatoes.TabIndex = 9;
            this.rctomatoes.Tag = "5";
            this.rctomatoes.Text = "Tomatoes";
            this.rctomatoes.UseVisualStyleBackColor = true;
            this.rctomatoes.CheckedChanged += new System.EventHandler(this.rctomatoes_CheckedChanged);
            // 
            // rcgreenpeppers
            // 
            this.rcgreenpeppers.AutoSize = true;
            this.rcgreenpeppers.Location = new System.Drawing.Point(171, 108);
            this.rcgreenpeppers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rcgreenpeppers.Name = "rcgreenpeppers";
            this.rcgreenpeppers.Size = new System.Drawing.Size(138, 25);
            this.rcgreenpeppers.TabIndex = 10;
            this.rcgreenpeppers.Tag = "5";
            this.rcgreenpeppers.Text = "GreenPeppers";
            this.rcgreenpeppers.UseVisualStyleBackColor = true;
            this.rcgreenpeppers.CheckedChanged += new System.EventHandler(this.rcgreenpeppers_CheckedChanged);
            // 
            // rcolives
            // 
            this.rcolives.AutoSize = true;
            this.rcolives.Location = new System.Drawing.Point(171, 64);
            this.rcolives.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rcolives.Name = "rcolives";
            this.rcolives.Size = new System.Drawing.Size(78, 25);
            this.rcolives.TabIndex = 13;
            this.rcolives.Tag = "5";
            this.rcolives.Text = "Olives";
            this.rcolives.UseVisualStyleBackColor = true;
            this.rcolives.CheckedChanged += new System.EventHandler(this.rcolives_CheckedChanged);
            // 
            // rcmurshooms
            // 
            this.rcmurshooms.AutoSize = true;
            this.rcmurshooms.Location = new System.Drawing.Point(11, 71);
            this.rcmurshooms.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rcmurshooms.Name = "rcmurshooms";
            this.rcmurshooms.Size = new System.Drawing.Size(120, 25);
            this.rcmurshooms.TabIndex = 14;
            this.rcmurshooms.Tag = "5";
            this.rcmurshooms.Text = "Murshooms";
            this.rcmurshooms.UseVisualStyleBackColor = true;
            this.rcmurshooms.CheckedChanged += new System.EventHandler(this.rcmurshooms_CheckedChanged);
            // 
            // rconion
            // 
            this.rconion.AutoSize = true;
            this.rconion.Location = new System.Drawing.Point(171, 20);
            this.rconion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rconion.Name = "rconion";
            this.rconion.Size = new System.Drawing.Size(77, 25);
            this.rconion.TabIndex = 15;
            this.rconion.Tag = "5";
            this.rconion.Text = "Onion";
            this.rconion.UseVisualStyleBackColor = true;
            this.rconion.CheckedChanged += new System.EventHandler(this.rconion_CheckedChanged);
            // 
            // rccheese
            // 
            this.rccheese.AutoSize = true;
            this.rccheese.Location = new System.Drawing.Point(11, 25);
            this.rccheese.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rccheese.Name = "rccheese";
            this.rccheese.Size = new System.Drawing.Size(142, 25);
            this.rccheese.TabIndex = 8;
            this.rccheese.Tag = "5";
            this.rccheese.Text = "Extra Cheeses";
            this.rccheese.UseVisualStyleBackColor = true;
            this.rccheese.CheckedChanged += new System.EventHandler(this.rccheese_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbEatPlace);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.lbcurst);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.lbToppings);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.lbsize);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(587, 91);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Size = new System.Drawing.Size(201, 257);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Order Summary";
            // 
            // lbToppings
            // 
            this.lbToppings.AutoSize = true;
            this.lbToppings.Location = new System.Drawing.Point(70, 129);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(0, 21);
            this.lbToppings.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Toppings :";
            // 
            // lbsize
            // 
            this.lbsize.AutoSize = true;
            this.lbsize.Location = new System.Drawing.Point(98, 33);
            this.lbsize.Name = "lbsize";
            this.lbsize.Size = new System.Drawing.Size(54, 21);
            this.lbsize.TabIndex = 1;
            this.lbsize.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size :";
            // 
            // lbprice
            // 
            this.lbprice.AutoSize = true;
            this.lbprice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprice.ForeColor = System.Drawing.Color.Green;
            this.lbprice.Location = new System.Drawing.Point(702, 385);
            this.lbprice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbprice.Name = "lbprice";
            this.lbprice.Size = new System.Drawing.Size(52, 55);
            this.lbprice.TabIndex = 10;
            this.lbprice.Text = "0";
            // 
            // TITELE
            // 
            this.TITELE.AutoSize = true;
            this.TITELE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TITELE.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITELE.ForeColor = System.Drawing.Color.ForestGreen;
            this.TITELE.Location = new System.Drawing.Point(205, 9);
            this.TITELE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TITELE.Name = "TITELE";
            this.TITELE.Size = new System.Drawing.Size(479, 58);
            this.TITELE.TabIndex = 11;
            this.TITELE.Text = "MAKE YOUR PIZZA";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbTrick);
            this.groupBox3.Controls.Add(this.rbThink);
            this.groupBox3.Location = new System.Drawing.Point(5, 267);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(206, 105);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CurstType";
            // 
            // rbTrick
            // 
            this.rbTrick.AutoSize = true;
            this.rbTrick.Location = new System.Drawing.Point(119, 37);
            this.rbTrick.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbTrick.Name = "rbTrick";
            this.rbTrick.Size = new System.Drawing.Size(71, 25);
            this.rbTrick.TabIndex = 6;
            this.rbTrick.TabStop = true;
            this.rbTrick.Tag = "10";
            this.rbTrick.Text = "Trick";
            this.rbTrick.UseVisualStyleBackColor = true;
            this.rbTrick.CheckedChanged += new System.EventHandler(this.rbTrick_CheckedChanged);
            // 
            // rbThink
            // 
            this.rbThink.AutoSize = true;
            this.rbThink.Location = new System.Drawing.Point(16, 37);
            this.rbThink.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbThink.Name = "rbThink";
            this.rbThink.Size = new System.Drawing.Size(75, 25);
            this.rbThink.TabIndex = 5;
            this.rbThink.TabStop = true;
            this.rbThink.Tag = "0";
            this.rbThink.Text = "Think";
            this.rbThink.UseVisualStyleBackColor = true;
            this.rbThink.CheckedChanged += new System.EventHandler(this.rbThink_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "CurstType :";
            // 
            // lbcurst
            // 
            this.lbcurst.AutoSize = true;
            this.lbcurst.Location = new System.Drawing.Point(107, 165);
            this.lbcurst.Name = "lbcurst";
            this.lbcurst.Size = new System.Drawing.Size(0, 21);
            this.lbcurst.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Where To Eat :";
            // 
            // lbEatPlace
            // 
            this.lbEatPlace.AutoSize = true;
            this.lbEatPlace.Location = new System.Drawing.Point(153, 215);
            this.lbEatPlace.Name = "lbEatPlace";
            this.lbEatPlace.Size = new System.Drawing.Size(0, 21);
            this.lbEatPlace.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(591, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 478);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.TITELE);
            this.Controls.Add(this.lbprice);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.btSetForm);
            this.Controls.Add(this.btOrderForm);
            this.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Size.ResumeLayout(false);
            this.Size.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOrderForm;
        private System.Windows.Forms.Button btSetForm;
        private System.Windows.Forms.RadioButton rbsmall;
        private System.Windows.Forms.RadioButton rblarge;
        private System.Windows.Forms.RadioButton rbmadim;
        private System.Windows.Forms.GroupBox Size;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbeatout;
        private System.Windows.Forms.RadioButton rbeatin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox rccheese;
        private System.Windows.Forms.CheckBox rctomatoes;
        private System.Windows.Forms.CheckBox rcgreenpeppers;
        private System.Windows.Forms.CheckBox rcolives;
        private System.Windows.Forms.CheckBox rcmurshooms;
        private System.Windows.Forms.CheckBox rconion;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbprice;
        private System.Windows.Forms.Label TITELE;
        private System.Windows.Forms.Label lbsize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbTrick;
        private System.Windows.Forms.RadioButton rbThink;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbcurst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbEatPlace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

