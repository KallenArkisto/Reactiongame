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
            Start.Location = new Point(553, 238);
            Start.Name = "Start";
            Start.Size = new Size(102, 48);
            Start.TabIndex = 0;
            Start.Text = "Start (Spacebar)";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // scoreboardListBox
            // 
            scoreboardListBox.FormattingEnabled = true;
            scoreboardListBox.ItemHeight = 15;
            scoreboardListBox.Location = new Point(301, 12);
            scoreboardListBox.Name = "scoreboardListBox";
            scoreboardListBox.Size = new Size(221, 274);
            scoreboardListBox.TabIndex = 2;
            // 
            // SetPlayerName
            // 
            SetPlayerName.BackColor = SystemColors.Info;
            SetPlayerName.Location = new Point(686, 3);
            SetPlayerName.Name = "SetPlayerName";
            SetPlayerName.Size = new Size(103, 23);
            SetPlayerName.TabIndex = 3;
            SetPlayerName.Text = "Set Player Name";
            SetPlayerName.UseVisualStyleBackColor = false;
            SetPlayerName.Click += SetPlayerName_Click;
            // 
            // scoreLabel
            // 
            scoreLabel.BackColor = SystemColors.ControlLightLight;
            scoreLabel.Location = new Point(553, 92);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(100, 23);
            scoreLabel.TabIndex = 4;
            scoreLabel.Text = "score";
            // 
            // missClickLabel
            // 
            missClickLabel.Location = new Point(552, 155);
            missClickLabel.Name = "missClickLabel";
            missClickLabel.Size = new Size(100, 23);
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
            timeLabel.Location = new Point(367, 442);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(230, 72);
            timeLabel.TabIndex = 8;
            timeLabel.Text = "Timer";
            timeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.AppWorkspace;
            pictureBox1.Image = Properties.Resources.Green_BG_One;
            pictureBox1.Location = new Point(11, 31);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 483);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.AppWorkspace;
            pictureBox2.Image = Properties.Resources.Red_BG_Zero;
            pictureBox2.Location = new Point(686, 31);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(265, 483);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // currentPlayerLabel
            // 
            currentPlayerLabel.AutoSize = true;
            currentPlayerLabel.BackColor = SystemColors.Control;
            currentPlayerLabel.Location = new Point(552, 74);
            currentPlayerLabel.Margin = new Padding(2, 0, 2, 0);
            currentPlayerLabel.Name = "currentPlayerLabel";
            currentPlayerLabel.Size = new Size(45, 15);
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
            label1.Location = new Point(552, 137);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 12;
            label1.Text = "MissClick counter";
            // 
            // playerNameTextBox
            // 
            playerNameTextBox.Location = new Point(795, 3);
            playerNameTextBox.Name = "playerNameTextBox";
            playerNameTextBox.Size = new Size(155, 23);
            playerNameTextBox.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(962, 546);
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