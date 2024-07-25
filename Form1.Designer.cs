namespace ScoreboardSSBU
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BracketComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NamePlayer1 = new System.Windows.Forms.TextBox();
            this.NamePlayer2 = new System.Windows.Forms.TextBox();
            this.UpScorePlayer1_Button = new System.Windows.Forms.Button();
            this.DownScorePlayer1_Button = new System.Windows.Forms.Button();
            this.UpScorePlayer2_Button = new System.Windows.Forms.Button();
            this.DownScorePlayer2_Button = new System.Windows.Forms.Button();
            this.ScorePlayer1 = new System.Windows.Forms.Label();
            this.ScorePlayer2 = new System.Windows.Forms.Label();
            this.RoundComboBox = new System.Windows.Forms.ComboBox();
            this.TournamentName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddPlayer_Button = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TournamentInformation = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ColorPlayer2 = new System.Windows.Forms.ComboBox();
            this.ColorPlayer1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CharacterPlayer2 = new System.Windows.Forms.ComboBox();
            this.CharacterPlayer1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChangePositionPlayerOnly = new System.Windows.Forms.Button();
            this.ChangePositionPlayerAndScore = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TeamPlayer2 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.TeamPlayer1 = new System.Windows.Forms.TextBox();
            this.ResetScorePlayer2_Button = new System.Windows.Forms.Button();
            this.ResetScorePlayer1_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BracketComboBox
            // 
            this.BracketComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.BracketComboBox.FormattingEnabled = true;
            this.BracketComboBox.Items.AddRange(new object[] {
            "Winner Bracket",
            "Looser Bracket"});
            this.BracketComboBox.Location = new System.Drawing.Point(69, 479);
            this.BracketComboBox.Name = "BracketComboBox";
            this.BracketComboBox.Size = new System.Drawing.Size(100, 21);
            this.BracketComboBox.TabIndex = 0;
            this.BracketComboBox.TabStop = false;
            this.BracketComboBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bracket";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Round";
            this.label2.Visible = false;
            // 
            // NamePlayer1
            // 
            this.NamePlayer1.Location = new System.Drawing.Point(7, 108);
            this.NamePlayer1.Name = "NamePlayer1";
            this.NamePlayer1.Size = new System.Drawing.Size(100, 20);
            this.NamePlayer1.TabIndex = 2;
            this.NamePlayer1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NamePlayer1_KeyDown);
            this.NamePlayer1.Leave += new System.EventHandler(this.NamePlayer1_Leave);
            // 
            // NamePlayer2
            // 
            this.NamePlayer2.Location = new System.Drawing.Point(224, 108);
            this.NamePlayer2.Name = "NamePlayer2";
            this.NamePlayer2.Size = new System.Drawing.Size(100, 20);
            this.NamePlayer2.TabIndex = 4;
            this.NamePlayer2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NamePlayer2_KeyDown);
            this.NamePlayer2.Leave += new System.EventHandler(this.NamePlayer2_Leave);
            // 
            // UpScorePlayer1_Button
            // 
            this.UpScorePlayer1_Button.Location = new System.Drawing.Point(118, 91);
            this.UpScorePlayer1_Button.Name = "UpScorePlayer1_Button";
            this.UpScorePlayer1_Button.Size = new System.Drawing.Size(45, 29);
            this.UpScorePlayer1_Button.TabIndex = 6;
            this.UpScorePlayer1_Button.TabStop = false;
            this.UpScorePlayer1_Button.Text = "↑";
            this.UpScorePlayer1_Button.UseVisualStyleBackColor = true;
            this.UpScorePlayer1_Button.Click += new System.EventHandler(this.UpScorePlayer1_Button_Click);
            // 
            // DownScorePlayer1_Button
            // 
            this.DownScorePlayer1_Button.Location = new System.Drawing.Point(118, 145);
            this.DownScorePlayer1_Button.Name = "DownScorePlayer1_Button";
            this.DownScorePlayer1_Button.Size = new System.Drawing.Size(45, 29);
            this.DownScorePlayer1_Button.TabIndex = 2;
            this.DownScorePlayer1_Button.TabStop = false;
            this.DownScorePlayer1_Button.Text = "↓";
            this.DownScorePlayer1_Button.UseVisualStyleBackColor = true;
            this.DownScorePlayer1_Button.Click += new System.EventHandler(this.DownScorePlayer1_Button_Click);
            // 
            // UpScorePlayer2_Button
            // 
            this.UpScorePlayer2_Button.Location = new System.Drawing.Point(168, 91);
            this.UpScorePlayer2_Button.Name = "UpScorePlayer2_Button";
            this.UpScorePlayer2_Button.Size = new System.Drawing.Size(44, 29);
            this.UpScorePlayer2_Button.TabIndex = 8;
            this.UpScorePlayer2_Button.TabStop = false;
            this.UpScorePlayer2_Button.Text = "↑";
            this.UpScorePlayer2_Button.UseVisualStyleBackColor = true;
            this.UpScorePlayer2_Button.Click += new System.EventHandler(this.UpScorePlayer2_Button_Click);
            // 
            // DownScorePlayer2_Button
            // 
            this.DownScorePlayer2_Button.Location = new System.Drawing.Point(168, 145);
            this.DownScorePlayer2_Button.Name = "DownScorePlayer2_Button";
            this.DownScorePlayer2_Button.Size = new System.Drawing.Size(44, 29);
            this.DownScorePlayer2_Button.TabIndex = 3;
            this.DownScorePlayer2_Button.TabStop = false;
            this.DownScorePlayer2_Button.Text = "↓";
            this.DownScorePlayer2_Button.UseVisualStyleBackColor = true;
            this.DownScorePlayer2_Button.Click += new System.EventHandler(this.DownScorePlayer2_Button_Click);
            // 
            // ScorePlayer1
            // 
            this.ScorePlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScorePlayer1.Location = new System.Drawing.Point(118, 116);
            this.ScorePlayer1.Name = "ScorePlayer1";
            this.ScorePlayer1.Size = new System.Drawing.Size(45, 32);
            this.ScorePlayer1.TabIndex = 10;
            this.ScorePlayer1.Text = "0";
            this.ScorePlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScorePlayer2
            // 
            this.ScorePlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScorePlayer2.Location = new System.Drawing.Point(168, 116);
            this.ScorePlayer2.Name = "ScorePlayer2";
            this.ScorePlayer2.Size = new System.Drawing.Size(44, 32);
            this.ScorePlayer2.TabIndex = 11;
            this.ScorePlayer2.Text = "0";
            this.ScorePlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoundComboBox
            // 
            this.RoundComboBox.FormattingEnabled = true;
            this.RoundComboBox.Items.AddRange(new object[] {
            "Round",
            "Finals",
            "Grand Final"});
            this.RoundComboBox.Location = new System.Drawing.Point(175, 479);
            this.RoundComboBox.Name = "RoundComboBox";
            this.RoundComboBox.Size = new System.Drawing.Size(100, 21);
            this.RoundComboBox.TabIndex = 0;
            this.RoundComboBox.TabStop = false;
            this.RoundComboBox.Visible = false;
            // 
            // TournamentName
            // 
            this.TournamentName.Location = new System.Drawing.Point(7, 28);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(317, 20);
            this.TournamentName.TabIndex = 13;
            this.TournamentName.TabStop = false;
            this.TournamentName.Text = "Tourney #1";
            this.TournamentName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TournamentName_KeyDown);
            this.TournamentName.Leave += new System.EventHandler(this.TournamentName_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tournament Name";
            // 
            // AddPlayer_Button
            // 
            this.AddPlayer_Button.Location = new System.Drawing.Point(82, 431);
            this.AddPlayer_Button.Name = "AddPlayer_Button";
            this.AddPlayer_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddPlayer_Button.Size = new System.Drawing.Size(176, 23);
            this.AddPlayer_Button.TabIndex = 15;
            this.AddPlayer_Button.TabStop = false;
            this.AddPlayer_Button.Text = "Add Player";
            this.AddPlayer_Button.UseVisualStyleBackColor = true;
            this.AddPlayer_Button.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 381);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 16;
            this.textBox2.TabStop = false;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(158, 405);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 17;
            this.textBox3.TabStop = false;
            this.textBox3.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Name";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Main";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(7, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Name Player 1";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(224, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Name Player 2";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TournamentInformation);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ColorPlayer2);
            this.groupBox1.Controls.Add(this.ColorPlayer1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.CharacterPlayer2);
            this.groupBox1.Controls.Add(this.CharacterPlayer1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.ChangePositionPlayerOnly);
            this.groupBox1.Controls.Add(this.ChangePositionPlayerAndScore);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.NamePlayer2);
            this.groupBox1.Controls.Add(this.NamePlayer1);
            this.groupBox1.Controls.Add(this.UpScorePlayer1_Button);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.DownScorePlayer1_Button);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.UpScorePlayer2_Button);
            this.groupBox1.Controls.Add(this.DownScorePlayer2_Button);
            this.groupBox1.Controls.Add(this.ScorePlayer1);
            this.groupBox1.Controls.Add(this.ScorePlayer2);
            this.groupBox1.Controls.Add(this.TournamentName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(5, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 239);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // TournamentInformation
            // 
            this.TournamentInformation.Location = new System.Drawing.Point(7, 68);
            this.TournamentInformation.Name = "TournamentInformation";
            this.TournamentInformation.Size = new System.Drawing.Size(317, 20);
            this.TournamentInformation.TabIndex = 43;
            this.TournamentInformation.Text = "Winner Round 1 - Bo3";
            this.TournamentInformation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TournamentInformation_KeyDown);
            this.TournamentInformation.Leave += new System.EventHandler(this.TournamentInformation_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Tournament Information";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(276, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Color PJ2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Color PJ1";
            // 
            // ColorPlayer2
            // 
            this.ColorPlayer2.FormattingEnabled = true;
            this.ColorPlayer2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.ColorPlayer2.Location = new System.Drawing.Point(279, 211);
            this.ColorPlayer2.Name = "ColorPlayer2";
            this.ColorPlayer2.Size = new System.Drawing.Size(45, 21);
            this.ColorPlayer2.TabIndex = 39;
            this.ColorPlayer2.SelectedIndexChanged += new System.EventHandler(this.ColorPlayer2_SelectedIndexChanged);
            this.ColorPlayer2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ColorPlayer2_KeyDown);
            this.ColorPlayer2.Leave += new System.EventHandler(this.ColorPlayer2_Leave);
            // 
            // ColorPlayer1
            // 
            this.ColorPlayer1.FormattingEnabled = true;
            this.ColorPlayer1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.ColorPlayer1.Location = new System.Drawing.Point(63, 211);
            this.ColorPlayer1.Name = "ColorPlayer1";
            this.ColorPlayer1.Size = new System.Drawing.Size(44, 21);
            this.ColorPlayer1.TabIndex = 38;
            this.ColorPlayer1.SelectedIndexChanged += new System.EventHandler(this.ColorPlayer1_SelectedIndexChanged);
            this.ColorPlayer1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ColorPlayer1_KeyDown);
            this.ColorPlayer1.Leave += new System.EventHandler(this.ColorPlayer1_Leave);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(224, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Character Player 2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Character Player 1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(224, 188);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // CharacterPlayer2
            // 
            this.CharacterPlayer2.FormattingEnabled = true;
            this.CharacterPlayer2.Location = new System.Drawing.Point(224, 151);
            this.CharacterPlayer2.Name = "CharacterPlayer2";
            this.CharacterPlayer2.Size = new System.Drawing.Size(100, 21);
            this.CharacterPlayer2.TabIndex = 34;
            this.CharacterPlayer2.SelectedIndexChanged += new System.EventHandler(this.CharacterPlayer2_SelectedIndexChanged);
            this.CharacterPlayer2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CharacterPlayer2_KeyDown);
            this.CharacterPlayer2.Leave += new System.EventHandler(this.CharacterPlayer2_Leave);
            // 
            // CharacterPlayer1
            // 
            this.CharacterPlayer1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CharacterPlayer1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CharacterPlayer1.FormattingEnabled = true;
            this.CharacterPlayer1.Location = new System.Drawing.Point(7, 151);
            this.CharacterPlayer1.Name = "CharacterPlayer1";
            this.CharacterPlayer1.Size = new System.Drawing.Size(100, 21);
            this.CharacterPlayer1.TabIndex = 33;
            this.CharacterPlayer1.SelectedIndexChanged += new System.EventHandler(this.CharacterPlayer1_SelectedIndexChanged);
            this.CharacterPlayer1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CharacterPlayer1_KeyDown);
            this.CharacterPlayer1.Leave += new System.EventHandler(this.CharacterPlayer1_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(7, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // ChangePositionPlayerOnly
            // 
            this.ChangePositionPlayerOnly.Location = new System.Drawing.Point(118, 211);
            this.ChangePositionPlayerOnly.Name = "ChangePositionPlayerOnly";
            this.ChangePositionPlayerOnly.Size = new System.Drawing.Size(94, 23);
            this.ChangePositionPlayerOnly.TabIndex = 30;
            this.ChangePositionPlayerOnly.TabStop = false;
            this.ChangePositionPlayerOnly.Text = "Change PJ Only";
            this.ChangePositionPlayerOnly.UseVisualStyleBackColor = true;
            this.ChangePositionPlayerOnly.Click += new System.EventHandler(this.ChangePositionPlayerOnly_Click);
            // 
            // ChangePositionPlayerAndScore
            // 
            this.ChangePositionPlayerAndScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePositionPlayerAndScore.Location = new System.Drawing.Point(118, 184);
            this.ChangePositionPlayerAndScore.Name = "ChangePositionPlayerAndScore";
            this.ChangePositionPlayerAndScore.Size = new System.Drawing.Size(94, 25);
            this.ChangePositionPlayerAndScore.TabIndex = 29;
            this.ChangePositionPlayerAndScore.TabStop = false;
            this.ChangePositionPlayerAndScore.Text = "Change All";
            this.ChangePositionPlayerAndScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ChangePositionPlayerAndScore.UseVisualStyleBackColor = true;
            this.ChangePositionPlayerAndScore.Click += new System.EventHandler(this.ChangePositionPlayerAndScore_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 23);
            this.button1.TabIndex = 28;
            this.button1.TabStop = false;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TeamPlayer2
            // 
            this.TeamPlayer2.Enabled = false;
            this.TeamPlayer2.Location = new System.Drawing.Point(229, 330);
            this.TeamPlayer2.Name = "TeamPlayer2";
            this.TeamPlayer2.Size = new System.Drawing.Size(100, 20);
            this.TeamPlayer2.TabIndex = 3;
            this.TeamPlayer2.TabStop = false;
            this.TeamPlayer2.Visible = false;
            this.TeamPlayer2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeamPlayer2_KeyDown);
            this.TeamPlayer2.Leave += new System.EventHandler(this.TeamPlayer2_Leave);
            // 
            // label30
            // 
            this.label30.Enabled = false;
            this.label30.Location = new System.Drawing.Point(229, 315);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(100, 13);
            this.label30.TabIndex = 26;
            this.label30.Text = "Team Player 2";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label30.Visible = false;
            // 
            // label29
            // 
            this.label29.Enabled = false;
            this.label29.Location = new System.Drawing.Point(12, 316);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(100, 13);
            this.label29.TabIndex = 25;
            this.label29.Text = "Team Player 1";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label29.Visible = false;
            // 
            // TeamPlayer1
            // 
            this.TeamPlayer1.Enabled = false;
            this.TeamPlayer1.Location = new System.Drawing.Point(12, 330);
            this.TeamPlayer1.Name = "TeamPlayer1";
            this.TeamPlayer1.Size = new System.Drawing.Size(100, 20);
            this.TeamPlayer1.TabIndex = 1;
            this.TeamPlayer1.TabStop = false;
            this.TeamPlayer1.Visible = false;
            this.TeamPlayer1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeamPlayer1_KeyDown);
            this.TeamPlayer1.Leave += new System.EventHandler(this.TeamPlayer1_Leave);
            // 
            // ResetScorePlayer2_Button
            // 
            this.ResetScorePlayer2_Button.Enabled = false;
            this.ResetScorePlayer2_Button.Location = new System.Drawing.Point(175, 331);
            this.ResetScorePlayer2_Button.Name = "ResetScorePlayer2_Button";
            this.ResetScorePlayer2_Button.Size = new System.Drawing.Size(35, 19);
            this.ResetScorePlayer2_Button.TabIndex = 23;
            this.ResetScorePlayer2_Button.TabStop = false;
            this.ResetScorePlayer2_Button.Text = "R";
            this.ResetScorePlayer2_Button.UseVisualStyleBackColor = true;
            this.ResetScorePlayer2_Button.Visible = false;
            this.ResetScorePlayer2_Button.Click += new System.EventHandler(this.ResetScorePlayer2_Button_Click);
            // 
            // ResetScorePlayer1_Button
            // 
            this.ResetScorePlayer1_Button.Enabled = false;
            this.ResetScorePlayer1_Button.Location = new System.Drawing.Point(122, 330);
            this.ResetScorePlayer1_Button.Name = "ResetScorePlayer1_Button";
            this.ResetScorePlayer1_Button.Size = new System.Drawing.Size(34, 20);
            this.ResetScorePlayer1_Button.TabIndex = 22;
            this.ResetScorePlayer1_Button.TabStop = false;
            this.ResetScorePlayer1_Button.Text = "R";
            this.ResetScorePlayer1_Button.UseVisualStyleBackColor = true;
            this.ResetScorePlayer1_Button.Visible = false;
            this.ResetScorePlayer1_Button.Click += new System.EventHandler(this.ResetScorePlayer1_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 243);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.AddPlayer_Button);
            this.Controls.Add(this.RoundComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BracketComboBox);
            this.Controls.Add(this.ResetScorePlayer2_Button);
            this.Controls.Add(this.ResetScorePlayer1_Button);
            this.Controls.Add(this.TeamPlayer2);
            this.Controls.Add(this.TeamPlayer1);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ScoreboardSSBU";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BracketComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NamePlayer1;
        private System.Windows.Forms.TextBox NamePlayer2;
        private System.Windows.Forms.Button UpScorePlayer1_Button;
        private System.Windows.Forms.Button DownScorePlayer1_Button;
        private System.Windows.Forms.Button UpScorePlayer2_Button;
        private System.Windows.Forms.Button DownScorePlayer2_Button;
        private System.Windows.Forms.Label ScorePlayer1;
        private System.Windows.Forms.Label ScorePlayer2;
        private System.Windows.Forms.ComboBox RoundComboBox;
        private System.Windows.Forms.TextBox TournamentName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddPlayer_Button;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TeamPlayer2;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox TeamPlayer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ChangePositionPlayerAndScore;
        private System.Windows.Forms.Button ChangePositionPlayerOnly;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CharacterPlayer1;
        private System.Windows.Forms.ComboBox CharacterPlayer2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button ResetScorePlayer2_Button;
		private System.Windows.Forms.Button ResetScorePlayer1_Button;
        private System.Windows.Forms.ComboBox ColorPlayer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ColorPlayer2;
        private System.Windows.Forms.TextBox TournamentInformation;
        private System.Windows.Forms.Label label12;
    }
}

