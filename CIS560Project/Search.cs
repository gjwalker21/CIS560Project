using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS560Project
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchText = "";

            if (TabControl.SelectedTab != null && TabControl.SelectedTab.Name == "TeamTab")
            {
                searchText = TeamSearch();
            }
            if (TabControl.SelectedTab != null && TabControl.SelectedTab.Name == "PlayerTab")
            {
                searchText = PlayerSearch();
            }
            if (TabControl.SelectedTab != null && TabControl.SelectedTab.Name == "GameTab")
            {
                searchText = GameSearch();
            }

            if (searchText != "")
            {
                try
                {
                    Login.form2.DataAdapter = new(searchText, Login.form2.Connection);
                    Login.form2.DataTable = new();
                    Login.form2.DataAdapter.Fill(Login.form2.DataTable);
                    Login.form2.dataGridView1.DataSource = Login.form2.DataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private string TeamSearch()
        {
            bool goAhead = false;

            foreach (Control control in TeamBox.Controls)
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
                b.Append("SELECT DISTINCT T.TeamID, T.TeamName, D.DivisionName, C.ConferenceName, TS.SeasonID, S.Date\n");
                b.Append(
                    "FROM fb.Team T\n" +
                    "INNER JOIN fb.Division D ON D.DivisionID = T.DivisionID\n" +
                    "INNER JOIN fb.Conference C ON C.ConferenceID = D.ConferenceID\n" +
                    "LEFT JOIN fb.Schedule S ON (S.HomeTeamID = T.TeamID OR S.AwayTeamID = T.TeamID)\n" +
                    "LEFT JOIN fb.TeamSeason TS ON TS.TeamID = T.TeamID\n" +
                    "WHERE ");

                bool useAnd = false;


                if (!string.IsNullOrEmpty(TeamTeamName.SelectedItem?.ToString()))
                {
                    if (useAnd) b.Append("AND ");
                    b.Append($"T.TeamName = '{TeamTeamName.SelectedItem}' ");
                    useAnd = true;
                }

                if (!string.IsNullOrEmpty(TeamDivision.SelectedItem?.ToString()))
                {
                    if (useAnd) b.Append("AND ");
                    b.Append($"D.DivisionName = '{TeamDivision.SelectedItem}' ");
                    useAnd = true;
                }

                if (!string.IsNullOrEmpty(TeamConference.SelectedItem?.ToString()))
                {
                    if (useAnd) b.Append("AND ");
                    b.Append($"C.ConferenceName = '{TeamConference.SelectedItem}' ");
                    useAnd = true;
                }

                if (!string.IsNullOrEmpty(TeamSeason.SelectedItem?.ToString()))
                {
                    if (useAnd) b.Append("AND ");
                    b.Append($"TS.SeasonID = {TeamSeason.SelectedItem} ");
                    useAnd = true;
                }

                if (!string.IsNullOrEmpty(TeamPlayedOn.Text))
                {
                    if (useAnd) b.Append("AND ");
                    b.Append($"S.Date = '{TeamPlayedOn.Text}' ");
                    useAnd = true;
                }
                if (!string.IsNullOrEmpty(TeamPlayedAt.SelectedItem?.ToString()))
                {
                    if (useAnd) b.Append("AND ");
                    b.Append($"S.Location = '{TeamPlayedAt.SelectedItem}' ");
                }

                b.Append(" AND S.SeasonID = TS.SeasonID");

                b.Append("\nORDER BY T.TeamName ASC;");

                return b.ToString();
            }

            return "";
        }

        private string PlayerSearch()
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
                    if (text.Text != null)
                    {
                        goAhead = true;
                        break;
                    }
                }
            }
            if (goAhead)
            {
                StringBuilder b = new();
                b.Append("SELECT DISTINCT P.PlayerID, P.PlayerName, P.Position, PC.AgeDuringSeason, T.TeamName, PC.SeasonID AS Season, D.DivisionName, C.ConferenceName\n" +
                        "FROM fb.Player P\n" +
                        "INNER JOIN fb.PlayerContract PC ON PC.PlayerID = P.PlayerID\n" +
                        "INNER JOIN fb.TeamSeason TS ON TS.TeamID = PC.TeamID\n" +
                        "INNER JOIN fb.Team T ON T.TeamID = TS.TeamID\n" +
                        "INNER JOIN fb.Division D ON D.DivisionID = T.DivisionID\n" +
                        "INNER JOIN fb.Conference C ON C.ConferenceID = D.ConferenceID\n" +
                        "WHERE ");
                bool useAnd = false;
                if (!string.IsNullOrEmpty(PlayerName.Text))
                {
                    if (useAnd)
                    {
                        b.Append("AND ");
                    }
                    b.Append($"P.PlayerName = '{PlayerName.Text}' ");
                    useAnd = true;
                }
                if (!string.IsNullOrEmpty(PlayerDivision.SelectedItem?.ToString()))
                {
                    if (useAnd)
                    {
                        b.Append("AND ");
                    }
                    b.Append($"D.DivisionName = '{PlayerDivision.SelectedItem}' ");
                    useAnd = true;
                }
                if (!string.IsNullOrEmpty(PlayerSeason.SelectedItem?.ToString()))
                {
                    if (useAnd)
                    {
                        b.Append("AND ");
                    }
                    b.Append($"PC.SeasonID = {PlayerSeason.SelectedItem} ");
                    useAnd = true;
                }
                if (!string.IsNullOrEmpty(PlayerConference.SelectedItem?.ToString()))
                {
                    if (useAnd)
                    {
                        b.Append("AND ");
                    }
                    b.Append($"C.ConferenceName = '{PlayerConference.SelectedItem}' ");
                    useAnd = true;
                }
                if (!string.IsNullOrEmpty(PlayerAge.Text))
                {
                    if (useAnd)
                    {
                        b.Append("AND ");
                    }
                    b.Append($"PC.AgeDuringSeason = {PlayerAge.Text} ");
                    useAnd = true;
                }
                if (!string.IsNullOrEmpty(PlayerPosition.SelectedItem?.ToString()))
                {
                    if (useAnd)
                    {
                        b.Append("AND ");
                    }
                    b.Append($"P.Position = '{PlayerPosition.SelectedItem}' ");
                }
                if (!string.IsNullOrEmpty(PlayerTeam.SelectedItem?.ToString()))
                {
                    if (useAnd)
                    {
                        b.Append("AND ");
                    }
                    b.Append($"T.TeamName = '{PlayerTeam.SelectedItem}' ");
                }
                return b.ToString();
            }
            return "";
        }

        private string GameSearch()
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
                    if (text.Text != null)
                    {
                        goAhead = true;
                        break;
                    }
                }
            }
            if (goAhead)
            {
                StringBuilder b = new();
                b.Append("SELECT DISTINCT G.GameID, T1.TeamName AS HomeTeam, T2.TeamName AS AwayTeam, T3.TeamName AS Winner, G.WinnerScore, G.LoserScore, G.Date, G.Location, G.SeasonID AS Season, D1.DivisionName AS HomeTeamDivision, D2.DivisionName AS AwayTeamDivision, C1.ConferenceName AS Conference\n" +
                        "FROM fb.Schedule G\n" +
                        "INNER JOIN fb.Team T1 ON T1.TeamID = G.HomeTeamID\n" +
                        "INNER JOIN fb.Team T2 ON T2.TeamID = G.AwayTeamID\n" +
                        "INNER JOIN fb.Team T3 ON T3.TeamID = G.WinnerID\n" +
                        "INNER JOIN fb.Division D1 ON D1.DivisionID = T1.DivisionID\n" +
                        "INNER JOIN fb.Division D2 ON D2.DivisionID = T2.DivisionID\n" +
                        "INNER JOIN fb.Conference C1 ON C1.ConferenceID = D1.ConferenceID\n" +
                        "INNER JOIN fb.Conference C2 ON C2.ConferenceID = D2.ConferenceID\n" +
                        "WHERE ");
                bool useAnd = false;
                if (!string.IsNullOrEmpty(HomeTeam.SelectedItem?.ToString()))
                {
                    if (useAnd)
                    {
                        b.Append("AND ");
                    }
                    b.Append($"T1.TeamName = '{HomeTeam.SelectedItem}' ");
                    useAnd = true;
                }
                if (!string.IsNullOrEmpty(AwayTeam.SelectedItem?.ToString()))
                {
                    if (useAnd)
                    {
                        b.Append("AND ");
                    }
                    b.Append($"T2.TeamName = '{AwayTeam.SelectedItem}' ");
                    useAnd = true;
                }
                if (!string.IsNullOrEmpty(WinnerComboBox.SelectedItem?.ToString()))
                {
                    if (useAnd)
                    {
                        b.Append("AND ");
                    }
                    b.Append($"T3.TeamName = '{WinnerComboBox.SelectedItem}' ");
                    useAnd = true;
                }
                if (!string.IsNullOrEmpty(GameConference.SelectedItem?.ToString()))
                {
                    if (useAnd)
                    {
                        b.Append("AND ");
                    }
                    b.Append($"C1.ConferenceName = '{GameConference.SelectedItem}' ");
                    useAnd = true;
                }
                if (!string.IsNullOrEmpty(GameSeason.SelectedItem?.ToString()))
                {
                    if (useAnd)
                    {
                        b.Append("AND ");
                    }
                    b.Append($"G.SeasonID = '{GameSeason.SelectedItem}' ");
                    useAnd = true;
                }
                if (!string.IsNullOrEmpty(GameDate.Text))
                {
                    if (useAnd)
                    {
                        b.Append("AND ");
                    }
                    b.Append($"G.Date = '{GameDate.Text}' ");
                    useAnd = true;
                }
                if (!string.IsNullOrEmpty(GameLocation.SelectedItem?.ToString()))
                {
                    if (useAnd)
                    {
                        b.Append("AND ");
                    }
                    b.Append($"G.Location = '{GameLocation.SelectedItem}' ");
                }
                return b.ToString();
            }
            return "";
        }

        private void MyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
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
    }
}
