using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace Inventory.Employee
{
    class BLLEmployee
    {
        DAL_New _dal = new DAL_New();
        #region SharedFunctions
        public void FillCmbDepartment(ref ComboBox cmBox)
        {
            DataTable dt = _dal.ExecuteQuery("SELECT [Dept_ID],[Name] FROM [dbo].[Department]");
            cmBox.DataSource = dt;
            cmBox.DisplayMember = "Name";
            cmBox.ValueMember = "Dept_ID";
            cmBox.SelectedIndex = -1;
        }


        #endregion
        #region FrmEmpSrchDeleteFunctions
        public AutoCompleteStringCollection FillAutoCompleteStringCollectionWithEmpName()
        {
            DataTable dt = _dal.ExecuteQuery("SELECT [Name] FROM [dbo].[Employee]");
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count - 1; i++)
            {
                collection.Add(dt.Rows[i][0].ToString());
            }
            return collection;
        }

        public AutoCompleteStringCollection FillAutoCompleteStringCollectionWithEmpId()
        {
            DataTable dt = _dal.ExecuteQuery("SELECT Emp_ID FROM [dbo].[Employee]");
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count - 1; i++)
            {
                collection.Add(dt.Rows[i][0].ToString());
            }
            return collection;
        }

        public AutoCompleteStringCollection FillAutoCompleteStringCollectionWithDeptName()
        {
            DataTable dt = _dal.ExecuteQuery("SELECT Name FROM [dbo].[Department]");
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count - 1; i++)
            {
                collection.Add(dt.Rows[i][0].ToString());
            }
            return collection;
        }

        public DataTable GetEmpDataTable(string query, SqlParameter[] sqlParameters = null)
        {
            DataTable dt = new DataTable();
            dt = _dal.ExecuteQuery(query, sqlParameters);
            return dt;
        }

        public Image ConvertByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream stream = new MemoryStream(byteArray, 0, byteArray.Length, true))
            {
                return Image.FromStream(stream);
            }
        }
        #endregion
        #region FrmEmpAddEdit

        //public void FillCmbManagerbyDeptId(int deptId)
        //{
        //    DataTable dt = _dal.ExecuteQuery("select from employee e join departement d on e.dept_id=d.dept_id where e.dept_id");
        //}
        
        #endregion
    }
}
