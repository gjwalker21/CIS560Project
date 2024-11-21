using Microsoft.Data.SqlClient;
using System.Data;

namespace CIS560Project
{
    public partial class NFLDatabase : Form
    {
        public SqlConnection? Connection { get; set; }

        public NFLDatabase()
        {
            InitializeComponent();
        }

        private void Table_Click(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                if (b.Name == "ConferenceButton")
                    LoadTable("fb.Conference");

                if (b.Name == "DivisionsButton")
                    LoadTable("fb.Division");

                if (b.Name == "SeasonButton")
                    LoadTable("fb.Season");

                if (b.Name == "TeamsButton")
                    LoadTable("fb.Team");

                if (b.Name == "PlayerContractButton")
                    LoadTable("fb.PlayerContract");

                if (b.Name == "PlayersButton")
                    LoadTable("fb.Player");

                if (b.Name == "ScheduleButton")
                    LoadTable("fb.Schedule");

                if (b.Name == "TeamSeasonButton")
                    LoadTable("fb.TeamSeason");
            }
        }

        private void LoadTable(string table)
        {
            
            string query = $"SELECT * FROM {table}";

            try
            {
                SqlDataAdapter dataAdapter = new(query, Connection);
                DataTable dataTable = new();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void ExecuteNonQuery(SqlConnection cn, string command)
        {
            using var cmd = cn.CreateCommand();
            cmd.CommandText = command;
            cmd.ExecuteNonQuery();
        }

        private void RunQueryButton_Click(object sender, EventArgs e)
        {

        }
    }
}
