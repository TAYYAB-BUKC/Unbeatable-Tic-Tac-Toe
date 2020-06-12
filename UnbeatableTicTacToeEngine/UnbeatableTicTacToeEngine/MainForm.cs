using System;
using System.Collections.Generic;
using System.Drawing;
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
		private List<Button> buttonsList;
		private bool playBot = false;
		private bool gameEnd = false;
		private int lastMove = -1;
		private bool IsFriendPlaying = false;
		private delegate void Delegate();
		private static Delegate RunBot;


		public MainForm()
		{
			InitializeComponent();
			ButtonsPanel.Enabled = false;
			buttonsList = new List<Button>();
			buttonsList.Add(Button1);
			buttonsList.Add(Button2);
			buttonsList.Add(Button3);
			buttonsList.Add(Button4);
			buttonsList.Add(Button5);
			buttonsList.Add(Button6);
			buttonsList.Add(Button7);
			buttonsList.Add(Button8);
			buttonsList.Add(Button9);

			TurnLabel.Text = "";
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
			//TurnLabel.Text = playerOneTurn ? PlayerOneXRadioButton.Checked ? PlayerOneName.Text + " Turn" : PlayerTwoName.Text + " Turn" : PlayerTwoName.Text + " Turn";
			//TurnLabel.ForeColor = playerOneTurn ? PlayerOneXRadioButton.Checked ? Color.Red : Color.Blue : Color.Blue;
			TurnLabel.Text = PlayerOneStartRadioButton.Checked ? PlayerOneName.Text + " Turn" : PlayerTwoName.Text + " Turn";
			TurnLabel.ForeColor = PlayerOneXRadioButton.Checked ? Color.Red : Color.Blue;
			buttonClicksCounter = 0;
			mediumToolStripMenuItem.Enabled = false;
			impossibleToolStripMenuItem.Enabled = false;
			easyToolStripMenuItem.Enabled = false;
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
			playerOneTurn = PlayerOneStartRadioButton.Checked ? true : PlayerOneXRadioButton.Checked ? true : false;
			winsCounterforPlayerTwo = 0;
			winsCounterforPlayerOne = 0;
			drawCounter = 0;
			buttonClicksCounter = 0;
			PlayerOneName.Text = "Player One";
			PlayerTwoName.Text = "Player Two";
			WinsLabelForDraw.Text = "Draw: ";
			WinsLabelForPlayerOne.Text = PlayerOneName.Text + " Wins: ";
			WinsLabelForPlayerTwo.Text = PlayerTwoName.Text + " Wins: ";
			mediumToolStripMenuItem.Enabled = true;
			impossibleToolStripMenuItem.Enabled = true;
			easyToolStripMenuItem.Enabled = true;
			PlayerTwoName.Enabled = true;
			playBot = false;
			TurnLabel.Text = "";
			TurnLabel.ForeColor = playerOneTurn ? PlayerOneXRadioButton.Checked ? Color.Blue : Color.Red : Color.Red;
			IsFriendPlaying = true;
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

			TurnLabel.Text =  playBot ? PlayerOneName.Text + " Turn" : playerOneTurn ? PlayerOneXRadioButton.Checked ? PlayerOneName.Text + " Turn" : PlayerTwoName.Text + " Turn" : PlayerTwoName.Text + " Turn";
			//TurnLabel.ForeColor = !playerOneTurn ? PlayerOneXRadioButton.Checked ? Color.Blue : Color.Red : Color.Red;
			TurnLabel.ForeColor = PlayerTwoXRadioButton.Checked ? Color.Blue : Color.Red;
		}

		private void Button_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			StoreMove(button);

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
				if (!IsFriendPlaying)
				{
					playBot = true;
				}
				TurnLabel.Text = PlayerTwoName.Text + " Turn";
				//TurnLabel.ForeColor = !playerOneTurn ? PlayerOneXRadioButton.Checked ? Color.Blue : Color.Red : Color.Red;
				TurnLabel.ForeColor = PlayerOneXRadioButton.Checked ? Color.Blue : Color.Red;
			}
			else
			{
				button.Text = PlayerTwoXRadioButton.Checked ? "X" : "O";
				button.Enabled = false;
				playerOneTurn = true;
				TurnLabel.Text = PlayerOneName.Text + " Turn";
				//TurnLabel.ForeColor = !playerOneTurn ? PlayerOneXRadioButton.Checked ? Color.Red : Color.Blue : Color.Red;
				TurnLabel.ForeColor = PlayerTwoXRadioButton.Checked ? Color.Blue : Color.Red;
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
					Implementation(true,true);
				}
				else
				{
					Implementation(false,false);
				}
			}
		}

		private void Implementation(bool decideToEnd,bool checkDraw)
		{
			if (decideToEnd)
			{
				#region For Bot
				if (botType == (int)BotType.Easy && buttonClicksCounter != 9)
				{
					RunBot = RunEasyBot;
					//implementation for Easy Bot
					BotImplementation();
				}
				else if (botType == (int)BotType.Medium && buttonClicksCounter != 9)
				{
					RunBot = RunMediumBot;
					//implementation for Medium Bot
					BotImplementation();
				}
				else if (botType == (int)BotType.Impossible && buttonClicksCounter != 9)
				{
					RunBot = RunImpossibleBot;
					//implementation for Medium Bot
					BotImplementation();
				}
				#endregion
				else
				{
					HumanImplementation(checkDraw);
				}
			}
			else
			{
				#region For Bot
				if (botType == (int)BotType.Easy)
				{
					RunBot = RunEasyBot;
					//implementation for Easy Bot
					BotImplementation();
				}
				else if (botType == (int)BotType.Medium)
				{
					RunBot = RunMediumBot;
					//implementation for Medium Bot
					BotImplementation();
				}
				else if (botType == (int)BotType.Impossible)
				{
					RunBot = RunImpossibleBot;
					//implementation for Medium Bot
					BotImplementation();
				}
				#endregion
				else
				{
					HumanImplementation(checkDraw);
				}
			}
		}

		private void HumanImplementation(bool checkDraw)
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
				if (checkDraw)
				{
					DrawMessage();
				}
			}
			#endregion
		}

		private void BotImplementation()
		{
			#region EasyBot
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
					WaitSecondsBeforeTurn(0.33);
					RunBot();
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
			#endregion
		}

		private void DrawMessage()
		{
			MessageBox.Show("Game Draw", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ClearButtonsTextAndEnable("");
			WinsLabelForDraw.Text = "Draw: " + (++drawCounter);
			buttonClicksCounter = 0;
			playerOneTurn = PlayerOneXRadioButton.Checked ? true : false;
		}

		private void WinnerMessage()
		{
			if (IsFriendPlaying)
			{
				if (!playerOneTurn)
				{
					MessageBox.Show(PlayerOneName.Text + " Wins!!!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
					WinsLabelForPlayerOne.Text = PlayerOneName.Text + " Wins: " + (++winsCounterforPlayerOne);
					buttonClicksCounter = 0;
					gameEnd = true;
					playerOneTurn = playBot ? true : PlayerOneXRadioButton.Checked ? true : false;
				}
				else
				{
					MessageBox.Show(PlayerTwoName.Text + " Wins!!!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
					WinsLabelForPlayerTwo.Text = PlayerTwoName.Text + " Wins: " + (++winsCounterforPlayerTwo);
					buttonClicksCounter = 0;
					gameEnd = true;
					playerOneTurn = PlayerOneXRadioButton.Checked ? true : false;
				}
			}
			else
			{
				if (playBot && !playerOneTurn)
				{
					MessageBox.Show(PlayerOneName.Text + " Wins!!!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
					WinsLabelForPlayerOne.Text = PlayerOneName.Text + " Wins: " + (++winsCounterforPlayerOne);
					buttonClicksCounter = 0;
					gameEnd = true;
					playerOneTurn = playBot ? true : PlayerOneXRadioButton.Checked ? true : false;
				}
				else
				{
					MessageBox.Show(PlayerTwoName.Text + " Wins!!!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
					WinsLabelForPlayerTwo.Text = PlayerTwoName.Text + " Wins: " + (++winsCounterforPlayerTwo);
					buttonClicksCounter = 0;
					gameEnd = true;
					playerOneTurn = PlayerOneXRadioButton.Checked ? true : false;
				}
			}
		}

		private void PlayerOneName_TextChanged(object sender, EventArgs e)
		{
			if (PlayerOneName.Text == "")
			{
				PlayerOneName.Text = "Player One";
				WinsLabelForPlayerOne.Text = "Player One Wins:";
				PlayerOneXRadioButton.Text = "Player One";
				PlayerOneStartRadioButton.Text = "Player One";
			}
			else
			{
				WinsLabelForPlayerOne.Text = PlayerOneName.Text + " Wins:";
				PlayerOneXRadioButton.Text = PlayerOneName.Text;
				PlayerOneStartRadioButton.Text = PlayerOneName.Text;
			}
		}

		private void PlayerTwoName_TextChanged(object sender, EventArgs e)
		{
			if (PlayerTwoName.Text == "")
			{
				PlayerTwoName.Text = "Player Two";
				WinsLabelForPlayerTwo.Text = "Player Two Wins:";
				PlayerTwoXRadioButton.Text = "Player Two";
				PlayerTwoStartRadioButton.Text = "Player Two";
			}
			else
			{
				WinsLabelForPlayerTwo.Text = PlayerTwoName.Text + " Wins:";
				PlayerTwoXRadioButton.Text = PlayerTwoName.Text;
				PlayerTwoStartRadioButton.Text = PlayerTwoName.Text;
			}
		}

		private void easyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			botType = (int)BotType.Easy;
			PlayerTwoName.Text = "Easy Bot";
			PlayerTwoName.Enabled = false;
			StartPlayerGroupBox.Enabled = false;
			playBot = true;
			mediumToolStripMenuItem.Enabled = false;
			impossibleToolStripMenuItem.Enabled = false;
			buttonClicksCounter = 0;
			IsFriendPlaying = false;
		}

		private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
		{
			botType = (int)BotType.Medium;
			PlayerTwoName.Text = "Medium Bot";
			PlayerTwoName.Enabled = false;
			StartPlayerGroupBox.Enabled = false;
			easyToolStripMenuItem.Enabled = false;
			impossibleToolStripMenuItem.Enabled = false;
			playBot = true;
			buttonClicksCounter = 0;
			IsFriendPlaying = false;
		}

		private void impossibleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			botType = (int)BotType.Impossible;
			PlayerTwoName.Text = "Impossible Bot";
			PlayerTwoName.Enabled = false;
			StartPlayerGroupBox.Enabled = false;
			playBot = true;
			easyToolStripMenuItem.Enabled = false;
			mediumToolStripMenuItem.Enabled = false;
			buttonClicksCounter = 0;
			IsFriendPlaying = false;
		}

		private void RunEasyBot()
		{
			if (playBot)
			{
				playBot = false;
				//botClicksCount++;
				int getPosition = RandomPosition();
				Button button = buttonsList[getPosition];
				Button_Click(button, null);
				playerOneTurn = true;
			}
		}

		int RandomPosition()
		{
			int Count = 0;
			for (int i = 0; i <= 8; i++)
			{
				if (buttonsList[i].Text == "")
				{
					Count++;
				}
			}
			Random rnd = new Random();
			int iRandom = rnd.Next(1, Count);

			Count = 0;
			for (int i = 0; i <= 8; i++)
			{
				if (buttonsList[i].Text == "")
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

		private void RunMediumBot()
		{
			if (playBot)
			{
				playBot = false;
				int getposition = -1;
				//two type of values in buttonsList if it is -1 then it means X and if it is 1 then it means O 
				//string whoseTurn;
				//if (playerOneTurn)
				//{
				//	whoseTurn = "X";
				//}
				//else
				//{
				//	whoseTurn = "O";
				//}

				//int lm = lastMove;
				if (lastMove == -1)
				{
					getposition = RandomPosition();
				}
				else
				{
					CheckWinAndDontLose("X"); //Check dont lose
					CheckWinAndDontLose("O"); //Check win
					if (buttonsList[lastMove].Text != "")
					{
						getposition = RandomPosition();
					}
				}
				if (getposition == -1)
				{
					Button button = buttonsList[lastMove];
					Button_Click(button, null);
					playerOneTurn = true;
				}
				else
				{
					Button button = buttonsList[getposition];
					Button_Click(button, null);
					playerOneTurn = true;
				}
			}
		}

		private void StoreMove(Button button)
		{
			string str = button.Name.Trim('B', 'u', 't', 'o', 'n');
			int name = Convert.ToInt32(str);
			switch (name)
			{
				case 1:
					lastMove = 0;
					break;
				case 2:
					lastMove = 1;
					break;
				case 3:
					lastMove = 2;
					break;
				case 4:
					lastMove = 3;
					break;
				case 5:
					lastMove = 4;
					break;
				case 6:
					lastMove = 5;
					break;
				case 7:
					lastMove = 6;
					break;
				case 8:
					lastMove = 7;
					break;
				case 9:
					lastMove = 8;
					break;
			}

		}

		void CheckWinAndDontLose(string turn)
		{
			if (buttonsList[0].Text == "" && ((buttonsList[1].Text == turn && buttonsList[2].Text == turn) || (buttonsList[3].Text == turn && buttonsList[6].Text == turn) || (buttonsList[4].Text == turn && buttonsList[8].Text == turn)))
				lastMove = 0;
			else if (buttonsList[1].Text == "" && ((buttonsList[0].Text == turn && buttonsList[2].Text == turn) || (buttonsList[4].Text == turn && buttonsList[7].Text == turn)))
				lastMove = 1;
			else if (buttonsList[2].Text == "" && ((buttonsList[0].Text == turn && buttonsList[1].Text == turn) || (buttonsList[5].Text == turn && buttonsList[8].Text == turn) || (buttonsList[4].Text == turn && buttonsList[6].Text == turn)))
				lastMove = 2;
			else if (buttonsList[3].Text == "" && ((buttonsList[0].Text == turn && buttonsList[6].Text == turn) || (buttonsList[4].Text == turn && buttonsList[5].Text == turn)))
				lastMove = 3;
			else if (buttonsList[4].Text == ""  && ((buttonsList[0].Text == turn && buttonsList[8].Text == turn) || (buttonsList[2].Text == turn && buttonsList[6].Text == turn) || (buttonsList[1].Text == turn && buttonsList[7].Text == turn) || (buttonsList[3].Text == turn && buttonsList[5].Text == turn)))
				lastMove = 4;
			else if (buttonsList[5].Text == "" && ((buttonsList[2].Text == turn && buttonsList[8].Text == turn) || (buttonsList[3].Text == turn && buttonsList[4].Text == turn)))
				lastMove = 5;
			else if (buttonsList[6].Text == "" && ((buttonsList[0].Text == turn && buttonsList[3].Text == turn) || (buttonsList[7].Text == turn && buttonsList[8].Text == turn) || (buttonsList[2].Text == turn && buttonsList[4].Text == turn)))
				lastMove = 6;
			else if (buttonsList[7].Text == "" && ((buttonsList[1].Text == turn && buttonsList[4].Text == turn) || (buttonsList[6].Text == turn && buttonsList[8].Text == turn)))
				lastMove = 7;
			else if (buttonsList[8].Text == "" && ((buttonsList[2].Text == turn && buttonsList[5].Text == turn) || (buttonsList[6].Text == turn && buttonsList[7].Text == turn) || (buttonsList[0].Text == turn && buttonsList[4].Text == turn)))
				lastMove = 8;
		}

		void RunImpossibleBot()
		{
			string iOpponent = "X";
			string iTurn = "O";
			//Check win and dont lose
			//if (iTurn == "O") iOpponent = "X";
			//else iOpponent = "O";

			if (lastMove == -1)
			{
				//Paste on center
				if (buttonsList[4].Text == "")
				{
					lastMove= 4;
				}
			}
			else if (buttonsList[lastMove].Text != "")
			{
				MyCheckWinAndDontLose(iOpponent); //Check dont lose
				MyCheckWinAndDontLose(iTurn); //Check win
				if (buttonsList[lastMove].Text != "")
				{
					//lastMove is center
					if (lastMove == 4)
					{
						//Paste on corner
						if (buttonsList[0].Text == "")
						{
							lastMove = 0;
						}
						else if (buttonsList[2].Text == "")
						{
							lastMove = 2;
						}
						else if (buttonsList[6].Text == "")
						{
							lastMove = 6;
						}
						else if (buttonsList[8].Text == "")
						{
							lastMove = 8;
						}
						else lastMove = RandomPosition();
					}
					//lastMove is corner
					else if (lastMove == 0 || lastMove == 2 || lastMove == 6 || lastMove == 8)
					{
						//Paste on center
						if (buttonsList[4].Text == "")
						{
							lastMove = 4;
						}
						//Paste on opposite corner
						else if (buttonsList[0].Text == "" && buttonsList[8].Text == iOpponent)
						{
							lastMove = 0;
						}
						else if (buttonsList[2].Text == "" && buttonsList[6].Text == iOpponent)
						{
							lastMove = 2;
						}
						else if (buttonsList[6].Text == ""  && buttonsList[2].Text == iOpponent)
						{
							lastMove = 6;
						}
						else if (buttonsList[8].Text == "" && buttonsList[0].Text == iOpponent)
						{
							lastMove = 8;
						}
						//If opposite corners are opponent
						else if ((buttonsList[0].Text == iOpponent && buttonsList[8].Text == iOpponent) || (buttonsList[2].Text == iOpponent && buttonsList[6].Text == iOpponent))
						{
							//Paste on Edge
							if (buttonsList[1].Text == "")
							{
								lastMove = 1;
							}
							else if (buttonsList[3].Text == "")
							{
								lastMove = 3;
							}
							else if (buttonsList[5].Text == "")
							{
								lastMove = 5;
							}
							else if (buttonsList[7].Text == "")
							{
								lastMove = 7;
							}
						}
						//Paste on corner
						else if (buttonsList[0].Text == "")
						{
							lastMove = 0;
						}
						else if (buttonsList[2].Text == "")
						{
							lastMove = 2;
						}
						else if (buttonsList[6].Text == "")
						{
							lastMove = 6;
						}
						else if (buttonsList[8].Text == "")
						{
							lastMove = 8;
						}
						else lastMove = RandomPosition();
					}
					//lastMove is Edge
					else if (lastMove == 1 || lastMove == 3 || lastMove == 5 || lastMove == 7)
					{
						//Paste on center
						if (buttonsList[4].Text == "")
						{
							lastMove = 4;
						}
						//Paste on corner when edges are opponent
						else if (buttonsList[0].Text == "" && buttonsList[1].Text == iOpponent && buttonsList[3].Text == iOpponent)
						{
							lastMove = 0;
						}
						else if (buttonsList[2].Text == "" && buttonsList[1].Text == iOpponent && buttonsList[5].Text == iOpponent)
						{
							lastMove = 2;
						}
						else if (buttonsList[6].Text == "" && buttonsList[3].Text == iOpponent && buttonsList[7].Text == iOpponent)
						{
							lastMove = 6;
						}
						else if (buttonsList[8].Text == "" && buttonsList[5].Text == iOpponent && buttonsList[7].Text == iOpponent)
						{
							lastMove = 8;
						}
						//Paste the corner near the edge
						else if (buttonsList[0].Text == "" && ((buttonsList[1].Text == iOpponent) || (buttonsList[3].Text == iOpponent)))
						{
							lastMove = 0;
						}
						else if (buttonsList[2].Text == "" && ((buttonsList[1].Text == iOpponent) || (buttonsList[5].Text == iOpponent)))
						{
							lastMove = 2;
						}
						else if (buttonsList[6].Text == "" && ((buttonsList[3].Text == iOpponent) || (buttonsList[7].Text == iOpponent)))
						{
							lastMove = 6;
						}
						else if (buttonsList[8].Text == "" && ((buttonsList[5].Text == iOpponent) || (buttonsList[7].Text == iOpponent)))
						{
							lastMove = 8;
						}
						//Paste on corner
						else if (buttonsList[0].Text == "")
						{
							lastMove = 0;
						}
						else if (buttonsList[2].Text == "")
						{
							lastMove = 2;
						}
						else if (buttonsList[6].Text == "")
						{
							lastMove = 6;
						}
						else if (buttonsList[8].Text == "")
						{
							lastMove = 8;
						}
						//Paste on Edge
						else if (buttonsList[1].Text == "")
						{
							lastMove = 1;
						}
						else if (buttonsList[3].Text == "")
						{
							lastMove = 3;
						}
						else if (buttonsList[5].Text == "")
						{
							lastMove = 5;
						}
						else if (buttonsList[7].Text == "")
						{
							lastMove = 7;
						}
						else lastMove = RandomPosition();
					}
				}

			}

			playBot = false;
			Button button = buttonsList[lastMove];
			Button_Click(button, null);
			playerOneTurn = true;
		}

		void MyCheckWinAndDontLose(string turn)
		{
			if (buttonsList[0].Text == "" && ((buttonsList[1].Text == turn && buttonsList[2].Text == turn) || (buttonsList[3].Text == turn && buttonsList[6].Text == turn) || (buttonsList[4].Text == turn && buttonsList[8].Text == turn)))
				lastMove = 0;
			else if (buttonsList[1].Text == "" && ((buttonsList[0].Text == turn && buttonsList[2].Text == turn) || (buttonsList[4].Text == turn && buttonsList[7].Text == turn)))
				lastMove = 1;
			else if (buttonsList[2].Text == "" && ((buttonsList[0].Text == turn && buttonsList[1].Text == turn) || (buttonsList[5].Text == turn && buttonsList[8].Text == turn) || (buttonsList[4].Text == turn && buttonsList[6].Text == turn)))
				lastMove = 2;
			else if (buttonsList[3].Text == "" && ((buttonsList[0].Text == turn && buttonsList[6].Text == turn) || (buttonsList[4].Text == turn && buttonsList[5].Text == turn)))
				lastMove = 3;
			else if (buttonsList[4].Text == "" && ((buttonsList[0].Text == turn && buttonsList[8].Text == turn) || (buttonsList[2].Text == turn && buttonsList[6].Text == turn) || (buttonsList[1].Text == turn && buttonsList[7].Text == turn) || (buttonsList[3].Text == turn && buttonsList[5].Text == turn)))
				lastMove = 4;
			else if (buttonsList[5].Text == "" && ((buttonsList[2].Text == turn && buttonsList[8].Text == turn) || (buttonsList[3].Text == turn && buttonsList[4].Text == turn)))
				lastMove = 5;
			else if (buttonsList[6].Text == "" && ((buttonsList[0].Text == turn && buttonsList[3].Text == turn) || (buttonsList[7].Text == turn && buttonsList[8].Text == turn) || (buttonsList[2].Text == turn && buttonsList[4].Text == turn)))
				lastMove = 6;
			else if (buttonsList[7].Text == "" && ((buttonsList[1].Text == turn && buttonsList[4].Text == turn) || (buttonsList[6].Text == turn && buttonsList[8].Text == turn)))
				lastMove = 7;
			else if (buttonsList[8].Text == "" && ((buttonsList[2].Text == turn && buttonsList[5].Text == turn) || (buttonsList[6].Text == turn && buttonsList[7].Text == turn) || (buttonsList[0].Text == turn && buttonsList[4].Text == turn)))
				lastMove = 8;
			else if (buttonsList[7].Text == "" && (buttonsList[6].Text == turn && buttonsList[5].Text == turn && buttonsList[8].Text == turn))
				lastMove = 7;
			else if (buttonsList[7].Text == "" && (buttonsList[8].Text == turn && buttonsList[6].Text == turn))
				lastMove = 7;
		}

		private void Enabled_Change(object sender, EventArgs e)
		{
			Button button = sender as Button;
			button.ForeColor = button.Text == "X" ? Color.Red : Color.Blue;
		}

		private void Button_Paint(object sender, PaintEventArgs e)
		{
			dynamic btn = sender as Button;
			dynamic drawBrush = new SolidBrush(btn.ForeColor);
			dynamic sf = new StringFormat
			{
				Alignment = StringAlignment.Center,
				LineAlignment = StringAlignment.Center
			};
			e.Graphics.DrawString(btn.Text, btn.Font, drawBrush, e.ClipRectangle, sf);
			drawBrush.Dispose();
			sf.Dispose();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Developed By Tayyab Dost. All rights reserved © 2020", "About Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		private void WaitSecondsBeforeTurn(double seconds)
		{
			DateTime _desired = DateTime.Now.AddSeconds(seconds);
			while (DateTime.Now < _desired)
			{
				Application.DoEvents();
			}
		}

		private void PlayerTwoXRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			playerOneTurn = false;
		}

		private void PlayerTwoStartRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			playerOneTurn = false;
		}

		private void PlayerOneXRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			playerOneTurn = true;
		}

		private void PlayerOneStartRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			playerOneTurn = true;
		}

		private void PlayWithFriendItem_Click(object sender, EventArgs e)
		{
			resetGameToolStripMenuItem_Click(null, null);
		}
	}
}
