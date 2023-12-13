using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hashed
{
    public partial class Insert : Form
    {
        User user;
        Link link;
        Menu mainMenu;
        DBConnection conn = new DBConnection();
        public Insert(User user, Menu mainMenu)
        {
            InitializeComponent();
            this.user = user;
            this.mainMenu = mainMenu;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            string inputLink = insertTextBox.Text;
            string inputName = nameTextBox.Text;
            if (ValidateLink(inputLink, inputName))
            {
                InsertLink(inputLink, inputName);
                MessageBox.Show("Link has been added");
                mainMenu.Show();
                Hide();
            }
            else
            {
                ClearForm();
            }
        }
        private bool ValidateLink(string link, string name)
        {
            if(link == string.Empty || name == string.Empty)
            {
                MessageBox.Show("Please fill out the form");
                return false;
            }

            if(!Uri.IsWellFormedUriString(link, UriKind.Absolute))
            {
                MessageBox.Show("Please enter a valid link HTTP/HTTPS");
                return false;
            }

            if(name.Length > 20)
            {
                MessageBox.Show("The name cannot exceed 20 characters");
                return false;
            }
            
            conn.Connect();
            DataTable Table = new DataTable();
            SqlDataAdapter querry = new SqlDataAdapter($"SELECT * FROM Links WHERE link = '{link}' AND id_user = '{user.id}'", conn.con);
            querry.Fill(Table);
            if(Table.Rows.Count > 0) {
                MessageBox.Show("Link already exists");
                return false; 
            }
            conn.Disconnect();

            return true;
        }
        public void ClearForm()
        {
            insertTextBox.Text = null;
            nameTextBox.Text = null;
        }
        private void InsertLink(string newLink, string newName)
        {
            string hash = GenerateNewHash();
            conn.Connect();
            SqlCommand cmd = conn.con.CreateCommand();
            cmd.CommandText = $"INSERT INTO Links(name, link, hash, id_user) VALUES('{newName}', '{newLink}', '{hash}', '{user.id}')";
            cmd.ExecuteNonQuery();
            conn.Disconnect();
        }
        private string GenerateNewHash()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string hash = "";
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                hash +=chars[random.Next(chars.Length)];
            }
            return hash;
        }
        private void insertBackButton_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            ClearForm();
            Hide();
        }
    }
}
