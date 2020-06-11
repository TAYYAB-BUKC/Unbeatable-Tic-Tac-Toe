using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnbeatableTicTacToeEngine
{
	public partial class MainForm : Form
	{
		private bool playerOneTurn;
		private int buttonClicksCounter = 0;
		public MainForm()
		{
			InitializeComponent();
			ButtonsPanel.Enabled = false;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ButtonsEnableDisable(false);
			ButtonsPanel.Enabled = true;
			playerOneTurn = PlayerOneStartRadioButton.Checked ? true : false;
		}

		private void ButtonsEnableDisable(bool Bool)
		{
			PlayersNameGroupBox.Enabled = Bool;
			PlayerXGroupBox.Enabled = Bool;
			StartPlayerGroupBox.Enabled = Bool;
			startGameToolStripMenuItem.Enabled = Bool;
			
		}

		private void resetGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ButtonsEnableDisable(true);			
			ButtonsPanel.Enabled = false;
		}

		private void Button_Click(object sender, EventArgs e)
		{
			
			Button button = (Button)sender;

			if (playerOneTurn)
			{
				//if (PlayerOneXRadioButton.Checked)
				//{
				//	button.Text = "X";
				//}
				//else
				//{
				//	button.Text = "O";
				//}

				button.Text =  PlayerOneXRadioButton.Checked ? "X" : "O";
				button.Enabled = false;
				playerOneTurn = false;
			}
			else
			{
				button.Text = PlayerTwoXRadioButton.Checked ? "X" : "O";
				button.Enabled = false;
				playerOneTurn = true;
			}

			buttonClicksCounter++;

			WhoIsWinner();
		}

		private void WhoIsWinner()
		{
			if (buttonClicksCounter == 9)
			{
				MessageBox.Show("Game Draw", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				if ((Button1.Text == Button2.Text) && (Button2.Text == Button3.Text) && (!Button1.Enabled))
				{
					WinnerMessage();
				}
				else if ((Button4.Text == Button5.Text) && (Button5.Text == Button6.Text) && (!Button4.Enabled))
				{
					WinnerMessage();
				}
				else if ((Button7.Text == Button8.Text) && (Button8.Text == Button9.Text) && (!Button7.Enabled))
				{
					WinnerMessage();
				}
				else if ((Button1.Text == Button4.Text) && (Button4.Text == Button7.Text) && (!Button7.Enabled))
				{
					WinnerMessage();
				}
				else if ((Button2.Text == Button5.Text) && (Button5.Text == Button8.Text) && (!Button2.Enabled))
				{
					WinnerMessage();
				}
				else if ((Button3.Text == Button6.Text) && (Button6.Text == Button9.Text) && (!Button3.Enabled))
				{
					WinnerMessage();
				}
				else if ((Button1.Text == Button5.Text) && (Button5.Text == Button9.Text) && (!Button1.Enabled))
				{
					WinnerMessage();
				}
				else if ((Button3.Text == Button5.Text) && (Button5.Text == Button7.Text) && (!Button3.Enabled))
				{
					WinnerMessage();
				}
			}
		}

		private void WinnerMessage()
		{
			if (!playerOneTurn)
			{
				MessageBox.Show(PlayerOneName.Text + " is the Winner", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show(PlayerTwoName.Text + " is the Winner", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
