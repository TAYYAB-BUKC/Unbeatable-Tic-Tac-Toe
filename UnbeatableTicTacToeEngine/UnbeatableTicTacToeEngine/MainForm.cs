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
		public MainForm()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ButtonsEnableDisable(false);
			ButtonsPanel.Enabled = true;
			playerOneTurn = PlayerOneXRadioButton.Checked ? true : false;
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
			//ButtonsPanel.Enabled = true;
			ButtonsPanel.Enabled = false;
		}
	}
}
