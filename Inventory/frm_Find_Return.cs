using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Inventory
{
    public partial class frm_Find_Return : Form
    {
        SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
        public frm_Find_Return()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_Returns f1 = new frm_Returns("add");
            f1.ShowDialog();
        }
        SqlDataAdapter dad;
        private void cbo_Way_Of_Search_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbo_Way_Of_Search.SelectedItem == "All")
            {
                txt_Customer.Text="";
                txt_ID.Text = "";
                txt_Sal_Inv.Text = "";
                cbo_Created_By.SelectedIndex = -1;
                cbo_Store_Name.SelectedIndex = -1;
                grb_Search.Enabled = false;
                SqlCommand cmd = new SqlCommand("SELECT        dbo.Add_Returns.Ret_ID, dbo.Add_Returns.Sal_Inv_ID, dbo.Store.Name AS Store, dbo.Employee.Name, dbo.Add_Returns.Notes, dbo.Add_Returns.Created_At,  dbo.Customer.Name AS Customer FROM            dbo.Store INNER JOIN dbo.Add_Returns ON dbo.Store.Sto_ID = dbo.Add_Returns.Sto_ID INNER JOIN   dbo.Employee ON dbo.Add_Returns.Emp_ID = dbo.Employee.Emp_ID INNER JOIN dbo.Sales_Invoice ON dbo.Add_Returns.Sal_Inv_ID = dbo.Sales_Invoice.Sal_Inv_ID INNER JOIN dbo.Customer ON dbo.Sales_Invoice.Cust_ID = dbo.Customer.Cust_ID", Conn);
                dad = new SqlDataAdapter(cmd);
                DataTable DT = new DataTable();
                dad.Fill(DT);
                dgv_Return_Find.DataSource = DT;
            }
            else if (cbo_Way_Of_Search.SelectedItem == "Search By")
            {
                grb_Search.Enabled = true;

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {    try
            {   /// hgeeb kol el items elly mwgoda  gwa el return w 27othm fe data table  3shan 2lf 3leehom 2ms7hom wa7ed wa7ed
                int currentID = Convert.ToInt32(dgv_Return_Find.CurrentRow.Cells[0].Value);
                SqlCommand Cmd = new SqlCommand("SELECT [Ret_ID] ,[Itm_Sub_ID] ,[Qty] FROM [dbo].[Add_Returns_Details] where [Ret_ID]=@Ret_ID", Conn);
                Cmd.Parameters.AddWithValue("@Ret_ID",currentID);
                SqlDataAdapter dad = new SqlDataAdapter(Cmd);
                DataTable DT = new DataTable();
                dad.Fill(DT);
            ////////////// delete el return details( kol lfa btms7 item mn el retuen da)
                foreach (DataRow item in DT.Rows)
                {
                    SqlCommand CmdD = new SqlCommand("DELETE FROM [dbo].[Add_Returns_Details] WHERE [Itm_Sub_ID]=@Item AND [Ret_ID]=@Ret", Conn);
                    CmdD.Parameters.Clear();
                    CmdD.Parameters.AddWithValue("@Item", item[1]);
                    CmdD.Parameters.AddWithValue("@Ret", currentID);

                    if (Conn.State != ConnectionState.Open)
                        Conn.Open();
                    CmdD.ExecuteNonQuery();
                    Conn.Close(); 
                    
                 }
            /////////////////////////////////////////////////////////////////////////////////////
                ////////////// delete el return nfsha
                SqlCommand CmdDD = new SqlCommand("DELETE FROM [dbo].[Add_Returns] WHERE  [Ret_ID]=@Ret", Conn);
                CmdDD.Parameters.Clear();
                CmdDD.Parameters.AddWithValue("@Ret", currentID);
                if (Conn.State != ConnectionState.Open)
                    Conn.Open();
                CmdDD.ExecuteNonQuery();
                Conn.Close(); 
                ////////////////////////////////////////////////////////////////////////////////
            // shelholy mn el grid
                int Rows_Count = dgv_Return_Find.Rows.Count - 1;
                if (Rows_Count > 0)
                {
                    dgv_Return_Find.Rows.Remove(dgv_Return_Find.CurrentRow);
                }
                MessageBox.Show("deleted");

            }
            catch (Exception exp)
                {

                MessageBox.Show(exp.Message);
            }

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                int currentID = Convert.ToInt32(dgv_Return_Find.CurrentRow.Cells[0].Value);
                frm_Returns f2 = new frm_Returns(currentID, "edit");
                f2.ShowDialog();
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }

        }

        private void frm_Find_Return_Load(object sender, EventArgs e)
        {

            load_cbo_Create_By();
            SqlCommand Cmd = new SqlCommand("select [Sto_ID],[Store].[Name]as st_Name from [dbo].[Store], [dbo].[Store_Category]  where[Store].Sto_Cat_ID=[Store_Category].Sto_Cat_ID and [Store_Category].Name='returns'", Conn);
            SqlDataAdapter dad = new SqlDataAdapter(Cmd);
            DataTable DT = new DataTable();
            dad.Fill(DT);
            cbo_Store_Name.DataSource = DT;
            cbo_Store_Name.ValueMember = "Sto_ID";
            cbo_Store_Name.DisplayMember = "st_Name";
            cbo_Store_Name.SelectedIndex = -1;
        }

        private void load_cbo_Create_By()
        {
            try
            {
                SqlCommand Cmd = new SqlCommand("select [Emp_ID],[Name] from [dbo].[Employee] where [Dept_ID]=(select [Dept_ID] from [dbo].[Department] where [Name]='sales')", Conn);
                SqlDataAdapter dad = new SqlDataAdapter(Cmd);
                DataTable DT = new DataTable();
                dad.Fill(DT);
                cbo_Created_By.DataSource = DT;
                cbo_Created_By.ValueMember = "Emp_ID";
                cbo_Created_By.DisplayMember = "Name";
                cbo_Created_By.SelectedIndex = -1;
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            String Sql_Cmd_Text = " SELECT        dbo.Add_Returns.Ret_ID, dbo.Add_Returns.Sal_Inv_ID, dbo.Store.Name AS Store, dbo.Employee.Name AS employee, dbo.Add_Returns.Notes,   dbo.Add_Returns.Created_At, dbo.Customer.Name AS Customer FROM            dbo.Store INNER JOIN dbo.Add_Returns ON dbo.Store.Sto_ID = dbo.Add_Returns.Sto_ID INNER JOIN dbo.Employee ON dbo.Add_Returns.Emp_ID = dbo.Employee.Emp_ID INNER JOIN dbo.Sales_Invoice ON dbo.Add_Returns.Sal_Inv_ID = dbo.Sales_Invoice.Sal_Inv_ID INNER JOIN  dbo.Customer ON dbo.Sales_Invoice.Cust_ID = dbo.Customer.Cust_ID WHERE 1=1 ";
            SqlCommand cmd = new SqlCommand("", Conn);

            if (txt_ID.Text != string.Empty)
            {
                Sql_Cmd_Text += "   and   (dbo.Add_Returns.Ret_ID = @Ret_ID)";
                cmd.Parameters.AddWithValue("@Ret_ID", int.Parse(txt_ID.Text));
            }
            if (txt_Customer.Text != string.Empty)
            {
                Sql_Cmd_Text += " AND (dbo.Customer.Name like  @Customer)";
                cmd.Parameters.AddWithValue("@Customer", txt_Customer.Text + "%");
            }
            if (txt_Sal_Inv.Text != string.Empty)
            {
                Sql_Cmd_Text += "  AND (dbo.Add_Returns.Sal_Inv_ID = @Sal_Inv_ID)";
                cmd.Parameters.AddWithValue("@Sal_Inv_ID", txt_Sal_Inv.Text);
            }
            if (cbo_Created_By.Text != string.Empty)
            {
                Sql_Cmd_Text += "  AND (dbo.Employee.Name = @employee) ";
                cmd.Parameters.AddWithValue("@employee", cbo_Created_By.Text);
            }
            if (cbo_Store_Name.Text != string.Empty)
            {
                Sql_Cmd_Text += "    AND (dbo.Store.Name = @Store) ";
                cmd.Parameters.AddWithValue("@Store", cbo_Store_Name.Text);
            }
            if (dtp_From.Text !=null && dtp_To.Text !=null)
            {
                Sql_Cmd_Text += " or (dbo.Add_Returns.Created_At between @from and @to)";
                cmd.Parameters.AddWithValue("@from", Convert.ToDateTime(dtp_From.Text));
                cmd.Parameters.AddWithValue("@to", Convert.ToDateTime(dtp_To.Text));
            }
            cmd.CommandText = Sql_Cmd_Text;
            SqlDataAdapter dadd = new SqlDataAdapter(cmd);
            DataTable DT5 = new DataTable();
            dadd.Fill(DT5);
            dgv_Return_Find.DataSource = DT5;




        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_View_Details_Click(object sender, EventArgs e)
        {
            try
            {
                int currentID = Convert.ToInt32(dgv_Return_Find.CurrentRow.Cells[0].Value);
                frm_Returns f2 = new frm_Returns(currentID, "view");
                f2.ShowDialog();
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }
    }
}
