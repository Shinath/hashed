using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hashed
{
    public partial class Dashboard : Form
    {
        User user;
        Menu menu;
        DBConnection conn = new DBConnection();
        public Dashboard(User user, Menu menu)
        {
            InitializeComponent();
            this.user = user;
            this.menu = menu;   
            ShowAllLinks(ReturnAllLinks(user));
        }
        private void AddNewRow(string name, string hash)
        {
            tableDashboard.Size = new Size(482, 40 + 30 * tableDashboard.RowCount);
            tableDashboard.RowCount++;
            tableDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));

            CheckBox checkbox = new CheckBox();
            checkbox.Name = $"checkbox_{tableDashboard.RowCount}";
            //MessageBox.Show(checkbox.Name);
            checkbox.Location = new Point(10, 10);

            tableDashboard.Controls.Add(checkbox, 0, tableDashboard.RowCount  - 1);
            tableDashboard.Controls.Add(NewLabel(tableDashboard.RowCount, name, "name"), 1, tableDashboard.RowCount-1);
            tableDashboard.Controls.Add(NewLabel(tableDashboard.RowCount, hash, "hash"), 2, tableDashboard.RowCount-1);
            
        }
        private DataTable ReturnAllLinks(User user)
        {
            conn.Connect();
            DataTable table = new DataTable();
            SqlDataAdapter query = new SqlDataAdapter($"SELECT * FROM Links WHERE id_user = '{user.id}'", conn.con);
            query.Fill(table);
            conn.Disconnect();
            return table;
        }
        private void ShowAllLinks(DataTable table)
        {
            string name;
            string hash;
            foreach (DataRow row in table.Rows)
            {
                name = row["name"].ToString();
                hash = row["hash"].ToString();
                AddNewRow(name, hash);
            }
        }
        private Label NewLabel(int row, string text, string type)
        {
            Label label = new Label
            {
                Name = $"label_{type}_{row}",
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("MS Reference Sans Serif", 10),
                AutoSize = false,
                Width = 206,
                Height = 26
            };
            return label;
        }

        private void dashBackButton_Click(object sender, EventArgs e)
        {
            menu.Show();
            Close();
        }
        string args;
        private void openLinkButton_Click(object sender, EventArgs e)
        {
            CheckBoxSearch(true);
        }
        private void CheckBoxSearch(bool flag)
        {
            foreach (Control control in tableDashboard.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkbox = control as CheckBox;
                    if (checkbox.Checked)
                    {
                        string[] splitedName = checkbox.Name.Split('_');
                        string hashLabel = string.Concat("label_hash_", splitedName[1]);
                        Control hash = Controls.Find(hashLabel, true).FirstOrDefault();
                        Label hashed = hash as Label;
                        if(flag)
                        {
                            OpenLink(hashed.Text);
                        }
                        else
                        {
                            DeleteLink(hashed.Text);
                            
                        }
                        checkbox.Checked = false;
                    }
                }
            }
            Dashboard dash = new Dashboard(user, menu);
            dash.Show();
            Close();
        }
        private void OpenLink(string hash)
        {
            conn.Connect();
            DataTable table = new DataTable();
            SqlDataAdapter query = new SqlDataAdapter($"SELECT * FROM Links WHERE hash = '{hash}'", conn.con);
            query.Fill(table);
            System.Diagnostics.Process.Start(table.Rows[0]["link"].ToString());
            conn.Disconnect();
        }
        private void DeleteLink(string hash)
        {
            conn.Connect();
            SqlCommand cmd = conn.con.CreateCommand();
            cmd.CommandText = $"DELETE FROM Links WHERE hash = '{hash}' AND id_user = '{user.id}'";
            cmd.ExecuteNonQuery();
            conn.Disconnect();
        }

        private void deleteLinkButton_Click(object sender, EventArgs e)
        {
            CheckBoxSearch(false);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
