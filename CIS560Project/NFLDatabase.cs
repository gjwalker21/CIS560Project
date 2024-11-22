using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace CIS560Project
{
    public partial class NFLDatabase : Form
    {
        public SqlConnection? Connection { get; set; }

        public SqlDataAdapter? DataAdapter { get; set; }

        public DataTable? DataTable { get; set; }

        public string currentTable = "";

        public Search form3 = new();

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
                    LoadTable(currentTable);
                }

                if (b.Name == "DivisionsButton")
                {
                    currentTable = "fb.Division";
                    LoadTable(currentTable);
                }

                if (b.Name == "SeasonButton")
                {
                    currentTable = "fb.Season";
                    LoadTable(currentTable);
                }

                if (b.Name == "TeamsButton")
                {
                    currentTable = "fb.Team";
                    LoadTable(currentTable);
                }

                if (b.Name == "PlayerContractButton")
                {
                    currentTable = "fb.PlayerContract";
                    LoadTable(currentTable);
                }

                if (b.Name == "PlayersButton")
                {
                    currentTable = "fb.Player";
                    LoadTable(currentTable);
                }

                if (b.Name == "ScheduleButton")
                {
                    currentTable = "fb.Schedule";
                    LoadTable(currentTable);
                }

                if (b.Name == "TeamSeasonButton")
                {
                    currentTable = "fb.TeamSeason";
                    LoadTable(currentTable);
                }

            }
        }

        private void LoadTable(string table)
        {
            string query = $"SELECT * FROM {table}";
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
                || currentTable != "fb.Division" 
                || currentTable != "fb.Team")
            {
                string query;
                string rowID = currentTable switch
                {
                    "fb.Season" => "SeasonID",
                    "fb.Schedule" => "GameID",
                    "fb.PlayerContract" => "PlayerID",
                    "fb.TeamSeason" => "TeamID",
                    "fb.Player" => "PlayerID",
                    _ => ""
                };

                if (currentTable == "fb.PlayerContract")
                {
                    query = $"DELETE FROM {currentTable} WHERE {rowID} = {dataGridView1.CurrentCell.Value}";
                }
                else if (currentTable == "fb.TeamSeason")
                {
                    query = $"DELETE FROM {currentTable} WHERE {rowID} = {dataGridView1.CurrentCell.Value}";
                }
                else
                {
                    query = $"DELETE FROM {currentTable} WHERE {rowID} = {dataGridView1.CurrentCell.Value}";
                }

                

                if (Connection != null)
                {
                    ExecuteNonQuery(Connection, query);
                }
            }
        }

        private void AddRow_Click(object sender, EventArgs e)
        {
            if (currentTable != "fb.Conference"
                || currentTable != "fb.Division"
                || currentTable != "fb.Team")
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
            var cmd = cn.CreateCommand();
            cmd.CommandText = command;
            cmd.ExecuteNonQuery();
            LoadTable(currentTable);
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
        }

        public void RunQueryButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataAdapter = new(richTextBox1.Text, Connection);
                DataTable = new();
                DataAdapter.Fill(DataTable);
                dataGridView1.DataSource = DataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Mouse_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this.dataGridView1, e.Location);
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
    }
}
