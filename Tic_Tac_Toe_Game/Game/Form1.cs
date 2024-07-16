using Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        int[,] arr = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        int GawlaNumber = 0;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color Black = Color.FromArgb(255, 255, 255, 255);
            Pen pen = new Pen(Black);
            pen.Width = 10;

            // pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawRectangle(pen, 300, 100, 300, 300);
            // Horizontal Lines 
            e.Graphics.DrawLine(pen, 300, 200, 600, 200);
            e.Graphics.DrawLine(pen, 300, 300, 600, 300);

            // Vertical Lines

            e.Graphics.DrawLine(pen, 400, 100, 400, 400);
            e.Graphics.DrawLine(pen, 500, 100, 500, 400);
        }

        private void MakeArrayZero()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = 0;
                }
            }
        }

        private void Start()
        {
            lbTurn.Text = "Player 1";
            GawlaNumber = 0;
            lbWinerValue.Text = "In Progress";
            pb1.Image = Resources.Q;
            pb2.Image = Resources.Q;
            pb3.Image = Resources.Q;
            pb4.Image = Resources.Q;
            pb5.Image = Resources.Q;
            pb6.Image = Resources.Q;
            pb7.Image = Resources.Q;
            pb8.Image = Resources.Q;
            pb9.Image = Resources.Q;

            MakeArrayZero();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            Start();
        }

        bool IsRowEqual(int PlN, int Row)
        {
            for (int i = 0; i < 3; i++)
            {
                if (arr[Row, i] != PlN)
                    return false;
            }

            return true;
        }

        bool IsColEqual(int PlN, int Col)
        {
            for (int i = 0; i < 3; i++)
            {
                if (arr[i, Col] != PlN)
                    return false;
            }

            return true;
        }

        bool CheckRows(int PlN)
        {
            return (IsRowEqual(PlN, 0) || IsRowEqual(PlN, 1) || IsRowEqual(PlN, 2));
        }

        bool CheckColom(int PlN)
        {
            return (IsColEqual(PlN, 0) || IsColEqual(PlN, 1) || IsColEqual(PlN, 2));

        }

        bool IsDiaEqual(int PlN)
        {
            for (int i = 0; i < 3; i++)
            {
                if (arr[i, i] != PlN)
                    return false;
            }

            return true;
        }

        bool IsINDiaEqual(int PlN)
        {
            int j = 0;
            for (int i = 2; i >= 0; i--)
            {
                if (arr[j++, i] != PlN)
                    return false;
            }

            return true;
        }

        bool IsWinner(int PlN)
        {
            return (CheckRows(PlN) || CheckColom(PlN) || IsDiaEqual(PlN) || IsINDiaEqual(PlN));
        }

        void SendMessage()
        {
            MessageBox.Show("Game Over , ReStart The Game", "CamForm", MessageBoxButtons.OK);
        }

        bool DeFindWinner()
        {
            if (IsWinner(1))
            {
                lbWinerValue.Text = "Player 1";
                MessageBox.Show("Player 1 Is Winner", "CamForm", MessageBoxButtons.OK);
                return true;
            }
            else if (IsWinner(2))
            {
                lbWinerValue.Text = "Player 2";
                MessageBox.Show("Player 2 Is Winner", "CamForm", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }

        bool IsIndexPlay(int row, int col)
        {
            return (arr[row, col] != 0);
        }

        bool StartGame(int row, int col)
        {
            ++GawlaNumber;
            if (GawlaNumber > 9)
            {
                lbWinerValue.Text = "Drawn";
                SendMessage();
                return false;
            }
            if (IsIndexPlay(row, col))
            {
                MessageBox.Show("Play In Empty Place", "CamForm", MessageBoxButtons.OK);
                return false;
            }
            if (lbTurn.Text == "Player 1")
            {
                arr[row, col] = 1;
                lbTurn.Text = "Player 2";
            }
            else if (lbTurn.Text == "Player 2")
            {
                arr[row, col] = 2;
                lbTurn.Text = "Player 1";
            }
            return true;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if (StartGame(0, 0))
            {

            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (StartGame(0, 1))
            {
                if (lbTurn.Text == "Player 1")
                {
                    bt2.Image = Resources.O;
                }
                else if (lbTurn.Text == "Player 1")
                {
                    bt2.Image = Resources.X;
                }
            }
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (StartGame(0, 2))
            {
                if (lbTurn.Text == "Player 1")
                {
                    bt3.Image = Resources.O;
                }
                else if (lbTurn.Text == "Player 1")
                {
                    bt3.Image = Resources.X;
                }
            }
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (StartGame(1, 0))
            {
                if (lbTurn.Text == "Player 1")
                {
                    bt4.Image = Resources.O;
                }
                else if (lbTurn.Text == "Player 1")
                {
                    bt4.Image = Resources.X;
                }
            }
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (StartGame(1, 1))
            {
                if (lbTurn.Text == "Player 1")
                {
                    bt5.Image = Resources.O;
                }
                else if (lbTurn.Text == "Player 1")
                {
                    bt5.Image = Resources.X;
                }
            }
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (StartGame(1, 2))
            {
                if (lbTurn.Text == "Player 1")
                {
                    bt6.Image = Resources.O;
                }
                else if (lbTurn.Text == "Player 1")
                {
                    bt6.Image = Resources.X;
                }
            }
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if (StartGame(2, 0))
            {
                if (lbTurn.Text == "Player 1")
                {
                    bt7.Image = Resources.O;
                }
                else if (lbTurn.Text == "Player 1")
                {
                    bt7.Image = Resources.X;
                }
            }
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (StartGame(2, 1))
            {
                if (lbTurn.Text == "Player 1")
                {
                    bt8.Image = Resources.O;
                }
                else if (lbTurn.Text == "Player 1")
                {
                    bt8.Image = Resources.X;
                }
            }
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (StartGame(2, 2))
            {
                if (lbTurn.Text == "Player 1")
                {
                    bt8.Image = Resources.O;
                }
                else if (lbTurn.Text == "Player 1")
                {
                    bt8.Image = Resources.X;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            bt1_Click(sender, e);
            if (lbTurn.Text == "Player 1")
                pb1.Image = Resources.X;
            if (lbTurn.Text == "Player 2")
                pb1.Image = Resources.O;
            if (GawlaNumber >= 5)
            {
                if (DeFindWinner())
                {

                }
            }

        }

        private void pb2_Click(object sender, EventArgs e)
        {
            bt2_Click(sender, e);
            if (lbTurn.Text == "Player 1")
                pb2.Image = Resources.X;
            if (lbTurn.Text == "Player 2")
                pb2.Image = Resources.O;
            if (GawlaNumber >= 5)
            {
                if (DeFindWinner())
                {

                }
            }
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            bt3_Click(sender, e);
            if (lbTurn.Text == "Player 1")
                pb3.Image = Resources.X;
            if (lbTurn.Text == "Player 2")
                pb3.Image = Resources.O;
            if (GawlaNumber >= 5)
            {
                if (DeFindWinner())
                {

                }
            }
        }
       
        private void pb4_Click(object sender, EventArgs e)
        {
            bt4_Click(sender, e);
            if (lbTurn.Text == "Player 1")
                pb4.Image = Resources.X;
            if (lbTurn.Text == "Player 2")
                pb4.Image = Resources.O;
            if (GawlaNumber >= 5)
            {
                if (DeFindWinner())
                {

                }
            }
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            bt5_Click(sender, e);
            if (lbTurn.Text == "Player 1")
                pb5.Image = Resources.X;
            if (lbTurn.Text == "Player 2")
                pb5.Image = Resources.O;
            if (GawlaNumber >= 5)
            {
                if (DeFindWinner())
                {

                }
            }
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            bt6_Click(sender, e);
            if (lbTurn.Text == "Player 1")
                pb6.Image = Resources.X;
            if (lbTurn.Text == "Player 2")
                pb6.Image = Resources.O;
            if (GawlaNumber >= 5)
            {
                if (DeFindWinner())
                {

                }
            }
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            bt7_Click(sender, e);
            if (lbTurn.Text == "Player 1")
                pb7.Image = Resources.X;
            if (lbTurn.Text == "Player 2")
                pb7.Image = Resources.O;
            if (GawlaNumber >= 5)
            {
                if (DeFindWinner())
                {

                }
            }
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            bt8_Click(sender, e);
            if (lbTurn.Text == "Player 1")
                pb8.Image = Resources.X;
            if (lbTurn.Text == "Player 2")
                pb8.Image = Resources.O;
            if (GawlaNumber >= 5)
            {
                if (DeFindWinner())
                {

                }
            }
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            bt9_Click(sender, e);
            if (lbTurn.Text == "Player 1")
                pb9.Image = Resources.X;
            if (lbTurn.Text == "Player 2")
                pb9.Image = Resources.O;
            if (GawlaNumber >= 5)
            {
                if (DeFindWinner())
                {

                }
            }
        }
    }
    
}
