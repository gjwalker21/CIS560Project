namespace CIS560Project
{
    partial class NFLDatabase
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
            ConferenceButton = new Button();
            dataGridView1 = new DataGridView();
            DivisionsButton = new Button();
            TeamsButton = new Button();
            SeasonButton = new Button();
            PlayersButton = new Button();
            PlayerContractButton = new Button();
            ScheduleButton = new Button();
            TeamSeasonButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(56, 420);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1312, 364);
            dataGridView1.TabIndex = 1;
            // 
            // ConferenceButton
            // 
            ConferenceButton.Location = new Point(98, 58);
            ConferenceButton.Name = "ConferenceButton";
            ConferenceButton.Size = new Size(96, 23);
            ConferenceButton.TabIndex = 0;
            ConferenceButton.Text = "Conferences";
            ConferenceButton.UseVisualStyleBackColor = true;
            ConferenceButton.Click += Table_Click;
            // 
            // DivisionsButton
            // 
            DivisionsButton.Location = new Point(98, 141);
            DivisionsButton.Name = "DivisionsButton";
            DivisionsButton.Size = new Size(96, 23);
            DivisionsButton.TabIndex = 2;
            DivisionsButton.Text = "Divisions";
            DivisionsButton.UseVisualStyleBackColor = true;
            DivisionsButton.Click += Table_Click;
            // 
            // TeamsButton
            // 
            TeamsButton.Location = new Point(98, 225);
            TeamsButton.Name = "TeamsButton";
            TeamsButton.Size = new Size(96, 23);
            TeamsButton.TabIndex = 3;
            TeamsButton.Text = "Teams";
            TeamsButton.UseVisualStyleBackColor = true;
            TeamsButton.Click += Table_Click;
            // 
            // SeasonButton
            // 
            SeasonButton.Location = new Point(98, 309);
            SeasonButton.Name = "SeasonButton";
            SeasonButton.Size = new Size(96, 23);
            SeasonButton.TabIndex = 4;
            SeasonButton.Text = "Seasons";
            SeasonButton.UseVisualStyleBackColor = true;
            SeasonButton.Click += Table_Click;
            // 
            // PlayersButton
            // 
            PlayersButton.Location = new Point(291, 58);
            PlayersButton.Name = "PlayersButton";
            PlayersButton.Size = new Size(96, 23);
            PlayersButton.TabIndex = 5;
            PlayersButton.Text = "Players";
            PlayersButton.UseVisualStyleBackColor = true;
            PlayersButton.Click += Table_Click;
            // 
            // PlayerContractButton
            // 
            PlayerContractButton.Location = new Point(291, 141);
            PlayerContractButton.Name = "PlayerContractButton";
            PlayerContractButton.Size = new Size(96, 23);
            PlayerContractButton.TabIndex = 6;
            PlayerContractButton.Text = "PlayerContract";
            PlayerContractButton.UseVisualStyleBackColor = true;
            PlayerContractButton.Click += Table_Click;
            // 
            // ScheduleButton
            // 
            ScheduleButton.Location = new Point(291, 225);
            ScheduleButton.Name = "ScheduleButton";
            ScheduleButton.Size = new Size(96, 23);
            ScheduleButton.TabIndex = 7;
            ScheduleButton.Text = "Schedule";
            ScheduleButton.UseVisualStyleBackColor = true;
            ScheduleButton.Click += Table_Click;
            // 
            // TeamSeasonButton
            // 
            TeamSeasonButton.Location = new Point(291, 309);
            TeamSeasonButton.Name = "TeamSeasonButton";
            TeamSeasonButton.Size = new Size(96, 23);
            TeamSeasonButton.TabIndex = 8;
            TeamSeasonButton.Text = "TeamSeason";
            TeamSeasonButton.UseVisualStyleBackColor = true;
            TeamSeasonButton.Click += Table_Click;
            // 
            // NFLDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 819);
            Controls.Add(TeamSeasonButton);
            Controls.Add(ScheduleButton);
            Controls.Add(PlayerContractButton);
            Controls.Add(PlayersButton);
            Controls.Add(SeasonButton);
            Controls.Add(TeamsButton);
            Controls.Add(DivisionsButton);
            Controls.Add(dataGridView1);
            Controls.Add(ConferenceButton);
            Name = "NFLDatabase";
            Text = "NFLDatabase";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ConferenceButton;
        private DataGridView dataGridView1;
        private Button DivisionsButton;
        private Button TeamsButton;
        private Button SeasonButton;
        private Button PlayersButton;
        private Button PlayerContractButton;
        private Button ScheduleButton;
        private Button TeamSeasonButton;
    }
}
