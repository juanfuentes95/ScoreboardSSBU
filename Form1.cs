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

        private Hotkeys ghk1;
        private Hotkeys ghk2;
        private Hotkeys ghk3;
        private Hotkeys ghk4;
        private Hotkeys ghk5;
        private Hotkeys ghk6;


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
            //this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(MainForm_KeyDown);

            //Combobox default
            BracketComboBox.SelectedIndex = 0; //0 = Winner Bracket; 1 = Looser Bracket
            RoundComboBox.SelectedIndex = 0; //0 = Round; 1 = Finals; 2 = Grand Finals

            this.groupBox1.Click += new System.EventHandler(this.groupBox1_Click);

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
   
       
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
            {
                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
                int modifier = (int)m.LParam & 0xFFFF;
                if (modifier == Constants.ALT && key == Keys.D1)
                    UpScorePlayer1();
                else if (modifier == Constants.ALT && key == Keys.D2)
                    UpScorePlayer2();
                else if (modifier == Constants.ALT && key == Keys.Q)
                    DownScorePlayer1();
                else if (modifier == Constants.ALT && key == Keys.W)
                    DownScorePlayer2();
                else if (modifier == Constants.ALT && key == Keys.A)
                    ResetScorePlayer1();
                else if (modifier == Constants.ALT && key == Keys.S)
                    ResetScorePlayer2();

            }
            base.WndProc(ref m);
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

        private void UpScorePlayer1()
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
        private void DownScorePlayer1()
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
        private void UpScorePlayer2()
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
        private void DownScorePlayer2()
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

        private void ResetScorePlayer1()
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

        private void ResetScorePlayer2()
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


        /*
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
        */
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

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ActiveControl = null;
        }

        //Button "?"
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        //Delete hotkeys registered for score
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ghk1.Unregister();
            ghk2.Unregister();
            ghk3.Unregister();
            ghk4.Unregister();
            ghk5.Unregister();
            ghk6.Unregister();
        }

        //Register hotkeys for scores
        private void Form1_Load(object sender, EventArgs e)
        {
            ghk1 = new Hotkeys(Constants.ALT, Keys.D1, this);
            ghk1.Register();

            ghk2 = new Hotkeys(Constants.ALT, Keys.D2, this);
            ghk2.Register();

            ghk3 = new Hotkeys(Constants.ALT, Keys.Q, this);
            ghk3.Register();

            ghk4 = new Hotkeys(Constants.ALT, Keys.W, this);
            ghk4.Register();

            ghk5 = new Hotkeys(Constants.ALT, Keys.A, this);
            ghk5.Register();

            ghk6 = new Hotkeys(Constants.ALT, Keys.S, this);
            ghk6.Register();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strPlayerName1 = File.ReadAllText(@"Resources\PlayerName1.txt");
            string strPlayerName2 = File.ReadAllText(@"Resources\PlayerName2.txt");

            string strScorePlayer1 = File.ReadAllText(@"Resources\ScorePlayer1.txt");
            string strScorePlayer2 = File.ReadAllText(@"Resources\ScorePlayer2.txt");

            string strPlayerTeam1 = File.ReadAllText(@"Resources\PlayerTeam1.txt");
            string strPlayerTeam2 = File.ReadAllText(@"Resources\PlayerTeam2.txt");

            PlayerName1.Text = strPlayerName2;
            PlayerName2.Text = strPlayerName1;

            ScorePlayer1.Text = strScorePlayer2;
            ScorePlayer2.Text = strScorePlayer1;

            PlayerTeam1.Text = strPlayerTeam2;
            PlayerTeam2.Text = strPlayerTeam1;


            using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(@"Resources\PlayerName1.txt"))
            {
                file.WriteLine(strPlayerName2);
            }
            using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(@"Resources\PlayerName2.txt"))
            {
                file.WriteLine(strPlayerName1);
            }

            using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(@"Resources\ScorePlayer1.txt"))
            {
                file.WriteLine(strScorePlayer2);
            }
            using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(@"Resources\ScorePlayer2.txt"))
            {
                file.WriteLine(strScorePlayer1);
            }

            using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(@"Resources\PlayerTeam1.txt"))
            {
                file.WriteLine(strPlayerTeam2);
            }
            using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(@"Resources\PlayerTeam2.txt"))
            {
                file.WriteLine(strPlayerTeam1);
            }

        }
    }
}
