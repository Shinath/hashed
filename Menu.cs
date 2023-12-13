using System;
using System.Windows.Forms;

namespace Hashed
{
    public partial class Menu : Form
    {
        User user;
        Insert insert;
        Dashboard dashboard;
        public Menu(User user)
        {
            InitializeComponent();
            this.user = user;
            loggedUserLabel.Text = loggedUserLabel.Text + user.username;
            this.insert = new Insert(user, this);
        }

        private void hashLinkButton_Click(object sender, EventArgs e)
        {
            insert.Show();
            insert.ClearForm();
            Hide();
        }

        private void viewHashButton_Click(object sender, EventArgs e)
        {
            dashboard = new Dashboard(user, this);
            dashboard.Show();
            Hide();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
