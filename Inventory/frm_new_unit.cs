using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Inventory
{
    public partial class frm_new_unit : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
        public bool Flag = false;
        public frm_new_unit()
        {
            InitializeComponent();
        }
       
        private void frm_new_unit_Load(object sender, EventArgs e)
        {
            cbo_unit_load();
        }

        private void cbo_Unit_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Flag)
            {
                 SqlCommand CMd = new SqlCommand("SELECT [U_ID] ,[Name] ,[Qty] ,[Smallest_Unit_Name] FROM [dbo].[Units] where [U_ID] =@U_ID ", conn);
                CMd.Parameters.Clear();
                CMd.Parameters.AddWithValue("@U_ID",cbo_Unit_Name.SelectedValue );
                DataTable DT = Return_datatable_value(CMd);
                DataRow row = DT.Rows[0];
                txt_Small.Text = row[3].ToString();
                txt_Qty.Text = row[2].ToString();
            }
        }
        private void cbo_Unit_Name_TextChanged(object sender, EventArgs e)
        {  //check if this name already on unit table
                SqlCommand CMd = new SqlCommand("SELECT count(U_ID) FROM [dbo].[Units] where [Name]=@Name", conn);
                CMd.Parameters.Clear();
                CMd.Parameters.AddWithValue("@Name",cbo_Unit_Name.Text );
                int checkingg = Return_One_valueint(CMd);
            //lw fady 2w mknsh mwgod fel DB 2bl keda
            if (string.IsNullOrWhiteSpace(cbo_Unit_Name.Text) || checkingg==0)
            {
                btn_Unit_Add.Enabled = true;
                btn_Unit_update.Enabled = false;
                btn_unit_Delete.Enabled = false;

            }
            else
            {
                btn_Unit_update.Enabled = true;
                btn_Unit_Add.Enabled = false;
                btn_unit_Delete.Enabled = true;
            }
        }
        private void cbo_unit_load()
        {
            Flag = false;
            SqlCommand CMd = new SqlCommand("SELECT [U_ID] ,[Name] ,[Qty] ,[Smallest_Unit_Name] FROM [dbo].[Units]", conn);
            cbo_Unit_Name.DataSource = Return_datatable_value(CMd);
            cbo_Unit_Name.ValueMember = "U_ID";
            cbo_Unit_Name.DisplayMember = "Name";
            cbo_Unit_Name.SelectedIndex = -1;
            txt_Small.Text = "";
            txt_Qty.Text = "";
            Flag = true;
        }

        private void btn_Unit_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txt_Qty.Text) ||String.IsNullOrWhiteSpace(txt_Small.Text))
                {
                    MessageBox.Show("you must enter all fields ");
                }
                else
                {
                    SqlCommand CMd = new SqlCommand("declare @x int  declare @c int set @c=(select count([U_ID]) from[dbo].[Units]) if @c=0 begin set @x=1 end else begin  set @x=(select MAX([U_ID])+1 from [dbo].[Units]) end INSERT INTO [dbo].[Units] ([U_ID] ,[Name] ,[Qty] ,[Smallest_Unit_Name]) VALUES (@x ,@Name  ,@Qty  ,@Smallest_Unit_Name)", conn);
                    CMd.Parameters.Clear();
                    CMd.Parameters.AddWithValue("@Name", cbo_Unit_Name.Text);
                    CMd.Parameters.AddWithValue("@Qty", txt_Qty.Text);
                    CMd.Parameters.AddWithValue("@Smallest_Unit_Name", txt_Small.Text);
                    take_Insert_Update_Delete(CMd);
                    MessageBox.Show("Added");
                    cbo_unit_load();
                }
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }

        }
        private void btn_Unit_update_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand CMd = new SqlCommand("UPDATE [dbo].[Units] SET [Qty] =@Qty   ,[Smallest_Unit_Name] =@Smallest_Unit_Name  WHERE [U_ID] = @U_ID", conn);
                CMd.Parameters.Clear();
                CMd.Parameters.AddWithValue("@U_ID",cbo_Unit_Name.SelectedValue );
                CMd.Parameters.AddWithValue("@Qty", txt_Qty.Text);
                CMd.Parameters.AddWithValue("@Smallest_Unit_Name",txt_Small.Text);
                take_Insert_Update_Delete(CMd);
                MessageBox.Show("Edited");
                cbo_unit_load();
            }
            catch (Exception exp)
            {
                 MessageBox.Show(exp.Message);
               
            }
        }
        private void btn_unit_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand CMd = new SqlCommand("DELETE FROM [dbo].[Units] WHERE [U_ID] = @U_ID", conn);
                CMd.Parameters.Clear();
                CMd.Parameters.AddWithValue("@U_ID", cbo_Unit_Name.SelectedValue);
                take_Insert_Update_Delete(CMd);
                MessageBox.Show("Deleted");
                cbo_unit_load();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);

            }
        }


        public int Return_One_valueint(SqlCommand CMD)
        {
            SqlDataAdapter dad = new SqlDataAdapter(CMD);
            DataTable DT = new DataTable();
            dad.Fill(DT);
            DataRow row = DT.Rows[0];
            int x = (int)row[0];
            return x;
        }
        public DataTable Return_datatable_value(SqlCommand CMD)
        {
            SqlDataAdapter dad = new SqlDataAdapter(CMD);
            DataTable DT = new DataTable();
            dad.Fill(DT);
            return DT;
        }
        public void take_Insert_Update_Delete(SqlCommand CMD)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            CMD.ExecuteNonQuery();
            conn.Close();
        }

    }
}
