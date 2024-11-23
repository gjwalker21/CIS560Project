using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Text;

namespace CIS560Project
{
    public partial class NFLDatabase : Form
    {
        public SqlConnection? Connection { get; set; }

        public SqlDataAdapter? DataAdapter { get; set; }

        public DataTable? DataTable { get; set; }

        public string currentTable = "";

        public string query = "";

        public Search form3 = new();

        public Add form4 = new();

        public NFLDatabase()
        {
            InitializeComponent();
        }

        private void Table_Click(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                if (b.Name == "ConferenceButton")
                {
                    currentTable = "fb.Conference";
                    LoadTable();
                }

                if (b.Name == "DivisionsButton")
                {
                    currentTable = "fb.Division";
                    LoadTable();
                }

                if (b.Name == "SeasonButton")
                {
                    currentTable = "fb.Season";
                    LoadTable();
                }

                if (b.Name == "TeamsButton")
                {
                    currentTable = "fb.Team";
                    LoadTable();
                }

                if (b.Name == "PlayerContractButton")
                {
                    currentTable = "fb.PlayerContract";
                    LoadTable();
                }

                if (b.Name == "PlayersButton")
                {
                    currentTable = "fb.Player";
                    LoadTable();
                }

                if (b.Name == "ScheduleButton")
                {
                    currentTable = "fb.Schedule";
                    LoadTable();
                }

                if (b.Name == "TeamSeasonButton")
                {
                    currentTable = "fb.TeamSeason";
                    LoadTable();
                }

            }
        }

