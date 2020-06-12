namespace UnbeatableTicTacToeEngine
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.startGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PlayWithFriendItem = new System.Windows.Forms.ToolStripMenuItem();
			this.playWithBotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.impossibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button3 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.Button5 = new System.Windows.Forms.Button();
			this.Button6 = new System.Windows.Forms.Button();
			this.Button4 = new System.Windows.Forms.Button();
			this.Button8 = new System.Windows.Forms.Button();
			this.Button9 = new System.Windows.Forms.Button();
			this.Button7 = new System.Windows.Forms.Button();
			this.PlayersNameGroupBox = new System.Windows.Forms.GroupBox();
			this.PlayerTwoName = new System.Windows.Forms.TextBox();
			this.PlayerOneName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.PlayerXGroupBox = new System.Windows.Forms.GroupBox();
			this.PlayerTwoXRadioButton = new System.Windows.Forms.RadioButton();
			this.PlayerOneXRadioButton = new System.Windows.Forms.RadioButton();
			this.StartPlayerGroupBox = new System.Windows.Forms.GroupBox();
			this.PlayerTwoStartRadioButton = new System.Windows.Forms.RadioButton();
			this.PlayerOneStartRadioButton = new System.Windows.Forms.RadioButton();
			this.ButtonsPanel = new System.Windows.Forms.Panel();
			this.WinsLabelForPlayerTwo = new System.Windows.Forms.Label();
			this.WinsLabelForPlayerOne = new System.Windows.Forms.Label();
			this.WinsLabelForDraw = new System.Windows.Forms.Label();
			this.TurnLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.PlayersNameGroupBox.SuspendLayout();
			this.PlayerXGroupBox.SuspendLayout();
			this.StartPlayerGroupBox.SuspendLayout();
			this.ButtonsPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.PlayWithFriendItem,
            this.playWithBotToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(675, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// gameToolStripMenuItem
			// 
			this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameToolStripMenuItem,
            this.resetGameToolStripMenuItem});
			this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
			this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.gameToolStripMenuItem.Text = "Game";
			// 
			// startGameToolStripMenuItem
			// 
			this.startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
			this.startGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.startGameToolStripMenuItem.Text = "Start Game";
			this.startGameToolStripMenuItem.Click += new System.EventHandler(this.startGameToolStripMenuItem_Click);
			// 
			// resetGameToolStripMenuItem
			// 
			this.resetGameToolStripMenuItem.Name = "resetGameToolStripMenuItem";
			this.resetGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.resetGameToolStripMenuItem.Text = "Reset Game";
			this.resetGameToolStripMenuItem.Click += new System.EventHandler(this.resetGameToolStripMenuItem_Click);
			// 
			// PlayWithFriendItem
			// 
			this.PlayWithFriendItem.Name = "PlayWithFriendItem";
			this.PlayWithFriendItem.Size = new System.Drawing.Size(112, 20);
			this.PlayWithFriendItem.Text = "Play with a Friend";
			this.PlayWithFriendItem.Click += new System.EventHandler(this.PlayWithFriendItem_Click);
			// 
			// playWithBotToolStripMenuItem
			// 
			this.playWithBotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.impossibleToolStripMenuItem});
			this.playWithBotToolStripMenuItem.Name = "playWithBotToolStripMenuItem";
			this.playWithBotToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
			this.playWithBotToolStripMenuItem.Text = "Play with Bot";
			// 
			// easyToolStripMenuItem
			// 
			this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
			this.easyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.easyToolStripMenuItem.Text = "Easy";
			this.easyToolStripMenuItem.Click += new System.EventHandler(this.easyToolStripMenuItem_Click);
			// 
			// mediumToolStripMenuItem
			// 
			this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
			this.mediumToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.mediumToolStripMenuItem.Text = "Medium";
			this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
			// 
			// impossibleToolStripMenuItem
			// 
			this.impossibleToolStripMenuItem.Name = "impossibleToolStripMenuItem";
			this.impossibleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.impossibleToolStripMenuItem.Text = "Impossible";
			this.impossibleToolStripMenuItem.Click += new System.EventHandler(this.impossibleToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// Button1
			// 
			this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Button1.ForeColor = System.Drawing.Color.Blue;
			this.Button1.Location = new System.Drawing.Point(12, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(75, 72);
			this.Button1.TabIndex = 1;
			this.Button1.UseVisualStyleBackColor = true;
			this.Button1.EnabledChanged += new System.EventHandler(this.Enabled_Change);
			this.Button1.Click += new System.EventHandler(this.Button_Click);
			this.Button1.Paint += new System.Windows.Forms.PaintEventHandler(this.Button_Paint);
			// 
			// Button3
			// 
			this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Button3.ForeColor = System.Drawing.Color.Blue;
			this.Button3.Location = new System.Drawing.Point(201, 5);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(75, 72);
			this.Button3.TabIndex = 2;
			this.Button3.UseVisualStyleBackColor = true;
			this.Button3.EnabledChanged += new System.EventHandler(this.Enabled_Change);
			this.Button3.Click += new System.EventHandler(this.Button_Click);
			this.Button3.Paint += new System.Windows.Forms.PaintEventHandler(this.Button_Paint);
			// 
			// Button2
			// 
			this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Button2.ForeColor = System.Drawing.Color.Blue;
			this.Button2.Location = new System.Drawing.Point(104, 5);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(75, 72);
			this.Button2.TabIndex = 3;
			this.Button2.UseVisualStyleBackColor = true;
			this.Button2.EnabledChanged += new System.EventHandler(this.Enabled_Change);
			this.Button2.Click += new System.EventHandler(this.Button_Click);
			this.Button2.Paint += new System.Windows.Forms.PaintEventHandler(this.Button_Paint);
			// 
			// Button5
			// 
			this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Button5.ForeColor = System.Drawing.Color.Blue;
			this.Button5.Location = new System.Drawing.Point(104, 93);
			this.Button5.Name = "Button5";
			this.Button5.Size = new System.Drawing.Size(75, 72);
			this.Button5.TabIndex = 6;
			this.Button5.UseVisualStyleBackColor = true;
			this.Button5.EnabledChanged += new System.EventHandler(this.Enabled_Change);
			this.Button5.Click += new System.EventHandler(this.Button_Click);
			this.Button5.Paint += new System.Windows.Forms.PaintEventHandler(this.Button_Paint);
			// 
			// Button6
			// 
			this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Button6.ForeColor = System.Drawing.Color.Blue;
			this.Button6.Location = new System.Drawing.Point(201, 93);
			this.Button6.Name = "Button6";
			this.Button6.Size = new System.Drawing.Size(75, 72);
			this.Button6.TabIndex = 5;
			this.Button6.UseVisualStyleBackColor = true;
			this.Button6.EnabledChanged += new System.EventHandler(this.Enabled_Change);
			this.Button6.Click += new System.EventHandler(this.Button_Click);
			this.Button6.Paint += new System.Windows.Forms.PaintEventHandler(this.Button_Paint);
			// 
			// Button4
			// 
			this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Button4.ForeColor = System.Drawing.Color.Blue;
			this.Button4.Location = new System.Drawing.Point(12, 93);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(75, 72);
			this.Button4.TabIndex = 4;
			this.Button4.UseVisualStyleBackColor = true;
			this.Button4.EnabledChanged += new System.EventHandler(this.Enabled_Change);
			this.Button4.Click += new System.EventHandler(this.Button_Click);
			this.Button4.Paint += new System.Windows.Forms.PaintEventHandler(this.Button_Paint);
			// 
			// Button8
			// 
			this.Button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Button8.ForeColor = System.Drawing.Color.Blue;
			this.Button8.Location = new System.Drawing.Point(104, 184);
			this.Button8.Name = "Button8";
			this.Button8.Size = new System.Drawing.Size(75, 72);
			this.Button8.TabIndex = 9;
			this.Button8.UseVisualStyleBackColor = true;
			this.Button8.EnabledChanged += new System.EventHandler(this.Enabled_Change);
			this.Button8.Click += new System.EventHandler(this.Button_Click);
			this.Button8.Paint += new System.Windows.Forms.PaintEventHandler(this.Button_Paint);
			// 
			// Button9
			// 
			this.Button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Button9.ForeColor = System.Drawing.Color.Blue;
			this.Button9.Location = new System.Drawing.Point(201, 184);
			this.Button9.Name = "Button9";
			this.Button9.Size = new System.Drawing.Size(75, 72);
			this.Button9.TabIndex = 8;
			this.Button9.UseVisualStyleBackColor = true;
			this.Button9.EnabledChanged += new System.EventHandler(this.Enabled_Change);
			this.Button9.Click += new System.EventHandler(this.Button_Click);
			this.Button9.Paint += new System.Windows.Forms.PaintEventHandler(this.Button_Paint);
			// 
			// Button7
			// 
			this.Button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Button7.ForeColor = System.Drawing.Color.Blue;
			this.Button7.Location = new System.Drawing.Point(12, 184);
			this.Button7.Name = "Button7";
			this.Button7.Size = new System.Drawing.Size(75, 72);
			this.Button7.TabIndex = 7;
			this.Button7.UseVisualStyleBackColor = true;
			this.Button7.EnabledChanged += new System.EventHandler(this.Enabled_Change);
			this.Button7.Click += new System.EventHandler(this.Button_Click);
			this.Button7.Paint += new System.Windows.Forms.PaintEventHandler(this.Button_Paint);
			// 
			// PlayersNameGroupBox
			// 
			this.PlayersNameGroupBox.Controls.Add(this.PlayerTwoName);
			this.PlayersNameGroupBox.Controls.Add(this.PlayerOneName);
			this.PlayersNameGroupBox.Controls.Add(this.label3);
			this.PlayersNameGroupBox.Controls.Add(this.label2);
			this.PlayersNameGroupBox.Location = new System.Drawing.Point(330, 65);
			this.PlayersNameGroupBox.Name = "PlayersNameGroupBox";
			this.PlayersNameGroupBox.Size = new System.Drawing.Size(337, 83);
			this.PlayersNameGroupBox.TabIndex = 11;
			this.PlayersNameGroupBox.TabStop = false;
			this.PlayersNameGroupBox.Text = "Players Name";
			// 
			// PlayerTwoName
			// 
			this.PlayerTwoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PlayerTwoName.Location = new System.Drawing.Point(144, 49);
			this.PlayerTwoName.MaxLength = 20;
			this.PlayerTwoName.Name = "PlayerTwoName";
			this.PlayerTwoName.Size = new System.Drawing.Size(187, 24);
			this.PlayerTwoName.TabIndex = 15;
			this.PlayerTwoName.Text = "Player Two";
			this.PlayerTwoName.TextChanged += new System.EventHandler(this.PlayerTwoName_TextChanged);
			// 
			// PlayerOneName
			// 
			this.PlayerOneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PlayerOneName.Location = new System.Drawing.Point(144, 19);
			this.PlayerOneName.MaxLength = 20;
			this.PlayerOneName.Name = "PlayerOneName";
			this.PlayerOneName.Size = new System.Drawing.Size(187, 24);
			this.PlayerOneName.TabIndex = 14;
			this.PlayerOneName.Text = "Player One";
			this.PlayerOneName.TextChanged += new System.EventHandler(this.PlayerOneName_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(5, 51);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(122, 18);
			this.label3.TabIndex = 13;
			this.label3.Text = "PlayerTwo Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(6, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 18);
			this.label2.TabIndex = 12;
			this.label2.Text = "PlayerOne Name";
			// 
			// PlayerXGroupBox
			// 
			this.PlayerXGroupBox.Controls.Add(this.PlayerTwoXRadioButton);
			this.PlayerXGroupBox.Controls.Add(this.PlayerOneXRadioButton);
			this.PlayerXGroupBox.Location = new System.Drawing.Point(330, 154);
			this.PlayerXGroupBox.Name = "PlayerXGroupBox";
			this.PlayerXGroupBox.Size = new System.Drawing.Size(337, 71);
			this.PlayerXGroupBox.TabIndex = 16;
			this.PlayerXGroupBox.TabStop = false;
			this.PlayerXGroupBox.Text = "X For Player";
			// 
			// PlayerTwoXRadioButton
			// 
			this.PlayerTwoXRadioButton.AutoSize = true;
			this.PlayerTwoXRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PlayerTwoXRadioButton.Location = new System.Drawing.Point(169, 27);
			this.PlayerTwoXRadioButton.Name = "PlayerTwoXRadioButton";
			this.PlayerTwoXRadioButton.Size = new System.Drawing.Size(107, 24);
			this.PlayerTwoXRadioButton.TabIndex = 15;
			this.PlayerTwoXRadioButton.Text = "Player Two ";
			this.PlayerTwoXRadioButton.UseVisualStyleBackColor = true;
			this.PlayerTwoXRadioButton.CheckedChanged += new System.EventHandler(this.PlayerTwoXRadioButton_CheckedChanged);
			// 
			// PlayerOneXRadioButton
			// 
			this.PlayerOneXRadioButton.AutoSize = true;
			this.PlayerOneXRadioButton.Checked = true;
			this.PlayerOneXRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PlayerOneXRadioButton.Location = new System.Drawing.Point(8, 27);
			this.PlayerOneXRadioButton.Name = "PlayerOneXRadioButton";
			this.PlayerOneXRadioButton.Size = new System.Drawing.Size(108, 24);
			this.PlayerOneXRadioButton.TabIndex = 14;
			this.PlayerOneXRadioButton.TabStop = true;
			this.PlayerOneXRadioButton.Text = "Player One ";
			this.PlayerOneXRadioButton.UseVisualStyleBackColor = true;
			this.PlayerOneXRadioButton.CheckedChanged += new System.EventHandler(this.PlayerOneXRadioButton_CheckedChanged);
			// 
			// StartPlayerGroupBox
			// 
			this.StartPlayerGroupBox.Controls.Add(this.PlayerTwoStartRadioButton);
			this.StartPlayerGroupBox.Controls.Add(this.PlayerOneStartRadioButton);
			this.StartPlayerGroupBox.Location = new System.Drawing.Point(330, 231);
			this.StartPlayerGroupBox.Name = "StartPlayerGroupBox";
			this.StartPlayerGroupBox.Size = new System.Drawing.Size(337, 71);
			this.StartPlayerGroupBox.TabIndex = 17;
			this.StartPlayerGroupBox.TabStop = false;
			this.StartPlayerGroupBox.Text = "Start Player";
			// 
			// PlayerTwoStartRadioButton
			// 
			this.PlayerTwoStartRadioButton.AutoSize = true;
			this.PlayerTwoStartRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PlayerTwoStartRadioButton.Location = new System.Drawing.Point(169, 27);
			this.PlayerTwoStartRadioButton.Name = "PlayerTwoStartRadioButton";
			this.PlayerTwoStartRadioButton.Size = new System.Drawing.Size(107, 24);
			this.PlayerTwoStartRadioButton.TabIndex = 15;
			this.PlayerTwoStartRadioButton.Text = "Player Two ";
			this.PlayerTwoStartRadioButton.UseVisualStyleBackColor = true;
			this.PlayerTwoStartRadioButton.CheckedChanged += new System.EventHandler(this.PlayerTwoStartRadioButton_CheckedChanged);
			// 
			// PlayerOneStartRadioButton
			// 
			this.PlayerOneStartRadioButton.AutoSize = true;
			this.PlayerOneStartRadioButton.Checked = true;
			this.PlayerOneStartRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PlayerOneStartRadioButton.Location = new System.Drawing.Point(9, 27);
			this.PlayerOneStartRadioButton.Name = "PlayerOneStartRadioButton";
			this.PlayerOneStartRadioButton.Size = new System.Drawing.Size(108, 24);
			this.PlayerOneStartRadioButton.TabIndex = 14;
			this.PlayerOneStartRadioButton.TabStop = true;
			this.PlayerOneStartRadioButton.Text = "Player One ";
			this.PlayerOneStartRadioButton.UseVisualStyleBackColor = true;
			this.PlayerOneStartRadioButton.CheckedChanged += new System.EventHandler(this.PlayerOneStartRadioButton_CheckedChanged);
			// 
			// ButtonsPanel
			// 
			this.ButtonsPanel.Controls.Add(this.Button3);
			this.ButtonsPanel.Controls.Add(this.Button1);
			this.ButtonsPanel.Controls.Add(this.Button2);
			this.ButtonsPanel.Controls.Add(this.Button4);
			this.ButtonsPanel.Controls.Add(this.Button6);
			this.ButtonsPanel.Controls.Add(this.Button8);
			this.ButtonsPanel.Controls.Add(this.Button5);
			this.ButtonsPanel.Controls.Add(this.Button9);
			this.ButtonsPanel.Controls.Add(this.Button7);
			this.ButtonsPanel.Location = new System.Drawing.Point(23, 65);
			this.ButtonsPanel.Name = "ButtonsPanel";
			this.ButtonsPanel.Size = new System.Drawing.Size(301, 264);
			this.ButtonsPanel.TabIndex = 18;
			// 
			// WinsLabelForPlayerTwo
			// 
			this.WinsLabelForPlayerTwo.AutoSize = true;
			this.WinsLabelForPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WinsLabelForPlayerTwo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WinsLabelForPlayerTwo.Location = new System.Drawing.Point(259, 341);
			this.WinsLabelForPlayerTwo.Name = "WinsLabelForPlayerTwo";
			this.WinsLabelForPlayerTwo.Size = new System.Drawing.Size(124, 20);
			this.WinsLabelForPlayerTwo.TabIndex = 20;
			this.WinsLabelForPlayerTwo.Text = "PlayerTwo Wins:";
			// 
			// WinsLabelForPlayerOne
			// 
			this.WinsLabelForPlayerOne.AutoSize = true;
			this.WinsLabelForPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WinsLabelForPlayerOne.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WinsLabelForPlayerOne.Location = new System.Drawing.Point(20, 341);
			this.WinsLabelForPlayerOne.Name = "WinsLabelForPlayerOne";
			this.WinsLabelForPlayerOne.Size = new System.Drawing.Size(125, 20);
			this.WinsLabelForPlayerOne.TabIndex = 19;
			this.WinsLabelForPlayerOne.Text = "PlayerOne Wins:";
			// 
			// WinsLabelForDraw
			// 
			this.WinsLabelForDraw.AutoSize = true;
			this.WinsLabelForDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WinsLabelForDraw.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WinsLabelForDraw.Location = new System.Drawing.Point(525, 341);
			this.WinsLabelForDraw.Name = "WinsLabelForDraw";
			this.WinsLabelForDraw.Size = new System.Drawing.Size(54, 20);
			this.WinsLabelForDraw.TabIndex = 21;
			this.WinsLabelForDraw.Text = "Draw: ";
			// 
			// TurnLabel
			// 
			this.TurnLabel.AutoSize = true;
			this.TurnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TurnLabel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.TurnLabel.Location = new System.Drawing.Point(86, 32);
			this.TurnLabel.Name = "TurnLabel";
			this.TurnLabel.Size = new System.Drawing.Size(41, 20);
			this.TurnLabel.TabIndex = 22;
			this.TurnLabel.Text = "Turn";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(31, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 20);
			this.label1.TabIndex = 23;
			this.label1.Text = "Turn: ";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(675, 370);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TurnLabel);
			this.Controls.Add(this.WinsLabelForDraw);
			this.Controls.Add(this.WinsLabelForPlayerTwo);
			this.Controls.Add(this.WinsLabelForPlayerOne);
			this.Controls.Add(this.ButtonsPanel);
			this.Controls.Add(this.StartPlayerGroupBox);
			this.Controls.Add(this.PlayerXGroupBox);
			this.Controls.Add(this.PlayersNameGroupBox);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Unbeatable Tic Tac Toe";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.PlayersNameGroupBox.ResumeLayout(false);
			this.PlayersNameGroupBox.PerformLayout();
			this.PlayerXGroupBox.ResumeLayout(false);
			this.PlayerXGroupBox.PerformLayout();
			this.StartPlayerGroupBox.ResumeLayout(false);
			this.StartPlayerGroupBox.PerformLayout();
			this.ButtonsPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem startGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resetGameToolStripMenuItem;
		private System.Windows.Forms.Button Button1;
		private System.Windows.Forms.Button Button3;
		private System.Windows.Forms.Button Button2;
		private System.Windows.Forms.Button Button5;
		private System.Windows.Forms.Button Button6;
		private System.Windows.Forms.Button Button4;
		private System.Windows.Forms.Button Button8;
		private System.Windows.Forms.Button Button9;
		private System.Windows.Forms.Button Button7;
		private System.Windows.Forms.GroupBox PlayersNameGroupBox;
		private System.Windows.Forms.TextBox PlayerTwoName;
		private System.Windows.Forms.TextBox PlayerOneName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox PlayerXGroupBox;
		private System.Windows.Forms.RadioButton PlayerTwoXRadioButton;
		private System.Windows.Forms.RadioButton PlayerOneXRadioButton;
		private System.Windows.Forms.GroupBox StartPlayerGroupBox;
		private System.Windows.Forms.RadioButton PlayerTwoStartRadioButton;
		private System.Windows.Forms.RadioButton PlayerOneStartRadioButton;
		private System.Windows.Forms.Panel ButtonsPanel;
		private System.Windows.Forms.Label WinsLabelForPlayerTwo;
		private System.Windows.Forms.Label WinsLabelForPlayerOne;
		private System.Windows.Forms.Label WinsLabelForDraw;
		private System.Windows.Forms.ToolStripMenuItem playWithBotToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem impossibleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.Label TurnLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem PlayWithFriendItem;
	}
}

