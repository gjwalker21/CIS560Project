using Microsoft.Data.SqlClient;
using System.Data;

namespace CIS560Project
{
    public partial class NFLDatabase : Form
    {
        public SqlConnection? Connection { get; set; }

        private SqlDataAdapter? dataAdapter;

        private DataTable? dataTable;

        private SqlCommandBuilder? commandBuilder;

        private string currentTable = "";

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
                dataAdapter = new(query, Connection);
                dataTable = new();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentChanged(object sender, DataGridViewCellEventArgs e)
        {            
            if (dataGridView1.CurrentCell.Value != null 
                && dataAdapter != null 
                && dataTable != null 
                && BindingContext != null)
            {
                try
                {
                    dataGridView1.EndEdit(); 
                    BindingContext[dataTable].EndCurrentEdit(); 
                    commandBuilder = new(dataAdapter);
                    dataAdapter.Update(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            string query;
            string rowID = currentTable switch
            {
                "fb.Conference" => "ConferenceID",
                "fb.Division" => "DivisionID",
                "fb.Season" => "SeasonID",
                "fb.Schedule" => "ScheduleID",
                "fb.PlayerContract" => "PlayerContractID",
                "fb.TeamSeason" => "TeamSeasonID",
                "fb.Player" => "PlayerID",
                "fb.Team" => "TeamID",
                _ => ""
            };

            if (currentTable == "fb.Season")
            {
                query = $"DELETE FROM {currentTable} WHERE {rowID} = {dataGridView1.CurrentRow.Index + 2020}";
            }
            else
            {
                query = $"DELETE FROM {currentTable} WHERE {rowID} = {dataGridView1.CurrentRow.Index + 1}";
            }

            if (Connection != null)
            {
                ExecuteNonQuery(Connection, query);
            }
        }

        private void AddRow_Click(object sender, EventArgs e)
        {
            if (dataTable != null && dataAdapter != null)
            {
                DataRow newRow = dataTable.NewRow();
                dataTable.Rows.Add(newRow);
            }
        }


        private void ExecuteNonQuery(SqlConnection cn, string command)
        {
            var cmd = cn.CreateCommand();
            cmd.CommandText = command;
            cmd.ExecuteNonQuery();
            LoadTable(currentTable);
        }

        private void RunQueryButton_Click(object sender, EventArgs e)
        {

        }

        private void Mouse_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this.dataGridView1, e.Location);
            }
        }
    }
}
