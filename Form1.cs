using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ScoreboardSSBU
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
            NamePlayer1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            NamePlayer1.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //Player Name 2 textbox autocomplete
            NamePlayer2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            NamePlayer2.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //Character Name 2 textbox autocomplete
            CharacterPlayer2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CharacterPlayer2.AutoCompleteSource = AutoCompleteSource.CustomSource;

            ColorPlayer1.SelectedIndex = 0;
            ColorPlayer2.SelectedIndex = 0;

            //Create and initialize files (player names, score)
            InitializeNamesAndScoresAndDescription();

            //Load Player name's database from "PlayersDatabase.txt"
            //It's for textbox autocomplete (playername1 and playername2)
            UpdatePlayers();
            UpdateCharacters();

            //HotKeys Config
            //this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(MainForm_KeyDown);

            //Combobox default
            //BracketComboBox.SelectedIndex = 0; //0 = Winner Bracket; 1 = Looser Bracket
            //RoundComboBox.SelectedIndex = 0; //0 = Round; 1 = Finals; 2 = Grand Finals

            this.groupBox1.Click += new System.EventHandler(this.groupBox1_Click);

        }
        void InitializeNamesAndScoresAndDescription()
        {
            System.IO.Directory.CreateDirectory("Resources");

            File.Copy("Resources\\FixedData\\ImageEmptyIcon.png", "Resources\\IconPlayer1.png", true);
            File.Copy("Resources\\FixedData\\ImageEmptyIcon.png", "Resources\\IconPlayer2.png", true);
            File.Copy("Resources\\FixedData\\ImageEmptyPortrait.png", "Resources\\PortraitPlayer1.png", true);
            File.Copy("Resources\\FixedData\\ImageEmptyPortrait.png", "Resources\\PortraitPlayer2.png", true);

            string filePath = "";
            filePath = "Resources\\NamePlayer1.txt";
            CreateTextFile(@filePath, "");
            filePath = "Resources\\NamePlayer2.txt";
            CreateTextFile(@filePath, "");
            filePath = "Resources\\TeamPlayer1.txt";
            CreateTextFile(@filePath, "");
            filePath = "Resources\\TeamPlayer2.txt";
            CreateTextFile(@filePath, "");
            filePath = "Resources\\ScorePlayer1.txt";
            CreateTextFile(@filePath, "0");
            filePath = "Resources\\ScorePlayer2.txt";
            CreateTextFile(@filePath, "0");
            filePath = "Resources\\tournament_name.txt";
            CreateTextFile(@filePath, TournamentName.Text);
            filePath = "Resources\\tournament_information.txt";
            CreateTextFile(@filePath, TournamentInformation.Text);

            filePath = "Resources\\FixedData\\PlayersDatabase.txt";
            if (!File.Exists(filePath))
            {
                CreateTextFile(@filePath, "");
            }

            filePath = "Resources\\FixedData\\CharactersList.txt";
            if (!File.Exists(filePath))
            {
                CreateTextFile(@filePath, "");
            }            
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
                //else if (modifier == Constants.ALT && key == Keys.A)
                //    ResetScorePlayer1();
                //else if (modifier == Constants.ALT && key == Keys.S)
                //    ResetScorePlayer2();
            }
            base.WndProc(ref m);
        }


        //_____________________________________________________________________________
        //--------------------- Action for autocomplete textbox suggestions------------
        void UpdatePlayers()
        {
            //Collection players name for textbox PlayerName1 and PlayerName2
            AutoCompleteStringCollection playersAutocomplete = new AutoCompleteStringCollection();

            //Read Player Database from " / Resources/PlayersDatabase.txt"
            string[] lines = System.IO.File.ReadAllLines("Resources\\FixedData\\PlayersDatabase.txt");
            foreach (string line in lines)
            {
                string name = line;
                PlayerList.Add(new Player(name));

                playersAutocomplete.Add(name);
            }

            //Add name's list to textbox PlayerName1 and PlayerName2
            NamePlayer1.AutoCompleteCustomSource = playersAutocomplete;
            NamePlayer2.AutoCompleteCustomSource = playersAutocomplete;
        }
        //--------------------- End Action for autocomplete textbox suggestions--------


        //--------------------- Action for autocomplete textbox suggestions------------
        void UpdateCharacters()
        {
            //Read Player Database from "/Resources/PlayersDatabase.txt"
            var list = new AutoCompleteStringCollection();

            string[] lines = System.IO.File.ReadAllLines("Resources\\FixedData\\CharactersList.txt");
            foreach (string line in lines)
            {
                string name = line;
                list.Add(name); 
            }
            //Character Name textbox autocomplete
            CharacterPlayer1.AutoCompleteCustomSource = list;
            CharacterPlayer2.AutoCompleteCustomSource = list;

            //This allows selection in combobox without autocomplete input
            BindingList<string> ObjectBindingList1;
            ObjectBindingList1 = new BindingList<string>();
            foreach(string line in lines){
                ObjectBindingList1.Add(line);
            }
            CharacterPlayer1.DataSource = ObjectBindingList1;
            CharacterPlayer1.Text = "none";

            BindingList<string> ObjectBindingList2;
            ObjectBindingList2 = new BindingList<string>();
            foreach (string line in lines)
            {
                ObjectBindingList2.Add(line);
            }
            CharacterPlayer2.DataSource = ObjectBindingList2;
            CharacterPlayer2.Text = "none";
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
                new System.IO.StreamWriter("Resources\\ScorePlayer1.txt"))
            {
                file.Write(Convert.ToString(score + 1));
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
                    new System.IO.StreamWriter("Resources\\ScorePlayer1.txt"))
                {
                    file.Write(Convert.ToString(score - 1));
                }
                ScorePlayer1.Text = Convert.ToString(score - 1);
            }
        }
        private void UpScorePlayer2()
        {
            int score = Convert.ToInt32(ScorePlayer2.Text);
            //Write Score
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter("Resources\\ScorePlayer2.txt"))
            {
                file.Write(Convert.ToString(score + 1));
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
                    new System.IO.StreamWriter("Resources\\ScorePlayer2.txt"))
                {
                    file.Write(Convert.ToString(score - 1));
                }
                ScorePlayer2.Text = Convert.ToString(score - 1);
            }
        }

        private void ResetScorePlayer1()
        {
            int score = Convert.ToInt32(ScorePlayer1.Text);
            //Write Score
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter("Resources\\ScorePlayer1.txt"))
            {
                file.Write(Convert.ToString(0));
            }
            ScorePlayer1.Text = Convert.ToString(0);
            /*
            string message = "Está seguro que quiere resetear el marcador izquierdo?";
            string title = "Reset";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int score = Convert.ToInt32(ScorePlayer1.Text);
                //Write Score
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter("Resources\\ScorePlayer1.txt"))
                {
                    file.Write(Convert.ToString(0));
                }
                ScorePlayer1.Text = Convert.ToString(0);
            }
            */
        }

        private void ResetScorePlayer2()
        {
            int score = Convert.ToInt32(ScorePlayer2.Text);
            //Write Score
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter("Resources\\ScorePlayer2.txt"))
            {
                file.Write(Convert.ToString(0));
            }
            ScorePlayer2.Text = Convert.ToString(0);
            /*
            string message = "Está seguro que quiere resetear el marcador derecho?";
            string title = "Reset";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int score = Convert.ToInt32(ScorePlayer2.Text);
                //Write Score
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter("Resources\\ScorePlayer2.txt"))
                {
                    file.Write(Convert.ToString(0));
                }
                ScorePlayer2.Text = Convert.ToString(0);
            }
            */
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
                new System.IO.StreamWriter("Resources\\ScorePlayer2.txt"))
            {
                file.Write(Convert.ToString(score + 1));
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
                    new System.IO.StreamWriter("Resources\\ScorePlayer2.txt"))
                {
                    file.Write(Convert.ToString(score - 1));
                }

                ScorePlayer2.Text = Convert.ToString(score - 1);
            }
        }
        private void UpScorePlayer1_Button_Click(object sender, EventArgs e)
        {
            int score = Convert.ToInt32(ScorePlayer1.Text);

            //Write Score
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter("Resources\\ScorePlayer1.txt"))
            {
                file.Write(Convert.ToString(score + 1));
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
                new System.IO.StreamWriter("Resources\\ScorePlayer1.txt"))
                {
                    file.Write(Convert.ToString(score - 1));
                }

                ScorePlayer1.Text = Convert.ToString(score - 1);
            }
        }
        private void ResetScorePlayer2_Button_Click(object sender, EventArgs e)
        {
            int score = Convert.ToInt32(ScorePlayer2.Text);
            //Write Score
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter("Resources\\ScorePlayer2.txt"))
            {
                file.Write(Convert.ToString(0));
            }
            ScorePlayer2.Text = Convert.ToString(0);
            /*
            string message = "Está seguro que quiere resetear el marcador derecho?";
            string title = "Reset";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int score = Convert.ToInt32(ScorePlayer2.Text);
                //Write Score
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter("Resources\\ScorePlayer2.txt"))
                {
                    file.Write(Convert.ToString(0));
                }
                ScorePlayer2.Text = Convert.ToString(0);
            }
            */

        }
        private void ResetScorePlayer1_Button_Click(object sender, EventArgs e)
        {
            int score = Convert.ToInt32(ScorePlayer1.Text);
            //Write Score
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter("Resources\\ScorePlayer1.txt"))
            {
                file.Write(Convert.ToString(0));
            }
            ScorePlayer1.Text = Convert.ToString(0);
            /*
            string message = "Está seguro que quiere resetear el marcador izquierdo?";
            string title = "Reset";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int score = Convert.ToInt32(ScorePlayer1.Text);
                //Write Score
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter("Resources\\ScorePlayer1.txt"))
                {
                    file.Write(Convert.ToString(0));
                }
                ScorePlayer1.Text = Convert.ToString(0);
            }
            */
        }
        //-------------------------End Actions Score's Button -----------------------------
        //_________________________________________________________________________________
        //_________________________________________________________________________________




        //___________________________ Player's name and team to OBS _______________________
        //_________________________________________________________________________________
        //------------------------- Add Player names into .txt for OBS -----------------------        
        private void NamePlayer1_KeyDown(object sender, KeyEventArgs e)
        {
            //Press enter to activate
            if (e.KeyCode == Keys.Enter)
            {
                //PlayerName1.Text = FirstLetterToUpper(PlayerName1.Text);
                //Write playername1
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter("Resources\\NamePlayer1.txt"))
                {
                    file.Write(NamePlayer1.Text);
                }
            }
        }
        private void NamePlayer2_KeyDown(object sender, KeyEventArgs e)
        {
            //Press enter to activate
            if (e.KeyCode == Keys.Enter)
            {
                //PlayerName2.Text = FirstLetterToUpper(PlayerName2.Text);
                //Write playername2
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter("Resources\\NamePlayer2.txt"))
                {
                    file.Write(NamePlayer2.Text);
                }
            }
        }
        private void NamePlayer1_Leave(object sender, EventArgs e)
        {
            //Leave textbox to activate
            //PlayerName1.Text = FirstLetterToUpper(PlayerName1.Text);
            //Write playername1
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter("Resources\\NamePlayer1.txt"))
            {
                file.Write(NamePlayer1.Text);
            }
        }
        private void NamePlayer2_Leave(object sender, EventArgs e)
        {
            //Leave textbox to activate
            //PlayerName2.Text = FirstLetterToUpper(PlayerName2.Text);
            //Write playername2
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter("Resources\\NamePlayer2.txt"))
            {
                file.Write(NamePlayer2.Text);
            }
        }
        //------------------------- End Add Player names to txt for OBS -------------------
        //_________________________________________________________________________________



        //_________________________________________________________________________________
        //------------------------- Write Players Team into .txt for OBS -----------------------
        private void TeamPlayer1_KeyDown(object sender, KeyEventArgs e)
        {
            //Press enter to activate
            if (e.KeyCode == Keys.Enter)
            {
                //PlayerTeam1.Text = PlayerTeam1.Text.ToUpper();
                //Write PlayerTeam1
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter("Resources\\TeamPlayer1.txt"))
                {
                    file.Write(TeamPlayer1.Text);
                }
            }
        }
        private void TeamPlayer2_KeyDown(object sender, KeyEventArgs e)
        {
            //Press enter to activate
            if (e.KeyCode == Keys.Enter)
            {
                //PlayerTeam2.Text = PlayerTeam2.Text.ToUpper();
                //Write PlayerTeam2
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter("Resources\\TeamPlayer2.txt"))
                {
                    file.Write(TeamPlayer2.Text);
                }
            }
        }
        private void TeamPlayer1_Leave(object sender, EventArgs e)
        {
            //Leave textbox to activate
            //PlayerTeam1.Text = PlayerTeam1.Text.ToUpper();
            //Write PlayerTeam1
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter("Resources\\TeamPlayer1.txt"))
            {
                file.Write(TeamPlayer1.Text);
            }
        }
        private void TeamPlayer2_Leave(object sender, EventArgs e)
        {
            //Leave textbox to activate
            //PlayerTeam2.Text = PlayerTeam2.Text.ToUpper();
            //Write PlayerTeam2
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter("Resources\\TeamPlayer2.txt"))
            {
                file.Write(TeamPlayer2.Text);
            }
        }
        //------------------------- End Add Players Team to txt for OBS -------------------
        //_________________________________________________________________________________


        public void ReplaceImage(string name, string player, string imageType, string imageColor)
        {
            try
            {
                string strColor = imageColor;
                int result = -1; 
                if(player == "Player1")
                {
                    strColor = ColorPlayer1.Text;
                    result = Int32.Parse(strColor);
                    result--;
                    if (result < 0 || result > 7)
                    {
                        Console.WriteLine("No valid color");
                        int auxThrow = Int32.Parse("exception");
                    }
                }
                else if(player == "Player2")
                {
                    strColor = ColorPlayer2.Text;
                    result = Int32.Parse(strColor);
                    result--;
                    if (result < 0 || result > 7)
                    {
                        Console.WriteLine("No valid color");
                        int auxThrow = Int32.Parse("exception");
                    }
                }

                string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                var directory = System.IO.Path.GetDirectoryName(path);
                string filepath = @directory + "\\" + imageType + "\\" + name + "_0" + result.ToString() + ".png";
                Console.WriteLine(filepath);
                if (!File.Exists(@filepath))
                {
                    try
                    {
                        File.Copy("Resources\\FixedData\\ImageEmpty" + imageType + ".png", "Resources\\" + imageType + player + ".png", true);
                        if (player == "Player1")
                        {
                            pictureBox1.Image = Image.FromFile("Resources\\FixedData\\ImageEmpty" + imageType + ".png");
                            pictureBox1.Refresh();
                        }
                        else if (player == "Player2")
                        {
                            pictureBox2.Image = Image.FromFile("Resources\\FixedData\\ImageEmpty" + imageType + ".png");
                            pictureBox2.Refresh();
                        }
                        Console.WriteLine("No image found");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error copy Resources\\FixedData\\ImageEmpty" + imageType + ".png to Resources\\" + imageType + player + ".png");
                    }
                }
                else
                {
                    try
                    {
                        File.Copy(@filepath, "Resources\\" + imageType + player + ".png", true);
                        if (player == "Player1")
                        {
                            pictureBox1.Image = Image.FromFile(@filepath);
                            pictureBox1.Refresh();
                        }
                        else if (player == "Player2")
                        {
                            pictureBox2.Image = Image.FromFile(@filepath);
                            pictureBox2.Refresh();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error copy " + imageType + "\\" + name + ".png to Resources\\" + imageType + player + ".png");
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse color from string to int");
            }
                    
        }


        //_______________________________________________________________________________
        //------------------------- Add characters to txt for OBS -----------------------
        private void CharacterPlayer1_KeyDown(object sender, KeyEventArgs e)
        {
            //Press enter to activate
            if (e.KeyCode == Keys.Enter)
            {
                string name = CharacterPlayer1.Text.ToLower();
               
                name = name.Replace(".", "");
                name = name.Replace(" ", "_");
                name = name.Replace("-", "_");
                name = name.Replace("\n", "").Replace("\r", "");

                ReplaceImage(name, "Player1", "Portrait", ColorPlayer1.Text);
                ReplaceImage(name, "Player1", "Icon", ColorPlayer1.Text);
            }
        }
        private void CharacterPlayer2_KeyDown(object sender, KeyEventArgs e)
        {
            //Press enter to activate
            if (e.KeyCode == Keys.Enter)
            {
                string name = CharacterPlayer2.Text.ToLower();

                name = name.Replace(".", "");
                name = name.Replace(" ", "_");
                name = name.Replace("-", "_");
                name = name.Replace("\n", "").Replace("\r", "");

                ReplaceImage(name, "Player2", "Portrait", ColorPlayer2.Text);
                ReplaceImage(name, "Player2", "Icon", ColorPlayer2.Text);                
            }
        }
        private void CharacterPlayer1_Leave(object sender, EventArgs e)
        {
            string name = CharacterPlayer1.Text.ToLower();

            name = name.Replace(".", "");
            name = name.Replace(" ", "_");
            name = name.Replace("-", "_");
            name = name.Replace("\n", "").Replace("\r", "");

            ReplaceImage(name, "Player1", "Portrait", ColorPlayer1.Text);
            ReplaceImage(name, "Player1", "Icon", ColorPlayer1.Text);            
        }
        private void CharacterPlayer2_Leave(object sender, EventArgs e)
        {
            string name = CharacterPlayer2.Text.ToLower();

            name = name.Replace(".", "");
            name = name.Replace(" ", "_");
            name = name.Replace("-", "_");
            name = name.Replace("\n", "").Replace("\r", "");

            ReplaceImage(name, "Player2", "Portrait", ColorPlayer2.Text);
            ReplaceImage(name, "Player2", "Icon", ColorPlayer2.Text);            
        }
        //------------------------- End Add characters to txt for OBS -------------------
        //_________________________________________________________________________________



        //_________________________________________________________________________________
        //------------------------- Add Description Tourney to txt for OBS ----------------
        private void TournamentName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //descripcionTorneo.Text = FirstLetterToUpper(descripcionTorneo.Text);
                //Write descripcionTorneo
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter("Resources\\tournament_name.txt"))
                {
                    file.Write(TournamentName.Text);
                }
            }
        }

        private void TournamentName_Leave(object sender, EventArgs e)
        {
            //Leave textbox to activate
            using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter("Resources\\tournament_name.txt"))
            {
                file.Write(TournamentName.Text);
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
                    file.Write(initValue);
                }
            }
            else
            {
                //Players and Scores initialization
                using (StreamWriter file =
                    new StreamWriter(@filePath))
                {
                    file.Write(initValue);
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




        private void ChangePositionPlayerAndScore_Click(object sender, EventArgs e)
        {
            //Change scores
            string strScorePlayer1 = File.ReadAllText("Resources\\ScorePlayer1.txt");
            string strScorePlayer2 = File.ReadAllText("Resources\\ScorePlayer2.txt");

            ScorePlayer1.Text = strScorePlayer2;
            ScorePlayer2.Text = strScorePlayer1;

            using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter("Resources\\ScorePlayer1.txt"))
            {
                file.Write(strScorePlayer2);
            }
            using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter("Resources\\ScorePlayer2.txt"))
            {
                file.Write(strScorePlayer1);
            }

            //Change images and names
            ChangePositionPlayerOnly.PerformClick();
        }

        private void ChangePositionPlayerOnly_Click(object sender, EventArgs e)
        {
            //Change images and names only
            string strNamePlayer1 = File.ReadAllText("Resources\\NamePlayer1.txt");
            string strNamePlayer2 = File.ReadAllText("Resources\\NamePlayer2.txt");

            NamePlayer1.Text = strNamePlayer2;
            NamePlayer2.Text = strNamePlayer1;

            string aux = CharacterPlayer1.Text;
            CharacterPlayer1.Text = CharacterPlayer2.Text;
            CharacterPlayer2.Text = aux;

            string aux1 = ColorPlayer1.Text;
            ColorPlayer1.Text = ColorPlayer2.Text;
            ColorPlayer2.Text = aux1;

            using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter("Resources\\NamePlayer1.txt"))
            {
                file.Write(strNamePlayer2);
            }
            using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter("Resources\\NamePlayer2.txt"))
            {
                file.Write(strNamePlayer1);
            }

            //update images player1
            string strCharacterName1 = CharacterPlayer1.Text.ToLower();
            strCharacterName1 = strCharacterName1.Replace(".", "");
            strCharacterName1 = strCharacterName1.Replace(" ", "_");
            strCharacterName1 = strCharacterName1.Replace("-", "_");
            strCharacterName1 = strCharacterName1.Replace("\n", "").Replace("\r", "");

            ReplaceImage(strCharacterName1, "Player1", "Portrait", ColorPlayer1.Text);
            ReplaceImage(strCharacterName1, "Player1", "Icon", ColorPlayer1.Text);

            //update images player2
            string strCharacterName2 = CharacterPlayer2.Text.ToLower();
            strCharacterName2 = strCharacterName2.Replace(".", "");
            strCharacterName2 = strCharacterName2.Replace(" ", "_");
            strCharacterName2 = strCharacterName2.Replace("-", "_");
            strCharacterName2 = strCharacterName2.Replace("\n", "").Replace("\r", "");

            ReplaceImage(strCharacterName2, "Player2", "Portrait", ColorPlayer2.Text);
            ReplaceImage(strCharacterName2, "Player2", "Icon", ColorPlayer2.Text);            
        }


		private void CharacterPlayer1_SelectedIndexChanged(object sender, EventArgs e)
		{
            string name = CharacterPlayer1.Text.ToLower();

            name = name.Replace(".", "");
            name = name.Replace(" ", "_");
            name = name.Replace("-", "_");
            name = name.Replace("\n", "").Replace("\r", "");

            ReplaceImage(name, "Player1", "Portrait", ColorPlayer1.Text);
            ReplaceImage(name, "Player1", "Icon", ColorPlayer1.Text);            
        }

		private void CharacterPlayer2_SelectedIndexChanged(object sender, EventArgs e)
		{
            string name = CharacterPlayer2.Text.ToLower();

            name = name.Replace(".", "");
            name = name.Replace(" ", "_");
            name = name.Replace("-", "_");
            name = name.Replace("\n", "").Replace("\r", "");

            ReplaceImage(name, "Player2", "Portrait", ColorPlayer2.Text);
            ReplaceImage(name, "Player2", "Icon", ColorPlayer2.Text);            
        }

        private void ColorPlayer1_Leave(object sender, EventArgs e)
        {
            string name = CharacterPlayer1.Text.ToLower();
            name = name.Replace(".", "");
            name = name.Replace(" ", "_");
            name = name.Replace("-", "_");
            name = name.Replace("\n", "").Replace("\r", "");

            ReplaceImage(name, "Player1", "Portrait", ColorPlayer1.Text);
            ReplaceImage(name, "Player1", "Icon", ColorPlayer1.Text);
        }

        private void ColorPlayer1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = CharacterPlayer1.Text.ToLower();
            name = name.Replace(".", "");
            name = name.Replace(" ", "_");
            name = name.Replace("-", "_");
            name = name.Replace("\n", "").Replace("\r", "");

            ReplaceImage(name, "Player1", "Portrait", ColorPlayer1.Text);
            ReplaceImage(name, "Player1", "Icon", ColorPlayer1.Text);
        }

        private void ColorPlayer1_KeyDown(object sender, KeyEventArgs e)
        {
            //Press enter to activate
            if (e.KeyCode == Keys.Enter)
            {
                string name = CharacterPlayer1.Text.ToLower();
                name = name.Replace(".", "");
                name = name.Replace(" ", "_");
                name = name.Replace("-", "_");
                name = name.Replace("\n", "").Replace("\r", "");

                ReplaceImage(name, "Player1", "Portrait", ColorPlayer1.Text);
                ReplaceImage(name, "Player1", "Icon", ColorPlayer1.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void ColorPlayer2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = CharacterPlayer2.Text.ToLower();
            name = name.Replace(".", "");
            name = name.Replace(" ", "_");
            name = name.Replace("-", "_");
            name = name.Replace("\n", "").Replace("\r", "");

            ReplaceImage(name, "Player2", "Portrait", ColorPlayer2.Text);
            ReplaceImage(name, "Player2", "Icon", ColorPlayer2.Text);
        }

        private void ColorPlayer2_Leave(object sender, EventArgs e)
        {
            string name = CharacterPlayer2.Text.ToLower();
            name = name.Replace(".", "");
            name = name.Replace(" ", "_");
            name = name.Replace("-", "_");
            name = name.Replace("\n", "").Replace("\r", "");

            ReplaceImage(name, "Player2", "Portrait", ColorPlayer2.Text);
            ReplaceImage(name, "Player2", "Icon", ColorPlayer2.Text);
        }

        private void ColorPlayer2_KeyDown(object sender, KeyEventArgs e)
        {
            
            //Press enter to activate
            if (e.KeyCode == Keys.Enter)
            {
                string name = CharacterPlayer2.Text.ToLower();
                name = name.Replace(".", "");
                name = name.Replace(" ", "_");
                name = name.Replace("-", "_");
                name = name.Replace("\n", "").Replace("\r", "");

                ReplaceImage(name, "Player2", "Portrait", ColorPlayer2.Text);
                ReplaceImage(name, "Player2", "Icon", ColorPlayer2.Text);

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void TournamentInformation_Leave(object sender, EventArgs e)
        {
            //Leave textbox to activate
            using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter("Resources\\tournament_information.txt"))
            {
                file.Write(TournamentName.Text);
            }
        }

        private void TournamentInformation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //descripcionTorneo.Text = FirstLetterToUpper(descripcionTorneo.Text);
                //Write descripcionTorneo
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter("Resources\\tournament_information.txt"))
                {
                    file.Write(TournamentName.Text);
                }
            }
        }
    }
}
