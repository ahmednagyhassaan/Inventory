using System;
using System.Data;
using System.Data.SqlClient;
namespace Inventory
{
    class DAL_New
    {
        readonly string _connString;//data source:...; initial cataloge:....;integrated security=true
        SqlConnection _conn;
        SqlCommand _command;
        SqlDataAdapter _da;
        DataTable _dt;

        public DAL_New()
        {
            _connString = Properties.Settings.Default.ConnectionString;
            _conn = new SqlConnection(_connString);
        }

        public DataTable ExecuteQuery(string Query,SqlParameter[] SqlParams=null)//دالة انا اللى عملاها 
        {
            _command = new SqlCommand(Query, _conn);
            if (SqlParams != null)
            {
                _command.Parameters.AddRange(SqlParams);
            }
            _da = new SqlDataAdapter(_command);
            _dt = new DataTable();
            try {
                _da.Fill(_dt);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return _dt;
        }
    }
}
