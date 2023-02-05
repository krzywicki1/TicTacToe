using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = false;//false = X; true = O
        bool isPvc = false; //true = player vs computer
        int turnCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Lukasz", "About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //if (turn & !isPvc)
            //{
            //    button.Text = "O";
            //    whosTurn.Text = "X turn";
            //}
            //else if (turn & isPvc)
            //{
            //    computerMakeMove();
            //    whosTurn.Text = "Computer's turn";
            //}
            //else
            //{
            //    button.Text = "X";
            //    whosTurn.Text = "O turn";
            //}

            if (turn)
            {
                whosTurn.Text = "X turn!";
                button.Text = "O";
            }
            else
            {
                whosTurn.Text = "O turn!";
                button.Text = "X";
            }
            


            turn = !turn;

            button.Enabled = false;

            turnCount++;

            checkForWinner();
            if ((turn) && (isPvc))
            {
                computerMakeMove();
            }
        }

        private void MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled)
            {
                
                if (turn && !isPvc)
                {
                    button.ForeColor = Color.Red;
                    button.Text = "O";
                }
                else
                {
                    button.ForeColor = Color.Blue;
                    button.Text = "X";
                }
            }
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled)
            {
                button.Text = "";
            }
        }

        private void checkForWinner()
        {
            bool thereIsWinner = false;

            //Horizontal check
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                thereIsWinner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                thereIsWinner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                thereIsWinner = true;
            //Vertical check
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                thereIsWinner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                thereIsWinner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                thereIsWinner = true;
            //Diagonal check
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                thereIsWinner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                thereIsWinner = true;

            if (thereIsWinner)
            {
                disableButtons();

                String winner = "";
                if (turn)
                    winner = "X";
                else
                    winner = "O";

                MessageBox.Show(winner + " wins!", "Congratulation!");
                restart();
            }
            else
            {
                if(turnCount == 9)
                {
                    MessageBox.Show("Draw!", "GG!");
                    restart();
                }
            }
        }

        private void disableButtons()
        {
            try
            {
                foreach (var button in this.Controls.OfType<Button>())
                {
                    Button b = (Button)button;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void computerMakeMove()
        {
            //1. win
            //2. block
            //3. corner
            //4. open space

            Button move = null;
            //look for win
            move = lookForWinOrBlock("O");      //look for win
            if(move == null)
            {
                move = lookForWinOrBlock("X");  //look for block
                if(move == null)
                {
                    move = lookForCorner();
                    if(move == null)
                    {
                        move = lookForSpace();
                    }
                }
            }
            move.PerformClick();

        }

        private Button lookForCorner()
        {
            if (A1.Text == "") return A1;
            if (A3.Text == "") return A3;
            if (C1.Text == "") return C1;
            if (C3.Text == "") return C3;
            return null;

        }

        private Button lookForSpace()
        {
            Button b = null;
            foreach(Control c in Controls)
            {
                b = c as Button;
                if(b != null)
                {
                    if (b.Text == "") return b;
                }
            }
            return null;
        }

        private Button lookForWinOrBlock(string v)
        {
            //Hor lines
            if ((A1.Text == v) && (A2.Text == v) && (A3.Text == "")) return A3;
            if ((A1.Text == v) && (A2.Text == "") && (A3.Text == v)) return A2;
            if ((A1.Text == "") && (A2.Text == v) && (A3.Text == v)) return A1;

            if ((B1.Text == v) && (B2.Text == v) && (B3.Text == "")) return B3;
            if ((B1.Text == v) && (B2.Text == "") && (B3.Text == v)) return B2;
            if ((B1.Text == "") && (B2.Text == v) && (B3.Text == v)) return B1;

            if ((C1.Text == v) && (C2.Text == v) && (C3.Text == "")) return C3;
            if ((C1.Text == v) && (C2.Text == "") && (C3.Text == v)) return C2;
            if ((C1.Text == "") && (C2.Text == v) && (C3.Text == v)) return C1;

            //Ver lines
            if ((A1.Text == v) && (B1.Text == v) && (C1.Text == "")) return C1;
            if ((A1.Text == v) && (B1.Text == "") && (C1.Text == v)) return B1;
            if ((A1.Text == "") && (B1.Text == v) && (C1.Text == v)) return A1;

            if ((A2.Text == v) && (B2.Text == v) && (C2.Text == "")) return C2;
            if ((A2.Text == v) && (B2.Text == "") && (C2.Text == v)) return B2;
            if ((A2.Text == "") && (B2.Text == v) && (C2.Text == v)) return A2;

            if ((A3.Text == v) && (B3.Text == v) && (C3.Text == "")) return C3;
            if ((A3.Text == v) && (B3.Text == "") && (C3.Text == v)) return B3;
            if ((A3.Text == "") && (B3.Text == v) && (C3.Text == v)) return A3;

            //Diag lines
            if ((A1.Text == v) && (B2.Text == v) && (C3.Text == "")) return C3;
            if ((A1.Text == v) && (B2.Text == "") && (C3.Text == v)) return B2;
            if ((A1.Text == "") && (B2.Text == v) && (C3.Text == v)) return A1;

            if ((A3.Text == v) && (B2.Text == v) && (C1.Text == "")) return C1;
            if ((A3.Text == v) && (B2.Text == "") && (C1.Text == v)) return B2;
            if ((A3.Text == "") && (B2.Text == v) && (C1.Text == v)) return A3;

            return null;

        }

        private void pvPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = false;
            turnCount = 0;
            isPvc = false;
            clearSpaces();
        }

        private void vsComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("PVC");
            isPvc = true;
            turn = false;
            turnCount = 0;
            clearSpaces();
        }
        private void restart()
        {
            turn = false;
            turnCount = 0;
            clearSpaces();
        }
        private void clearSpaces()
        {
            try
            {
                foreach (var button in this.Controls.OfType<Button>())
                {
                    Button b = (Button)button;
                    b.Enabled = true;
                    b.Text = "";
                    whosTurn.Text = "X turn";

                }
            }
            catch { }
        }


    }
}
