using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hashed
{
    public partial class LogIn : Form
    {
        DBConnection conn = new DBConnection();
        static int id;
        static string username;
        static string password;
        User user = new User(id, username, password);
        
        public LogIn()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            username = usernameLogInTB.Text;
            password = passwordLogInTB.Text;
            Login(username, password);
        }
        private void Login(string username, string password)
        {
            conn.Connect();
            SqlDataAdapter query = new SqlDataAdapter($"SELECT * FROM Users WHERE username = '{username}'",conn.con);
            DataTable Table = new DataTable();
            query.Fill(Table);
            if(username == string.Empty || password == string.Empty)
            {
                MessageBox.Show("Please enter login and password");
                ClearForm();
            }
            else if (Table.Rows.Count > 0)
            {
                if (Table.Rows[0]["password"].ToString() == password)
                {
                    user.id = Convert.ToInt32(Table.Rows[0]["id"]);
                    user.password = password;
                    user.username = username;

                    Menu mainMenu = new Menu(user);
                    mainMenu.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Invalid password");
                    ClearForm();
                }
            }
            else
            {
                MessageBox.Show("User with this login doesn't exists");
                ClearForm();
            }
            conn.Disconnect();
        }
        private void ClearForm()
        {
            passwordLogInTB.Text = "";
            usernameLogInTB.Text = "";
        }

        private void SingInButton_Click(object sender, EventArgs e)
        {
            SingIn si = new SingIn();
            si.Show();
            Hide();
        }
    }
}
