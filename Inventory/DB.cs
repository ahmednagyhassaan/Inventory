using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory
{
    class DataBase
    {
        SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");

        public void SendData(string Query)
        {
            Conn.Open();

            SqlCommand CMD = new SqlCommand(Query, Conn);
            CMD.ExecuteNonQuery();
            Conn.Close();
        }

        public DataTable ReturnTable(string Query)
        {
            Conn.Open();
            SqlCommand CMD = new SqlCommand(Query, Conn);
            SqlDataReader reader = CMD.ExecuteReader();
            DataTable DT = new DataTable();
            DT.Load(reader);
            Conn.Close();
            return DT;
        }

        public DataRow ReturnRow(string Query)
        {
            Conn.Open();
            SqlCommand CMD = new SqlCommand(Query, Conn);
            SqlDataReader reader = CMD.ExecuteReader();
            DataTable DT = new DataTable();
            DT.Load(reader);
            Conn.Close();
            DataRow row = DT.Rows[0];
            return row;
        }

        public void LoadCbo(string Query, ComboBox cbo, string Display, string Value)
        {
            Conn.Open();
            SqlCommand CMD = new SqlCommand(Query, Conn);
            SqlDataReader reader = CMD.ExecuteReader();
            DataTable DT = new DataTable();
            DT.Load(reader);
            Conn.Close();
            cbo.DataSource = DT;
            cbo.DisplayMember = Display;
            cbo.ValueMember = Value;
            cbo.SelectedIndex = -1;
        }
 
    }
}