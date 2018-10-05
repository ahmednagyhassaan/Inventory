using System.Windows.Forms;
using System.Data;

namespace Inventory.Employee
{
    class BLLfrmEmpSearchDelete
    {
        DAL_New DAL;
        public BLLfrmEmpSearchDelete()
        {
            DAL = new DAL_New();
        }
        public void FillCboDepartment(ComboBox cbo)
        {
            DataTable dt = DAL.ExecuteQuery("SELECT [Dept_ID],[Name] FROM [dbo].[Department]");
            cbo.DataSource = dt;
            cbo.DisplayMember = "Name";
            cbo.ValueMember = "Dept_ID";
         }
    }
}
