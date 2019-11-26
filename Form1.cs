using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Scoreboards7r
{
    public partial class Form1 : Form
    {
        //Player List
        List<Player> PlayerList = new List<Player>();

        public Form1()
        {
            InitializeComponent();

            //Player Name 1 textbox autocomplete
            PlayerName1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            PlayerName1.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //Player Name 2 textbox autocomplete
            PlayerName2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            PlayerName2.AutoCompleteSource = AutoCompleteSource.CustomSource;


            //Create and initialize files (player names, score)
            InitializeNamesAndScoresAndDescription();

            //Load Player name's database from "PlayersDatabase.txt"
            //It's for textbox autocomplete (playername1 and playername2)
            UpdatePlayers();

            //HotKeys Config
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(MainForm_KeyDown);

            //Combobox default
            BracketComboBox.SelectedIndex = 0; //0 = Winner Bracket; 1 = Looser Bracket
            RoundComboBox.SelectedIndex = 0; //0 = Round; 1 = Finals; 2 = Grand Finals

            this.groupBox1.Click += new System.EventHandler(this.groupBox1_Click);
            this.groupBox2.Click += new System.EventHandler(this.groupBox2_Click);
            this.groupBox3.Click += new System.EventHandler(this.groupBox3_Click);
            this.groupBox4.Click += new System.EventHandler(this.groupBox4_Click);

        }
        void InitializeNamesAndScoresAndDescription()
        {
            System.IO.Directory.CreateDirectory("Resources");
            string filePath = "";
            filePath = @"Resources\PlayerName1.txt";
            CreateTextFile(@filePath, "");
            filePath = @"Resources\PlayerName2.txt";
            CreateTextFile(@filePath, "");
            filePath = @"Resources\PlayerTeam1.txt";
            CreateTextFile(@filePath, "");
            filePath = @"Resources\PlayerTeam2.txt";
            CreateTextFile(@filePath, "");
            filePath = @"Resources\ScorePlayer1.txt";
            CreateTextFile(@filePath, "0");
            filePath = @"Resources\ScorePlayer2.txt";
            CreateTextFile(@filePath, "0");
            filePath = @"Resources\descripcionTorneo.txt";
            CreateTextFile(@filePath, descripcionTorneo.Text);
        }


        //_____________________________________________________________________________
        //--------------------- Action for autocomplete textbox suggestions------------
        void UpdatePlayers()
        {
            //Collection players name for textbox PlayerName1 and PlayerName2
            AutoCompleteStringCollection playersAutocomplete = new AutoCompleteStringCollection();

            //Read Player Database from "/Resources/PlayersDatabase.txt"
            string[] lines = System.IO.File.ReadAllLines(@"Resources\PlayersDatabase.txt");
            foreach (string line in lines)
            {
                string name = line;
                PlayerList.Add(new Player(name));

                playersAutocomplete.Add(name);
            }

            //Add name's list to textbox PlayerName1 and PlayerName2
            PlayerName1.AutoCompleteCustomSource = playersAutocomplete;
            PlayerName2.AutoCompleteCustomSource = playersAutocomplete;
        }
        //--------------------- End Action for autocomplete textbox suggestions--------
        //_____________________________________________________________________________


        //_____________________________________________________________________________
        //-------------------------Hotkeys Configuration-------------------------------
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            //up keys
            if (e.Alt && e.KeyCode == Keys.D1)
            {
                e.SuppressKeyPress = true;
                UpScorePlayer1_Button_Click(sender, e);
            }
            if (e.Alt && e.KeyCode == Keys.D2)
            {
                e.SuppressKeyPress = true;
                UpScorePlayer2_Button_Click(sender, e);
            }

            //down keys
            if (e.Alt && e.KeyCode == Keys.Q)
            {
                e.SuppressKeyPress = true;
                DownScorePlayer1_Button_Click(sender, e);
            }
            if (e.Alt && e.KeyCode == Keys.W)
            {
                e.SuppressKeyPress = true;
                DownScorePlayer2_Button_Click(sender, e);
            }

            //reset keys
            if (e.Alt && e.KeyCode == Keys.A)
            {
                e.SuppressKeyPress = true;
                ResetScorePlayer1_Button_Click(sender, e);
            }
            if (e.Alt && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true;
                ResetScorePlayer2_Button_Click(sender, e);
            }
        }
        //---------------------End Hotkeys Configuration-------------------------------
        //_____________________________________________________________________________






        //_________________________ Player's Score  to OBS ____________________________
        //_____________________________________________________________________________
        //-------------------------Actions Score's Button -----------------------------
        private void UpScorePlayer2_Button_Click(object sender, EventArgs e)
        {
            int score = Convert.ToInt32(ScorePlayer2.Text);

            //Write Score
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"Resources\ScorePlayer2.txt"))
            {
                file.WriteLine(Convert.ToString(score + 1));
            }

            ScorePlayer2.Text = Convert.ToString(score + 1);
        }
        private void DownScorePlayer2_Button_Click(object sender, EventArgs e)
        {
            int score = Convert.ToInt32(ScorePlayer2.Text);
            if (score > 0)
            {
                //Write Score
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(@"Resources\ScorePlayer2.txt"))
                {
                    file.WriteLine(Convert.ToString(score - 1));
                }

                ScorePlayer2.Text = Convert.ToString(score - 1);
            }
        }
        private void UpScorePlayer1_Button_Click(object sender, EventArgs e)
        {
            int score = Convert.ToInt32(ScorePlayer1.Text);

            //Write Score
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"Resources\ScorePlayer1.txt"))
            {
                file.WriteLine(Convert.ToString(score + 1));
            }

            ScorePlayer1.Text = Convert.ToString(score + 1);
        }
        private void DownScorePlayer1_Button_Click(object sender, EventArgs e)
        {
            int score = Convert.ToInt32(ScorePlayer1.Text);
            if (score > 0)
            {
                //Write Score
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"Resources\ScorePlayer1.txt"))
                {
                    file.WriteLine(Convert.ToString(score - 1));
                }

                ScorePlayer1.Text = Convert.ToString(score - 1);
            }
        }
        private void ResetScorePlayer2_Button_Click(object sender, EventArgs e)
        {
            int score = Convert.ToInt32(ScorePlayer2.Text);

            //Write Score
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"Resources\ScorePlayer2.txt"))
            {
                file.WriteLine(Convert.ToString(0));
            }

            ScorePlayer2.Text = Convert.ToString(0);
        }
        private void ResetScorePlayer1_Button_Click(object sender, EventArgs e)
        {
            int score = Convert.ToInt32(ScorePlayer1.Text);

            //Write Score
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"Resources\ScorePlayer1.txt"))
            {
                file.WriteLine(Convert.ToString(0));
            }

            ScorePlayer1.Text = Convert.ToString(0);
        }
        //-------------------------End Actions Score's Button -----------------------------
        //_________________________________________________________________________________
        //_________________________________________________________________________________




        //___________________________ Player's name and team to OBS _______________________
        //_________________________________________________________________________________
        //------------------------- Add Player names to txt for OBS -----------------------        
        private void PlayerName1_KeyDown(object sender, KeyEventArgs e)
        {
            //Press enter to activate
            if (e.KeyCode == Keys.Enter)
            {
                PlayerName1.Text = FirstLetterToUpper(PlayerName1.Text);
                //Write playername1
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(@"Resources\PlayerName1.txt"))
                {
                    file.WriteLine(PlayerName1.Text);
                }
            }
        }
        private void PlayerName2_KeyDown(object sender, KeyEventArgs e)
        {
            //Press enter to activate
            if (e.KeyCode == Keys.Enter)
            {
                PlayerName2.Text = FirstLetterToUpper(PlayerName2.Text);
                //Write playername2
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(@"Resources\PlayerName2.txt"))
                {
                    file.WriteLine(PlayerName2.Text);
                }
            }
        }
        private void PlayerName1_Leave(object sender, EventArgs e)
        {
            //Leave textbox to activate
            PlayerName1.Text = FirstLetterToUpper(PlayerName1.Text);
            //Write playername1
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"Resources\PlayerName1.txt"))
            {
                file.WriteLine(PlayerName1.Text);
            }
        }
        private void PlayerName2_Leave(object sender, EventArgs e)
        {
            //Leave textbox to activate
            PlayerName2.Text = FirstLetterToUpper(PlayerName2.Text);
            //Write playername2
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"Resources\PlayerName2.txt"))
            {
                file.WriteLine(PlayerName2.Text);
            }
        }
        //------------------------- End Add Player names to txt for OBS -------------------
        //_________________________________________________________________________________



        //_________________________________________________________________________________
        //------------------------- Add Players Team to txt for OBS -----------------------
        private void PlayerTeam1_KeyDown(object sender, KeyEventArgs e)
        {
            //Press enter to activate
            if (e.KeyCode == Keys.Enter)
            {
                PlayerTeam1.Text = PlayerTeam1.Text.ToUpper();
                //Write PlayerTeam1
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(@"Resources\PlayerTeam1.txt"))
                {
                    file.WriteLine(PlayerTeam1.Text);
                }
            }
        }
        private void PlayerTeam2_KeyDown(object sender, KeyEventArgs e)
        {
            //Press enter to activate
            if (e.KeyCode == Keys.Enter)
            {
                PlayerTeam2.Text = PlayerTeam2.Text.ToUpper();
                //Write PlayerTeam2
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(@"Resources\PlayerTeam2.txt"))
                {
                    file.WriteLine(PlayerTeam2.Text);
                }
            }
        }
        private void PlayerTeam1_Leave(object sender, EventArgs e)
        {
            //Leave textbox to activate
            PlayerTeam1.Text = PlayerTeam1.Text.ToUpper();
            //Write PlayerTeam1
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"Resources\PlayerTeam1.txt"))
            {
                file.WriteLine(PlayerTeam1.Text);
            }
        }
        private void PlayerTeam2_Leave(object sender, EventArgs e)
        {
            //Leave textbox to activate
            PlayerTeam2.Text = PlayerTeam2.Text.ToUpper();
            //Write PlayerTeam2
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"Resources\PlayerTeam2.txt"))
            {
                file.WriteLine(PlayerTeam2.Text);
            }
        }
        //------------------------- End Add Players Team to txt for OBS -------------------
        //_________________________________________________________________________________



        //_________________________________________________________________________________
        //------------------------- Add Description Tourney to txt for OBS ----------------
        private void descripcionTorneo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                descripcionTorneo.Text = FirstLetterToUpper(descripcionTorneo.Text);
                //Write descripcionTorneo
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(@"Resources\descripcionTorneo.txt"))
                {
                    file.WriteLine(descripcionTorneo.Text);
                }
            }
        }
        //------------------------- End Add Description Tourney to txt for OBS ------------
        //_________________________________________________________________________________
        //_________________________________________________________________________________




        //_________________________________________________________________________________
        //---------------- Others ---------------------------------------------------------

        //Change string to format "Xxxxxxxx"
        public string FirstLetterToUpper(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }
        //Create text file from filePath and a initial Value string
        void CreateTextFile(string filePath, string initValue)
        {
            if (!File.Exists(@filePath))
            {
                // Create a file to write to.
                using (StreamWriter file = File.CreateText(@filePath))
                {
                    file.WriteLine(initValue);
                }
            }
            else
            {
                //Players and Scores initialization
                using (StreamWriter file =
                    new StreamWriter(@filePath))
                {
                    file.WriteLine(initValue);
                }
            }
        }
        //ActiveControl -> null for Tab key Action :)
        private void groupBox1_Click(object sender, System.EventArgs e)
        {
            ActiveControl = null;
        }
        private void groupBox2_Click(object sender, System.EventArgs e)
        {
            ActiveControl = null;
        }
        private void groupBox3_Click(object sender, System.EventArgs e)
        {
            ActiveControl = null;
        }
        private void groupBox4_Click(object sender, System.EventArgs e)
        {
            ActiveControl = null;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ActiveControl = null;
        }
    }
}
