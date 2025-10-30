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
            this.components = new System.ComponentModel.Container();
            this.Start = new System.Windows.Forms.Button();
            this.scoreboardListBox = new System.Windows.Forms.ListBox();
            this.SetPlayerName = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.TextBox();
            this.missClickLabel = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.currentPlayerLabel = new System.Windows.Forms.Label();
            this.pictureTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(553, 238);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(102, 48);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // scoreboardListBox
            // 
            this.scoreboardListBox.FormattingEnabled = true;
            this.scoreboardListBox.ItemHeight = 15;
            this.scoreboardListBox.Location = new System.Drawing.Point(301, 12);
            this.scoreboardListBox.Name = "scoreboardListBox";
            this.scoreboardListBox.Size = new System.Drawing.Size(221, 274);
            this.scoreboardListBox.TabIndex = 2;
            // 
            // SetPlayerName
            // 
            this.SetPlayerName.BackColor = System.Drawing.SystemColors.Info;
            this.SetPlayerName.Location = new System.Drawing.Point(686, 3);
            this.SetPlayerName.Name = "SetPlayerName";
            this.SetPlayerName.Size = new System.Drawing.Size(103, 23);
            this.SetPlayerName.TabIndex = 3;
            this.SetPlayerName.Text = "Set Player Name";
            this.SetPlayerName.UseVisualStyleBackColor = false;
            this.SetPlayerName.Click += new System.EventHandler(this.SetPlayerName_Click);
            
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.scoreLabel.Location = new System.Drawing.Point(553, 92);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(100, 23);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "score";
            // 
            // missClickLabel
            // 
            this.missClickLabel.Location = new System.Drawing.Point(552, 155);
            this.missClickLabel.Name = "missClickLabel";
            this.missClickLabel.Size = new System.Drawing.Size(100, 23);
            this.missClickLabel.TabIndex = 5;
            this.missClickLabel.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.Location = new System.Drawing.Point(367, 442);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(230, 72);
            this.timeLabel.TabIndex = 8;
            this.timeLabel.Text = "Timer";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Image = global::Reaction_game.Properties.Resources.Green_BG_One;
            this.pictureBox1.Location = new System.Drawing.Point(11, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 483);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.Image = global::Reaction_game.Properties.Resources.Red_BG_Zero;
            this.pictureBox2.Location = new System.Drawing.Point(686, 31);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(265, 483);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // currentPlayerLabel
            // 
            this.currentPlayerLabel.AutoSize = true;
            this.currentPlayerLabel.BackColor = System.Drawing.SystemColors.Control;
            this.currentPlayerLabel.Location = new System.Drawing.Point(552, 74);
            this.currentPlayerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentPlayerLabel.Name = "currentPlayerLabel";
            this.currentPlayerLabel.Size = new System.Drawing.Size(45, 15);
            this.currentPlayerLabel.TabIndex = 11;
            this.currentPlayerLabel.Text = "Player1";
            // 
            // pictureTimer
            // 
            this.pictureTimer.Interval = 300;
            this.pictureTimer.Tick += new System.EventHandler(this.pictureTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(552, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "MissClick counter";
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Location = new System.Drawing.Point(795, 3);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(155, 23);
            this.playerNameTextBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(962, 546);
            this.Controls.Add(this.playerNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentPlayerLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.missClickLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.SetPlayerName);
            this.Controls.Add(this.scoreboardListBox);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Reaction game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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