        public void LoadTable()
        {
            if (currentTable == "fb.Team")
            {
                query = "SELECT T.TeamID, T.TeamName, D.DivisionName, C.ConferenceName\n" +
                        "FROM fb.Team T\n" +
                        "INNER JOIN fb.Division D ON D.DivisionID = T.DivisionID\n" +
                        "INNER JOIN fb.Conference C ON C.ConferenceID = D.ConferenceID;";
            }
            else if (currentTable == "fb.Player")
            {
                query = "SELECT DISTINCT P.PlayerID, P.PlayerName, P.Position, PC.AgeDuringSeason, T.TeamName, PC.SeasonID AS Season, D.DivisionName, C.ConferenceName\n" +
                        "FROM fb.Player P\n" +
                        "INNER JOIN fb.PlayerContract PC ON PC.PlayerID = P.PlayerID\n" +
                        "INNER JOIN fb.TeamSeason TS ON TS.TeamID = PC.TeamID\n" +
                        "INNER JOIN fb.Team T ON T.TeamID = TS.TeamID\n" +
                        "INNER JOIN fb.Division D ON D.DivisionID = T.DivisionID\n" +
                        "INNER JOIN fb.Conference C ON C.ConferenceID = D.ConferenceID\n" +
                        "ORDER BY P.PlayerID ASC;";
            }
            else if (currentTable == "fb.Schedule")
            {
                query = "SELECT G.GameID, T1.TeamName AS HomeTeam, T2.TeamName AS AwayTeam, T3.TeamName AS Winner, G.WinnerScore, G.LoserScore, G.Date, G.Location, G.SeasonID AS Season\n" +
                        "FROM fb.Schedule G\n" +
                        "INNER JOIN fb.Team T1 ON T1.TeamID = G.HomeTeamID\n" +
                        "INNER JOIN fb.Team T2 ON T2.TeamID = G.AwayTeamID\n" +
                        "INNER JOIN fb.Team T3 ON T3.TeamID = G.WinnerID;";
            }
            else
            {
                query = $"SELECT * FROM {currentTable};";
            }

            try
            {
                DataAdapter = new(query, Connection);
                DataTable = new();
                DataAdapter.Fill(DataTable);
                dataGridView1.DataSource = DataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            if (currentTable != "fb.Conference"
                && currentTable != "fb.Division"
                && currentTable != "fb.Team")
            {
                StringBuilder b = new();

                if (dataGridView1.SelectedRows.Count == 1 && currentTable == "fb.Player")
                {
                    b.Append("DELETE FROM fb.PlayerContract\n");
                    b.Append("WHERE PlayerID = (\n");
                    b.Append("SELECT PlayerID\n");
                    b.Append("FROM fb.Player\n");
                    b.Append($"WHERE PlayerName = '{dataGridView1.CurrentRow.Cells[1].Value.ToString()}' ");
                    b.Append($"AND [Position] = '{dataGridView1.CurrentRow.Cells[2].Value.ToString()}' ");
                    b.Append("AND TeamID = (\n");
                    b.Append("SELECT TeamID\n");
                    b.Append("FROM fb.Team\n");
                    b.Append($"WHERE TeamName = '{dataGridView1.CurrentRow.Cells[4].Value.ToString()}')\n);");

                    b.Append("DELETE FROM fb.Player\n");
                    b.Append($"WHERE PlayerName = '{dataGridView1.CurrentRow.Cells[1].Value.ToString()}' ");
                    b.Append($"AND [Position] = '{dataGridView1.CurrentRow.Cells[2].Value.ToString()}'");
                }
                else if (dataGridView1.SelectedRows.Count == 1 && currentTable == "fb.Schedule")
                {
                    string? dateString = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    
                    if (!string.IsNullOrEmpty(dateString))
                    {
                        DateTime parsedDate = DateTime.Parse(dateString);
                        string formattedDate = parsedDate.ToString("yyyy-MM-dd");
                        b.Append("DELETE FROM fb.Schedule\n");
                        b.Append("WHERE HomeTeamID = (\n");
                        b.Append("SELECT TeamID\n");
                        b.Append("FROM fb.Team\n");
                        b.Append($"WHERE TeamName = '{dataGridView1.CurrentRow.Cells[1].Value.ToString()}') AND ");
                        b.Append("AwayTeamID = (\n");
                        b.Append("SELECT TeamID\n");
                        b.Append("FROM fb.Team\n");
                        b.Append($"WHERE TeamName = '{dataGridView1.CurrentRow.Cells[2].Value.ToString()}') AND ");
                        b.Append("WinnerID = (\n");
                        b.Append("SELECT TeamID\n");
                        b.Append("FROM fb.Team\n");
                        b.Append($"WHERE TeamName = '{dataGridView1.CurrentRow.Cells[3].Value.ToString()}') AND ");
                        b.Append($"WinnerScore = {dataGridView1.CurrentRow.Cells[4].Value.ToString()} AND ");
                        b.Append($"LoserScore = {dataGridView1.CurrentRow.Cells[5].Value.ToString()} AND ");
                        b.Append($"Date = '{formattedDate}' AND ");
                        b.Append($"Location = '{dataGridView1.CurrentRow.Cells[7].Value.ToString()}' AND ");
                        b.Append($"SeasonID = {dataGridView1.CurrentRow.Cells[8].Value.ToString()}");
                    }
                }

                if (Connection != null)
                {
                    ExecuteNonQuery(Connection, b.ToString());
                }
            }
        }

        private void AddRow_Click(object sender, EventArgs e)
        {
            if (currentTable != "fb.Conference"
                && currentTable != "fb.Division"
                && currentTable != "fb.Team")
            {
                if (DataTable != null && DataAdapter != null)
                {
                    DataRow newRow = DataTable.NewRow();
                    DataTable.Rows.Add(newRow);
                }
            }
        }

        private void ExecuteNonQuery(SqlConnection cn, string command)
        {
            try
            {
                var cmd = cn.CreateCommand();
                cmd.CommandText = command;
                cmd.ExecuteNonQuery();
                LoadTable();
                MessageBox.Show("Row deleted!");
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void LoadQueryButton_Click(object sender, EventArgs e)
        {
            string fileName = "";
            if (sender is Button b)
            {
                if (b.Name == "HomeTeamPerformance")
                {
                    fileName = "HomeTeamPerformance.sql";
                }
                if (b.Name == "ConferenceRank")
                {
                    fileName = "Conf_rank.sql";
                }
                if (b.Name == "AverageAge")
                {
                    fileName = "AVG_agePos.sql";
                }
                if (b.Name == "AverageWins")
                {
                    fileName = "AVG_wins_3.sql";
                }
            }

            using StreamReader sr = new(fileName);
            richTextBox1.Text = sr.ReadToEnd();
            RunQuery(richTextBox1.Text);
        }

        public void RunQueryButton_Click(object sender, EventArgs e)
        {
            RunQuery(richTextBox1.Text);
        }

        private void RunQuery(string query)
        {
            try
            {
                DataAdapter = new(query, Connection);
                DataTable = new();
                DataAdapter.Fill(DataTable);
                dataGridView1.DataSource = DataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Finalize_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.Value != null
                && DataAdapter != null
                && DataTable != null
                && BindingContext != null
                && dataGridView1.IsCurrentRowDirty == false)
            {
                try
                {
                    dataGridView1.EndEdit();
                    BindingContext[DataTable].EndCurrentEdit();
                    SqlCommandBuilder commandBuilder = new(DataAdapter);
                    DataAdapter.Update(DataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            form3.Show();
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            form4.Show();
        }
    }
}
