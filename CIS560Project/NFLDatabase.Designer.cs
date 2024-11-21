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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            RunQueryButton = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            addRowToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(56, 420);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1312, 364);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellValueChanged += dataGridView1_CellContentChanged;
            dataGridView1.MouseClick += Mouse_Click;
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
            // richTextBox1
            // 
            richTextBox1.Location = new Point(691, 58);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(677, 274);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(476, 58);
            button1.Name = "button1";
            button1.Size = new Size(96, 23);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(476, 141);
            button2.Name = "button2";
            button2.Size = new Size(96, 23);
            button2.TabIndex = 11;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(476, 225);
            button3.Name = "button3";
            button3.Size = new Size(96, 23);
            button3.TabIndex = 12;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(476, 309);
            button4.Name = "button4";
            button4.Size = new Size(96, 23);
            button4.TabIndex = 13;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // RunQueryButton
            // 
            RunQueryButton.Location = new Point(1237, 361);
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
            // NFLDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 819);
            Controls.Add(RunQueryButton);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button RunQueryButton;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem addRowToolStripMenuItem;
    }
}
