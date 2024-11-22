using System;
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
                b.Append("SELECT DISTINCT ");
                if (TeamTeamName != null)
                {
                    b.Append("T.TeamName");
                }
                if (TeamDivision != null)
                {
                    b.Append("D.Division,");
                }
                if (TeamSeason != null)
                {
                    b.Append("T.TeamName,");
                }
                if (TeamConference != null)
                {
                    b.Append("T.TeamName,");
                }
                if (TeamPlayedOn != null)
                {
                    b.Append("T.TeamName,");
                }
                if (TeamPlayedAt != null)
                {
                    b.Append("T.TeamName,");
                }

                b.Append(
                    "FROM fb.Team T\n" +
                    "INNER JOIN fb.Division D ON D.DivisionID = T.DivisionID\n" +
                    "INNER JOIN fb.Conference C ON C.ConferenceID = D.ConferenceID\n" +
                    "INNER JOIN fb.Schedule S1 ON S.HomeTeamID = T.TeamID\n" +
                    "INNER JOIN fb.Schedule S2 ON S.AwayID = T.TeamID\n" +
                    "INNER JOIN fb.TeamSeason TS ON TS.TeamID = T.TeamID\n" +
                    "INNER JOIN fb.PlayerContract PC ON PC.TeamID = TS.TeamID\n" +
                    "INNER JOIN fb.Player P ON P.PlayerID = PC.PlayerID\n" +
                    "WHERE ");

                int count = 0;
                if (TeamTeamName.Text != null && count == 0)
                {
                    b.Append($"T.TeamName = {TeamTeamName.Text} ");
                    count++;
                }
                else if (TeamTeamName.SelectedItem != null && count >= 1)
                {
                    b.Append($"AND T.TeamName = {TeamTeamName.SelectedItem} ");
                    count++;
                }

                if (TeamDivision.SelectedItem != null && count == 0)
                {
                    b.Append($"D.DivisionName = {TeamDivision.SelectedItem} ");
                    count++;
                }
                else if (TeamDivision.SelectedItem != null && count >= 1)
                {
                    b.Append($"AND D.DivisionName = {TeamDivision.SelectedItem} ");
                    count++;
                }

                if (TeamSeason.SelectedItem != null && count == 0)
                {
                    b.Append($"TS.SeasonID = {TeamSeason.SelectedItem} ");
                    count++;
                }
                else if (TeamSeason.SelectedItem != null && count >= 1)
                {
                    b.Append($"AND TS.SeasonID = {TeamSeason.SelectedItem} ");
                    count++;
                }


                if (TeamConference.SelectedItem != null && count == 0)
                {
                    b.Append($"C.ConferenceName = {TeamConference.SelectedItem} ");
                    count++;
                }
                else if (TeamConference.SelectedItem != null && count >= 1)
                {
                    b.Append($"AND C.ConferenceName = {TeamConference.SelectedItem} ");
                    count++;
                }

                if (TeamPlayedOn.Text != null && count == 0)
                {
                    b.Append($"S1.Date = {TeamPlayedOn.Text} ");
                    count++;
                }
                else if (TeamPlayedOn.Text != null && count >= 1)
                {
                    b.Append($"AND S1.Date = {TeamPlayedOn.Text} ");
                    count++;
                }

                if (TeamPlayedAt.SelectedItem != null && count == 0)
                {
                    b.Append($"S1.Location = {TeamPlayedAt.SelectedItem} ");
                    count++;
                }
                if (TeamPlayedAt.SelectedItem != null && count >= 1)
                {
                    b.Append($"AND S1.Location = {TeamPlayedAt.SelectedItem} ");
                    count++;
                }

                return b.ToString();
            }

            return "";
        }


        private string PlayerSearch()
        {
            List<string> list = [];
            foreach (TextBox box in PlayerBox.Controls)
            {
                list.Add(box.Text);
            }
            return "SELECT * FROM fb.Player";
        }

        private string GameSearch()
        {
            List<string> list = [];
            foreach (TextBox box in GameBox.Controls)
            {
                list.Add(box.Text);
            }
            return "SELECT * FROM fb.Schedule";
        }
    }
}
