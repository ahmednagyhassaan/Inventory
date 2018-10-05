using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Inventory.Employee
{
    class BLLfrmEmpSearchDelete
    {
        DAL_New _dal= new DAL_New();
        public void FillCmbDepartment(ComboBox cmBox)
        {
            DataTable dt = _dal.ExecuteQuery("SELECT [Dept_ID],[Name] FROM [dbo].[Department]");
            cmBox.DataSource = dt;
            cmBox.DisplayMember = "Name";
            cmBox.ValueMember = "Dept_ID";
            cmBox.SelectedIndex = -1;
        }

        public AutoCompleteStringCollection FillAutoCompleteStringCollectionWithEmpName()
        {
            DataTable dt = _dal.ExecuteQuery("SELECT [Name] FROM [dbo].[Employee]");
            AutoCompleteStringCollection collection=new AutoCompleteStringCollection();
            foreach (DataRow dr in dt.Rows)
            {
                collection.Add(dr[0].ToString());
            }
            return collection;
        }

        public AutoCompleteStringCollection FillAutoCompleteStringCollectionWithEmpId()
        {
            DataTable dt = _dal.ExecuteQuery("SELECT Emp_ID FROM [dbo].[Employee]");
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dt.Rows)
            {
                collection.Add(dr[0].ToString());
            }
            return collection;
        }

        public AutoCompleteStringCollection FillAutoCompleteStringCollectionWithDeptName()
        {
            DataTable dt = _dal.ExecuteQuery("SELECT Name FROM [dbo].[Department]");
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dt.Rows)
            {
                collection.Add(dr[0].ToString());
            }
            return collection;
        }

        public DataTable GetEmpDataTable(string query, SqlParameter[] sqlParameters=null)
        {
            DataTable dt=new DataTable();
            dt = _dal.ExecuteQuery(query, sqlParameters);
            return dt;
        }
    }
}
