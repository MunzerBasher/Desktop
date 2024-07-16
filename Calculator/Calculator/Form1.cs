using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        int Number1 = 0;
        int Number2 = 0;
        int ReSault = 0;
        string Ope = "?";
        int N1 = 0;
        int N2 = 0;

        private int Abs(int value)
        {
            if (value > 0)
                return value;
            return -1 * value;
        }

        private int Pow(int pow, int Number)
        {
            int result = 1;
            if (Number == 0)
                return 0;
            else if(Number == 1)
                return 1;
            if (pow == 0)
                return 1;
            if (pow == 1)
                return Number;
            else
                for(int i = 0; i < pow; i++)
                {
                    result *= Number;
                }
                return result;
        }
        private int Divide(int value1 , int value2)
        {
            if(value1 == 0)
                return 0;
            if(value2 == 0)
                value2 = 1;
            return value1 / value2;
        }
        private int Mod(int value1, int value2)
        {
            return value1 % value2;
        }
        private int Sum(int value1, int value2)
        {
            return (value1 + value2);
        }
        private int Mult(int value1, int value2)
        {
            return value2 * value1;
        }
        private int Abstrc(int value1, int value2)
        {
            return value1 - value2;
        }
        public Calculator()
        {
            InitializeComponent();
        }
        private int ConvertStringToInt(Button b)
        {
            string str = b.Text;
            return int.Parse(str); 
        }

        private int MakeNumber(int B)
        {
            return (B * 10);
        }
        private int CalculatorAction()
        {
            if (Ope == "+")
                return Sum(Number1, Number2);
            else if(Ope == "-")
                return Abstrc(Number1,Number2);
            else if (Ope == "x")
                return Mult(Number1,Number2);
            else if (Ope == "/")
                return Divide(Number1, Number2);
            else if (Ope == "%")
                return Mod(Number1 , Number2);
            else if (Ope == "|X|")
                return Abs(Number1);
            else if (Ope == "pow")
                return Pow(Number2, Number1);
            return 0;
        }

        private void FullNumbers(object sender, EventArgs e)
        {
            string n1 = Number1.ToString();
            string n2 = Number2.ToString();

            if (Ope == "?")
            {
                if (n1.Length > 8)
                    return;
                N1 = Number1;
                Number1 = ConvertStringToInt((Button)sender);
                if (Number1 != 0)
                {
                    N1 = MakeNumber(N1);
                    Number1 += N1;                   
                }
                else
                {
                    Number1 = N1 * 10;
                }
                tb2.Text = Number1.ToString();
            }
            else
            {
                if (n2.Length > 8)
                    return;
                N2 = Number2;
                Number2 = ConvertStringToInt((Button)sender);
                if (Number2 != 0)
                {
                    N2 = MakeNumber(N2);
                    Number2 += N2;
                }
                else
                {
                    Number2 = N2 * 10;
                }
                tb2.Text = Number2.ToString();
            }

           
        }
        
        private void SetColors()
        {
            foreach (Control c in this.Controls)
            {
                if (c == tb1 || c == tb2)
                    continue;
                c.BackColor = Color.DeepSkyBlue;
            }
        }
     
       
        private void ChangeOpe(object sender, EventArgs e)
        {
            Ope = ((Button)sender).Text;
            SetColors();
            ((Button)sender).BackColor = Color.Brown;
            tb1.Text = Number1.ToString();
        }
        private int DeleteFromNumber(int Number)
        {
            if(Number < 10)
            {
                return 0;
            }
            return Number / 10;
        }
        private void DeleteNumbers()
        {
            if(Number1 == 0  && Number2 == 0 && Ope == "?" && tb1.Text == "") 
            {
                return;
            }
            else
            {
                if (Number2 != 0)
                {
                    Number2 = DeleteFromNumber(Number2);
                    tb2.Text = Number2.ToString();
                }
                else if (Number1 != 0)
                {
                    Number1 = DeleteFromNumber(Number1);
                    tb2.Text = Number1.ToString();
                }
                else if (Ope != "?")
                {
                    Ope = "?";
                }
                else
                {
                    
                    ReSault = 0;
                    tb1.Text = "";
                }

               
            }
        }

        private void DeleteEvens(object sender, EventArgs e)
        {
            DeleteNumbers();
        }
        private void Equal()
        {
            ReSault = CalculatorAction();
            tb1.Text = ReSault.ToString();
        }


        private void Equal(object sender, EventArgs e)
        {
            Equal();
            SetColors();
            Number1 = ReSault;
            tb2.Text = "";
            Number2 = 0;
        }

        private void AfterClickedDotOpr()
        {

        }

    }

}
