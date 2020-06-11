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
		private int winsCounterforPlayerOne = 0;
		private int winsCounterforPlayerTwo = 0;
		private int drawCounter = 0;

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
			ClearButtonsText("");
			playerOneTurn = true;
			winsCounterforPlayerTwo = 0;
			winsCounterforPlayerOne = 0;
			drawCounter = 0;

			PlayerOneName.Text = "Player One";
			PlayerTwoName.Text = "Player Two";
			WinsLabelForDraw.Text = "Draw: ";
			WinsLabelForPlayerOne.Text = PlayerOneName.Text + " Wins: ";
			WinsLabelForPlayerTwo.Text = PlayerTwoName.Text + " Wins: ";



		}

		private void ClearButtonsText(string text)
		{
			Button1.Text = text;
			Button2.Text = text;
			Button3.Text = text;
			Button4.Text = text;
			Button5.Text = text;
			Button6.Text = text;
			Button7.Text = text;
			Button8.Text = text;
			Button9.Text = text;
		}
		private void ClearButtonsTextAndEnable(string text)
		{
			Button1.Text = text;
			Button2.Text = text;
			Button3.Text = text;
			Button4.Text = text;
			Button5.Text = text;
			Button6.Text = text;
			Button7.Text = text;
			Button8.Text = text;
			Button9.Text = text;

			Button1.Enabled = true;
			Button2.Enabled = true;
			Button3.Enabled = true;
			Button4.Enabled = true;
			Button5.Enabled = true;
			Button6.Enabled = true;
			Button7.Enabled = true;
			Button8.Enabled = true;
			Button9.Enabled = true;

			ButtonsPanel.Enabled = true;
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

				button.Text = PlayerOneXRadioButton.Checked ? "X" : "O";
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
				if ((Button1.Text == Button2.Text) && (Button2.Text == Button3.Text) && (!Button1.Enabled))
				{
					WinnerMessage();
					ClearButtonsTextAndEnable("");
				}
				else if ((Button4.Text == Button5.Text) && (Button5.Text == Button6.Text) && (!Button4.Enabled))
				{
					WinnerMessage();
					ClearButtonsTextAndEnable("");
				}
				else if ((Button7.Text == Button8.Text) && (Button8.Text == Button9.Text) && (!Button7.Enabled))
				{
					WinnerMessage();
					ClearButtonsTextAndEnable("");
				}
				else if ((Button1.Text == Button4.Text) && (Button4.Text == Button7.Text) && (!Button7.Enabled))
				{
					WinnerMessage();
					ClearButtonsTextAndEnable("");
				}
				else if ((Button2.Text == Button5.Text) && (Button5.Text == Button8.Text) && (!Button2.Enabled))
				{
					WinnerMessage();
					ClearButtonsTextAndEnable("");
				}
				else if ((Button3.Text == Button6.Text) && (Button6.Text == Button9.Text) && (!Button3.Enabled))
				{
					WinnerMessage();
					ClearButtonsTextAndEnable("");
				}
				else if ((Button1.Text == Button5.Text) && (Button5.Text == Button9.Text) && (!Button1.Enabled))
				{
					WinnerMessage();
					ClearButtonsTextAndEnable("");
				}
				else if ((Button3.Text == Button5.Text) && (Button5.Text == Button7.Text) && (!Button3.Enabled))
				{
					WinnerMessage();
					ClearButtonsTextAndEnable("");
				}
				else
				{
					MessageBox.Show("Game Draw", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClearButtonsTextAndEnable("");
					WinsLabelForDraw.Text = "Draw: " + (++drawCounter);
					buttonClicksCounter = 0;

				}
			}
			else
			{
				if ((Button1.Text == Button2.Text) && (Button2.Text == Button3.Text) && (!Button1.Enabled))
				{
					WinnerMessage();
					ClearButtonsTextAndEnable("");
				}
				else if ((Button4.Text == Button5.Text) && (Button5.Text == Button6.Text) && (!Button4.Enabled))
				{
					WinnerMessage();
					ClearButtonsTextAndEnable("");
				}
				else if ((Button7.Text == Button8.Text) && (Button8.Text == Button9.Text) && (!Button7.Enabled))
				{
					WinnerMessage();
					ClearButtonsTextAndEnable("");
				}
				else if ((Button1.Text == Button4.Text) && (Button4.Text == Button7.Text) && (!Button7.Enabled))
				{
					WinnerMessage();
					ClearButtonsTextAndEnable("");
				}
				else if ((Button2.Text == Button5.Text) && (Button5.Text == Button8.Text) && (!Button2.Enabled))
				{
					WinnerMessage();
					ClearButtonsTextAndEnable("");
				}
				else if ((Button3.Text == Button6.Text) && (Button6.Text == Button9.Text) && (!Button3.Enabled))
				{
					WinnerMessage();
					ClearButtonsTextAndEnable("");
				}
				else if ((Button1.Text == Button5.Text) && (Button5.Text == Button9.Text) && (!Button1.Enabled))
				{
					WinnerMessage();
					ClearButtonsTextAndEnable("");
				}
				else if ((Button3.Text == Button5.Text) && (Button5.Text == Button7.Text) && (!Button3.Enabled))
				{
					WinnerMessage();
					ClearButtonsTextAndEnable("");
				}
			}
		}

		private void WinnerMessage()
		{
			if (!playerOneTurn)
			{
				MessageBox.Show(PlayerOneName.Text + " is the Winner", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
				WinsLabelForPlayerOne.Text = PlayerOneName.Text + " Wins: " + (++winsCounterforPlayerOne);
				buttonClicksCounter = 0;
			}
			else
			{
				MessageBox.Show(PlayerTwoName.Text + " is the Winner", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
				WinsLabelForPlayerTwo.Text = PlayerTwoName.Text + " Wins: " + (++winsCounterforPlayerTwo);
				buttonClicksCounter = 0;
			}
		}

		private void PlayerOneName_TextChanged(object sender, EventArgs e)
		{
			WinsLabelForPlayerOne.Text = PlayerOneName.Text + " Wins:";
		}

		private void PlayerTwoName_TextChanged(object sender, EventArgs e)
		{
			WinsLabelForPlayerTwo.Text = PlayerTwoName.Text + " Wins:";
		}
	}
}
