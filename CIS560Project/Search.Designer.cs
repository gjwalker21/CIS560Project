namespace CIS560Project
{
    partial class Search
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
            label13 = new Label();
            TabControl = new TabControl();
            TeamTab = new TabPage();
            TeamBox = new GroupBox();
            label7 = new Label();
            TeamPlayedOn = new TextBox();
            TeamPlayedAt = new ComboBox();
            TeamConference = new ComboBox();
            TeamSeason = new ComboBox();
            TeamDivision = new ComboBox();
            TeamTeamName = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            PlayerTab = new TabPage();
            label8 = new Label();
            label25 = new Label();
            label26 = new Label();
            PlayerBox = new GroupBox();
            PlayerTeam = new ComboBox();
            PlayerDivision = new ComboBox();
            PlayerConference = new ComboBox();
            PlayerSeason = new ComboBox();
            PlayerPosition = new ComboBox();
            PlayerAge = new TextBox();
            PlayerName = new TextBox();
            label16 = new Label();
            label19 = new Label();
            label23 = new Label();
            label21 = new Label();
            GameTab = new TabPage();
            GameBox = new GroupBox();
            GameLocation = new ComboBox();
            label12 = new Label();
            label10 = new Label();
            label24 = new Label();
            label17 = new Label();
            GameSeason = new ComboBox();
            GameConference = new ComboBox();
            Winner = new ComboBox();
            AwayTeam = new ComboBox();
            HomeTeam = new ComboBox();
            GameDate = new TextBox();
            label11 = new Label();
            label20 = new Label();
            label18 = new Label();
            label22 = new Label();
            SearchButton = new Button();
            TabControl.SuspendLayout();
            TeamTab.SuspendLayout();
            TeamBox.SuspendLayout();
            PlayerTab.SuspendLayout();
            PlayerBox.SuspendLayout();
            GameTab.SuspendLayout();
            GameBox.SuspendLayout();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(54, 41);
            label13.Name = "label13";
            label13.Size = new Size(61, 15);
            label13.TabIndex = 50;
            label13.Text = "Search by:";
            // 
            // TabControl
            // 
            TabControl.Controls.Add(TeamTab);
            TabControl.Controls.Add(PlayerTab);
            TabControl.Controls.Add(GameTab);
            TabControl.Location = new Point(47, 71);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(696, 306);
            TabControl.TabIndex = 53;
            // 
            // TeamTab
            // 
            TeamTab.Controls.Add(TeamBox);
            TeamTab.Location = new Point(4, 24);
            TeamTab.Name = "TeamTab";
            TeamTab.Padding = new Padding(3);
            TeamTab.Size = new Size(688, 278);
            TeamTab.TabIndex = 0;
            TeamTab.Text = "Team";
            TeamTab.UseVisualStyleBackColor = true;
            // 
            // TeamBox
            // 
            TeamBox.Controls.Add(label7);
            TeamBox.Controls.Add(TeamPlayedOn);
            TeamBox.Controls.Add(TeamPlayedAt);
            TeamBox.Controls.Add(TeamConference);
            TeamBox.Controls.Add(TeamSeason);
            TeamBox.Controls.Add(TeamDivision);
            TeamBox.Controls.Add(TeamTeamName);
            TeamBox.Controls.Add(label5);
            TeamBox.Controls.Add(label3);
            TeamBox.Controls.Add(label1);
            TeamBox.Controls.Add(label2);
            TeamBox.Controls.Add(label4);
            TeamBox.Controls.Add(label6);
            TeamBox.Location = new Point(38, 28);
            TeamBox.Name = "TeamBox";
            TeamBox.Size = new Size(598, 250);
            TeamBox.TabIndex = 73;
            TeamBox.TabStop = false;
            TeamBox.Text = "TeamBox";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(445, 107);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 69;
            label7.Text = "(yyyy-mm-dd)";
            // 
            // TeamPlayedOn
            // 
            TeamPlayedOn.Location = new Point(445, 81);
            TeamPlayedOn.Name = "TeamPlayedOn";
            TeamPlayedOn.Size = new Size(121, 23);
            TeamPlayedOn.TabIndex = 68;
            // 
            // TeamPlayedAt
            // 
            TeamPlayedAt.DropDownStyle = ComboBoxStyle.DropDownList;
            TeamPlayedAt.FormattingEnabled = true;
            TeamPlayedAt.Items.AddRange(new object[] { "Arlington", "Atlanta", "Baltimore", "Charlotte", "Chicago", "Cincinnati", "Cleveland", "Denver", "Detroit", "East Rutherford", "Foxborough", "Glendale", "Green Bay", "Houston", "Indianapolis", "Inglewood", "Jacksonville", "Kansas City", "Landover", "Las Vegas", "Miami Gardens", "Minneapolis", "Nashville", "New Orleans", "Orchard Park", "Philadelphia", "Pittsburgh", "Santa Clara", "Seattle", "Tampa" });
            TeamPlayedAt.Location = new Point(445, 143);
            TeamPlayedAt.Name = "TeamPlayedAt";
            TeamPlayedAt.Size = new Size(121, 23);
            TeamPlayedAt.TabIndex = 67;
            // 
            // TeamConference
            // 
            TeamConference.DropDownStyle = ComboBoxStyle.DropDownList;
            TeamConference.FormattingEnabled = true;
            TeamConference.Items.AddRange(new object[] { "", "AFC", "NFC" });
            TeamConference.Location = new Point(445, 30);
            TeamConference.Name = "TeamConference";
            TeamConference.Size = new Size(121, 23);
            TeamConference.TabIndex = 65;
            // 
            // TeamSeason
            // 
            TeamSeason.DropDownStyle = ComboBoxStyle.DropDownList;
            TeamSeason.FormattingEnabled = true;
            TeamSeason.Items.AddRange(new object[] { "", "2020", "2021", "2022", "2023", "2024" });
            TeamSeason.Location = new Point(168, 141);
            TeamSeason.Name = "TeamSeason";
            TeamSeason.Size = new Size(121, 23);
            TeamSeason.TabIndex = 64;
            // 
            // TeamDivision
            // 
            TeamDivision.DropDownStyle = ComboBoxStyle.DropDownList;
            TeamDivision.FormattingEnabled = true;
            TeamDivision.Items.AddRange(new object[] { "", "AFC North", "AFC East", "AFC South", "AFC West", "NFC North", "NFC East", "NFC South", "NFC West" });
            TeamDivision.Location = new Point(168, 81);
            TeamDivision.Name = "TeamDivision";
            TeamDivision.Size = new Size(121, 23);
            TeamDivision.TabIndex = 63;
            // 
            // TeamTeamName
            // 
            TeamTeamName.DropDownStyle = ComboBoxStyle.DropDownList;
            TeamTeamName.FormattingEnabled = true;
            TeamTeamName.Items.AddRange(new object[] { "", "Arizona Cardinals", "Atlanta Falcons", "Baltimore Ravens", "Buffalo Bills", "Carolina Panthers", "Chicago Bears", "Cincinnati Bengals", "Cleveland Browns", "Dallas Cowboys", "Denver Broncos", "Detroit Lions", "Green Bay Packers", "Houston Texans", "Indianapolis Colts", "Jacksonville Jaguars", "Kansas City Chiefs", "Las Vegas Raiders", "Los Angeles Chargers", "Los Angeles Rams", "Miami Dolphins", "Minnesota Vikings", "New England Patriots", "New Orleans Saints", "New York Giants", "New York Jets", "Philadelphia Eagles", "Pittsburgh Steelers", "San Francisco 49ers", "Seattle Seahawks", "Tampa Bay Buccaneers", "Tennessee Titans", "Washington Commanders" });
            TeamTeamName.Location = new Point(168, 30);
            TeamTeamName.Name = "TeamTeamName";
            TeamTeamName.Size = new Size(121, 23);
            TeamTeamName.TabIndex = 62;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(349, 146);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 60;
            label5.Text = "Played At";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 30);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 50;
            label3.Text = "Team Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 30);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 48;
            label1.Text = "In Conference";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 84);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 49;
            label2.Text = "In Division";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 141);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 56;
            label4.Text = "Season Played";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(325, 84);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 54;
            label6.Text = "Played On Date";
            // 
            // PlayerTab
            // 
            PlayerTab.Controls.Add(label8);
            PlayerTab.Controls.Add(label25);
            PlayerTab.Controls.Add(label26);
            PlayerTab.Controls.Add(PlayerBox);
            PlayerTab.Location = new Point(4, 24);
            PlayerTab.Name = "PlayerTab";
            PlayerTab.Padding = new Padding(3);
            PlayerTab.Size = new Size(688, 278);
            PlayerTab.TabIndex = 1;
            PlayerTab.Text = "Player";
            PlayerTab.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(382, 108);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 97;
            label8.Text = "In Division";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(363, 159);
            label25.Name = "label25";
            label25.Size = new Size(81, 15);
            label25.TabIndex = 74;
            label25.Text = "In Conference";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(388, 57);
            label26.Name = "label26";
            label26.Size = new Size(55, 15);
            label26.TabIndex = 73;
            label26.Text = "On Team";
            // 
            // PlayerBox
            // 
            PlayerBox.Controls.Add(PlayerTeam);
            PlayerBox.Controls.Add(PlayerDivision);
            PlayerBox.Controls.Add(PlayerConference);
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
            PlayerTeam.Items.AddRange(new object[] { "", "Arizona Cardinals", "Atlanta Falcons", "Baltimore Ravens", "Buffalo Bills", "Carolina Panthers", "Chicago Bears", "Cincinnati Bengals", "Cleveland Browns", "Dallas Cowboys", "Denver Broncos", "Detroit Lions", "Green Bay Packers", "Houston Texans", "Indianapolis Colts", "Jacksonville Jaguars", "Kansas City Chiefs", "Las Vegas Raiders", "Los Angeles Chargers", "Los Angeles Rams", "Miami Dolphins", "Minnesota Vikings", "New England Patriots", "New Orleans Saints", "New York Giants", "New York Jets", "Philadelphia Eagles", "Pittsburgh Steelers", "San Francisco 49ers", "Seattle Seahawks", "Tampa Bay Buccaneers", "Tennessee Titans", "Washington Commanders" });
            PlayerTeam.Location = new Point(460, 30);
            PlayerTeam.Name = "PlayerTeam";
            PlayerTeam.Size = new Size(121, 23);
            PlayerTeam.TabIndex = 94;
            // 
            // PlayerDivision
            // 
            PlayerDivision.DropDownStyle = ComboBoxStyle.DropDownList;
            PlayerDivision.FormattingEnabled = true;
            PlayerDivision.Items.AddRange(new object[] { "", "AFC North", "AFC East", "AFC South", "AFC West", "NFC North", "NFC East", "NFC South", "NFC West" });
            PlayerDivision.Location = new Point(460, 84);
            PlayerDivision.Name = "PlayerDivision";
            PlayerDivision.Size = new Size(121, 23);
            PlayerDivision.TabIndex = 93;
            // 
            // PlayerConference
            // 
            PlayerConference.DropDownStyle = ComboBoxStyle.DropDownList;
            PlayerConference.FormattingEnabled = true;
            PlayerConference.Items.AddRange(new object[] { "", "AFC", "NFC" });
            PlayerConference.Location = new Point(460, 132);
            PlayerConference.Name = "PlayerConference";
            PlayerConference.Size = new Size(121, 23);
            PlayerConference.TabIndex = 92;
            // 
            // PlayerSeason
            // 
            PlayerSeason.DropDownStyle = ComboBoxStyle.DropDownList;
            PlayerSeason.FormattingEnabled = true;
            PlayerSeason.Items.AddRange(new object[] { "", "2020", "2021", "2022", "2023", "2024" });
            PlayerSeason.Location = new Point(177, 188);
            PlayerSeason.Name = "PlayerSeason";
            PlayerSeason.Size = new Size(121, 23);
            PlayerSeason.TabIndex = 91;
            // 
            // PlayerPosition
            // 
            PlayerPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            PlayerPosition.FormattingEnabled = true;
            PlayerPosition.Items.AddRange(new object[] { "", "G", "TE", "DL", "OLB", "ROLB/LOLB", "ROLB", "SS", "RG/RT", "DT/DE", "LDE/RDE", "LCB/RCB", "MLB", "LCB", "RCB", "RILB", "OT", "LB", "RCB/LCB", "RLB", "RT/LT", "LDE", "OL", "LG", "QB", "LS", "LOLB", "RDT/LDT", "FS", "NT", "DT", "RDE", "C/LG", "RB", "C", "LDT", "RLB/LLB", "LLB", "RG", "DB", "RG/C", "OG", "RLB/MLB", "DE", "ROLB/RILB", "LILB", "P", "RT", "RILB/LILB", "S", "DE/DT", "RT/RG", "K", "RDT", "CB", "WR", "SS/RLB", "WR/QB", "SS/FS", "T", "KB", "LT/RT", "FB", "LT" });
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
            label19.Location = new Point(49, 191);
            label19.Name = "label19";
            label19.Size = new Size(82, 15);
            label19.TabIndex = 87;
            label19.Text = "Season Played";
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
            GameTab.Controls.Add(GameBox);
            GameTab.Location = new Point(4, 24);
            GameTab.Name = "GameTab";
            GameTab.Padding = new Padding(3);
            GameTab.Size = new Size(688, 278);
            GameTab.TabIndex = 2;
            GameTab.Text = "Game";
            GameTab.UseVisualStyleBackColor = true;
            // 
            // GameBox
            // 
            GameBox.Controls.Add(GameLocation);
            GameBox.Controls.Add(label12);
            GameBox.Controls.Add(label10);
            GameBox.Controls.Add(label24);
            GameBox.Controls.Add(label17);
            GameBox.Controls.Add(GameSeason);
            GameBox.Controls.Add(GameConference);
            GameBox.Controls.Add(Winner);
            GameBox.Controls.Add(AwayTeam);
            GameBox.Controls.Add(HomeTeam);
            GameBox.Controls.Add(GameDate);
            GameBox.Controls.Add(label11);
            GameBox.Controls.Add(label20);
            GameBox.Controls.Add(label18);
            GameBox.Controls.Add(label22);
            GameBox.Location = new Point(32, 21);
            GameBox.Name = "GameBox";
            GameBox.Size = new Size(619, 251);
            GameBox.TabIndex = 116;
            GameBox.TabStop = false;
            GameBox.Text = "GameBox";
            // 
            // GameLocation
            // 
            GameLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            GameLocation.FormattingEnabled = true;
            GameLocation.Items.AddRange(new object[] { "", "Arlington", "Atlanta", "Baltimore", "Charlotte", "Chicago", "Cincinnati", "Cleveland", "Denver", "Detroit", "East Rutherford", "Foxborough", "Glendale", "Green Bay", "Houston", "Indianapolis", "Inglewood", "Jacksonville", "Kansas City", "Landover", "Las Vegas", "Miami Gardens", "Minneapolis", "Nashville", "New Orleans", "Orchard Park", "Philadelphia", "Pittsburgh", "Santa Clara", "Seattle", "Tampa" });
            GameLocation.Location = new Point(457, 158);
            GameLocation.Name = "GameLocation";
            GameLocation.Size = new Size(121, 23);
            GameLocation.TabIndex = 120;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(352, 158);
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
            label24.Location = new Point(361, 48);
            label24.Name = "label24";
            label24.Size = new Size(44, 15);
            label24.TabIndex = 99;
            label24.Text = "Season";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(374, 99);
            label17.Name = "label17";
            label17.Size = new Size(31, 15);
            label17.TabIndex = 115;
            label17.Text = "Date";
            // 
            // GameSeason
            // 
            GameSeason.DropDownStyle = ComboBoxStyle.DropDownList;
            GameSeason.FormattingEnabled = true;
            GameSeason.Items.AddRange(new object[] { "", "2020", "2021", "2022", "2023", "2024" });
            GameSeason.Location = new Point(457, 45);
            GameSeason.Name = "GameSeason";
            GameSeason.Size = new Size(121, 23);
            GameSeason.TabIndex = 115;
            // 
            // GameConference
            // 
            GameConference.DropDownStyle = ComboBoxStyle.DropDownList;
            GameConference.FormattingEnabled = true;
            GameConference.Items.AddRange(new object[] { "", "AFC", "NFC" });
            GameConference.Location = new Point(178, 203);
            GameConference.Name = "GameConference";
            GameConference.Size = new Size(121, 23);
            GameConference.TabIndex = 114;
            // 
            // Winner
            // 
            Winner.DropDownStyle = ComboBoxStyle.DropDownList;
            Winner.FormattingEnabled = true;
            Winner.Items.AddRange(new object[] { "", "Arizona Cardinals", "Atlanta Falcons", "Baltimore Ravens", "Buffalo Bills", "Carolina Panthers", "Chicago Bears", "Cincinnati Bengals", "Cleveland Browns", "Dallas Cowboys", "Denver Broncos", "Detroit Lions", "Green Bay Packers", "Houston Texans", "Indianapolis Colts", "Jacksonville Jaguars", "Kansas City Chiefs", "Las Vegas Raiders", "Los Angeles Chargers", "Los Angeles Rams", "Miami Dolphins", "Minnesota Vikings", "New England Patriots", "New Orleans Saints", "New York Giants", "New York Jets", "Philadelphia Eagles", "Pittsburgh Steelers", "San Francisco 49ers", "Seattle Seahawks", "Tampa Bay Buccaneers", "Tennessee Titans", "Washington Commanders" });
            Winner.Location = new Point(178, 149);
            Winner.Name = "Winner";
            Winner.Size = new Size(121, 23);
            Winner.TabIndex = 113;
            // 
            // AwayTeam
            // 
            AwayTeam.DropDownStyle = ComboBoxStyle.DropDownList;
            AwayTeam.FormattingEnabled = true;
            AwayTeam.Items.AddRange(new object[] { "", "Arizona Cardinals", "Atlanta Falcons", "Baltimore Ravens", "Buffalo Bills", "Carolina Panthers", "Chicago Bears", "Cincinnati Bengals", "Cleveland Browns", "Dallas Cowboys", "Denver Broncos", "Detroit Lions", "Green Bay Packers", "Houston Texans", "Indianapolis Colts", "Jacksonville Jaguars", "Kansas City Chiefs", "Las Vegas Raiders", "Los Angeles Chargers", "Los Angeles Rams", "Miami Dolphins", "Minnesota Vikings", "New England Patriots", "New Orleans Saints", "New York Giants", "New York Jets", "Philadelphia Eagles", "Pittsburgh Steelers", "San Francisco 49ers", "Seattle Seahawks", "Tampa Bay Buccaneers", "Tennessee Titans", "Washington Commanders" });
            AwayTeam.Location = new Point(178, 93);
            AwayTeam.Name = "AwayTeam";
            AwayTeam.Size = new Size(121, 23);
            AwayTeam.TabIndex = 112;
            // 
            // HomeTeam
            // 
            HomeTeam.DropDownStyle = ComboBoxStyle.DropDownList;
            HomeTeam.FormattingEnabled = true;
            HomeTeam.Items.AddRange(new object[] { "", "Arizona Cardinals", "Atlanta Falcons", "Baltimore Ravens", "Buffalo Bills", "Carolina Panthers", "Chicago Bears", "Cincinnati Bengals", "Cleveland Browns", "Dallas Cowboys", "Denver Broncos", "Detroit Lions", "Green Bay Packers", "Houston Texans", "Indianapolis Colts", "Jacksonville Jaguars", "Kansas City Chiefs", "Las Vegas Raiders", "Los Angeles Chargers", "Los Angeles Rams", "Miami Dolphins", "Minnesota Vikings", "New England Patriots", "New Orleans Saints", "New York Giants", "New York Jets", "Philadelphia Eagles", "Pittsburgh Steelers", "San Francisco 49ers", "Seattle Seahawks", "Tampa Bay Buccaneers", "Tennessee Titans", "Washington Commanders" });
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
            label11.Location = new Point(64, 45);
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
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(55, 203);
            label22.Name = "label22";
            label22.Size = new Size(81, 15);
            label22.TabIndex = 100;
            label22.Text = "In Conference";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(346, 401);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 55;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchButton);
            Controls.Add(TabControl);
            Controls.Add(label13);
            Name = "Search";
            Text = "Search";
            FormClosing += MyForm_FormClosing;
            TabControl.ResumeLayout(false);
            TeamTab.ResumeLayout(false);
            TeamBox.ResumeLayout(false);
            TeamBox.PerformLayout();
            PlayerTab.ResumeLayout(false);
            PlayerTab.PerformLayout();
            PlayerBox.ResumeLayout(false);
            PlayerBox.PerformLayout();
            GameTab.ResumeLayout(false);
            GameBox.ResumeLayout(false);
            GameBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label13;
        private TabControl TabControl;
        private TabPage TeamTab;
        private Label label4;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage PlayerTab;
        private TabPage GameTab;
        private Label label16;
        private Label label19;
        private Label label21;
        private Label label23;
        private Label label25;
        private Label label26;
        private Label label8;
        private Label label11;
        private Label label18;
        private Label label20;
        private Label label22;
        private Label label24;
        private Label label17;
        private GroupBox TeamBox;
        private GroupBox PlayerBox;
        private GroupBox GameBox;
        private Button SearchButton;
        private Label label5;
        private ComboBox TeamTeamName;
        private ComboBox TeamDivision;
        private ComboBox TeamSeason;
        private ComboBox TeamConference;
        private ComboBox TeamPlayedAt;
        private TextBox PlayerName;
        private TextBox PlayerAge;
        private ComboBox PlayerPosition;
        private ComboBox PlayerSeason;
        private ComboBox PlayerConference;
        private ComboBox PlayerDivision;
        private ComboBox PlayerTeam;
        private TextBox GameDate;
        private ComboBox HomeTeam;
        private ComboBox AwayTeam;
        private ComboBox Winner;
        private ComboBox GameConference;
        private ComboBox GameSeason;
        private TextBox TeamPlayedOn;
        private Label label7;
        private Label label10;
        private Label label12;
        private ComboBox GameLocation;
    }
}