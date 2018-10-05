using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Inventory.Employee;


namespace Inventory
{
    public partial class frmEmpSearchDelete : Form
    {
        BLLfrmEmpSearchDelete  BLL;
        public frmEmpSearchDelete()
        {
            InitializeComponent();
            BLL = new BLLfrmEmpSearchDelete();
        }

        private void Close_Click(object sender, EventArgs e)
        {

        }



        private void btn_Add_Employee_Click_1(object sender, EventArgs e)
        {

        }

        private void cbx_Search_Dept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_Way_Of_Search_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_ID.Text = "";
            txt_Name.Text = "";
            cbo_Dept_Name.SelectedIndex = -1;
            if (cbo_Way_Of_Search.SelectedItem == "All")
            {
                groupBox1.Enabled = false;
                //dgv_Emp_Find.DataSource = DAL.ExecuteQuery("SELECT  [Emp_ID],b.[Name] as Name,a.[Name] as Dept_Name,[Certifications],[Salary],[Date_Of_Birth] ,[Hire_Date],[phone] FROM dbo.Employee as b ,[dbo].[Department]as a where b.[Dept_ID]=a.[Dept_ID] and [Still_Work] ='true'");
            }
            else if (cbo_Way_Of_Search.SelectedItem == "Search By")
            {
                groupBox1.Enabled = true;
                BLL.FillCboDepartment(cbo_Dept_Name);
            }

        }

        private void grid_Load()
        {
            
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frmEmpAddEdit fae = new frmEmpAddEdit("add");
            fae.Show();
            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //    try
            //    {
            //    String Sql_Cmd_Text = "SELECT  [Emp_ID],b.[Name] as Name,a.[Name] as Dept_Name,[Certifications],[Salary],[Date_Of_Birth] ,[Hire_Date],[phone]FROM   dbo.Employee as b ,[dbo].[Department]as a where b.[Dept_ID]=a.[Dept_ID] and [Still_Work] ='true'";
            //    SqlCommand cmd = new SqlCommand("", Conn);


            //    if (txt_ID.Text != string.Empty)
            //    {
            //        Sql_Cmd_Text += " AND [Emp_ID]=@ID";
            //        cmd.Parameters.AddWithValue("@ID", int.Parse(txt_ID.Text));
            //    }
            //    if (txt_Name.Text != string.Empty)
            //    {
            //        Sql_Cmd_Text += " AND b.[Name] like @Name";
            //        cmd.Parameters.AddWithValue("@Name", txt_Name.Text + "%");
            //    }
            //    if (cbo_Dept_Name.Text != string.Empty)
            //    {
            //        Sql_Cmd_Text += " AND  b.[Dept_ID]= @Dept_ID";
            //        cmd.Parameters.AddWithValue("@Dept_ID", cbo_Dept_Name.SelectedValue);
            //    }

            //    cmd.CommandText = Sql_Cmd_Text;
            //    SqlDataAdapter dad = new SqlDataAdapter(cmd);
            //    DataTable DT = new DataTable();
            //    dad.Fill(DT);
            //    dgv_Emp_Find.DataSource = DAL.ExecuteQuery("");

            //}
            //catch (Exception exp)
            //{

            //    MessageBox.Show(exp.Message);
            //}
        }

        private void frm_Find_Emp_Load(object sender, EventArgs e)
        {
            Load_cbo();
        }
        private void Load_cbo()
        {
            //SqlCommand cmd = new SqlCommand("SELECT [Dept_ID],[Name] ,[Manager_ID] FROM [dbo].[Department]", Conn);
            //SqlDataAdapter dad = new SqlDataAdapter(cmd);
            //DataTable DT = new DataTable();
            //dad.Fill(DT);
            //cbo_Dept_Name.DataSource = DT;
            //cbo_Dept_Name.ValueMember = "Dept_ID";
            //cbo_Dept_Name.DisplayMember = "Name";
            //cbo_Dept_Name.SelectedIndex = -1;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                int currentID = Convert.ToInt32(dgv_Emp_Find.CurrentRow.Cells[0].Value);
                frmEmpAddEdit f1 = new frmEmpAddEdit(currentID, "edit");
                this.Close();
                f1.ShowDialog();

            }
            catch (Exception exp)
            {
                MessageBox.Show(" you must select  Employee first");
            }
        }

        private void btn_View_Details_Click(object sender, EventArgs e)
        {

            try
            {
                int currentID = Convert.ToInt32(dgv_Emp_Find.CurrentRow.Cells[0].Value);
                frmEmpAddEdit f1 = new frmEmpAddEdit(currentID, "view");
                f1.ShowDialog();
                this.Close();
            }
            catch (Exception exp)
            {

                MessageBox.Show(" you must select  Employee first");
            }
        }

        private void txt_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
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

        private void cbo_Way_Of_Search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
