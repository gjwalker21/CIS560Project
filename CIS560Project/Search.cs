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

        private string TeamSearch()
        {
            StringBuilder b = new();
            List<string> list = [];
            foreach (TextBox box in TeamBox.Controls)
            {
                if (box.Text == null)
                {
                    list.Add("*");
                }
                else
                {
                    list.Add(box.Text);
                }
            }
            b.Append("SELECT T.TeamID, T.DivisionID, T.TeamName");
            /*
            "FROM fb.Team T\n" +
            "JOIN fb.Division D ON D.DivisionID = T.DivisionID\n" +
            "JOIN fb.Conference C ON C.ConferenceID = D.ConferenceID\n" +
            "JOIN fb.Schedule S ON S.WinnerID = T.TeamID\n" +
            "JOIN fb.TeamSeason TS ON TS.TeamID = T.TeamID\n" +
            "JOIN fb.PlayerContract PC ON PC.TeamID = TS.TeamID\n" +
            "JOIN fb.Player P ON P.PlayerID = PC.PlayerID\n" +
            "JOIN fb.Season SE ON SE.SeasonID = S.SeasonID\n" +
            $"WHERE T.TeamID = {TeamTeamID}";
            */
            return b.ToString();
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
