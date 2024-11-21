using Microsoft.Data.SqlClient;
using System.Data;

namespace CIS560Project
{
    public partial class NFLDatabase : Form
    {
        public NFLDatabase()
        {
            InitializeComponent();
            try
            {
                ///You need to put this file in \CIS560Project\bin\Debug\net8.0-windows
                ///with your username and password for the server
                ///remember to take it out before pushing to repository
                using StreamReader reader = new("info.txt");
                username = reader.ReadLine();
                password = reader.ReadLine();
            }
            catch(IOException)
            {
                Console.WriteLine("You need to put \"info.txt\" in \\CIS560Project\\bin\\Debug\\net8.0-windows");
            }
        }

        private readonly string? username;

        private readonly string? password;

        private void Table_Click(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                if (b.Name == "ConferenceButton")
                    LoadData("fb.Conference");

                if (b.Name == "DivisionsButton")
                    LoadData("fb.Division");

                if (b.Name == "SeasonButton")
                    LoadData("fb.Season");

                if (b.Name == "TeamsButton")
                    LoadData("fb.Team");

                if (b.Name == "PlayerContractButton")
                    LoadData("fb.PlayerContract");

                if (b.Name == "PlayersButton")
                    LoadData("fb.Player");

                if (b.Name == "ScheduleButton")
                    LoadData("fb.Schedule");

                if (b.Name == "TeamSeasonButton")
                    LoadData("fb.TeamSeason");
            }
        }

        private void LoadData(string table)
        {
            string connectionString = $"Server=mssql.cs.ksu.edu;Database=cis560_team15;User Id={username};Password={password};Encrypt=True;TrustServerCertificate=True;";
            string query = $"SELECT * FROM {table}";

            using SqlConnection connection = new(connectionString);
            try
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new(query, connection);
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

    }
}
