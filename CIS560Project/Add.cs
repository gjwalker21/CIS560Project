using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS560Project
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private string AddPlayer()
        {
            bool goAhead = false;
            foreach (Control control in PlayerBox.Controls)
            {
                if (control is ComboBox box)
                {
                    if (box.SelectedItem != null)
                    {
                        goAhead = true;
                        break;
                    }
                }
                if (control is TextBox text)
                {
                    if (!string.IsNullOrWhiteSpace(text.Text))
                    {
                        goAhead = true;
                        break;
                    }
                }
            }
            if (goAhead)
            {
                StringBuilder b = new();

                b.Append("INSERT INTO fb.Player (PlayerName, [Position])\n");
                b.Append($"VALUES ('{PlayerName.Text}', '{PlayerPosition.SelectedItem?.ToString()}')\n");

                b.Append("DECLARE @NewPlayerID INT\n");
                b.Append("SET @NewPlayerID = SCOPE_IDENTITY()\n");

                b.Append("INSERT INTO fb.PlayerContract (PlayerID, TeamID, SeasonID, AgeDuringSeason)\n");
                b.Append($"VALUES (@NewPlayerID, " +
                    $"(SELECT TeamID FROM fb.Team " +
                    $"WHERE TeamName = '{PlayerTeam.SelectedItem?.ToString()}'), " +
                    $"{PlayerSeason.SelectedItem?.ToString()}, " +
                    $"{PlayerAge.Text})");

                return b.ToString();
            }
            return "";
        }

        private string AddGame()
        {
            bool goAhead = false;
            foreach (Control control in GameBox.Controls)
            {
                if (control is ComboBox box)
                {
                    if (box.SelectedItem != null)
                    {
                        goAhead = true;
                        break;
                    }
                }
                if (control is TextBox text)
                {
                    if (!string.IsNullOrWhiteSpace(text.Text))
                    {
                        goAhead = true;
                        break;
                    }
                }
            }
            if (goAhead)
            {
                StringBuilder b = new();

                b.Append("INSERT INTO fb.Schedule (HomeTeamID, AwayTeamID, WinnerID, WinnerScore, LoserScore, [Date], [Location], SeasonID)\n");
                b.Append("VALUES (\n");
                b.Append("(SELECT TeamID\n" +
                         "FROM fb.Team\n");
                b.Append($"WHERE TeamName = '{HomeTeam.SelectedItem?.ToString()}'),\n"); // Added single quotes
                b.Append("(SELECT TeamID\n" +
                         "FROM fb.Team\n");
                b.Append($"WHERE TeamName = '{AwayTeam.SelectedItem?.ToString()}'),\n"); // Added single quotes
                b.Append("(SELECT TeamID\n" +
                         "FROM fb.Team\n");
                b.Append($"WHERE TeamName = '{Winner.SelectedItem?.ToString()}'),\n"); // Added single quotes
                b.Append($"{WinnerScore.Text},\n");
                b.Append($"{LoserScore.Text},\n");
                b.Append($"'{GameDate.Text}',\n"); // Added single quotes for date
                b.Append($"'{GameLocation.SelectedItem?.ToString()}',\n"); // Added single quotes for location
                b.Append($"{GameSeason.SelectedItem?.ToString()})");

                return b.ToString();
            }
            return "";
        }


        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            bool goAhead = true;
            foreach (Control control in PlayerBox.Controls)
            {
                if (control is ComboBox box)
                {
                    if (string.IsNullOrEmpty(box.SelectedItem?.ToString()))
                    {
                        goAhead = false;
                    }
                }
            }
            if (goAhead)
            {
                if (!string.IsNullOrWhiteSpace(HomeTeam.SelectedItem?.ToString())
                    && !string.IsNullOrWhiteSpace(AwayTeam.SelectedItem?.ToString())
                    && !string.IsNullOrWhiteSpace(Winner.SelectedItem?.ToString())
                    && !string.IsNullOrWhiteSpace(GameSeason.SelectedItem?.ToString())
                    && !string.IsNullOrWhiteSpace(GameDate.Text)
                    && Login.form2.Connection != null)
                {
                    ExecuteNonQuery(Login.form2.Connection, AddPlayer());
                    MessageBox.Show("Player added successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please fill out all fields.");
            }
        }

        private void MyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void ExecuteNonQuery(SqlConnection cn, string command)
        {
            var cmd = cn.CreateCommand();
            cmd.CommandText = command;
            cmd.ExecuteNonQuery();
            Login.form2.LoadTable();
        }

        private void AddGameButton_Click(object sender, EventArgs e)
        {
            bool goAhead = true;
            if (HomeTeam.SelectedItem != null)
            if (goAhead)
            {
                if (Login.form2.Connection != null)
                {
                    ExecuteNonQuery(Login.form2.Connection, AddGame());
                    MessageBox.Show("Game added successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please fill out all fields.");
            }
        }
    }
}
