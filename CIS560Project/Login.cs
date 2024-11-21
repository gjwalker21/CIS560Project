using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS560Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private string? username;

        private string? password;

        private readonly NFLDatabase form2 = new();

        private void LoginToServer()
        {
            try
            {
                string connectionString = $"Server=mssql.cs.ksu.edu;Database=cis560_team15;User Id={username};Password={password};Encrypt=True;TrustServerCertificate=True;";
                SqlConnection connection = new(connectionString);
                connection.Open();
                form2.Connection = connection;
                this.Hide();
                form2.Show();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            username = UsernameBox.Text;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            password = PasswordBox.Text;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            LoginToServer();
        }
    }
}
