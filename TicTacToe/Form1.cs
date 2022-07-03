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
            if (turn)
            {
                button.Text = "O";
                whosTurn.Text = "X turn";
            }
            else
            {
                button.Text = "X";
                whosTurn.Text = "O turn";
            }

            turn = !turn;

            button.Enabled = false;

            turnCount++;

            checkForWinner();
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
            }
            else
            {
                if(turnCount == 9)
                {
                    MessageBox.Show("Draw!", "GG!");
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

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = false;
            turnCount = 0;
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
