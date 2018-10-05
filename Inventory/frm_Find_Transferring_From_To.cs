using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory
{
    public partial class frm_Find_Transferring_From_To : Form
    {
        public frm_Find_Transferring_From_To()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
        SqlDataAdapter dad;

        private void cbo_Way_Of_Search_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbo_Way_Of_Search.SelectedItem == "All")
            {
                grb_Search.Enabled = false;
                SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[Transferring_View]", Conn);
                dad = new SqlDataAdapter(cmd);
                DataTable DT = new DataTable();
                dad.Fill(DT);
                dgv_Transfer_Find.DataSource = DT;
            }
            else if (cbo_Way_Of_Search.SelectedItem == "Search By")
            {
                grb_Search.Enabled = true;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_Transferring_From_To f1 = new frm_Transferring_From_To("add");
            f1.Show();
            this.Close();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int currentID = Convert.ToInt32(dgv_Transfer_Find.CurrentRow.Cells[0].Value);
            frm_Transferring_From_To f2 = new frm_Transferring_From_To(currentID, "edit");
            f2.Show();
            this.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int currentID = Convert.ToInt32(dgv_Transfer_Find.CurrentRow.Cells[0].Value);
            SqlCommand Cmd = new SqlCommand("SELECT [Tran_ID] ,[Itm_Sub_ID] ,[Qty] FROM [dbo].[Transfering_Details] where [Tran_ID]=@Tran_ID", Conn);
            Cmd.Parameters.AddWithValue("@Tran_ID", currentID);
            SqlDataAdapter dad = new SqlDataAdapter(Cmd);
            DataTable DT = new DataTable();
            dad.Fill(DT);
            ////////////// delete el return details( kol lfa btms7 item mn el retuen da)
            foreach (DataRow item in DT.Rows)
            {
                SqlCommand CmdD = new SqlCommand("DELETE FROM [dbo].[Transfering_Details] WHERE [Itm_Sub_ID]=@Item AND [Tran_ID]=@Tran", Conn);
                CmdD.Parameters.Clear();
                CmdD.Parameters.AddWithValue("@Item", item[1]);
                CmdD.Parameters.AddWithValue("@Tran", currentID);

                if (Conn.State != ConnectionState.Open)
                    Conn.Open();
                CmdD.ExecuteNonQuery();
                Conn.Close();

            }
            /////////////////////////////////////////////////////////////////////////////////////
            ////////////// delete el Transfer nfsha
            SqlCommand CmdDD = new SqlCommand("DELETE FROM [dbo].[Transfering_From_To] WHERE  [Tran_ID]=@Tran", Conn);
            CmdDD.Parameters.Clear();
            CmdDD.Parameters.AddWithValue("@Tran", currentID);
            if (Conn.State != ConnectionState.Open)
                Conn.Open();
            CmdDD.ExecuteNonQuery();
            Conn.Close();
            ////////////////////////////////////////////////////////////////////////////////
            // shelholy mn el grid
            int Rows_Count = dgv_Transfer_Find.Rows.Count - 1;
            if (Rows_Count > 0)
            {
                dgv_Transfer_Find.Rows.Remove(dgv_Transfer_Find.CurrentRow);
            }
            MessageBox.Show("deleted");

        }

        private void frm_Find_Transferring_From_To_Load(object sender, EventArgs e)
        {
            load_cbo_Create_By();
        }
        private void load_cbo_Create_By()
        {
            SqlCommand Cmd = new SqlCommand("select [Emp_ID],[Name] from [dbo].[Employee]", Conn);
            SqlDataAdapter dad = new SqlDataAdapter(Cmd);
            DataTable DT = new DataTable();
            dad.Fill(DT);
            cbo_Created_By.DataSource = DT;
            cbo_Created_By.ValueMember = "Emp_ID";
            cbo_Created_By.DisplayMember = "Name";
            cbo_Created_By.SelectedIndex = -1;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            String Query = "SELECT [Tran_ID],[Emp_Name] ,[Created_At] ,[Notes] ,[Store_From],[Store_To] FROM [dbo].[Transferring_View]  where 1=1";
            SqlCommand cmd = new SqlCommand("", Conn);
            if (txt_ID.Text !=string.Empty)
            {
                Query += " AND [Tran_ID]=@Tran_ID";
                cmd.Parameters.AddWithValue("@Tran_ID", txt_ID.Text);
            }
            if (cbo_Created_By.Text != string.Empty)
            {
                Query += " AND [Emp_Name] = @Emp_Name";
                cmd.Parameters.AddWithValue("@Emp_Name", cbo_Created_By.Text);
            }
            if (dtp_From.Text != string.Empty && dtp_To.Text != string.Empty)
            {
                Query += " OR Created_At between @from and  @to";
                cmd.Parameters.AddWithValue("@from", Convert.ToDateTime(dtp_From.Text));
                cmd.Parameters.AddWithValue("@to", Convert.ToDateTime(dtp_To.Text));
            }
            cmd.CommandText = Query;
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            dad.Fill(DT);
            dgv_Transfer_Find.DataSource = DT;

        }

        private void btn_View_Details_Click(object sender, EventArgs e)
        {
            int currentID = Convert.ToInt32(dgv_Transfer_Find.CurrentRow.Cells[0].Value);
            frm_Transferring_From_To f2 = new frm_Transferring_From_To(currentID, "View");
            f2.Show();
            

        }
    }
}
