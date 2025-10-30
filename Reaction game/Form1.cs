using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.IO;
using System.Text.Json;
namespace Reaction_game
{

    public partial class Form1 : Form
    {
        private readonly string scoreFilePath = "scores.json";
        private List<PlayerScore> scores = new List<PlayerScore>();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadScoresFromFile();
            UpdateScoreboard();
        }



        Random rand = new Random();
        private bool GameOn = false;
        int timeLeft = 15;
        int score = 0;
        int missed = 0;
        string playerName = "Player1";
        

        public class PlayerScore
        {
            public string PlayerName { get; set; }
            public int Score { get; set; }

            public int Missed { get; set; }

            public PlayerScore() { } // required for JSON deserialization

            public PlayerScore(string playerName, int score, int missed)
            {
                PlayerName = playerName;
                Score = score;
                Missed = missed;
            }

            public override string ToString()
            {
                return $"{PlayerName}  Score:{Score}   Missed:{Missed}";
            }
        }



        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // lets the form capture key events
            this.KeyDown += Form1_KeyDown;

            this.Load += Form1_Load;

        }


        
        

       

        private void Start_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pictureTimer.Start();

            
            score = 0;
            missed = 0;
            timeLeft = 15;

            missClickLabel.Text = missed + "";
            scoreLabel.Text = "Score: " + score;
            timeLabel.Text = timeLeft + " seconds";

            Start.Enabled = false;
            GameOn = true;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            


        }

        //KEYPRESS READER
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 && pictureBox1.Visible)
            {
                pictureBox1.Visible = false;
                score++;
                scoreLabel.Text = "Score: " + score;
            }
            else if (e.KeyCode == Keys.D0 && pictureBox2.Visible)
            {
                pictureBox2.Visible = false;
                score++;
                scoreLabel.Text = "Score: " + score;
            }
            else if (GameOn== true)
                { 
                missed++;
                missClickLabel.Text = missed + "";
                    }
            else if (e.KeyCode == Keys.Space)
            {
                Start_Click(sender, e);
            }

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft - 1;
            timeLabel.Text = timeLeft + " seconds";
            if (timeLeft <= 0)
            {
                timer1.Stop();
                pictureTimer.Stop();
                Start.Enabled = true;
                GameOn = false;
                
                // Add the player's score to the list
                if (!string.IsNullOrEmpty(playerName))
                {
                    scores.Add(new PlayerScore(playerName, score, missed));
                    SaveScoresToFile();
                    UpdateScoreboard();
                }
            }
            }
        private void pictureTimer_Tick(object sender, EventArgs e)
        {
            

           int choice = rand.Next(1, 3); 
            
            {
                

                if (choice == 1)
                {
                    pictureBox1.Visible = true;
                    
                }
                if (choice == 2)
                {
                    pictureBox2.Visible = true;
                    
                }
            }
        }
        private void UpdateScoreboard()
        {
            // Sort descending by score
            var topScores = scores.OrderByDescending(s => s.Score).Take(10).ToList();

            scoreboardListBox.Items.Clear();

            foreach (var playerScore in topScores)
            {
                scoreboardListBox.Items.Add(playerScore);
            }
        }

        private void SetPlayerName_Click(object sender, EventArgs e)
        {
            string inputName = playerNameTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(inputName))
            {
                playerName = inputName;
                MessageBox.Show($"Player name set to: {playerName}");

                // Optionally update a label showing the current player name
                currentPlayerLabel.Text = "Player: " + playerName;
                this.ActiveControl = null;
            }
            else
            {
                MessageBox.Show("Please enter a valid player name.");
            }
        }
        private void SaveScoresToFile()
        {
            try
            {
                string json = JsonSerializer.Serialize(scores);
                File.WriteAllText(scoreFilePath, json);
                MessageBox.Show("Saving to: " + Path.GetFullPath(scoreFilePath));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving scores: " + ex.Message);
            }
        }

        private void LoadScoresFromFile()
        {
            try
            {
                if (File.Exists(scoreFilePath))
                {
                    string json = File.ReadAllText(scoreFilePath);
                    scores = JsonSerializer.Deserialize<List<PlayerScore>>(json) ?? new List<PlayerScore>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading scores: " + ex.Message);
                scores = new List<PlayerScore>(); // fallback
            }
        }



    }







}