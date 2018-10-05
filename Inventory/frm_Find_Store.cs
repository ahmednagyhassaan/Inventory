using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory
{
    public partial class frm_Find_Store : Form
    {
        SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");

        public frm_Find_Store()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_Add_Store frm1 = new frm_Add_Store("add");
            frm1.ShowDialog();
            this.Close();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int currentID = Convert.ToInt32(dgv_Store_Search.CurrentRow.Cells[0].Value);
            frm_Add_Store frm2 = new frm_Add_Store(currentID, "edit");
            frm2.ShowDialog();
            this.Close();
        }
     
        private void cbo_Store_Search_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cbo_Store_Search.SelectedItem == "All")
            {
                gbx_Search.Enabled = false;
                SqlCommand cmd = new SqlCommand("select * from [dbo].[Store_View] where [Valid]='True'", Conn);
                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                DataTable DT = new DataTable();
                dad.Fill(DT);
                dgv_Store_Search.DataSource = DT;
                txt_Name.Text = "";
                txt_Address.Text = "";
                txt_Phone.Text = "";
                cbo_Type.SelectedIndex = -1;
            }
            else if (cbo_Store_Search.SelectedItem == "Search By")
            {
                gbx_Search.Enabled = true;
            }

        }

        private void frm_Store_Search_Load(object sender, EventArgs e)
        {
            gbx_Search.Enabled = false;
            Load_Cbo_Type();

        }

        private void Load_Cbo_Type()
        {
            String Query = "SELECT [Sto_Cat_ID] ,[Name] FROM [dbo].[Store_Category]";
            SqlCommand Cmd = new SqlCommand(Query, Conn);
            SqlDataAdapter dad = new SqlDataAdapter(Cmd);
            DataTable DT = new DataTable();
            dad.Fill(DT);
            DataRow row = DT.Rows[0];
            cbo_Type.DataSource = DT;
            cbo_Type.ValueMember = "Sto_Cat_ID";
            cbo_Type.DisplayMember = "Name";
            cbo_Type.SelectedIndex = -1;

        }

        private void cbo_Store_Search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            String Query="SELECT [Sto_ID] ,[Type_Name] ,[Name] ,[Capacity] ,[Area] ,[Address] ,[Phone] FROM [dbo].[Store_View] where [Valid]='True'";
            SqlCommand cmd = new SqlCommand("",Conn);
            cmd.Parameters.Clear();
            if (txt_Name.Text != string.Empty)
            {
                Query += " AND [Name] like @Name";
                cmd.Parameters.AddWithValue("@Name", txt_Name.Text + "%");
            }
            if (cbo_Type.Text != string.Empty)
            {
                Query += " AND [Type_Name] like @Type_Name";
                cmd.Parameters.AddWithValue("@Type_Name", cbo_Type.Text + "%");
            }
            if (txt_Address.Text != string.Empty)
            {
                Query += " AND [Address]=@Address";
                cmd.Parameters.AddWithValue("@Address", "%" +txt_Address.Text +"%");
            }
            if(txt_Phone.Text !=string.Empty)
            {
                Query += " AND [Phone]=@Phone";
                cmd.Parameters.AddWithValue("@Phone", txt_Phone.Text);
            }
            cmd.CommandText = Query;
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            dad.Fill(DT);
            dgv_Store_Search.DataSource = DT;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {    
            try
            {
                int currentID = Convert.ToInt32(dgv_Store_Search.CurrentRow.Cells[0].Value);
                SqlCommand CmdDD = new SqlCommand("DELETE FROM [dbo].[Store] WHERE  [Sto_ID]=@Sto_ID", Conn);
                CmdDD.Parameters.Clear();
                CmdDD.Parameters.AddWithValue("@Sto_ID", currentID);
                if (Conn.State != ConnectionState.Open)
                    Conn.Open();
                CmdDD.ExecuteNonQuery();
                Conn.Close();
                int Rows_Count = dgv_Store_Search.Rows.Count - 1;
                if (Rows_Count > 0)
                {
                    dgv_Store_Search.Rows.Remove(dgv_Store_Search.CurrentRow);
                }
                MessageBox.Show("Store is deleted");
            }
            catch (Exception )
            {
                int currentID = Convert.ToInt32(dgv_Store_Search.CurrentRow.Cells[0].Value);
                SqlCommand CmdDD = new SqlCommand("UPDATE [dbo].[Store] SET [Valid] = 'False' WHERE [Sto_ID]=@Sto_ID", Conn);
                CmdDD.Parameters.Clear();
                CmdDD.Parameters.AddWithValue("@Sto_ID", currentID);
                if (Conn.State != ConnectionState.Open)
                    Conn.Open();
                CmdDD.ExecuteNonQuery();
                Conn.Close();
                MessageBox.Show("deleted but this store is related to other tables");
            }
            
        }


    }
}
