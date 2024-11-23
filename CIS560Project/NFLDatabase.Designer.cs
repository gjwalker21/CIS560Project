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
            ScheduleButton = new Button();
            richTextBox1 = new RichTextBox();
            WinsByAgeGroup = new Button();
            HomefieldAdvantage = new Button();
            DivisionSuccess = new Button();
            AverageWins = new Button();
            RunQueryButton = new Button();
            SearchButton = new Button();
            label1 = new Label();
            label2 = new Label();
            AddRowButton = new Button();
            DeleteRowButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ConferenceButton
            // 
            ConferenceButton.Location = new Point(284, 141);
            ConferenceButton.Name = "ConferenceButton";
            ConferenceButton.Size = new Size(113, 43);
            ConferenceButton.TabIndex = 0;
            ConferenceButton.Text = "Conferences";
            ConferenceButton.UseVisualStyleBackColor = true;
            ConferenceButton.Click += Table_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(57, 420);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(936, 364);
            dataGridView1.TabIndex = 1;
            // 
            // DivisionsButton
            // 
            DivisionsButton.Location = new Point(284, 213);
            DivisionsButton.Name = "DivisionsButton";
            DivisionsButton.Size = new Size(113, 43);
            DivisionsButton.TabIndex = 2;
            DivisionsButton.Text = "Divisions";
            DivisionsButton.UseVisualStyleBackColor = true;
            DivisionsButton.Click += Table_Click;
            // 
            // TeamsButton
            // 
            TeamsButton.Location = new Point(91, 141);
            TeamsButton.Name = "TeamsButton";
            TeamsButton.Size = new Size(113, 43);
            TeamsButton.TabIndex = 3;
            TeamsButton.Text = "Teams";
            TeamsButton.UseVisualStyleBackColor = true;
            TeamsButton.Click += Table_Click;
            // 
            // SeasonButton
            // 
            SeasonButton.Location = new Point(284, 284);
            SeasonButton.Name = "SeasonButton";
            SeasonButton.Size = new Size(113, 43);
            SeasonButton.TabIndex = 4;
            SeasonButton.Text = "Seasons";
            SeasonButton.UseVisualStyleBackColor = true;
            SeasonButton.Click += Table_Click;
            // 
            // PlayersButton
            // 
            PlayersButton.Location = new Point(91, 213);
            PlayersButton.Name = "PlayersButton";
            PlayersButton.Size = new Size(113, 43);
            PlayersButton.TabIndex = 5;
            PlayersButton.Text = "Players";
            PlayersButton.UseVisualStyleBackColor = true;
            PlayersButton.Click += Table_Click;
            // 
            // ScheduleButton
            // 
            ScheduleButton.Location = new Point(91, 284);
            ScheduleButton.Name = "ScheduleButton";
            ScheduleButton.Size = new Size(113, 43);
            ScheduleButton.TabIndex = 7;
            ScheduleButton.Text = "Schedule";
            ScheduleButton.UseVisualStyleBackColor = true;
            ScheduleButton.Click += Table_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(712, 77);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(677, 274);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // WinsByAgeGroup
            // 
            WinsByAgeGroup.Location = new Point(469, 118);
            WinsByAgeGroup.Name = "WinsByAgeGroup";
            WinsByAgeGroup.Size = new Size(158, 23);
            WinsByAgeGroup.TabIndex = 10;
            WinsByAgeGroup.Text = "Wins by Age Group";
            WinsByAgeGroup.UseVisualStyleBackColor = true;
            WinsByAgeGroup.Click += LoadQueryButton_Click;
            // 
            // HomefieldAdvantage
            // 
            HomefieldAdvantage.Location = new Point(469, 182);
            HomefieldAdvantage.Name = "HomefieldAdvantage";
            HomefieldAdvantage.Size = new Size(158, 23);
            HomefieldAdvantage.TabIndex = 11;
            HomefieldAdvantage.Text = "Homefield Advantage";
            HomefieldAdvantage.UseVisualStyleBackColor = true;
            HomefieldAdvantage.Click += LoadQueryButton_Click;
            // 
            // DivisionSuccess
            // 
            DivisionSuccess.Location = new Point(469, 316);
            DivisionSuccess.Name = "DivisionSuccess";
            DivisionSuccess.Size = new Size(158, 23);
            DivisionSuccess.TabIndex = 12;
            DivisionSuccess.Text = "Division Success";
            DivisionSuccess.UseVisualStyleBackColor = true;
            DivisionSuccess.Click += LoadQueryButton_Click;
            // 
            // AverageWins
            // 
            AverageWins.Location = new Point(469, 249);
            AverageWins.Name = "AverageWins";
            AverageWins.Size = new Size(158, 23);
            AverageWins.TabIndex = 13;
            AverageWins.Text = "Average Wins per Team";
            AverageWins.UseVisualStyleBackColor = true;
            AverageWins.Click += LoadQueryButton_Click;
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
            // SearchButton
            // 
            SearchButton.Location = new Point(1026, 753);
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
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 55);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 19;
            label1.Text = "Tables";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(712, 27);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 20;
            label2.Text = "SQL Query";
            // 
            // AddRowButton
            // 
            AddRowButton.Location = new Point(1026, 420);
            AddRowButton.Name = "AddRowButton";
            AddRowButton.Size = new Size(85, 23);
            AddRowButton.TabIndex = 21;
            AddRowButton.Text = "Add Row";
            AddRowButton.UseVisualStyleBackColor = true;
            AddRowButton.Click += AddRowButton_Click;
            // 
            // DeleteRowButton
            // 
            DeleteRowButton.Location = new Point(1026, 464);
            DeleteRowButton.Name = "DeleteRowButton";
            DeleteRowButton.Size = new Size(85, 23);
            DeleteRowButton.TabIndex = 22;
            DeleteRowButton.Text = "Delete Row";
            DeleteRowButton.UseVisualStyleBackColor = true;
            DeleteRowButton.Click += DeleteRow_Click;
            // 
            // NFLDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 819);
            Controls.Add(DeleteRowButton);
            Controls.Add(AddRowButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SearchButton);
            Controls.Add(RunQueryButton);
            Controls.Add(AverageWins);
            Controls.Add(DivisionSuccess);
            Controls.Add(HomefieldAdvantage);
            Controls.Add(WinsByAgeGroup);
            Controls.Add(richTextBox1);
            Controls.Add(ScheduleButton);
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
            PerformLayout();
        }

        #endregion

        private Button ConferenceButton;
        private Button DivisionsButton;
        private Button TeamsButton;
        private Button SeasonButton;
        private Button PlayersButton;
        private Button ScheduleButton;
        private RichTextBox richTextBox1;
        private Button WinsByAgeGroup;
        private Button HomefieldAdvantage;
        private Button DivisionSuccess;
        private Button AverageWins;
        private Button RunQueryButton;
        private Button SearchButton;
        private Label label1;
        private Label label2;
        public DataGridView dataGridView1;
        private Button AddRowButton;
        private Button DeleteRowButton;
    }
}
