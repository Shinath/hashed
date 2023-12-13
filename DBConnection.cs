using System.Data.SqlClient;

namespace Hashed
{
    internal class DBConnection
    {
        public SqlConnection con;

        public DBConnection()
        { }

        public void Connect()
        {
            //if (con == null)
            //{
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=False;MultipleActiveResultSets=true;");
                con.Open();
            //}
        }

        public void  Disconnect()
        {
            if (con != null)
            {
                con.Close();
            }
        }
    }
}
