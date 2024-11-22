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
            components = new System.ComponentModel.Container();
            ConferenceButton = new Button();
            dataGridView1 = new DataGridView();
            DivisionsButton = new Button();
            TeamsButton = new Button();
            SeasonButton = new Button();
            PlayersButton = new Button();
            PlayerContractButton = new Button();
            ScheduleButton = new Button();
            TeamSeasonButton = new Button();
            richTextBox1 = new RichTextBox();
            HomeTeamPerformance = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            RunQueryButton = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            addRowToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            button5 = new Button();
            SearchButton = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ConferenceButton
            // 
            ConferenceButton.Location = new Point(91, 76);
            ConferenceButton.Name = "ConferenceButton";
            ConferenceButton.Size = new Size(96, 23);
            ConferenceButton.TabIndex = 0;
            ConferenceButton.Text = "Conferences";
            ConferenceButton.UseVisualStyleBackColor = true;
            ConferenceButton.Click += Table_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(57, 420);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(936, 364);
            dataGridView1.TabIndex = 1;
            dataGridView1.MouseClick += Mouse_Click;
            // 
            // DivisionsButton
            // 
            DivisionsButton.Location = new Point(91, 159);
            DivisionsButton.Name = "DivisionsButton";
            DivisionsButton.Size = new Size(96, 23);
            DivisionsButton.TabIndex = 2;
            DivisionsButton.Text = "Divisions";
            DivisionsButton.UseVisualStyleBackColor = true;
            DivisionsButton.Click += Table_Click;
            // 
            // TeamsButton
            // 
            TeamsButton.Location = new Point(91, 243);
            TeamsButton.Name = "TeamsButton";
            TeamsButton.Size = new Size(96, 23);
            TeamsButton.TabIndex = 3;
            TeamsButton.Text = "Teams";
            TeamsButton.UseVisualStyleBackColor = true;
            TeamsButton.Click += Table_Click;
            // 
            // SeasonButton
            // 
            SeasonButton.Location = new Point(91, 327);
            SeasonButton.Name = "SeasonButton";
            SeasonButton.Size = new Size(96, 23);
            SeasonButton.TabIndex = 4;
            SeasonButton.Text = "Seasons";
            SeasonButton.UseVisualStyleBackColor = true;
            SeasonButton.Click += Table_Click;
            // 
            // PlayersButton
            // 
            PlayersButton.Location = new Point(284, 76);
            PlayersButton.Name = "PlayersButton";
            PlayersButton.Size = new Size(96, 23);
            PlayersButton.TabIndex = 5;
            PlayersButton.Text = "Players";
            PlayersButton.UseVisualStyleBackColor = true;
            PlayersButton.Click += Table_Click;
            // 
            // PlayerContractButton
            // 
            PlayerContractButton.Location = new Point(284, 159);
            PlayerContractButton.Name = "PlayerContractButton";
            PlayerContractButton.Size = new Size(96, 23);
            PlayerContractButton.TabIndex = 6;
            PlayerContractButton.Text = "PlayerContract";
            PlayerContractButton.UseVisualStyleBackColor = true;
            PlayerContractButton.Click += Table_Click;
            // 
            // ScheduleButton
            // 
            ScheduleButton.Location = new Point(284, 243);
            ScheduleButton.Name = "ScheduleButton";
            ScheduleButton.Size = new Size(96, 23);
            ScheduleButton.TabIndex = 7;
            ScheduleButton.Text = "Schedule";
            ScheduleButton.UseVisualStyleBackColor = true;
            ScheduleButton.Click += Table_Click;
            // 
            // TeamSeasonButton
            // 
            TeamSeasonButton.Location = new Point(284, 327);
            TeamSeasonButton.Name = "TeamSeasonButton";
            TeamSeasonButton.Size = new Size(96, 23);
            TeamSeasonButton.TabIndex = 8;
            TeamSeasonButton.Text = "TeamSeason";
            TeamSeasonButton.UseVisualStyleBackColor = true;
            TeamSeasonButton.Click += Table_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(712, 77);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(677, 274);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // HomeTeamPerformance
            // 
            HomeTeamPerformance.Location = new Point(469, 76);
            HomeTeamPerformance.Name = "HomeTeamPerformance";
            HomeTeamPerformance.Size = new Size(164, 23);
            HomeTeamPerformance.TabIndex = 10;
            HomeTeamPerformance.Text = "Home Team Performance";
            HomeTeamPerformance.UseVisualStyleBackColor = true;
            HomeTeamPerformance.Click += LoadQueryButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(469, 159);
            button2.Name = "button2";
            button2.Size = new Size(96, 23);
            button2.TabIndex = 11;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(469, 243);
            button3.Name = "button3";
            button3.Size = new Size(96, 23);
            button3.TabIndex = 12;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(469, 327);
            button4.Name = "button4";
            button4.Size = new Size(96, 23);
            button4.TabIndex = 13;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // RunQueryButton
            // 
            RunQueryButton.Location = new Point(1258, 376);
            RunQueryButton.Name = "RunQueryButton";
            RunQueryButton.Size = new Size(131, 26);
            RunQueryButton.TabIndex = 14;
            RunQueryButton.Text = "Run Query";
            RunQueryButton.UseVisualStyleBackColor = true;
            RunQueryButton.Click += RunQueryButton_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { addRowToolStripMenuItem, toolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(134, 48);
            // 
            // addRowToolStripMenuItem
            // 
            addRowToolStripMenuItem.Name = "addRowToolStripMenuItem";
            addRowToolStripMenuItem.Size = new Size(133, 22);
            addRowToolStripMenuItem.Text = "Add Row";
            addRowToolStripMenuItem.Click += AddRow_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.AccessibleName = "DeleteRow";
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(133, 22);
            toolStripMenuItem1.Text = "Delete Row";
            toolStripMenuItem1.Click += DeleteRow_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1026, 420);
            button5.Name = "button5";
            button5.Size = new Size(120, 31);
            button5.TabIndex = 17;
            button5.Text = "Finalize Changes";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Finalize_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(1026, 694);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(85, 31);
            SearchButton.TabIndex = 18;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 27);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 19;
            label1.Text = "Tables";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(712, 27);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 20;
            label2.Text = "SQL Query";
            // 
            // NFLDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 819);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SearchButton);
            Controls.Add(button5);
            Controls.Add(RunQueryButton);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(HomeTeamPerformance);
            Controls.Add(richTextBox1);
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
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConferenceButton;
        private Button DivisionsButton;
        private Button TeamsButton;
        private Button SeasonButton;
        private Button PlayersButton;
        private Button PlayerContractButton;
        private Button ScheduleButton;
        private Button TeamSeasonButton;
        private RichTextBox richTextBox1;
        private Button HomeTeamPerformance;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button RunQueryButton;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem addRowToolStripMenuItem;
        private Button button5;
        private Button SearchButton;
        private Label label1;
        private Label label2;
        public DataGridView dataGridView1;
    }
}
