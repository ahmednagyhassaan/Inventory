using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory
{
    public partial class frm_Find_Cus_Invoices : Form
    {
        bool flage = false;
        bool flagtem = false;
        public frm_Find_Cus_Invoices()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");

        private void frm_Find_Cus_Invoices_Load(object sender, EventArgs e)
        {
            txt_Itm_No.Enabled = false;
            gbo_Search_By.Enabled = false;
            SqlCommand cmd = new SqlCommand("select * from [dbo].[Customer]", conn);
            conn.Open();
            SqlDataReader readsup = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(readsup);
            conn.Close();
            cbo_cust_Name.DataSource = dt;
            cbo_cust_Name.ValueMember = "Cust_ID";
            cbo_cust_Name.DisplayMember = "Name";
            cbo_cust_Name.SelectedIndex = -1;

            SqlCommand cmd1 = new SqlCommand("select * from [dbo].[Item_Category]", conn);
            conn.Open();
            SqlDataReader readitem = cmd1.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(readitem);
            conn.Close();
            cbo_Itm_Cat.DataSource = dt1;
            cbo_Itm_Cat.ValueMember = "Itm_Cat_ID";
            cbo_Itm_Cat.DisplayMember = "Name";
            cbo_Itm_Cat.SelectedIndex = -1;
            flage = true;
        }

        //public int CheckItemExist(int ItmID)
        //{
        //    //try
        //    //{
        //    SqlCommand CmdID = new SqlCommand("select [Sal_Inv_ID] from  [dbo].[Add_Returns]  ", conn);

        //    if (conn.State != ConnectionState.Open)

        //        conn.Open();

        //    SqlDataReader reader = CmdID.ExecuteReader();
        //    DataTable DT = new DataTable();
        //    DT.Load(reader);
        //    conn.Close();
           
        //        foreach (DataRow currentid in DT.Rows)
        //        {
        //            if (ItmID == Convert.ToInt32(currentid))
        //            {
        //                MessageBox.Show("This Invoice Has Returnes Cant deleted");
        //            }

        //        }
        //        return -1;
            //}
            //catch (Exception exp)
            //{
            //    MessageBox.Show(exp.Message);
            //    return -1;

            //}


        //}

        private void btn_Search_Click(object sender, EventArgs e)
        {
try
{
        string Sqlstatment = "SELECT dbo.Sales_Invoice.Sal_Inv_ID, dbo.Sales_Invoice.Emp_ID, dbo.Sales_Invoice.Cust_ID, dbo.Sales_Invoice.Created_At, dbo.Sales_Invoice.Discount, dbo.Sales_Invoice.Pay_Method_ID, dbo.Sales_Invoice.Paid,dbo.Sales_Invoice.Total_Cost, dbo.Sales_Invoice.Total_Cost_After_Disc, dbo.Sales_Invoice.Sto_ID, dbo.Sales_Invoice.Notes, dbo.Sales_Invoice_Details.Itm_Sub_ID FROM dbo.Sales_Invoice INNER JOIN dbo.Sales_Invoice_Details ON dbo.Sales_Invoice.Sal_Inv_ID = dbo.Sales_Invoice_Details.Sal_Inv_ID INNER JOIN dbo.Item_Subcategory ON dbo.Sales_Invoice_Details.Itm_Sub_ID = dbo.Item_Subcategory.Itm_Sub_ID INNER JOIN dbo.Item_Category ON dbo.Item_Subcategory.Itm_Cat_ID = dbo.Item_Category.Itm_Cat_ID where 1 = 1";

        conn.Open();
        SqlCommand sql = new SqlCommand("", conn);
        if (txt_Inv_No.Text != string.Empty)
        {
            Sqlstatment += " AND dbo.Sales_Invoice.Sal_Inv_ID=@Add_Inv_ID";
            sql.Parameters.AddWithValue("@Add_Inv_ID", txt_Inv_No.Text);
        }
        if (cbo_cust_Name.SelectedItem != null)
        {
            Sqlstatment += " AND dbo.Sales_Invoice.Cust_ID= @cus_ID";
            sql.Parameters.AddWithValue("@cus_ID", cbo_cust_Name.SelectedValue);
        }
        if (txt_Inv_Total_Price.Text != string.Empty)
        {
            Sqlstatment += " AND dbo.Sales_Invoice.Total_Cost_After_Disc= @total_cost";
            sql.Parameters.AddWithValue("@total_cost", txt_Inv_Total_Price.Text);
        }
        if (cbo_Itm_Cat.SelectedItem != null)
        {
            Sqlstatment += " AND dbo.Item_Category.Name =@item_cat";
            sql.Parameters.AddWithValue("@item_cat", cbo_Itm_Cat.Text);
        }
        if (cbo_Itm_Name.SelectedItem != null)
        {
            Sqlstatment += " AND  dbo.Item_Subcategory.Name = @item_sub_cat";
            sql.Parameters.AddWithValue("@item_sub_cat", cbo_Itm_Name.Text);
        }
        if (txt_Itm_No.Text != string.Empty)
        {
            Sqlstatment += " AND dbo.Sales_Invoice_Details.Itm_Sub_ID=@item_ID";
            sql.Parameters.AddWithValue("@item_ID", txt_Itm_No.Text);
        }
        if (dtp_Inv_Date_From.Text != string.Empty || dtp_Inv_Date_To.Text != string.Empty)
        {
            Sqlstatment += " or dbo.Sales_Invoice.Created_At between @from and @to ";
            sql.Parameters.AddWithValue("@from", Convert.ToDateTime(dtp_Inv_Date_From.Text));
            sql.Parameters.AddWithValue("@to", Convert.ToDateTime(dtp_Inv_Date_To.Text));
        }



        sql.CommandText = Sqlstatment;
        SqlDataReader sdr = sql.ExecuteReader();
        DataTable dt = new DataTable();
        dt.Load(sdr);
        conn.Close();

        dgv_search.DataSource = dt;
             }
            
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void cbo_Itm_Cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                if (flage == true)
                {
                    flagtem = false;
                    SqlCommand cmd2 = new SqlCommand("select * from  [dbo].[Item_Subcategory] where [Itm_Cat_ID]=" + cbo_Itm_Cat.SelectedValue, conn);

                    conn.Open();
                    SqlDataReader readsitem = cmd2.ExecuteReader();
                    DataTable dt2 = new DataTable();
                    dt2.Load(readsitem);
                    conn.Close();
                    cbo_Itm_Name.DataSource = dt2;
                    cbo_Itm_Name.DisplayMember = "Name";
                    cbo_Itm_Name.ValueMember = "Itm_Sub_ID";
                    cbo_Itm_Name.SelectedIndex = -1;
                    flagtem = true;
                }
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void cbo_Itm_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flagtem == true)
            {
                txt_Itm_No.Text = cbo_Itm_Name.SelectedValue.ToString();
            }
        }

        private void cbo_Way_Of_Search_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (cbo_Way_Of_Search.Text == "All")
                {
                    gbo_Search_By.Enabled = false;

                    SqlCommand cmd = new SqlCommand("select * from	[dbo].[all_sales_invoices]", conn);

                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dtall = new DataTable();
                    adapt.Fill(dtall);
                    dgv_search.DataSource = dtall;

                }
                else if (cbo_Way_Of_Search.Text == "Search By")
                {
                    gbo_Search_By.Enabled = true;
                }
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void btn_New_Invoice_Click(object sender, EventArgs e)
        {
            frm_Sales_Invoice frm_sal_inv = new frm_Sales_Invoice("Add");
            frm_sal_inv.ShowDialog();



        }

        private void btn_View_Edit_inv_Click(object sender, EventArgs e)
        {
            try
            {
                int selected_Inv_ID = Convert.ToInt16(dgv_search.CurrentRow.Cells[0].Value);
                frm_Sales_Invoice frm_edit = new frm_Sales_Invoice("Edit", selected_Inv_ID);
                frm_edit.ShowDialog();
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void btn_Delete_Inv_Click(object sender, EventArgs e)
        {
            try
            {

                int x = Convert.ToInt32(dgv_search.CurrentRow.Cells[0].Value);
                SqlCommand Cmd2 = new SqlCommand(" select [Sal_Inv_ID] ,[Itm_Sub_ID],	[Qty] from 	[dbo].[Sales_Invoice_Details] where [Sal_Inv_ID]= @Inv_ID ", conn);
               Cmd2.Parameters.AddWithValue("@Inv_ID", x);
                SqlDataAdapter adapt = new SqlDataAdapter(Cmd2);
                DataTable dt = new DataTable();
                adapt.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {
                    SqlCommand Cmd_del = new SqlCommand(" DELETE FROM [dbo].[Sales_Invoice_Details] WHERE  [Sal_Inv_ID]=@Inv_ID and [Itm_Sub_ID]=@item_ID", conn);

                    Cmd_del.Parameters.Clear();
                    Cmd_del.Parameters.AddWithValue("@Inv_ID", x);
                    Cmd_del.Parameters.AddWithValue("@item_ID", item[1]);

                    if (conn.State != ConnectionState.Open)

                        conn.Open();

                    Cmd_del.ExecuteNonQuery();
                    conn.Close();

                }

        //public int CheckItemExist(x)
        //{
        //    //try
        //    //{
                SqlCommand CmdID = new SqlCommand("select [Sal_Inv_ID] from  [dbo].[Add_Returns]  ", conn);

                if (conn.State != ConnectionState.Open)

                    conn.Open();

                SqlDataReader reader = CmdID.ExecuteReader();
                DataTable DTID = new DataTable();
                DTID.Load(reader);
                conn.Close();

                foreach (DataRow currentid in DTID.Rows)
                {
                    if (x == Convert.ToInt32(currentid[0]))
                    {
                        MessageBox.Show("This Invoice Has Returnes Cant deleted");
                    }

                            
            
                SqlCommand Cmd_del_inv = new SqlCommand(" DELETE FROM  [dbo].[Sales_Invoice] WHERE  [Sal_Inv_ID]=@Invo_ID  ", conn);
                Cmd_del_inv.Parameters.Clear();
                Cmd_del_inv.Parameters.AddWithValue("@Invo_ID", x);

                if (conn.State != ConnectionState.Open)

                    conn.Open();
                Cmd_del_inv.ExecuteNonQuery();
                conn.Close();

                cbo_Way_Of_Search_SelectedIndexChanged(sender, e);
                btn_Search_Click(sender, e);

                MessageBox.Show("deleted");
}
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
}
    }
}
