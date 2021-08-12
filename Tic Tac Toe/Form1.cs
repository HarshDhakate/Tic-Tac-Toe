using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class TicTacToeForm : Form
    {
        public TicTacToeForm()
        {
            InitializeComponent();
        }

        int counter = 0;
        bool winner = false;
        private void TicTacToeForm_Load(object sender, EventArgs e)
        {
            DisableButtons();

        }

        private void DisableButtons()
        {
            EnableDisableButtons(false);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableDisableButtons(true);
            EnableDisablePanels(false);
        }

        private void EnableDisableButtons(bool value)
        {
            button1.Enabled = value;
            button2.Enabled = value;
            button3.Enabled = value;
            button4.Enabled = value;
            button5.Enabled = value;
            button6.Enabled = value;
            button7.Enabled = value;
            button8.Enabled = value;
            button9.Enabled = value;
        }

        private void EnableDisablePanels(bool value)
        {
            PlayersInformationPanel.Enabled = value;
            GameSettingPanel.Enabled = value;
        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void restartGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void ResetGame()
        {
            EnableDisableButtons(false);
            EnableDisablePanels(true);
            counter = 0;
            winner = false;
            ResetButtons();
        }

        private void ResetButtons()
        {
            button1.Text = string.Empty;
            button2.Text = string.Empty;
            button3.Text = string.Empty;
            button4.Text = string.Empty;
            button5.Text = string.Empty;
            button6.Text = string.Empty;
            button7.Text = string.Empty;
            button8.Text = string.Empty;
            button9.Text = string.Empty;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (StartingPlayerOne.Checked)
            {
                if (XPlayerOneRadio.Checked)
                    b.Text = "X";
                else
                    b.Text = "O";
                StartingPlayerTwo.Checked = true;
            }
            else
            {
                if (XPlayerTwoRadio.Checked)
                    b.Text = "X";
                else
                    b.Text = "O";
                StartingPlayerOne.Checked = true;
            }
            b.Enabled = false;
            counter++;
            checkWinner();
        }

        private void checkWinner()
        {
            if (counter == 9)
            {
                MessageBox.Show("Game is draw, Please try again.", "Game Draw", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGame();
            }
            else
            {
                if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (!button1.Enabled == true))
                    winner = true;
                else if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (!button4.Enabled == true))
                    winner = true;
                else if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (!button7.Enabled == true))
                    winner = true;
                else if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (!button1.Enabled == true))
                    winner = true;
                else if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (!button2.Enabled == true))
                    winner = true;
                else if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (!button3.Enabled == true))
                    winner = true;
                else if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (!button1.Enabled == true))
                    winner = true;
                else if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (!button3.Enabled == true))
                    winner = true;

                if (winner)
                {
                    if (!StartingPlayerOne.Checked)
                    {
                        MessageBox.Show(playerOneTextBox.Text + " Wins the Game","Game Finish", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(playerTwoTextBox.Text + " Wins the Game", "Game Finish", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    ResetGame();
                }
            }
               
        }
    }
}
