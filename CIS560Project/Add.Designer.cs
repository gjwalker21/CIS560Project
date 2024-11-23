namespace CIS560Project
{
    partial class Add
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
            AddTab = new TabControl();
            PlayerTab = new TabPage();
            AddPlayerButton = new Button();
            PlayerBox = new GroupBox();
            PlayerTeam = new ComboBox();
            label26 = new Label();
            PlayerSeason = new ComboBox();
            PlayerPosition = new ComboBox();
            PlayerAge = new TextBox();
            PlayerName = new TextBox();
            label16 = new Label();
            label19 = new Label();
            label23 = new Label();
            label21 = new Label();
            GameTab = new TabPage();
            AddGameButton = new Button();
            GameBox = new GroupBox();
            LoserScore = new TextBox();
            WinnerScore = new TextBox();
            label2 = new Label();
            label1 = new Label();
            GameLocation = new ComboBox();
            label12 = new Label();
            label10 = new Label();
            label24 = new Label();
            label17 = new Label();
            GameSeason = new ComboBox();
            WinnerComboBox = new ComboBox();
            AwayTeam = new ComboBox();
            HomeTeam = new ComboBox();
            GameDate = new TextBox();
            label11 = new Label();
            label20 = new Label();
            label18 = new Label();
            SeasonTab = new TabPage();
            label3 = new Label();
            SeasonSeason = new TextBox();
            AddSeasonButton = new Button();
            label4 = new Label();
            AddTab.SuspendLayout();
            PlayerTab.SuspendLayout();
            PlayerBox.SuspendLayout();
            GameTab.SuspendLayout();
            GameBox.SuspendLayout();
            SeasonTab.SuspendLayout();
            SuspendLayout();
            // 
            // AddTab
            // 
            AddTab.Controls.Add(PlayerTab);
            AddTab.Controls.Add(GameTab);
            AddTab.Controls.Add(SeasonTab);
            AddTab.Location = new Point(46, 53);
            AddTab.Name = "AddTab";
            AddTab.SelectedIndex = 0;
            AddTab.Size = new Size(696, 339);
            AddTab.TabIndex = 54;
            // 
            // PlayerTab
            // 
            PlayerTab.Controls.Add(AddPlayerButton);
            PlayerTab.Controls.Add(PlayerBox);
            PlayerTab.Location = new Point(4, 24);
            PlayerTab.Name = "PlayerTab";
            PlayerTab.Padding = new Padding(3);
            PlayerTab.Size = new Size(688, 311);
            PlayerTab.TabIndex = 1;
            PlayerTab.Text = "Player";
            PlayerTab.UseVisualStyleBackColor = true;
            // 
            // AddPlayerButton
            // 
            AddPlayerButton.Location = new Point(304, 282);
            AddPlayerButton.Name = "AddPlayerButton";
            AddPlayerButton.Size = new Size(75, 23);
            AddPlayerButton.TabIndex = 101;
            AddPlayerButton.Text = "Add Player";
            AddPlayerButton.UseVisualStyleBackColor = true;
            AddPlayerButton.Click += AddPlayerButton_Click;
            // 
            // PlayerBox
            // 
            PlayerBox.Controls.Add(PlayerTeam);
            PlayerBox.Controls.Add(label26);
            PlayerBox.Controls.Add(PlayerSeason);
            PlayerBox.Controls.Add(PlayerPosition);
            PlayerBox.Controls.Add(PlayerAge);
            PlayerBox.Controls.Add(PlayerName);
            PlayerBox.Controls.Add(label16);
            PlayerBox.Controls.Add(label19);
            PlayerBox.Controls.Add(label23);
            PlayerBox.Controls.Add(label21);
            PlayerBox.Location = new Point(28, 24);
            PlayerBox.Name = "PlayerBox";
            PlayerBox.Size = new Size(624, 237);
            PlayerBox.TabIndex = 100;
            PlayerBox.TabStop = false;
            PlayerBox.Text = "PlayerBox";
            // 
            // PlayerTeam
            // 
            PlayerTeam.DropDownStyle = ComboBoxStyle.DropDownList;
            PlayerTeam.FormattingEnabled = true;
            PlayerTeam.Items.AddRange(new object[] { "Arizona Cardinals", "Atlanta Falcons", "Baltimore Ravens", "Buffalo Bills", "Carolina Panthers", "Chicago Bears", "Cincinnati Bengals", "Cleveland Browns", "Dallas Cowboys", "Denver Broncos", "Detroit Lions", "Green Bay Packers", "Houston Texans", "Indianapolis Colts", "Jacksonville Jaguars", "Kansas City Chiefs", "Las Vegas Raiders", "Los Angeles Chargers", "Los Angeles Rams", "Miami Dolphins", "Minnesota Vikings", "New England Patriots", "New Orleans Saints", "New York Giants", "New York Jets", "Philadelphia Eagles", "Pittsburgh Steelers", "San Francisco 49ers", "Seattle Seahawks", "Tampa Bay Buccaneers", "Tennessee Titans", "Washington Commanders" });
            PlayerTeam.Location = new Point(474, 51);
            PlayerTeam.Name = "PlayerTeam";
            PlayerTeam.Size = new Size(121, 23);
            PlayerTeam.TabIndex = 94;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(396, 54);
            label26.Name = "label26";
            label26.Size = new Size(36, 15);
            label26.TabIndex = 73;
            label26.Text = "Team";
            // 
            // PlayerSeason
            // 
            PlayerSeason.DropDownStyle = ComboBoxStyle.DropDownList;
            PlayerSeason.FormattingEnabled = true;
            PlayerSeason.Items.AddRange(new object[] { "2020", "2021", "2022", "2023", "2024" });
            PlayerSeason.Location = new Point(474, 114);
            PlayerSeason.Name = "PlayerSeason";
            PlayerSeason.Size = new Size(121, 23);
            PlayerSeason.TabIndex = 91;
            // 
            // PlayerPosition
            // 
            PlayerPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            PlayerPosition.FormattingEnabled = true;
            PlayerPosition.Items.AddRange(new object[] { "G", "TE", "DL", "OLB", "ROLB/LOLB", "ROLB", "SS", "RG/RT", "DT/DE", "LDE/RDE", "LCB/RCB", "MLB", "LCB", "RCB", "RILB", "OT", "LB", "RCB/LCB", "RLB", "RT/LT", "LDE", "OL", "LG", "QB", "LS", "LOLB", "RDT/LDT", "FS", "NT", "DT", "RDE", "C/LG", "RB", "C", "LDT", "RLB/LLB", "LLB", "RG", "DB", "RG/C", "OG", "RLB/MLB", "DE", "ROLB/RILB", "LILB", "P", "RT", "RILB/LILB", "S", "DE/DT", "RT/RG", "K", "RDT", "CB", "WR", "SS/RLB", "WR/QB", "SS/FS", "T", "KB", "LT/RT", "FB", "LT" });
            PlayerPosition.Location = new Point(177, 132);
            PlayerPosition.Name = "PlayerPosition";
            PlayerPosition.Size = new Size(121, 23);
            PlayerPosition.TabIndex = 90;
            // 
            // PlayerAge
            // 
            PlayerAge.Location = new Point(177, 81);
            PlayerAge.Name = "PlayerAge";
            PlayerAge.Size = new Size(121, 23);
            PlayerAge.TabIndex = 89;
            // 
            // PlayerName
            // 
            PlayerName.Location = new Point(177, 30);
            PlayerName.Name = "PlayerName";
            PlayerName.Size = new Size(121, 23);
            PlayerName.TabIndex = 88;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(71, 33);
            label16.Name = "label16";
            label16.Size = new Size(74, 15);
            label16.TabIndex = 75;
            label16.Text = "Player Name";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(388, 117);
            label19.Name = "label19";
            label19.Size = new Size(44, 15);
            label19.TabIndex = 87;
            label19.Text = "Season";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(71, 84);
            label23.Name = "label23";
            label23.Size = new Size(63, 15);
            label23.TabIndex = 80;
            label23.Text = "Player Age";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(49, 135);
            label21.Name = "label21";
            label21.Size = new Size(85, 15);
            label21.TabIndex = 85;
            label21.Text = "Player Position";
            // 
            // GameTab
            // 
            GameTab.Controls.Add(AddGameButton);
            GameTab.Controls.Add(GameBox);
            GameTab.Location = new Point(4, 24);
            GameTab.Name = "GameTab";
            GameTab.Padding = new Padding(3);
            GameTab.Size = new Size(688, 311);
            GameTab.TabIndex = 2;
            GameTab.Text = "Game";
            GameTab.UseVisualStyleBackColor = true;
            // 
            // AddGameButton
            // 
            AddGameButton.Location = new Point(302, 282);
            AddGameButton.Name = "AddGameButton";
            AddGameButton.Size = new Size(75, 23);
            AddGameButton.TabIndex = 117;
            AddGameButton.Text = "Add Game";
            AddGameButton.UseVisualStyleBackColor = true;
            AddGameButton.Click += AddGameButton_Click;
            // 
            // GameBox
            // 
            GameBox.Controls.Add(LoserScore);
            GameBox.Controls.Add(WinnerScore);
            GameBox.Controls.Add(label2);
            GameBox.Controls.Add(label1);
            GameBox.Controls.Add(GameLocation);
            GameBox.Controls.Add(label12);
            GameBox.Controls.Add(label10);
            GameBox.Controls.Add(label24);
            GameBox.Controls.Add(label17);
            GameBox.Controls.Add(GameSeason);
            GameBox.Controls.Add(WinnerComboBox);
            GameBox.Controls.Add(AwayTeam);
            GameBox.Controls.Add(HomeTeam);
            GameBox.Controls.Add(GameDate);
            GameBox.Controls.Add(label11);
            GameBox.Controls.Add(label20);
            GameBox.Controls.Add(label18);
            GameBox.Location = new Point(32, 21);
            GameBox.Name = "GameBox";
            GameBox.Size = new Size(619, 251);
            GameBox.TabIndex = 116;
            GameBox.TabStop = false;
            GameBox.Text = "GameBox";
            // 
            // LoserScore
            // 
            LoserScore.Location = new Point(457, 211);
            LoserScore.Name = "LoserScore";
            LoserScore.Size = new Size(121, 23);
            LoserScore.TabIndex = 126;
            // 
            // WinnerScore
            // 
            WinnerScore.Location = new Point(178, 209);
            WinnerScore.Name = "WinnerScore";
            WinnerScore.Size = new Size(121, 23);
            WinnerScore.TabIndex = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 214);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 124;
            label2.Text = "Loser Score";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 209);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 123;
            label1.Text = "Winner Score";
            // 
            // GameLocation
            // 
            GameLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            GameLocation.FormattingEnabled = true;
            GameLocation.Items.AddRange(new object[] { "Arlington", "Atlanta", "Baltimore", "Charlotte", "Chicago", "Cincinnati", "Cleveland", "Denver", "Detroit", "East Rutherford", "Foxborough", "Glendale", "Green Bay", "Houston", "Indianapolis", "Inglewood", "Jacksonville", "Kansas City", "Landover", "Las Vegas", "Miami Gardens", "Minneapolis", "Nashville", "New Orleans", "Orchard Park", "Philadelphia", "Pittsburgh", "Santa Clara", "Seattle", "Tampa" });
            GameLocation.Location = new Point(457, 158);
            GameLocation.Name = "GameLocation";
            GameLocation.Size = new Size(121, 23);
            GameLocation.TabIndex = 120;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(362, 158);
            label12.Name = "label12";
            label12.Size = new Size(53, 15);
            label12.TabIndex = 119;
            label12.Text = "Location";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(457, 122);
            label10.Name = "label10";
            label10.Size = new Size(85, 15);
            label10.TabIndex = 117;
            label10.Text = "(yyyy-mm-dd)";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(371, 48);
            label24.Name = "label24";
            label24.Size = new Size(44, 15);
            label24.TabIndex = 99;
            label24.Text = "Season";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(384, 99);
            label17.Name = "label17";
            label17.Size = new Size(31, 15);
            label17.TabIndex = 115;
            label17.Text = "Date";
            // 
            // GameSeason
            // 
            GameSeason.DropDownStyle = ComboBoxStyle.DropDownList;
            GameSeason.FormattingEnabled = true;
            GameSeason.Items.AddRange(new object[] { "2020", "2021", "2022", "2023", "2024" });
            GameSeason.Location = new Point(457, 45);
            GameSeason.Name = "GameSeason";
            GameSeason.Size = new Size(121, 23);
            GameSeason.TabIndex = 115;
            // 
            // WinnerComboBox
            // 
            WinnerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            WinnerComboBox.FormattingEnabled = true;
            WinnerComboBox.Location = new Point(178, 149);
            WinnerComboBox.Name = "WinnerComboBox";
            WinnerComboBox.Size = new Size(121, 23);
            WinnerComboBox.TabIndex = 113;
            WinnerComboBox.DropDown += WinnerComboBox_DropDown;
            // 
            // AwayTeam
            // 
            AwayTeam.DropDownStyle = ComboBoxStyle.DropDownList;
            AwayTeam.FormattingEnabled = true;
            AwayTeam.Items.AddRange(new object[] { "Arizona Cardinals", "Atlanta Falcons", "Baltimore Ravens", "Buffalo Bills", "Carolina Panthers", "Chicago Bears", "Cincinnati Bengals", "Cleveland Browns", "Dallas Cowboys", "Denver Broncos", "Detroit Lions", "Green Bay Packers", "Houston Texans", "Indianapolis Colts", "Jacksonville Jaguars", "Kansas City Chiefs", "Las Vegas Raiders", "Los Angeles Chargers", "Los Angeles Rams", "Miami Dolphins", "Minnesota Vikings", "New England Patriots", "New Orleans Saints", "New York Giants", "New York Jets", "Philadelphia Eagles", "Pittsburgh Steelers", "San Francisco 49ers", "Seattle Seahawks", "Tampa Bay Buccaneers", "Tennessee Titans", "Washington Commanders" });
            AwayTeam.Location = new Point(178, 96);
            AwayTeam.Name = "AwayTeam";
            AwayTeam.Size = new Size(121, 23);
            AwayTeam.TabIndex = 112;
            // 
            // HomeTeam
            // 
            HomeTeam.DropDownStyle = ComboBoxStyle.DropDownList;
            HomeTeam.FormattingEnabled = true;
            HomeTeam.Items.AddRange(new object[] { "Arizona Cardinals", "Atlanta Falcons", "Baltimore Ravens", "Buffalo Bills", "Carolina Panthers", "Chicago Bears", "Cincinnati Bengals", "Cleveland Browns", "Dallas Cowboys", "Denver Broncos", "Detroit Lions", "Green Bay Packers", "Houston Texans", "Indianapolis Colts", "Jacksonville Jaguars", "Kansas City Chiefs", "Las Vegas Raiders", "Los Angeles Chargers", "Los Angeles Rams", "Miami Dolphins", "Minnesota Vikings", "New England Patriots", "New Orleans Saints", "New York Giants", "New York Jets", "Philadelphia Eagles", "Pittsburgh Steelers", "San Francisco 49ers", "Seattle Seahawks", "Tampa Bay Buccaneers", "Tennessee Titans", "Washington Commanders" });
            HomeTeam.Location = new Point(178, 42);
            HomeTeam.Name = "HomeTeam";
            HomeTeam.Size = new Size(121, 23);
            HomeTeam.TabIndex = 111;
            // 
            // GameDate
            // 
            GameDate.Location = new Point(457, 96);
            GameDate.Name = "GameDate";
            GameDate.Size = new Size(121, 23);
            GameDate.TabIndex = 110;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(60, 45);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 101;
            label11.Text = "Home Team";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(64, 96);
            label20.Name = "label20";
            label20.Size = new Size(68, 15);
            label20.TabIndex = 105;
            label20.Text = "Away Team";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(87, 152);
            label18.Name = "label18";
            label18.Size = new Size(45, 15);
            label18.TabIndex = 109;
            label18.Text = "Winner";
            // 
            // SeasonTab
            // 
            SeasonTab.Controls.Add(label4);
            SeasonTab.Controls.Add(label3);
            SeasonTab.Controls.Add(SeasonSeason);
            SeasonTab.Controls.Add(AddSeasonButton);
            SeasonTab.Location = new Point(4, 24);
            SeasonTab.Name = "SeasonTab";
            SeasonTab.Padding = new Padding(3);
            SeasonTab.Size = new Size(688, 311);
            SeasonTab.TabIndex = 3;
            SeasonTab.Text = "Season";
            SeasonTab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(262, 91);
            label3.Name = "label3";
            label3.Size = new Size(146, 15);
            label3.TabIndex = 2;
            label3.Text = "Enter Starting Season Year:";
            // 
            // SeasonSeason
            // 
            SeasonSeason.Location = new Point(262, 135);
            SeasonSeason.Name = "SeasonSeason";
            SeasonSeason.Size = new Size(100, 23);
            SeasonSeason.TabIndex = 1;
            // 
            // AddSeasonButton
            // 
            AddSeasonButton.Location = new Point(298, 243);
            AddSeasonButton.Name = "AddSeasonButton";
            AddSeasonButton.Size = new Size(75, 23);
            AddSeasonButton.TabIndex = 0;
            AddSeasonButton.Text = "Add Season";
            AddSeasonButton.UseVisualStyleBackColor = true;
            AddSeasonButton.Click += AddSeasonButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(381, 138);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "(yyyy)";
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddTab);
            Name = "Add";
            Text = "Add";
            FormClosing += MyForm_FormClosing;
            AddTab.ResumeLayout(false);
            PlayerTab.ResumeLayout(false);
            PlayerBox.ResumeLayout(false);
            PlayerBox.PerformLayout();
            GameTab.ResumeLayout(false);
            GameBox.ResumeLayout(false);
            GameBox.PerformLayout();
            SeasonTab.ResumeLayout(false);
            SeasonTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl AddTab;
        private TabPage PlayerTab;
        private Label label26;
        private GroupBox PlayerBox;
        private ComboBox PlayerTeam;
        private ComboBox PlayerSeason;
        private ComboBox PlayerPosition;
        private TextBox PlayerAge;
        private TextBox PlayerName;
        private Label label16;
        private Label label19;
        private Label label23;
        private Label label21;
        private TabPage GameTab;
        private GroupBox GameBox;
        private ComboBox GameLocation;
        private Label label12;
        private Label label10;
        private Label label24;
        private Label label17;
        private ComboBox GameSeason;
        private ComboBox WinnerComboBox;
        private ComboBox AwayTeam;
        private ComboBox HomeTeam;
        private TextBox GameDate;
        private Label label11;
        private Label label20;
        private Label label18;
        private Button AddPlayerButton;
        private Button AddGameButton;
        private Label label1;
        private Label label2;
        private TextBox LoserScore;
        private TextBox WinnerScore;
        private TabPage SeasonTab;
        private Button AddSeasonButton;
        private TextBox SeasonSeason;
        private Label label3;
        private Label label4;
    }
}