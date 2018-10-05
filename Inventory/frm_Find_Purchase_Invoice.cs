using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory
{
    public partial class frm_Find_Purchase_Invoice : Form
    {
        bool flage = false;
        bool flagtem = false;
        public frm_Find_Purchase_Invoice()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_Purchase_Invoice new_pur_inv = new frm_Purchase_Invoice("Add");

            new_pur_inv.ShowDialog();

        }

        private void Frm_Find_Invoice_Load(object sender, EventArgs e)
        {
            txt_Itm_No.Enabled = false;
            gbo_Search_By.Enabled = false;
            SqlCommand cmd = new SqlCommand("select * from [dbo].[Supplier]", conn);
            conn.Open();
            SqlDataReader readsup = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(readsup);
            conn.Close();
            cbo_Supp_Name.DataSource = dt;
            cbo_Supp_Name.ValueMember = "Sup_ID";
            cbo_Supp_Name.DisplayMember = "Name";
            cbo_Supp_Name.SelectedIndex = -1;

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

            dtp_Inv_Date_From.Format = DateTimePickerFormat.Custom;
            dtp_Inv_Date_From.CustomFormat = "";
        }


        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {

                string Sqlstatment = "SELECT dbo.Purchase_Invoice.Pur_Inv_ID, dbo.Purchase_Invoice.Created_At, dbo.Purchase_Invoice.Paid, dbo.Purchase_Invoice.Total_Cost, dbo.Purchase_Invoice.Discount, dbo.Purchase_Invoice.Total_Cost_After_Disc, dbo.Purchase_Invoice.Notes, dbo.Store.Name AS Store_Name, dbo.Supplier.Name AS Sup_Name, dbo.Payment_Method.Method_Name, dbo.Employee.Name AS CreatedBy, dbo.Purchase_Invoice.Sup_ID, dbo.Purchase_Inv_Details.Itm_Sub_ID, dbo.Item_Subcategory.Name, dbo.Item_Category.Name AS cat_name FROM dbo.Purchase_Invoice INNER JOIN dbo.Store ON dbo.Purchase_Invoice.Sto_ID = dbo.Store.Sto_ID INNER JOIN dbo.Supplier ON dbo.Purchase_Invoice.Sup_ID = dbo.Supplier.Sup_ID INNER JOIN dbo.Payment_Method ON dbo.Purchase_Invoice.Pay_Method_ID = dbo.Payment_Method.Pay_Method_ID INNER JOIN dbo.Employee ON dbo.Purchase_Invoice.Emp_ID = dbo.Employee.Emp_ID INNER JOIN dbo.Purchase_Inv_Details ON dbo.Purchase_Invoice.Pur_Inv_ID = dbo.Purchase_Inv_Details.Pur_Inv_ID AND dbo.Purchase_Invoice.Sup_ID = dbo.Purchase_Inv_Details.Sup_ID INNER JOIN dbo.Item_Subcategory ON dbo.Purchase_Inv_Details.Itm_Sub_ID = dbo.Item_Subcategory.Itm_Sub_ID INNER JOIN dbo.Item_Category ON dbo.Item_Subcategory.Itm_Cat_ID = dbo.Item_Category.Itm_Cat_ID where 1 = 1";
                    //check if No is not Null
                    
               
                    conn.Open();
                    SqlCommand sql = new SqlCommand("", conn);
                    if (txt_Inv_No.Text != string.Empty)
                    {
                        Sqlstatment += " AND dbo.Purchase_Invoice.Pur_Inv_ID=@Add_Inv_ID";
                        sql.Parameters.AddWithValue("@Add_Inv_ID", txt_Inv_No.Text);
                    }
                    if (cbo_Supp_Name.SelectedItem != null)
                    {
                        Sqlstatment += " AND dbo.Supplier.Name= @suppName";
                        sql.Parameters.AddWithValue("@suppName",cbo_Supp_Name.Text);
                    }
                    if (txt_Inv_Total_Price.Text!= string.Empty)
                    {
                        Sqlstatment += " AND dbo.Purchase_Invoice.Total_Cost_After_Disc= @total_cost";
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
                        Sqlstatment += " AND dbo.Purchase_Inv_Details.Itm_Sub_ID=@item_ID";
                        sql.Parameters.AddWithValue("@item_ID", txt_Itm_No.Text);
                    }
                    if (dtp_Inv_Date_From.Text != string.Empty||dtp_Inv_Date_To.Text != string.Empty)
                    {
                        Sqlstatment += " or dbo.Purchase_Invoice.Created_At between @from and @to ";
                       sql.Parameters.AddWithValue("@from", Convert.ToDateTime(dtp_Inv_Date_From.Text));
                       sql.Parameters.AddWithValue("@to", Convert.ToDateTime(dtp_Inv_Date_To.Text));
                    }
                  
                    

                    sql.CommandText = Sqlstatment;
                    SqlDataReader sdr = sql.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(sdr);
                    conn.Close();

                  dgv_search.DataSource = dt;
                //if (cbo_Way_Of_Search.Text == "Search By")
                //{
                //    SqlCommand cmd = new SqlCommand("select * from [dbo].[All_Invoices] where ([Sup_Name]= @sup_name) or([Itm_Sub_ID]=@Item_id) or ([Pur_Inv_ID]=@INV_ID) or([Created_At] between @from and @to ) or([Total_Cost_After_Disc]=@finalprice)", conn);
                //    cmd.Parameters.AddWithValue("@sup_name", cbo_Supp_Name.Text);
                //    if (txt_Itm_No.Text == "")
                //    {
                //        txt_Itm_No.Text = "0";
                //    }
                //    cmd.Parameters.AddWithValue("@Item_id", Convert.ToInt32(txt_Itm_No.Text));

                //    if (txt_Inv_No.Text == "")
                //    {
                //        txt_Inv_No.Text = "0";
                //    }
                //    cmd.Parameters.AddWithValue("@INV_ID", int.Parse(txt_Inv_No.Text));
                //    cmd.Parameters.AddWithValue("@from", Convert.ToDateTime(dtp_Inv_Date_From.Text));
                //    cmd.Parameters.AddWithValue("@to", Convert.ToDateTime(dtp_Inv_Date_To.Text));
                //    if (txt_Inv_Total_Price.Text == "")
                //    {
                //        txt_Inv_Total_Price.Text = "0";
                //    }
                //    cmd.Parameters.AddWithValue("@finalprice", Convert.ToDecimal(txt_Inv_Total_Price.Text));
                //    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                //    DataTable dt = new DataTable();
                //    adapt.Fill(dt);
                //    dgv_search.DataSource = dt;

                //}
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

        private void btn_View_Edit_inv_Click(object sender, EventArgs e)
        {
            try
            {
            int selected_Inv_ID = Convert.ToInt16(dgv_search.CurrentRow.Cells[0].Value);
            string sup_name = (dgv_search.CurrentRow.Cells[8].Value).ToString();

            frm_Purchase_Invoice frm_edit = new frm_Purchase_Invoice("Edit", sup_name, selected_Inv_ID);
            frm_edit.ShowDialog();
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }


        private void cbo_Way_Of_Search_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_Way_Of_Search.Text == "All")
                {
                    gbo_Search_By.Enabled = false;

                    SqlCommand cmd = new SqlCommand("select * from	 [dbo].[Search_All]", conn);

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

        private void button1_Click(object sender, EventArgs e)
        { int ID= Convert.ToInt32(dgv_search.CurrentRow.Cells[0].Value);
            frm_Purchase_Invoice_Details all_inv = new frm_Purchase_Invoice_Details( ID);
            all_inv.ShowDialog();       
        }


        private void btn_Delete_Inv_Click(object sender, EventArgs e)
        {
            try
            {

                int x = Convert.ToInt32(dgv_search.CurrentRow.Cells[0].Value);
                SqlCommand Cmd2 = new SqlCommand(" select[Pur_Inv_ID] ,[Itm_Sub_ID], [Qty] from [dbo].[Purchase_Inv_Details] where [Pur_Inv_ID]= @Inv_ID ", conn);

                Cmd2.Parameters.AddWithValue("@Inv_ID", x);

                SqlDataAdapter adapt = new SqlDataAdapter(Cmd2);
                DataTable dt = new DataTable();
                adapt.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {
                    SqlCommand Cmd_del = new SqlCommand(" DELETE FROM [dbo].[Purchase_Inv_Details] WHERE  [Pur_Inv_ID]=@Inv_ID and [Itm_Sub_ID]=@item_ID", conn);

                    Cmd_del.Parameters.Clear();
                    Cmd_del.Parameters.AddWithValue("@Inv_ID", x);
                    Cmd_del.Parameters.AddWithValue("@item_ID", item[1]);

                    if (conn.State != ConnectionState.Open)

                        conn.Open();

                    Cmd_del.ExecuteNonQuery();
                    conn.Close();


                }

                SqlCommand Cmd_del_inv = new SqlCommand(" DELETE FROM   [dbo].[Purchase_Invoice] WHERE  [Pur_Inv_ID]=@Invo_ID and [Sup_ID]=@Sup_ID ", conn);
                Cmd_del_inv.Parameters.Clear();
                Cmd_del_inv.Parameters.AddWithValue("@Invo_ID", x);
                Cmd_del_inv.Parameters.AddWithValue("@Sup_ID", Convert.ToInt32(dgv_search.CurrentRow.Cells[11].Value));

                if (conn.State != ConnectionState.Open)

                    conn.Open();
                Cmd_del_inv.ExecuteNonQuery();
                conn.Close();

                cbo_Way_Of_Search_SelectedIndexChanged(sender, e);
                btn_Search_Click(sender, e);

                MessageBox.Show("deleted");

            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void txt_Itm_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        


        }

    }


