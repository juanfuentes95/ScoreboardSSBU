namespace Scoreboards7r
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
            this.PlayerName1 = new System.Windows.Forms.TextBox();
            this.PlayerName2 = new System.Windows.Forms.TextBox();
            this.UpScorePlayer1_Button = new System.Windows.Forms.Button();
            this.DownScorePlayer1_Button = new System.Windows.Forms.Button();
            this.UpScorePlayer2_Button = new System.Windows.Forms.Button();
            this.DownScorePlayer2_Button = new System.Windows.Forms.Button();
            this.ScorePlayer1 = new System.Windows.Forms.Label();
            this.ScorePlayer2 = new System.Windows.Forms.Label();
            this.RoundComboBox = new System.Windows.Forms.ComboBox();
            this.descripcionTorneo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddPlayer_Button = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ResetScorePlayer1_Button = new System.Windows.Forms.Button();
            this.ResetScorePlayer2_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PlayerTeam2 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.PlayerTeam1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BracketComboBox
            // 
            this.BracketComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.BracketComboBox.FormattingEnabled = true;
            this.BracketComboBox.Items.AddRange(new object[] {
            "Winner Bracket",
            "Looser Bracket"});
            this.BracketComboBox.Location = new System.Drawing.Point(65, 420);
            this.BracketComboBox.Name = "BracketComboBox";
            this.BracketComboBox.Size = new System.Drawing.Size(100, 21);
            this.BracketComboBox.TabIndex = 0;
            this.BracketComboBox.TabStop = false;
            this.BracketComboBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bracket";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Round";
            this.label2.Visible = false;
            // 
            // PlayerName1
            // 
            this.PlayerName1.Location = new System.Drawing.Point(44, 94);
            this.PlayerName1.Name = "PlayerName1";
            this.PlayerName1.Size = new System.Drawing.Size(100, 20);
            this.PlayerName1.TabIndex = 2;
            this.PlayerName1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayerName1_KeyDown);
            this.PlayerName1.Leave += new System.EventHandler(this.PlayerName1_Leave);
            // 
            // PlayerName2
            // 
            this.PlayerName2.Location = new System.Drawing.Point(292, 94);
            this.PlayerName2.Name = "PlayerName2";
            this.PlayerName2.Size = new System.Drawing.Size(100, 20);
            this.PlayerName2.TabIndex = 4;
            this.PlayerName2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayerName2_KeyDown);
            this.PlayerName2.Leave += new System.EventHandler(this.PlayerName2_Leave);
            // 
            // UpScorePlayer1_Button
            // 
            this.UpScorePlayer1_Button.Location = new System.Drawing.Point(161, 68);
            this.UpScorePlayer1_Button.Name = "UpScorePlayer1_Button";
            this.UpScorePlayer1_Button.Size = new System.Drawing.Size(27, 23);
            this.UpScorePlayer1_Button.TabIndex = 6;
            this.UpScorePlayer1_Button.TabStop = false;
            this.UpScorePlayer1_Button.Text = "↑";
            this.UpScorePlayer1_Button.UseVisualStyleBackColor = true;
            this.UpScorePlayer1_Button.Click += new System.EventHandler(this.UpScorePlayer1_Button_Click);
            // 
            // DownScorePlayer1_Button
            // 
            this.DownScorePlayer1_Button.Location = new System.Drawing.Point(161, 120);
            this.DownScorePlayer1_Button.Name = "DownScorePlayer1_Button";
            this.DownScorePlayer1_Button.Size = new System.Drawing.Size(27, 23);
            this.DownScorePlayer1_Button.TabIndex = 2;
            this.DownScorePlayer1_Button.TabStop = false;
            this.DownScorePlayer1_Button.Text = "↓";
            this.DownScorePlayer1_Button.UseVisualStyleBackColor = true;
            this.DownScorePlayer1_Button.Click += new System.EventHandler(this.DownScorePlayer1_Button_Click);
            // 
            // UpScorePlayer2_Button
            // 
            this.UpScorePlayer2_Button.Location = new System.Drawing.Point(211, 68);
            this.UpScorePlayer2_Button.Name = "UpScorePlayer2_Button";
            this.UpScorePlayer2_Button.Size = new System.Drawing.Size(27, 23);
            this.UpScorePlayer2_Button.TabIndex = 8;
            this.UpScorePlayer2_Button.TabStop = false;
            this.UpScorePlayer2_Button.Text = "↑";
            this.UpScorePlayer2_Button.UseVisualStyleBackColor = true;
            this.UpScorePlayer2_Button.Click += new System.EventHandler(this.UpScorePlayer2_Button_Click);
            // 
            // DownScorePlayer2_Button
            // 
            this.DownScorePlayer2_Button.Location = new System.Drawing.Point(211, 120);
            this.DownScorePlayer2_Button.Name = "DownScorePlayer2_Button";
            this.DownScorePlayer2_Button.Size = new System.Drawing.Size(27, 23);
            this.DownScorePlayer2_Button.TabIndex = 3;
            this.DownScorePlayer2_Button.TabStop = false;
            this.DownScorePlayer2_Button.Text = "↓";
            this.DownScorePlayer2_Button.UseVisualStyleBackColor = true;
            this.DownScorePlayer2_Button.Click += new System.EventHandler(this.DownScorePlayer2_Button_Click);
            // 
            // ScorePlayer1
            // 
            this.ScorePlayer1.AutoSize = true;
            this.ScorePlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScorePlayer1.Location = new System.Drawing.Point(161, 90);
            this.ScorePlayer1.Name = "ScorePlayer1";
            this.ScorePlayer1.Size = new System.Drawing.Size(29, 31);
            this.ScorePlayer1.TabIndex = 10;
            this.ScorePlayer1.Text = "0";
            // 
            // ScorePlayer2
            // 
            this.ScorePlayer2.AutoSize = true;
            this.ScorePlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScorePlayer2.Location = new System.Drawing.Point(210, 90);
            this.ScorePlayer2.Name = "ScorePlayer2";
            this.ScorePlayer2.Size = new System.Drawing.Size(29, 31);
            this.ScorePlayer2.TabIndex = 11;
            this.ScorePlayer2.Text = "0";
            // 
            // RoundComboBox
            // 
            this.RoundComboBox.FormattingEnabled = true;
            this.RoundComboBox.Items.AddRange(new object[] {
            "Round",
            "Finals",
            "Grand Final"});
            this.RoundComboBox.Location = new System.Drawing.Point(171, 420);
            this.RoundComboBox.Name = "RoundComboBox";
            this.RoundComboBox.Size = new System.Drawing.Size(100, 21);
            this.RoundComboBox.TabIndex = 0;
            this.RoundComboBox.TabStop = false;
            this.RoundComboBox.Visible = false;
            // 
            // descripcionTorneo
            // 
            this.descripcionTorneo.Location = new System.Drawing.Point(148, 33);
            this.descripcionTorneo.Name = "descripcionTorneo";
            this.descripcionTorneo.Size = new System.Drawing.Size(100, 20);
            this.descripcionTorneo.TabIndex = 13;
            this.descripcionTorneo.TabStop = false;
            this.descripcionTorneo.Text = "Juntas Semanales";
            this.descripcionTorneo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.descripcionTorneo_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Descripción Torneo";
            // 
            // AddPlayer_Button
            // 
            this.AddPlayer_Button.Location = new System.Drawing.Point(78, 346);
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
            this.textBox2.Location = new System.Drawing.Point(154, 296);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 16;
            this.textBox2.TabStop = false;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(154, 320);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 17;
            this.textBox3.TabStop = false;
            this.textBox3.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Name";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Main";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nombre Jugador 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Nombre Jugador 2";
            // 
            // ResetScorePlayer1_Button
            // 
            this.ResetScorePlayer1_Button.Location = new System.Drawing.Point(161, 149);
            this.ResetScorePlayer1_Button.Name = "ResetScorePlayer1_Button";
            this.ResetScorePlayer1_Button.Size = new System.Drawing.Size(27, 23);
            this.ResetScorePlayer1_Button.TabIndex = 22;
            this.ResetScorePlayer1_Button.TabStop = false;
            this.ResetScorePlayer1_Button.Text = "R";
            this.ResetScorePlayer1_Button.UseVisualStyleBackColor = true;
            this.ResetScorePlayer1_Button.Click += new System.EventHandler(this.ResetScorePlayer1_Button_Click);
            // 
            // ResetScorePlayer2_Button
            // 
            this.ResetScorePlayer2_Button.Location = new System.Drawing.Point(211, 149);
            this.ResetScorePlayer2_Button.Name = "ResetScorePlayer2_Button";
            this.ResetScorePlayer2_Button.Size = new System.Drawing.Size(27, 23);
            this.ResetScorePlayer2_Button.TabIndex = 23;
            this.ResetScorePlayer2_Button.TabStop = false;
            this.ResetScorePlayer2_Button.Text = "R";
            this.ResetScorePlayer2_Button.UseVisualStyleBackColor = true;
            this.ResetScorePlayer2_Button.Click += new System.EventHandler(this.ResetScorePlayer2_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.PlayerTeam2);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.PlayerTeam1);
            this.groupBox1.Controls.Add(this.PlayerName2);
            this.groupBox1.Controls.Add(this.ResetScorePlayer2_Button);
            this.groupBox1.Controls.Add(this.PlayerName1);
            this.groupBox1.Controls.Add(this.ResetScorePlayer1_Button);
            this.groupBox1.Controls.Add(this.UpScorePlayer1_Button);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.DownScorePlayer1_Button);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.UpScorePlayer2_Button);
            this.groupBox1.Controls.Add(this.DownScorePlayer2_Button);
            this.groupBox1.Controls.Add(this.ScorePlayer1);
            this.groupBox1.Controls.Add(this.ScorePlayer2);
            this.groupBox1.Controls.Add(this.descripcionTorneo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(5, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 206);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(161, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 23);
            this.button2.TabIndex = 29;
            this.button2.TabStop = false;
            this.button2.Text = "Cambiar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 23);
            this.button1.TabIndex = 28;
            this.button1.TabStop = false;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlayerTeam2
            // 
            this.PlayerTeam2.Location = new System.Drawing.Point(255, 94);
            this.PlayerTeam2.Name = "PlayerTeam2";
            this.PlayerTeam2.Size = new System.Drawing.Size(31, 20);
            this.PlayerTeam2.TabIndex = 3;
            this.PlayerTeam2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayerTeam2_KeyDown);
            this.PlayerTeam2.Leave += new System.EventHandler(this.PlayerTeam2_Leave);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(254, 78);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(34, 13);
            this.label30.TabIndex = 26;
            this.label30.Text = "Team";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 78);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(34, 13);
            this.label29.TabIndex = 25;
            this.label29.Text = "Team";
            // 
            // PlayerTeam1
            // 
            this.PlayerTeam1.Location = new System.Drawing.Point(7, 94);
            this.PlayerTeam1.Name = "PlayerTeam1";
            this.PlayerTeam1.Size = new System.Drawing.Size(31, 20);
            this.PlayerTeam1.TabIndex = 1;
            this.PlayerTeam1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayerTeam1_KeyDown);
            this.PlayerTeam1.Leave += new System.EventHandler(this.PlayerTeam1_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 207);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Scoreboard S7R v1.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BracketComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PlayerName1;
        private System.Windows.Forms.TextBox PlayerName2;
        private System.Windows.Forms.Button UpScorePlayer1_Button;
        private System.Windows.Forms.Button DownScorePlayer1_Button;
        private System.Windows.Forms.Button UpScorePlayer2_Button;
        private System.Windows.Forms.Button DownScorePlayer2_Button;
        private System.Windows.Forms.Label ScorePlayer1;
        private System.Windows.Forms.Label ScorePlayer2;
        private System.Windows.Forms.ComboBox RoundComboBox;
        private System.Windows.Forms.TextBox descripcionTorneo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddPlayer_Button;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ResetScorePlayer1_Button;
        private System.Windows.Forms.Button ResetScorePlayer2_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PlayerTeam2;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox PlayerTeam1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

