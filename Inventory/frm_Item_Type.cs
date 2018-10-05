using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Inventory
{
    public partial class frm_Item_Type : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
        public bool Flag = false;
        public frm_Item_Type()
        {
            InitializeComponent();
        }

        private void frm_Item_Type_Load(object sender, EventArgs e)
        {
            cbo_Cat_Load();
        }

        private void cbo_Cat_Load()
        {
            Flag = false;
            SqlCommand CMd = new SqlCommand("SELECT [Itm_Cat_ID],[Name] ,[Notes] FROM [dbo].[Item_Category] where [Type] ='true'", conn);
            cbo_Name.DataSource = Return_datatable_value(CMd);
            cbo_Name.ValueMember = "Itm_Cat_ID";
            cbo_Name.DisplayMember = "Name";
            cbo_Name.SelectedIndex = -1;
            txt_Type_Desc.Text = "";
            Flag = true;
        }
        private void cbo_Name_TextChanged(object sender, EventArgs e)
        {
            //check if this name already on item category  table
            SqlCommand CMd = new SqlCommand("SELECT count([Itm_Cat_ID]) FROM [dbo].[Item_Category] where [Name]=@Name", conn);
            CMd.Parameters.Clear();
            CMd.Parameters.AddWithValue("@Name", cbo_Name.Text);
            int checkingg = Return_One_valueint(CMd);
            //lw fady 2w mknsh mwgod fel DB 2bl keda
            if (string.IsNullOrWhiteSpace(cbo_Name.Text) || checkingg == 0)
            {
                btn_Cat_Add.Enabled = true;
                btn_Cat_update.Enabled = false;
                btn_Cat_Delete.Enabled = false;

            }
            else
            {
                btn_Cat_update.Enabled = true;
                btn_Cat_Add.Enabled = false;
                btn_Cat_Delete.Enabled = true;
            }
        }
        private void cbo_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Flag)
            {
                SqlCommand CMd = new SqlCommand("SELECT [Itm_Cat_ID]  ,[Name] ,[Type]  ,[Notes]  FROM [dbo].[Item_Category] where [Itm_Cat_ID] =@Itm_Cat_ID", conn);
                CMd.Parameters.Clear();
                CMd.Parameters.AddWithValue("@Itm_Cat_ID", cbo_Name.SelectedValue);
                DataTable DT = Return_datatable_value(CMd);
                DataRow row = DT.Rows[0];
                txt_Type_Desc.Text = row[3].ToString();
               
            }
        }


        public DataTable Return_datatable_value(SqlCommand CMD)
        {
            SqlDataAdapter dad = new SqlDataAdapter(CMD);
            DataTable DT = new DataTable();
            dad.Fill(DT);
            return DT;
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
        public void take_Insert_Update_Delete(SqlCommand CMD)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            CMD.ExecuteNonQuery();
            conn.Close();
        }

        private void btn_Cat_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(cbo_Name.Text) )
                {
                    MessageBox.Show("you must enter at least category name ");
                }
                else
                {
                    SqlCommand CMd = new SqlCommand("declare @x int  declare @c int  set @c=(select count([Itm_Cat_ID]) from [dbo].[Item_Category]) if @c=0 begin set @x=1 end   else begin  set @x=(select MAX([Itm_Cat_ID])+1 from [dbo].[Item_Category]) end   INSERT INTO [dbo].[Item_Category] ([Itm_Cat_ID] ,[Name] ,[Type] ,[Notes])  VALUES ( @x, @Name, 'true' , @Notes)", conn);
                    CMd.Parameters.Clear();
                    CMd.Parameters.AddWithValue("@Name", cbo_Name.Text);
                    CMd.Parameters.AddWithValue("@Notes", txt_Type_Desc.Text);
          
                    take_Insert_Update_Delete(CMd);
                    MessageBox.Show("Added");
                    cbo_Cat_Load();
                }
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }
        private void btn_Cat_update_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand CMd = new SqlCommand("UPDATE [dbo].[Item_Category] SET [Notes] = @Notes  WHERE [Itm_Cat_ID] = @Itm_Cat_ID", conn);
                CMd.Parameters.Clear();
                CMd.Parameters.AddWithValue("@Itm_Cat_ID", cbo_Name.SelectedValue);
                CMd.Parameters.AddWithValue("@Notes", txt_Type_Desc.Text);
                take_Insert_Update_Delete(CMd);
                MessageBox.Show("Edited");
                cbo_Cat_Load();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);

            }
        }

        private void btn_Cat_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand CMd = new SqlCommand("DELETE FROM [dbo].[Item_Category] WHERE  [Itm_Cat_ID] = @Itm_Cat_ID", conn);
                CMd.Parameters.Clear();
                CMd.Parameters.AddWithValue("@Itm_Cat_ID", cbo_Name.SelectedValue);
                take_Insert_Update_Delete(CMd);
                MessageBox.Show("Deleted");
                cbo_Cat_Load();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);

            }
        }
    }
}
