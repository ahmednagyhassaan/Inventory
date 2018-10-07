using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Inventory.Employee;

namespace Inventory
{
    internal partial class FrmEmpSearchDelete : BaseForm
    {
        private readonly BLLfrmEmpSearchDelete _bll = new BLLfrmEmpSearchDelete();
        private readonly MessageBoxes _messageBoxes = new MessageBoxes();
        private readonly AutoCompleteStringCollection _autoCompleteStringCollection = new AutoCompleteStringCollection();
        public FrmEmpSearchDelete()
        {
            InitializeComponent();
       }



        private void cbo_Way_Of_Search_SelectedValueChanged(object sender, EventArgs e)
        {
            txtEmpID.Text = "";
            txtEmpName.Text = "";
            cmbDept.DataSource = null;
            PgdDGV.DataSource = null;
            if (cmbSrchWay.SelectedItem == "All")
            {
                groupBox1.Enabled = false;
                btn_Search_Click(null, null);
            }
            else if (cmbSrchWay.SelectedItem == "Search By")
            {
                groupBox1.Enabled = true;
                try
                {
                    _bll.FillCmbDepartment(cmbDept);
                    txtEmpID.AutoCompleteCustomSource = _bll.FillAutoCompleteStringCollectionWithEmpId();
                    txtEmpName.AutoCompleteCustomSource = _bll.FillAutoCompleteStringCollectionWithEmpName();
                    cmbDept.AutoCompleteCustomSource = _bll.FillAutoCompleteStringCollectionWithDeptName();
                }
                catch (Exception ex)
                {
                    _messageBoxes.ErrorMsgBox(ex.Message);
                }
            }

        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            frmEmpAddEdit fae = new frmEmpAddEdit("add");
            fae.Show();
            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                String sqlCmdText = "SELECT e.Emp_ID AS ID,e.Name,d.Name AS DepartmentName FROM dbo.Employee e JOIN dbo.Department d ON e.Dept_ID=d.Dept_ID";
                if (groupBox1.Enabled)
                {
                    sqlCmdText += " Where ";
                    List<SqlParameter> sqlParameters = new List<SqlParameter>();
                    if (txtEmpID.Text != string.Empty)
                    {
                        sqlCmdText += "e.Emp_ID=@ID AND ";
                        SqlParameter a = new SqlParameter("@ID", txtEmpID.Text);
                        sqlParameters.Add(a);
                    }
                    if (txtEmpName.Text.Trim() != string.Empty)
                    {
                        sqlCmdText += "e.Name=@Name AND ";
                        SqlParameter b = new SqlParameter("@Name", txtEmpName.Text);
                        sqlParameters.Add(b);
                    }
                    if (Convert.ToInt16(cmbDept.SelectedValue) != -1)
                    {
                        sqlCmdText += "e.Dept_ID=@DeptID and ";
                        SqlParameter c = new SqlParameter("@DeptID", cmbDept.SelectedValue);
                        sqlParameters.Add(c);
                    }
                    if (sqlParameters.Count != 0)
                    {
                        sqlCmdText = sqlCmdText.Remove(sqlCmdText.Length - 4, 4);
                        PgdDGV.DataSource = _bll.GetEmpDataTable(sqlCmdText, sqlParameters.ToArray());
                      
                    }
                    else
                    {
                        _messageBoxes.ErrorMsgBox("Please select at least one criteria");
                        cmbSrchWay.SelectedItem = "Search By";
                        cbo_Way_Of_Search_SelectedValueChanged(null, null);
                    }
                }
                else
                {
                    PgdDGV.DataSource= _bll.GetEmpDataTable(sqlCmdText);
                }

            }
            catch (Exception exp)
            {

                _messageBoxes.ErrorMsgBox(exp.Message);
            }
        }

      private void btn_Edit_Click(object sender, EventArgs e)
        {
        //    try
        //    {
        //        int currentID = Convert.ToInt32(PgdDGV.CurrentRow.Cells[0].Value);
        //        frmEmpAddEdit f1 = new frmEmpAddEdit(currentID, "edit");
        //        this.Close();
        //        f1.ShowDialog();

        //    }
        //    catch (Exception exp)
        //    {
        //        MessageBox.Show(" you must select  Employee first");
        //    }
        //}

        //private void btn_View_Details_Click(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        int currentID = Convert.ToInt32(dgv_Emp_Find.CurrentRow.Cells[0].Value);
        //        frmEmpAddEdit f1 = new frmEmpAddEdit(currentID, "view");
        //        f1.ShowDialog();
        //        this.Close();
        //    }
        //    catch (Exception exp)
        //    {

        //        MessageBox.Show(" you must select  Employee first");
        //    }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    try
            //    {
            //        int Current_ID = Convert.ToInt32(dgv_Emp_Find.CurrentRow.Cells[0].Value);
            //        SqlCommand CMDD = new SqlCommand("DELETE FROM [dbo].[Employee] WHERE [Emp_ID]=@Emp_ID", Conn);
            //        CMDD.Parameters.AddWithValue("@Emp_ID", Current_ID);
            //        if (Conn.State != ConnectionState.Open)
            //            Conn.Open();
            //        CMDD.ExecuteNonQuery();
            //        Conn.Close();
            //        //message for use delete is done
            //        MessageBox.Show("deleted");
            //        //3shan yshelhaly mn el gride 
            //        int Rows_Count = dgv_Emp_Find.Rows.Count - 1;
            //        if (Rows_Count > 0)
            //        {
            //            dgv_Emp_Find.Rows.Remove(dgv_Emp_Find.CurrentRow);
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        int current_ID = Convert.ToInt32(dgv_Emp_Find.CurrentRow.Cells[0].Value);
            //        SqlCommand CM = new SqlCommand("UPDATE [dbo].[Employee]  SET [Still_Work] ='False'  WHERE [Emp_ID]=@Emp_ID", Conn);
            //        CM.Parameters.AddWithValue("@Emp_ID", current_ID);
            //        if (Conn.State != ConnectionState.Open)
            //            Conn.Open();
            //        CM.ExecuteNonQuery();
            //        Conn.Close();
            //        MessageBox.Show(" deleted but this Employee may be  related with other tables");
            //        int Rows_Count = dgv_Emp_Find.Rows.Count - 1;
            //        if (Rows_Count > 0)
            //        {
            //            dgv_Emp_Find.Rows.Remove(dgv_Emp_Find.CurrentRow);
            //        }
            //    }


            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("you must select Employee First");

            //}

        }

    }
}
