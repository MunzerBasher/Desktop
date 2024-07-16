using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PIZZA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EnterValue()
        {
            rbmadim.Checked = true;
            rbThink.Checked = true;
            rbeatin.Checked = true;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            EnterValue();
        }


        float ToppingPrice()
        {
            float price = 0;
            if(rccheese.Checked)
            {
                price += 5;
            }
            if(rcgreenpeppers.Checked)
            {
                price += 5;
            }
            if(rcmurshooms.Checked) 
            {
                price += 5;
            }
            if(rcolives.Checked)
            {
                price += 5;
            }
            if(rconion.Checked) 
            {
                price += 5;
            }
            if(rctomatoes.Checked)
            {
                price += 5;
            }
            return price;
        }


        float CurstTypePrice()
        {
            float def = 0;
            if(rbThink.Checked)
            {
                return Convert.ToSingle(rbThink.Tag);
            }
            if (rbTrick.Checked)
            {
                return Convert.ToSingle(rbTrick.Tag);
            }
            return def;
        }

        float SizePrice()
        {
            if (rbsmall.Checked)
            {
                return Convert.ToSingle(rbsmall.Tag);
            }
            if (rbmadim.Checked)
            {
                return Convert.ToSingle(rbmadim.Tag);
            }
            return Convert.ToSingle(rblarge.Tag);
        }

        float CalculateTotalPrice()
        {
            return (SizePrice() + CurstTypePrice() + ToppingPrice());
        }

        void UpdatePrice()
        {
            float price = CalculateTotalPrice();
            lbprice.Text = "$" + price.ToString();
        }

        void UpdateSize()
        {
            UpdatePrice();
            if (rbsmall.Checked)
            {
                lbsize.Text = "Small";
                return;
            }
            if(rbmadim.Checked)
            {
                lbsize.Text = "Midaim";
                return;
            }
            if(rblarge.Checked)
            {
                lbsize.Text = "Large";
                return;
            }
        }

        private void rbsmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbmadim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rblarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void UpdateToppings()
        {
            UpdatePrice();
            string Topp = "";
            if (rccheese.Checked)
            {
                Topp += "cheese";
            }
            if (rcgreenpeppers.Checked)
            {
                Topp += ",green peppers";
            }
            if (rcmurshooms.Checked)
            {
                Topp += ", murshooms";
            }
            if (rcolives.Checked)
            {
                Topp += ", olives";
            }
            if (rconion.Checked)
            {
                Topp += ", onion";
            }
            if (rctomatoes.Checked)
            {
                Topp += ", tomatoes";
            }
            if(Topp == "")
            {
                lbToppings.Text = "No Toppings";
                return;
            }
            if(Topp.StartsWith(",")  )
            {
                Topp = Topp.Substring(1,Topp.Length - 1);
            }
            lbToppings.Text = Topp;
        }

        private void rccheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rcmurshooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rctomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rconion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rcolives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rcgreenpeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void UpdateCurstType()
        {
            UpdatePrice();
            if(rbThink.Checked)
            {
                lbcurst.Text = "Think";
                return;
            }
            if(rbTrick.Checked)
            { 
                lbcurst.Text = "Trick";             
            }
        }

        private void rbThink_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCurstType();
        }

        private void rbTrick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCurstType();
        }

        private void rbeatin_CheckedChanged(object sender, EventArgs e)
        {
            lbEatPlace.Text = "Eat In";
        }

        private void rbeatout_CheckedChanged(object sender, EventArgs e)
        {
            lbEatPlace.Text = "Eat Out";
        }

        private void ResetToppings()
        {
            if (MessageBox.Show("Are Your Sure !", "Camform", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                rccheese.Checked = false;
                rcgreenpeppers.Checked = false;
                rcmurshooms.Checked = false;
                rcolives.Checked = false;
                rconion.Checked = false;
                rctomatoes.Checked = false;
                EnterValue();
                MessageBox.Show("You Complete Succesfully !", "(:-");
            }
        }

        private void btOrderForm_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            Size.Enabled = false;
        }

        private void btSetForm_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            Size.Enabled = true;
            ResetToppings();
        }
    }
}

