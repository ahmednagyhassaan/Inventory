using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
namespace Inventory
{
    public class DataAccessLayer
    {
        static string ConnectionString = "Data Source=.;Initial Catalog=Project;Integrated Security=True";



        internal static DataTable GetDataTable(string TableName, string Condition)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Select  * from " + TableName + Condition, connection);
                    dt.Load(command.ExecuteReader());
                }
                return dt;//Display The Selected Items.
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
                return null;
            }

        }
        internal static DataTable GetDataTableComplex(string sql, string Condition)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql + Condition, connection);
                    dt.Load(command.ExecuteReader());
                }
                return dt;//Display The Selected Items.
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
                return null;
            }

        }

        internal static void DeleteRowByID(string TableName, string ColumnName, int ID)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Delete  from " + TableName + " Where " + ColumnName + " = " + ID.ToString(), connection);
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        internal static object RunStoredProcedure(string StoredProcedureName, Hashtable Params, outputParams Out)
        {
            object returnValue = null;
            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {

                    SqlCommand command = new SqlCommand("PRO_Itm_Qty", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    foreach (DictionaryEntry item in Params)
                        command.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                    command.Parameters.AddWithValue(Out.ParamName, Out.ParamValue);
                    command.Parameters[Out.ParamName].Direction = ParameterDirection.Output;
                    connection.Open();
                    command.ExecuteNonQuery();
                    return command.Parameters[Out.ParamName].Value;


                }
                //Display The Selected Items.
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);

            }
            return returnValue;
        }

        internal static void ExecuteNoneQuery(string Str)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(Str, connection);
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        internal static string NewRowID(string TableName, string ColumnName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Select ISNULL(Max(" + ColumnName + "),0) + 1 FROM " + TableName, connection);
                    return command.ExecuteScalar().ToString();
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return "-1";
            }
        }

        internal static bool CheckRowByID(string TableName, string ColumnName, string ColumnValue)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Select * FROM " + TableName + " Where " + ColumnName + " = " + ColumnValue, connection);
                    return command.ExecuteReader().HasRows;
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return false;
            }
        }

        internal static DataRow GetRowByID(string TableName, string ColumnName, string ColumnValue)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Select * FROM " + TableName + " Where " + ColumnName + " = " + ColumnValue, connection);
                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());
                    return dt.Rows[0];
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return null;
            }
        }

        internal static DataTable GetRowsByID(string TableName, string ColumnName, string ColumnValue)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Select * FROM " + TableName + " Where " + ColumnName + " = " + ColumnValue, connection);
                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());
                    return dt;
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return null;
            }
        }

        public  DataTable ExecuteQuery(string query)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dad.Fill(dt);
            return dt;
        }
    }

    public class ProjectTools
    {
        public static void LoadCbo(ComboBox cbo, DataTable data, string _DisplayMember, string _ValueMemeber)
        {
            cbo.DataSource = data;
            cbo.ValueMember = _ValueMemeber;
            cbo.DisplayMember = _DisplayMember;
            cbo.SelectedIndex = -1;
            //cbo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cbo.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        public static DataTable ConvertGridToDataTable(DataGridView DGV, string TableName)
        {
            DataTable dt = new DataTable();
            try
            {
                dt.TableName = TableName;
                //First we need to build the Table
                foreach (DataGridViewColumn item in DGV.Columns)
                    dt.Columns.Add(item.HeaderText);

                foreach (DataGridViewRow item in DGV.Rows)
                {
                    DataRow dr = dt.NewRow();
                }

                return dt;

                //Display The Selected Items.
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
                return null;
            }
        }
    }

    public class outputParams
    {
        public string ParamName { get; set; }
        public object ParamValue { get; set; }
    }

}
