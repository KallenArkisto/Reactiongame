namespace Reaction_game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Start = new Button();
            scoreboardListBox = new ListBox();
            SetPlayerName = new Button();
            scoreLabel = new TextBox();
            missClickLabel = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timeLabel = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            currentPlayerLabel = new Label();
            pictureTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            playerNameTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Start
            // 
            Start.Location = new Point(790, 397);
            Start.Margin = new Padding(4, 5, 4, 5);
            Start.Name = "Start";
            Start.Size = new Size(146, 80);
            Start.TabIndex = 0;
            Start.Text = "Start (Spacebar)";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // scoreboardListBox
            // 
            scoreboardListBox.FormattingEnabled = true;
            scoreboardListBox.ItemHeight = 25;
            scoreboardListBox.Location = new Point(430, 20);
            scoreboardListBox.Margin = new Padding(4, 5, 4, 5);
            scoreboardListBox.Name = "scoreboardListBox";
            scoreboardListBox.Size = new Size(314, 454);
            scoreboardListBox.TabIndex = 2;
            // 
            // SetPlayerName
            // 
            SetPlayerName.BackColor = SystemColors.Info;
            SetPlayerName.Location = new Point(953, 5);
            SetPlayerName.Margin = new Padding(4, 5, 4, 5);
            SetPlayerName.Name = "SetPlayerName";
            SetPlayerName.Size = new Size(174, 38);
            SetPlayerName.TabIndex = 3;
            SetPlayerName.Text = "Set Player Name";
            SetPlayerName.UseVisualStyleBackColor = false;
            SetPlayerName.Click += SetPlayerName_Click;
            // 
            // scoreLabel
            // 
            scoreLabel.BackColor = SystemColors.ControlLightLight;
            scoreLabel.Location = new Point(790, 153);
            scoreLabel.Margin = new Padding(4, 5, 4, 5);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(141, 31);
            scoreLabel.TabIndex = 4;
            scoreLabel.Text = "score";
            // 
            // missClickLabel
            // 
            missClickLabel.Location = new Point(789, 258);
            missClickLabel.Margin = new Padding(4, 5, 4, 5);
            missClickLabel.Name = "missClickLabel";
            missClickLabel.Size = new Size(141, 31);
            missClickLabel.TabIndex = 5;
            missClickLabel.Text = "0";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timeLabel
            // 
            timeLabel.BackColor = SystemColors.ActiveCaption;
            timeLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.Location = new Point(524, 737);
            timeLabel.Margin = new Padding(4, 0, 4, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(329, 120);
            timeLabel.TabIndex = 8;
            timeLabel.Text = "Timer";
            timeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.AppWorkspace;
            pictureBox1.Image = Properties.Resources.Green_BG_One;
            pictureBox1.Location = new Point(16, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(379, 805);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.AppWorkspace;
            pictureBox2.Image = Properties.Resources.Red_BG_Zero;
            pictureBox2.Location = new Point(980, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(379, 805);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // currentPlayerLabel
            // 
            currentPlayerLabel.AutoSize = true;
            currentPlayerLabel.BackColor = SystemColors.Control;
            currentPlayerLabel.Location = new Point(789, 123);
            currentPlayerLabel.Name = "currentPlayerLabel";
            currentPlayerLabel.Size = new Size(69, 25);
            currentPlayerLabel.TabIndex = 11;
            currentPlayerLabel.Text = "Player1";
            // 
            // pictureTimer
            // 
            pictureTimer.Interval = 300;
            pictureTimer.Tick += pictureTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(789, 228);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 12;
            label1.Text = "MissClick counter";
            // 
            // playerNameTextBox
            // 
            playerNameTextBox.Location = new Point(1136, 5);
            playerNameTextBox.Margin = new Padding(4, 5, 4, 5);
            playerNameTextBox.Name = "playerNameTextBox";
            playerNameTextBox.Size = new Size(220, 31);
            playerNameTextBox.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1374, 910);
            Controls.Add(playerNameTextBox);
            Controls.Add(label1);
            Controls.Add(currentPlayerLabel);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(timeLabel);
            Controls.Add(missClickLabel);
            Controls.Add(scoreLabel);
            Controls.Add(SetPlayerName);
            Controls.Add(scoreboardListBox);
            Controls.Add(Start);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Reaction game";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button Start;
        private ListBox scoreboardListBox;
        private Button SetPlayerName;
        private TextBox scoreLabel;
        private TextBox missClickLabel;
        private System.Windows.Forms.Timer timer1;
        private Label timeLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label currentPlayerLabel;
        private System.Windows.Forms.Timer pictureTimer;
        private Label label1;
        private TextBox playerNameTextBox;
    }
}