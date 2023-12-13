using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hashed
{
    public partial class SingIn : Form
    {   
        DBConnection conn = new DBConnection();
        public SingIn()
        {
            InitializeComponent();
        }

        private void registerSingInButton_Click(object sender, EventArgs e)
        {
            string username = usernameSingInTB.Text;
            string password = PassSingInTB.Text;
            string password2 = Pass2SingInTB.Text;
            InputValidation(username, password, password2);    
        }

        private void InputValidation(string username, string pass, string pass2)
        {
            if (username == string.Empty || pass == string.Empty || pass2 == string.Empty)
            {
                MessageBox.Show("Please fill out the form");
                ClearForm();
            }
            else if (pass == pass2)
            {
                conn.Connect();
                DataTable Table = new DataTable();
                SqlDataAdapter querry = new SqlDataAdapter($"SELECT * FROM Users WHERE username = '{username}'", conn.con);
                querry.Fill(Table);

                if (Table.Rows.Count == 0)
                {
                    CreateNewUser(username, pass);
                    LogIn li = new LogIn();
                    li.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("An account with the given login already exists");
                    ClearForm();
                }
            }
            else
            {
                MessageBox.Show("Passwords must be the same");
                ClearForm();
            }
            conn.Disconnect();
        }

        private void ClearForm()
        {
            usernameSingInTB.Text = "";
            PassSingInTB.Text = "";
            Pass2SingInTB.Text = "";
        }

        private void CreateNewUser(string username, string password)
        {
            conn.Connect();
            SqlCommand cmd = conn.con.CreateCommand();
            cmd.CommandText = $"INSERT INTO Users(username, password) VALUES('{username}','{password}')";
            cmd.ExecuteNonQuery();
            conn.Disconnect();
        }

        private void backSingInButton_Click(object sender, EventArgs e)
        {
            LogIn li = new LogIn();
            li.Show();
            Close();
        }
    }
}
