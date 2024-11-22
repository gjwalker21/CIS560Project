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
            label15 = new Label();
            TabControl = new TabControl();
            TeamTab = new TabPage();
            TeamTeamName = new TextBox();
            label3 = new Label();
            TeamBox = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            TeamConference = new TextBox();
            TeamDivision = new TextBox();
            label4 = new Label();
            TeamSeason = new TextBox();
            label6 = new Label();
            TeamPlayedDate = new TextBox();
            PlayerTab = new TabPage();
            PlayerTeam = new TextBox();
            label8 = new Label();
            PlayerPlayerName = new TextBox();
            label16 = new Label();
            label19 = new Label();
            label21 = new Label();
            PlayerPosition = new TextBox();
            PlayerDivision = new TextBox();
            PlayerAge = new TextBox();
            label23 = new Label();
            PlayerSeason = new TextBox();
            PlayerConference = new TextBox();
            label25 = new Label();
            label26 = new Label();
            PlayerBox = new GroupBox();
            GameTab = new TabPage();
            label17 = new Label();
            Season = new TextBox();
            label9 = new Label();
            HomeTeam = new TextBox();
            label11 = new Label();
            label18 = new Label();
            Winner = new TextBox();
            Date = new TextBox();
            AwayTeam = new TextBox();
            label20 = new Label();
            GameConference = new TextBox();
            GameDivision = new TextBox();
            label22 = new Label();
            label24 = new Label();
            GameBox = new GroupBox();
            label27 = new Label();
            SearchButton = new Button();
            label5 = new Label();
            textBox1 = new TextBox();
            TabControl.SuspendLayout();
            TeamTab.SuspendLayout();
            TeamBox.SuspendLayout();
            PlayerTab.SuspendLayout();
            GameTab.SuspendLayout();
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
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(336, 27);
            label15.Name = "label15";
            label15.Size = new Size(244, 15);
            label15.TabIndex = 52;
            label15.Text = "Specify one or more for each search attribute";
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
            // TeamTeamName
            // 
            TeamTeamName.Location = new Point(171, 22);
            TeamTeamName.Name = "TeamTeamName";
            TeamTeamName.Size = new Size(100, 23);
            TeamTeamName.TabIndex = 53;
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
            // TeamBox
            // 
            TeamBox.Controls.Add(textBox1);
            TeamBox.Controls.Add(label5);
            TeamBox.Controls.Add(label3);
            TeamBox.Controls.Add(TeamTeamName);
            TeamBox.Controls.Add(label1);
            TeamBox.Controls.Add(label2);
            TeamBox.Controls.Add(TeamConference);
            TeamBox.Controls.Add(TeamDivision);
            TeamBox.Controls.Add(label4);
            TeamBox.Controls.Add(TeamSeason);
            TeamBox.Controls.Add(label6);
            TeamBox.Controls.Add(TeamPlayedDate);
            TeamBox.Location = new Point(38, 28);
            TeamBox.Name = "TeamBox";
            TeamBox.Size = new Size(598, 250);
            TeamBox.TabIndex = 73;
            TeamBox.TabStop = false;
            TeamBox.Text = "TeamBox";
            TeamBox.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 22);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 48;
            label1.Text = "In Conference";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 81);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 49;
            label2.Text = "In Division";
            // 
            // TeamConference
            // 
            TeamConference.Location = new Point(440, 19);
            TeamConference.Name = "TeamConference";
            TeamConference.Size = new Size(100, 23);
            TeamConference.TabIndex = 51;
            // 
            // TeamDivision
            // 
            TeamDivision.Location = new Point(171, 81);
            TeamDivision.Name = "TeamDivision";
            TeamDivision.Size = new Size(100, 23);
            TeamDivision.TabIndex = 52;
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
            // TeamSeason
            // 
            TeamSeason.Location = new Point(171, 138);
            TeamSeason.Name = "TeamSeason";
            TeamSeason.Size = new Size(100, 23);
            TeamSeason.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(325, 78);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 54;
            label6.Text = "Played On Date";
            // 
            // TeamPlayedDate
            // 
            TeamPlayedDate.Location = new Point(440, 78);
            TeamPlayedDate.Name = "TeamPlayedDate";
            TeamPlayedDate.Size = new Size(100, 23);
            TeamPlayedDate.TabIndex = 57;
            // 
            // PlayerTab
            // 
            PlayerTab.Controls.Add(PlayerTeam);
            PlayerTab.Controls.Add(label8);
            PlayerTab.Controls.Add(PlayerPlayerName);
            PlayerTab.Controls.Add(label16);
            PlayerTab.Controls.Add(label19);
            PlayerTab.Controls.Add(label21);
            PlayerTab.Controls.Add(PlayerPosition);
            PlayerTab.Controls.Add(PlayerDivision);
            PlayerTab.Controls.Add(PlayerAge);
            PlayerTab.Controls.Add(label23);
            PlayerTab.Controls.Add(PlayerSeason);
            PlayerTab.Controls.Add(PlayerConference);
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
            // PlayerTeam
            // 
            PlayerTeam.Location = new Point(485, 49);
            PlayerTeam.Name = "PlayerTeam";
            PlayerTeam.Size = new Size(100, 23);
            PlayerTeam.TabIndex = 98;
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
            // PlayerPlayerName
            // 
            PlayerPlayerName.Location = new Point(204, 95);
            PlayerPlayerName.Name = "PlayerPlayerName";
            PlayerPlayerName.Size = new Size(100, 23);
            PlayerPlayerName.TabIndex = 78;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(99, 103);
            label16.Name = "label16";
            label16.Size = new Size(74, 15);
            label16.TabIndex = 75;
            label16.Text = "Player Name";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(362, 215);
            label19.Name = "label19";
            label19.Size = new Size(82, 15);
            label19.TabIndex = 87;
            label19.Text = "Season Played";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(77, 215);
            label21.Name = "label21";
            label21.Size = new Size(85, 15);
            label21.TabIndex = 85;
            label21.Text = "Player Position";
            // 
            // PlayerPosition
            // 
            PlayerPosition.Location = new Point(204, 207);
            PlayerPosition.Name = "PlayerPosition";
            PlayerPosition.Size = new Size(100, 23);
            PlayerPosition.TabIndex = 84;
            // 
            // PlayerDivision
            // 
            PlayerDivision.Location = new Point(485, 100);
            PlayerDivision.Name = "PlayerDivision";
            PlayerDivision.Size = new Size(100, 23);
            PlayerDivision.TabIndex = 83;
            // 
            // PlayerAge
            // 
            PlayerAge.Location = new Point(204, 151);
            PlayerAge.Name = "PlayerAge";
            PlayerAge.Size = new Size(100, 23);
            PlayerAge.TabIndex = 82;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(99, 159);
            label23.Name = "label23";
            label23.Size = new Size(63, 15);
            label23.TabIndex = 80;
            label23.Text = "Player Age";
            // 
            // PlayerSeason
            // 
            PlayerSeason.Location = new Point(485, 207);
            PlayerSeason.Name = "PlayerSeason";
            PlayerSeason.Size = new Size(100, 23);
            PlayerSeason.TabIndex = 77;
            // 
            // PlayerConference
            // 
            PlayerConference.Location = new Point(485, 151);
            PlayerConference.Name = "PlayerConference";
            PlayerConference.Size = new Size(100, 23);
            PlayerConference.TabIndex = 76;
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
            PlayerBox.Location = new Point(28, 24);
            PlayerBox.Name = "PlayerBox";
            PlayerBox.Size = new Size(624, 270);
            PlayerBox.TabIndex = 100;
            PlayerBox.TabStop = false;
            PlayerBox.Text = "PlayerBox";
            PlayerBox.Visible = false;
            // 
            // GameTab
            // 
            GameTab.Controls.Add(label17);
            GameTab.Controls.Add(Season);
            GameTab.Controls.Add(label9);
            GameTab.Controls.Add(HomeTeam);
            GameTab.Controls.Add(label11);
            GameTab.Controls.Add(label18);
            GameTab.Controls.Add(Winner);
            GameTab.Controls.Add(Date);
            GameTab.Controls.Add(AwayTeam);
            GameTab.Controls.Add(label20);
            GameTab.Controls.Add(GameConference);
            GameTab.Controls.Add(GameDivision);
            GameTab.Controls.Add(label22);
            GameTab.Controls.Add(label24);
            GameTab.Controls.Add(GameBox);
            GameTab.Location = new Point(4, 24);
            GameTab.Name = "GameTab";
            GameTab.Padding = new Padding(3);
            GameTab.Size = new Size(688, 278);
            GameTab.TabIndex = 2;
            GameTab.Text = "Game";
            GameTab.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(406, 120);
            label17.Name = "label17";
            label17.Size = new Size(31, 15);
            label17.TabIndex = 115;
            label17.Text = "Date";
            // 
            // Season
            // 
            Season.Location = new Point(476, 61);
            Season.Name = "Season";
            Season.Size = new Size(100, 23);
            Season.TabIndex = 114;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(375, 176);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 113;
            label9.Text = "In Division";
            // 
            // HomeTeam
            // 
            HomeTeam.Location = new Point(203, 107);
            HomeTeam.Name = "HomeTeam";
            HomeTeam.Size = new Size(100, 23);
            HomeTeam.TabIndex = 104;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(96, 115);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 101;
            label11.Text = "Home Team";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(116, 227);
            label18.Name = "label18";
            label18.Size = new Size(45, 15);
            label18.TabIndex = 109;
            label18.Text = "Winner";
            // 
            // Winner
            // 
            Winner.Location = new Point(203, 219);
            Winner.Name = "Winner";
            Winner.Size = new Size(100, 23);
            Winner.TabIndex = 108;
            // 
            // Date
            // 
            Date.Location = new Point(476, 112);
            Date.Name = "Date";
            Date.Size = new Size(100, 23);
            Date.TabIndex = 107;
            // 
            // AwayTeam
            // 
            AwayTeam.Location = new Point(203, 163);
            AwayTeam.Name = "AwayTeam";
            AwayTeam.Size = new Size(100, 23);
            AwayTeam.TabIndex = 106;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(96, 171);
            label20.Name = "label20";
            label20.Size = new Size(68, 15);
            label20.TabIndex = 105;
            label20.Text = "Away Team";
            // 
            // GameConference
            // 
            GameConference.Location = new Point(476, 219);
            GameConference.Name = "GameConference";
            GameConference.Size = new Size(100, 23);
            GameConference.TabIndex = 103;
            // 
            // GameDivision
            // 
            GameDivision.Location = new Point(476, 163);
            GameDivision.Name = "GameDivision";
            GameDivision.Size = new Size(100, 23);
            GameDivision.TabIndex = 102;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(356, 227);
            label22.Name = "label22";
            label22.Size = new Size(81, 15);
            label22.TabIndex = 100;
            label22.Text = "In Conference";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(393, 69);
            label24.Name = "label24";
            label24.Size = new Size(44, 15);
            label24.TabIndex = 99;
            label24.Text = "Season";
            // 
            // GameBox
            // 
            GameBox.Location = new Point(32, 24);
            GameBox.Name = "GameBox";
            GameBox.Size = new Size(619, 266);
            GameBox.TabIndex = 116;
            GameBox.TabStop = false;
            GameBox.Text = "GameBox";
            GameBox.Visible = false;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(336, 53);
            label27.Name = "label27";
            label27.Size = new Size(183, 15);
            label27.TabIndex = 54;
            label27.Text = "(use commas to specify multiple)";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(325, 146);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 60;
            label5.Text = "Played At";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(440, 143);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 61;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchButton);
            Controls.Add(label27);
            Controls.Add(TabControl);
            Controls.Add(label15);
            Controls.Add(label13);
            Name = "Search";
            Text = "Search";
            TabControl.ResumeLayout(false);
            TeamTab.ResumeLayout(false);
            TeamBox.ResumeLayout(false);
            TeamBox.PerformLayout();
            PlayerTab.ResumeLayout(false);
            PlayerTab.PerformLayout();
            GameTab.ResumeLayout(false);
            GameTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label13;
        private Label label15;
        private TabControl TabControl;
        private TabPage TeamTab;
        private TextBox TeamSeason;
        private TextBox TeamPlayedDate;
        private Label label4;
        private Label label6;
        private TextBox TeamTeamName;
        private TextBox TeamDivision;
        private TextBox TeamConference;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage PlayerTab;
        private TabPage GameTab;
        private TextBox PlayerPlayerName;
        private Label label16;
        private Label label19;
        private Label label21;
        private TextBox PlayerPosition;
        private TextBox PlayerDivision;
        private TextBox PlayerAge;
        private Label label23;
        private TextBox PlayerSeason;
        private TextBox PlayerConference;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label8;
        private TextBox PlayerTeam;
        private TextBox Season;
        private Label label9;
        private TextBox HomeTeam;
        private Label label11;
        private Label label18;
        private TextBox Winner;
        private TextBox Date;
        private TextBox AwayTeam;
        private Label label20;
        private TextBox GameConference;
        private TextBox GameDivision;
        private Label label22;
        private Label label24;
        private Label label17;
        private GroupBox TeamBox;
        private GroupBox PlayerBox;
        private GroupBox GameBox;
        private Button SearchButton;
        private Label label5;
        private TextBox textBox1;
    }
}