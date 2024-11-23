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
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                b.Append($"VALUES ('{PlayerName.Text}', '{PlayerPosition.SelectedItem?.ToString()}');\n");

                b.Append("DECLARE @NewPlayerID INT\n");
                b.Append("SET @NewPlayerID = SCOPE_IDENTITY();\n");

                b.Append("INSERT INTO fb.PlayerContract (PlayerID, TeamID, SeasonID, AgeDuringSeason)\n");
                b.Append($"VALUES (@NewPlayerID, " +
                    $"(SELECT TeamID FROM fb.Team\n" +
                    $"WHERE TeamName = '{PlayerTeam.SelectedItem?.ToString()}'),\n" +
                    $"{PlayerSeason.SelectedItem?.ToString()},\n" +
                    $"{PlayerAge.Text});");

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
                if (Login.form2.Connection != null)
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

        private string AddGame(bool doAll)
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
                if (doAll == false)
                {
                    b.Append("INSERT INTO fb.Schedule (HomeTeamID, AwayTeamID, [Date], [Location], SeasonID)\n");
                    b.Append("VALUES (\n");
                    b.Append("(SELECT TeamID\n" +
                             "FROM fb.Team\n");
                    b.Append($"WHERE TeamName = '{HomeTeam.SelectedItem?.ToString()}'),\n");
                    b.Append("(SELECT TeamID\n" +
                             "FROM fb.Team\n");
                    b.Append($"WHERE TeamName = '{AwayTeam.SelectedItem?.ToString()}'),\n");
                    b.Append("(SELECT TeamID\n" +
                             "FROM fb.Team\n");
                    b.Append($"'{GameDate.Text}',\n");
                    b.Append($"'{GameLocation.SelectedItem?.ToString()}',\n");
                    b.Append($"{GameSeason.SelectedItem?.ToString()})");
                }
                else
                {
                    b.Append("INSERT INTO fb.Schedule (HomeTeamID, AwayTeamID, WinnerID, WinnerScore, LoserScore, [Date], [Location], SeasonID)\n");
                    b.Append("VALUES (\n");
                    b.Append("(SELECT TeamID\n" +
                             "FROM fb.Team\n");
                    b.Append($"WHERE TeamName = '{HomeTeam.SelectedItem?.ToString()}'),\n");
                    b.Append("(SELECT TeamID\n" +
                             "FROM fb.Team\n");
                    b.Append($"WHERE TeamName = '{AwayTeam.SelectedItem?.ToString()}'),\n");
                    b.Append("(SELECT TeamID\n" +
                             "FROM fb.Team\n");
                    b.Append($"WHERE TeamName = '{WinnerComboBox.SelectedItem?.ToString()}'),\n");
                    b.Append($"{WinnerScore.Text},\n");
                    b.Append($"{LoserScore.Text},\n");
                    b.Append($"'{GameDate.Text}',\n");
                    b.Append($"'{GameLocation.SelectedItem?.ToString()}',\n");
                    b.Append($"{GameSeason.SelectedItem?.ToString()})");
                }
                return b.ToString();
            }
            return "";
        }

        private void AddGameButton_Click(object sender, EventArgs e)
        {
            if (Login.form2.Connection != null)
            {
                if (!string.IsNullOrWhiteSpace(HomeTeam.SelectedItem?.ToString())
                    && !string.IsNullOrWhiteSpace(GameDate.Text)
                    && !string.IsNullOrWhiteSpace(AwayTeam.SelectedItem?.ToString())
                    && !string.IsNullOrWhiteSpace(GameLocation.SelectedItem?.ToString())
                    && !string.IsNullOrWhiteSpace(GameSeason.SelectedItem?.ToString())
                    && HomeTeam.SelectedItem?.ToString() != AwayTeam.SelectedItem?.ToString())
                {
                    if (string.IsNullOrWhiteSpace(WinnerComboBox.SelectedItem?.ToString())
                    && string.IsNullOrWhiteSpace(WinnerScore.Text)
                    && string.IsNullOrWhiteSpace(LoserScore.Text))
                    {
                        ExecuteNonQuery(Login.form2.Connection, AddGame(false));
                        MessageBox.Show("Game added successfully!");
                    }
                    else if (!string.IsNullOrWhiteSpace(WinnerComboBox.SelectedItem?.ToString())
                        && !string.IsNullOrWhiteSpace(WinnerScore.Text)
                        && !string.IsNullOrWhiteSpace(LoserScore.Text))
                    {
                        ExecuteNonQuery(Login.form2.Connection, AddGame(true));
                        MessageBox.Show("Game added successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid values for field(s)");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid values for field(s)");
                }
            }
        }

        private void MyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private static void ExecuteNonQuery(SqlConnection cn, string command)
        {
            var cmd = cn.CreateCommand();
            cmd.CommandText = command;
            try
            {
                cmd.ExecuteNonQuery();
                Login.form2.LoadTable();
                MessageBox.Show("Season added successfully!");
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        private void WinnerComboBox_DropDown(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(HomeTeam.SelectedItem?.ToString())
                && !string.IsNullOrEmpty(AwayTeam.SelectedItem?.ToString()))
            {
                WinnerComboBox.Items.Clear();
                WinnerComboBox.Items.Add("");
                WinnerComboBox.Items.Add(HomeTeam.SelectedItem);
                WinnerComboBox.Items.Add(AwayTeam.SelectedItem);
            }
        }

        private string AddSeason()
        {
            StringBuilder b = new();
            b.Append("INSERT fb.Season\n");
            b.Append($"VALUES ({SeasonSeason.Text})");
            return b.ToString();
        }

        private void AddSeasonButton_Click(object sender, EventArgs e)
        {
            if (Login.form2.Connection != null && SeasonSeason.Text.Length == 4)
            {
                ExecuteNonQuery(Login.form2.Connection, AddSeason());
            }
            else
            {
                MessageBox.Show("Invalid value (should be \"yyyy\")");
            }
        }
    }
}
