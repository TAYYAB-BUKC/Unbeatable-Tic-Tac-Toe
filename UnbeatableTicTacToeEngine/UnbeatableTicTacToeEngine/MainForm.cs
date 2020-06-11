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
		private int botType;
		private int botClicksCount = 0;		
		private List<Button> iData;
		private bool playBot = false;
		private bool gameEnd = false;
		
			public MainForm()
		{
			InitializeComponent();
			ButtonsPanel.Enabled = false;
			iData = new List<Button>();
			iData.Add(Button1);
			iData.Add(Button2);
			iData.Add(Button3);
			iData.Add(Button4);
			iData.Add(Button5);
			iData.Add(Button6);
			iData.Add(Button7);
			iData.Add(Button8);
			iData.Add(Button9);

		}

		public enum BotType
		{
			Easy = 1,
			Medium = 2,
			Impossible = 3,
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
			gameEnd = false;
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
				playBot = true;
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
			if (!gameEnd)
			{
				if (buttonClicksCounter == 9)
				{
					#region For Bot
					if (botType == (int)BotType.Easy && buttonClicksCounter != 9)
					{
						//implementation for Easy Bot
						if (playBot)
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
								EasyBot();
							}
						}
						//ChangeButtonBackgroundImage(iLastMove);
						//bEnableBot = false;
						//SetNextTurn();

					}
					else if (botType == (int)BotType.Medium && buttonClicksCounter != 9)
					{

					}
					else if (botType == (int)BotType.Medium && buttonClicksCounter != 9)
					{

					}
					#endregion
					else
					{
						#region For Human
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
							DrawMessage();
						}
						#endregion
					}
				}
				else
				{

					#region For Bot
					if (botType == (int)BotType.Easy)
					{
						//implementation for Easy Bot
						if (playBot)
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
								EasyBot();
							}
						}
					}
					else if (botType == (int)BotType.Medium)
					{

					}
					else if (botType == (int)BotType.Medium)
					{

					}
					#endregion
					else
					{
						#region For Human
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
							DrawMessage();
						}

						#endregion
					}
				}
			}
		}

		private void DrawMessage()
		{
			MessageBox.Show("Game Draw", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ClearButtonsTextAndEnable("");
			WinsLabelForDraw.Text = "Draw: " + (++drawCounter);
			buttonClicksCounter = 0;
			playerOneTurn = true;
		}

		private void WinnerMessage()
		{
			if (playBot)
			{
				MessageBox.Show(PlayerOneName.Text + " is the Winner", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
				WinsLabelForPlayerOne.Text = PlayerOneName.Text + " Wins: " + (++winsCounterforPlayerOne);
				buttonClicksCounter = 0;
				gameEnd = true;
				playerOneTurn = true;
			}
			else
			{
				MessageBox.Show(PlayerTwoName.Text + " is the Winner", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
				WinsLabelForPlayerTwo.Text = PlayerTwoName.Text + " Wins: " + (++winsCounterforPlayerTwo);
				buttonClicksCounter = 0;
				gameEnd = true;
				playerOneTurn = true;
			}
		}

		private void PlayerOneName_TextChanged(object sender, EventArgs e)
		{
			WinsLabelForPlayerOne.Text = PlayerOneName.Text + " Wins:";
			PlayerOneXRadioButton.Text = PlayerOneName.Text;
			PlayerOneStartRadioButton.Text = PlayerOneName.Text;
		}

		private void PlayerTwoName_TextChanged(object sender, EventArgs e)
		{
			WinsLabelForPlayerTwo.Text = PlayerTwoName.Text + " Wins:";
			PlayerTwoXRadioButton.Text = PlayerTwoName.Text;
			PlayerTwoStartRadioButton.Text = PlayerTwoName.Text;
		}

		private void easyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			botType = (int)BotType.Easy;
			PlayerTwoName.Text = "Easy Bot";
			PlayerTwoName.Enabled = false;
			StartPlayerGroupBox.Enabled = false;
			playBot = true;
		}

		private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
		{
			botType = (int)BotType.Medium;
			PlayerTwoName.Text = "Medium Bot";
			PlayerTwoName.Enabled = false;
			StartPlayerGroupBox.Enabled = false;
			playBot = true;
		}

		private void impossibleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			botType = (int)BotType.Impossible;
			PlayerTwoName.Text = "Impossible Bot";
			PlayerTwoName.Enabled = false;
			StartPlayerGroupBox.Enabled = false;
			playBot = true;
		}

		private void EasyBot()
		{
			if (playBot)
			{
				playBot = false;
				//botClicksCount++;
				int getPosition = RandomPosition();
				Button button = iData[getPosition];
				Button_Click(button, null);
				playerOneTurn = true;
			}
		}

		int RandomPosition()
		{
			int Count = 0;
			for (int i = 0; i <= 8; i++)
			{
				if (iData[i].Text == "")
				{
					Count++;
				}
			}
			Random rnd = new Random();
			int iRandom = rnd.Next(1, Count);

			Count = 0;
			for (int i = 0; i <= 8; i++)
			{
				if (iData[i].Text == "")
				{
					Count++;
					if (Count == iRandom)
					{
						return i;
					}
				}
			}
			return -1;
		}
	}
}
