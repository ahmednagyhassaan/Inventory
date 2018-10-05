using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Inventory
{
    public partial class frm_Purchase_Invoice : Form
    {
        public string new_or_edit = "";
         public string sup_name="";
        int ID = 0;
        
        public frm_Purchase_Invoice(string d)
        {
            InitializeComponent();
            new_or_edit = d;

        }
        public frm_Purchase_Invoice(string d,string q, int x)
        {
            InitializeComponent();
            new_or_edit = d;
            sup_name = q;
           
            ID = x;
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");

        bool flage = false;
        bool flagtem = false;
        private void Form1_Load(object sender, EventArgs e)
        { 
           txt_DisPrice.Enabled = false;
            txt_Itm_No.Enabled = false;
            SqlCommand cmd = new SqlCommand("select * from [dbo].[Supplier]",conn);
            conn.Open();
            SqlDataReader readsup = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(readsup);
            conn.Close();
            cbo_Supp_Name.DataSource =dt;
            cbo_Supp_Name.ValueMember = "Sup_ID";
            cbo_Supp_Name.DisplayMember = "Name";
            cbo_Supp_Name.SelectedIndex = -1;


            SqlCommand cmd3 = new SqlCommand("select * from [dbo].[Payment_Method]", conn);
            conn.Open();
            SqlDataReader readmethod = cmd3.ExecuteReader();
            DataTable dt3 = new DataTable();
            dt3.Load(readmethod);
            conn.Close();
            cbo_Pay_Method.DataSource = dt3;
            cbo_Pay_Method.ValueMember = "Pay_Method_ID";
            cbo_Pay_Method.DisplayMember = "Method_Name";
            cbo_Pay_Method.SelectedIndex = -1;



            SqlCommand cmd4 = new SqlCommand("select[Emp_ID],[Name] from [dbo].[Employee] where [Dept_ID]=2", conn);
            conn.Open();
            SqlDataReader reademp = cmd4.ExecuteReader();
            DataTable dt4 = new DataTable();
            dt4.Load(reademp);
            conn.Close();
            cbo_Created_By.DataSource = dt4;
            cbo_Created_By.ValueMember = "Emp_ID";
            cbo_Created_By.DisplayMember = "Name";
            cbo_Created_By.SelectedIndex = -1;

            SqlCommand cmd5 = new SqlCommand("select * from [dbo].[Store] where [Sto_Cat_ID]=1", conn);
            conn.Open();
            SqlDataReader readstore = cmd5.ExecuteReader();
            DataTable dtstor = new DataTable();
            dtstor.Load(readstore);
            conn.Close();
            cbo_storename.DataSource = dtstor;
            cbo_storename.ValueMember = "Sto_ID";
            cbo_storename.DisplayMember = "Name";
            cbo_storename.SelectedIndex = -1;


            SqlCommand cmd1 = new SqlCommand("select * from [dbo].[Item_Category] where [Type]='false'", conn);
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





            if (new_or_edit == "Edit")
            { Show_Edit_Details(); }

            else if (new_or_edit == "Add")
            {


                creat_dgv_colomns();
            }


        }

        private void creat_dgv_colomns()
        {
            dgv_Pur_Inv.ColumnCount = 7;
            dgv_Pur_Inv.Columns[0].Name = "ItemNo";
            dgv_Pur_Inv.Columns[1].Name = "ItemTotalQty";
            dgv_Pur_Inv.Columns[2].Name = "ItemCategory";
            dgv_Pur_Inv.Columns[3].Name = "ItemName";
            dgv_Pur_Inv.Columns[4].Name = "ItemPrice";
            dgv_Pur_Inv.Columns[5].Name = "Discount";
            dgv_Pur_Inv.Columns[6].Name = "FinalPrice";
        }

        DataTable DT_grd_edit = new DataTable();

        private void Show_Edit_Details()
        {
            try
            {




                SqlCommand cmd_edit = new SqlCommand("SELECT dbo.Supplier.Name, dbo.Purchase_Invoice.Sup_ID AS Expr1, dbo.Purchase_Invoice.Emp_ID, dbo.Purchase_Invoice.Pay_Method_ID, dbo.Purchase_Invoice.Created_At, dbo.Purchase_Invoice.Paid, dbo.Purchase_Invoice.Total_Cost, dbo.Purchase_Invoice.Discount, dbo.Purchase_Invoice.Total_Cost_After_Disc, dbo.Purchase_Invoice.Sto_ID, dbo.Purchase_Invoice.Notes, dbo.Purchase_Invoice.Pur_Inv_ID FROM dbo.Supplier INNER JOIN dbo.Purchase_Invoice ON dbo.Supplier.Sup_ID = dbo.Purchase_Invoice.Sup_ID where dbo.Purchase_Invoice.Pur_Inv_ID=@invoice_id and dbo.Supplier.Name= @sup_name ", conn);
                cmd_edit.Parameters.AddWithValue("@invoice_id", ID);
                cmd_edit.Parameters.AddWithValue("@sup_name", sup_name);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd_edit);
                DataTable DT_edit = new DataTable();
                adapt.Fill(DT_edit);
                DataRow row = DT_edit.Rows[0];

                cbo_Supp_Name.Text = row[0].ToString();
                cbo_Created_By.SelectedValue = row[2];
                cbo_Pay_Method.SelectedValue = row[3];

                dtp_Inv_Date.Text = row[4].ToString();
                txt_Paid.Text = row[5].ToString();
                txt_Total_Cost.Text = row[6].ToString();
                txt_Discount.Text = row[7].ToString();
                txt_Total_Cost_Disc.Text = row[8].ToString();
                cbo_storename.SelectedValue = Convert.ToInt32(row[9]);
                txt_Notes.Text = row[10].ToString();
                txt_Inv_No.Text = row[11].ToString();
                //--------------------------------------

                SqlCommand cmd_grd_edit = new SqlCommand("SELECT dbo.Purchase_Inv_Details.Itm_Sub_ID ,  dbo.Purchase_Inv_Details.Qty,dbo.Item_Category.Name AS Cat_Name,dbo.Item_Subcategory.Name AS Sub_Cat_Name, dbo.Purchase_Inv_Details.Price,[Discount],[FinalPrice], dbo.Purchase_Inv_Details.Pur_Inv_ID AS Pur_No, dbo.Purchase_Inv_Details.Sup_ID,dbo.Supplier.Name FROM  dbo.Item_Category INNER JOIN dbo.Item_Subcategory ON dbo.Item_Category.Itm_Cat_ID = dbo.Item_Subcategory.Itm_Cat_ID INNER JOIN dbo.Purchase_Inv_Details ON dbo.Item_Subcategory.Itm_Sub_ID = dbo.Purchase_Inv_Details.Itm_Sub_ID INNER JOIN dbo.Supplier ON dbo.Purchase_Inv_Details.Sup_ID = dbo.Supplier.Sup_ID WHERE (dbo.Purchase_Inv_Details.Pur_Inv_ID = @invoice_grd_id) AND (dbo.Supplier.Name = @sup_grd_name)", conn);
                cmd_grd_edit.Parameters.AddWithValue("@invoice_grd_id", ID);
                cmd_grd_edit.Parameters.AddWithValue("@sup_grd_name", sup_name);
                SqlDataAdapter adapt_grd = new SqlDataAdapter(cmd_grd_edit);


                adapt_grd.Fill(DT_grd_edit);

                dgv_Pur_Inv.DataSource = DT_grd_edit;

            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
            }
        //------------------------------------------------------
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

                    cbo_Itm_Name.Text = ("Select Here");
                    flagtem = true;
                }
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        public int CheckItemExist (int ItmID)
        {
            try
            {
                foreach (DataGridViewRow currentrow in dgv_Pur_Inv.Rows)
                {
                    if (ItmID == Convert.ToInt32(currentrow.Cells[0].Value))
                    {
                        return (Convert.ToInt32(currentrow.Cells[0].RowIndex));
                    }
                    
                }
                return -1;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return -1;
               
            }
            
        
        }

        int incerment = 0;

        private void btn_Add_Itm_Click(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrWhiteSpace(cbo_Itm_Name.Text))
                {
                    MessageBox.Show("please select the item first");
                }


                else
                {
                    if (String.IsNullOrWhiteSpace(txt_Smallunit.Text))
                        txt_Smallunit.Text = "0 ";

                    if (String.IsNullOrWhiteSpace(txt_BigQty.Text))

                        txt_BigQty.Text = "0 ";
                    if (String.IsNullOrWhiteSpace(txt_ItemPrice.Text))
                        txt_ItemPrice.Text = "0 ";
                    if (String.IsNullOrWhiteSpace(txt_ItemDiscount.Text))
                        txt_Discount.Text = "0 ";

                    SqlCommand Cmd = new SqlCommand("DECLARE @Qty int EXEC [dbo].[PRO_Itm_Qty] @Qty_Unit = @Qty_Unitt,@Qty_Smallest_Unit = @Qty_Smallest_Unitt,@Itm_ID = @Itm_IDD,@Qty = @Qty OUTPUT SELECT @Qty as Total_Quantity", conn);

                    Cmd.Parameters.AddWithValue("@Qty_Unitt", int.Parse(txt_BigQty.Text)); Cmd.Parameters.AddWithValue("@Qty_Smallest_Unitt", int.Parse(txt_Smallunit.Text)); Cmd.Parameters.AddWithValue("@Itm_IDD", cbo_Itm_Name.SelectedValue);

                    SqlDataAdapter adapt = new SqlDataAdapter(Cmd);
                    DataTable DT = new DataTable();
                    adapt.Fill(DT);
                    DataRow row = DT.Rows[0];

                    int selected = CheckItemExist(Convert.ToInt32(cbo_Itm_Name.SelectedValue));

                    if (selected == -1 && new_or_edit == "Add")
                    {
                        if (Convert.ToInt32(txt_BigQty.Text) <= 0 && Convert.ToInt32(txt_Smallunit.Text) <= 0)
                        {
                            MessageBox.Show("please enter item quality");
                        }
                        else
                        {
                            if (Convert.ToInt32(txt_ItemPrice.Text) <= 0)
                            {
                                MessageBox.Show("please enter item Price");
                            }
                            else
                            {
                                if (int.Parse(txt_ItemDiscount.Text) != 0)
                                {
                                    int x =(int.Parse(txt_ItemPrice.Text)- ((int.Parse(txt_ItemPrice.Text)) * (int.Parse(txt_ItemDiscount.Text)) / 100));
                                    txt_DisPrice.Text = x.ToString();
                                }
                                else
                                {
                                    int x = (int.Parse(txt_ItemPrice.Text));
                                    txt_DisPrice.Text = x.ToString();
                                }
                                dgv_Pur_Inv.Rows.Add();
                                dgv_Pur_Inv.Rows[incerment].Cells[0].Value = txt_Itm_No.Text;
                                dgv_Pur_Inv.Rows[incerment].Cells[1].Value = row[0];
                                dgv_Pur_Inv.Rows[incerment].Cells[2].Value = cbo_Itm_Cat.Text;
                                dgv_Pur_Inv.Rows[incerment].Cells[3].Value = cbo_Itm_Name.Text;
                                dgv_Pur_Inv.Rows[incerment].Cells[4].Value = txt_DisPrice.Text;
                                dgv_Pur_Inv.Rows[incerment].Cells[5].Value = txt_ItemDiscount.Text;
                                int y =Convert.ToInt32( row[0]);
                                decimal total = ((int.Parse(txt_DisPrice.Text)) * y);
                                dgv_Pur_Inv.Rows[incerment].Cells[6].Value = total.ToString();
                                incerment++;
                            }

                        }

                    }
                    else if (selected >= 0 && new_or_edit == "Add")
                    {
                        //dgv_Pur_Inv.Rows.Add();

                        if (int.Parse(txt_ItemDiscount.Text) != 0)
                        {
                            int x = ((int.Parse(txt_ItemPrice.Text)) * (int.Parse(txt_ItemDiscount.Text)) / 100);
                            txt_DisPrice.Text = x.ToString();
                        }
                        else
                        {
                            int x = (int.Parse(txt_ItemPrice.Text));
                            txt_DisPrice.Text = x.ToString();
                        }
                        dgv_Pur_Inv.Rows[selected].Cells[0].Value = txt_Itm_No.Text;
                        //int z = Convert.ToInt32(dgv_Pur_Inv.Rows[selected].Cells[1].Value);
                        //int p = Convert.ToInt32(row[0]);
                        dgv_Pur_Inv.Rows[selected].Cells[1].Value = row[0];

                        dgv_Pur_Inv.Rows[selected].Cells[2].Value = cbo_Itm_Cat.Text;
                        dgv_Pur_Inv.Rows[selected].Cells[3].Value = cbo_Itm_Name.Text;
                        dgv_Pur_Inv.Rows[selected].Cells[4].Value = txt_DisPrice.Text;
                        dgv_Pur_Inv.Rows[selected].Cells[5].Value = txt_ItemDiscount.Text;
                        int y = Convert.ToInt32(row[0]);
                        decimal total = ((int.Parse(txt_DisPrice.Text)) * y);
                        dgv_Pur_Inv.Rows[selected].Cells[6].Value = total.ToString();


                    }
                    else if (selected == -1 && new_or_edit == "Edit")
                    {


                        if (Convert.ToInt32(txt_BigQty.Text) <= 0 && Convert.ToInt32(txt_Smallunit.Text) <= 0)
                        {
                            MessageBox.Show("please enter item quality");
                        }
                        else
                        {
                            if (Convert.ToInt32(txt_ItemPrice.Text) <= 0)
                            {
                                MessageBox.Show("please enter item Price");
                            }
                            else
                            {

                                DataRow newRow = DT_grd_edit.NewRow();
                                newRow[0] = Convert.ToInt32(cbo_Itm_Name.SelectedValue);
                                newRow[2] = cbo_Itm_Cat.Text;
                                newRow[3] = cbo_Itm_Name.Text;
                                
                                
                                if (int.Parse(txt_ItemDiscount.Text) != 0)
                                {
                                    int x = (int.Parse(txt_ItemPrice.Text) - ((int.Parse(txt_ItemPrice.Text)) * (int.Parse(txt_ItemDiscount.Text)) / 100));
                                    txt_DisPrice.Text = x.ToString();
                                }
                                else
                                {
                                    int x = (int.Parse(txt_ItemPrice.Text));
                               
                                    txt_DisPrice.Text = x.ToString();
                                }
                                newRow[4] = txt_DisPrice.Text;
                                newRow[5] = txt_ItemDiscount.Text;
                                int y = Convert.ToInt32(row[0]);
                                decimal total = ((int.Parse(txt_DisPrice.Text)) * y);
                                newRow[6] = total.ToString();

                                newRow[1] = row[0];
                                newRow[7] = txt_Inv_No.Text;
                                newRow[8] = cbo_Supp_Name.SelectedValue;
                                newRow[9] = cbo_Supp_Name.Text;
                                DT_grd_edit.Rows.Add(newRow);
                            }
                        }
                    }
                    else if (selected >= 0 && new_or_edit == "Edit")
                    {
                        foreach (DataRow selrows in DT_grd_edit.Rows)
                        {
                            if (selrows[0].ToString() == (cbo_Itm_Name.SelectedValue).ToString())
                            {


                                selrows[0] = Convert.ToInt32(cbo_Itm_Name.SelectedValue);
                                selrows[2] = cbo_Itm_Cat.Text;
                                selrows[3] = cbo_Itm_Name.Text;
                                
                                if (!string.IsNullOrWhiteSpace(txt_ItemDiscount.Text) && !string.IsNullOrWhiteSpace(txt_ItemPrice.Text))
                                {


                                     if (int.Parse(txt_ItemDiscount.Text) != 0)
                                {
                                    int x =(int.Parse(txt_ItemPrice.Text)- ((int.Parse(txt_ItemPrice.Text)) * (int.Parse(txt_ItemDiscount.Text)) / 100));
                                    txt_DisPrice.Text = x.ToString();
                                }
                                else
                                {
                                    int x = (int.Parse(txt_ItemPrice.Text));
                                    txt_DisPrice.Text = x.ToString();
                                     }
                                     int y = Convert.ToInt32(row[0]);
                                     decimal total = ((int.Parse(txt_DisPrice.Text)) * y);
                                     selrows[4] = txt_DisPrice.Text;
                                     selrows[5] = txt_ItemDiscount.Text;
                                     selrows[6] = total.ToString();
                                }
                                //int z = Convert.ToInt32(selrows[4]);
                                //int p = Convert.ToInt32(row[0]);

                                selrows[1] = row[0];
                                selrows[7] = txt_Inv_No.Text;
                                selrows[8] = cbo_Supp_Name.SelectedValue;
                                selrows[9] = cbo_Supp_Name.Text;
                            }
                            txt_BigQty.Text = "";
                            txt_Smallunit.Text = "";

                        }



                    }

                }
            }

            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }
                
        private void cbo_Itm_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (flagtem == true)
                {
                    txt_Itm_No.Text = cbo_Itm_Name.SelectedValue.ToString();

                    //txt_BigQty.Text.Enabled = true;
                    //txt_Smallunit.Text.Enabled = true;
                    SqlCommand Cmd = new SqlCommand("SELECT Unt.[Name],Unt.[Smallest_Unit_Name] FROM [dbo].[Units] as Unt,[dbo].[Item_Subcategory] as Itm where Itm.U_ID=Unt.U_ID and Itm.[Itm_Sub_ID]=@Itm_Sub_ID", conn);
                    Cmd.Parameters.AddWithValue("@Itm_Sub_ID", cbo_Itm_Name.SelectedValue);

                    SqlDataAdapter adapt = new SqlDataAdapter(Cmd);
                    DataTable DT = new DataTable();
                    adapt.Fill(DT);
                    DataRow row = DT.Rows[0];
                    lbl_bigunit.Text = row[0].ToString();
                    lbl_SmallUnit.Text = row[1].ToString();


                }
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }
       
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                int y = (dgv_Pur_Inv.RowCount);
                if (txt_Inv_No.Text == "")
                {
                    MessageBox.Show("please you Must Enter Invoice Nomber");
                }
                else if (cbo_Pay_Method.Text == "Select Here")
                    {
                        MessageBox.Show("please Select Payment Method");
                    }

                else if (cbo_Supp_Name.Text == "Select Here")
                    {
                        MessageBox.Show("please Select Supplier Name");
                    }
                else if (cbo_storename.Text == "Select Here")
                    {
                        MessageBox.Show("please Select Store Name");
                    }
                else if (cbo_Created_By.Text == "Select Here")
                    {
                        MessageBox.Show("please Select Employee Name");
                    }
                else if (txt_Inv_No.Text == "")
                    {
                        MessageBox.Show("please you Must Enter Invoice Nomber");
                    }


                else if ((txt_Discount.Text) == "")
                    {
                        txt_Discount.Text = "0";
                    }

                else if (new_or_edit == "Add")
                    {


                        //int y = (dgv_Pur_Inv.RowCount);
                        decimal Sumprice = 0;
                        for (int i = 1; i < y; i++)
                        {


                            decimal x = Convert.ToInt64(dgv_Pur_Inv.Rows[i - 1].Cells[6].Value);
                            Sumprice = Sumprice + x;
                        }
                        txt_Total_Cost.Text = Sumprice.ToString();

                        //calculate_total_Price();



                        if ((txt_Discount.Text) == "")
                        {
                            txt_Discount.Text = "0";
                        }
                        if (Convert.ToDecimal(txt_Discount.Text) != 0)
                        {
                            decimal After_Discount = (Convert.ToDecimal(txt_Total_Cost.Text)) - ((Convert.ToDecimal(txt_Total_Cost.Text)) * (Convert.ToDecimal(txt_Discount.Text)) / 100);
                            txt_Total_Cost_Disc.Text = After_Discount.ToString();
                        }
                        else
                        {
                            txt_Total_Cost_Disc.Text = txt_Total_Cost.Text;
                        }



                        SqlCommand cmd = new SqlCommand("insert into [dbo].[Purchase_Invoice]  values (@invoiceno,@supplierno,@paymethodno,@empname,@invdate,@Paid,@totalcost,@discount,@totcostfinal,@storeid,@notes)", conn);
                        cmd.Parameters.AddWithValue("@invoiceno", int.Parse(txt_Inv_No.Text));
                        cmd.Parameters.AddWithValue("@supplierno", int.Parse(cbo_Supp_Name.SelectedValue.ToString()));
                        cmd.Parameters.AddWithValue("@paymethodno", int.Parse(cbo_Pay_Method.SelectedValue.ToString()));
                        cmd.Parameters.AddWithValue("@empname", cbo_Created_By.SelectedValue);
                        cmd.Parameters.AddWithValue("@invdate", Convert.ToDateTime(dtp_Inv_Date.Text));
                        cmd.Parameters.AddWithValue("@Paid", Convert.ToDecimal(txt_Paid.Text));
                        cmd.Parameters.AddWithValue("@totalcost", Convert.ToDecimal(txt_Total_Cost.Text));
                        cmd.Parameters.AddWithValue("@discount", Convert.ToDecimal(txt_Discount.Text));
                        cmd.Parameters.AddWithValue("@totcostfinal", Convert.ToDecimal(txt_Total_Cost_Disc.Text));
                        cmd.Parameters.AddWithValue("@storeid", int.Parse(cbo_storename.SelectedValue.ToString()));
                        cmd.Parameters.AddWithValue("@notes", txt_Notes.Text);

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        cmd.ExecuteNonQuery();
                        conn.Close();


                        insert_grid_into_db(y);
                        MessageBox.Show("added successfully");
                    }


                    else if (new_or_edit == "Edit")
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE [dbo].[Purchase_Invoice] SET [Pur_Inv_ID] = @invoiceno,[Sup_ID] = @supplierno,[Pay_Method_ID] = @paymethodno,[Emp_ID] = @empid ,[Created_At] = @invdate,[Paid] = @Paid,[Total_Cost] = @totalcost,[Discount] = @discount,[Total_Cost_After_Disc] = @totcostfinal ,[Sto_ID] = @storeid,[Notes] = @notes  WHERE [Pur_Inv_ID]= @invoiceno and [Sup_ID]= @supplierno", conn);
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@invoiceno", ID);
                        cmd.Parameters.AddWithValue("@supplierno", int.Parse(cbo_Supp_Name.SelectedValue.ToString()));
                        cmd.Parameters.AddWithValue("@paymethodno", int.Parse(cbo_Pay_Method.SelectedValue.ToString()));
                        cmd.Parameters.AddWithValue("@empid", cbo_Created_By.SelectedValue);
                        cmd.Parameters.AddWithValue("@invdate", Convert.ToDateTime(dtp_Inv_Date.Text));
                        cmd.Parameters.AddWithValue("@Paid", Convert.ToDecimal(txt_Paid.Text));
                        cmd.Parameters.AddWithValue("@totalcost", Convert.ToDecimal(txt_Total_Cost.Text));
                        cmd.Parameters.AddWithValue("@discount", Convert.ToDecimal(txt_Discount.Text));
                        cmd.Parameters.AddWithValue("@totcostfinal", Convert.ToDecimal(txt_Total_Cost_Disc.Text));
                        cmd.Parameters.AddWithValue("@storeid", int.Parse(cbo_storename.SelectedValue.ToString()));
                        cmd.Parameters.AddWithValue("@notes", txt_Notes.Text);
                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        for (int i = 0; i < y; i++)
                        {


                            SqlCommand Cmd = new SqlCommand(" DELETE FROM [dbo].[Purchase_Inv_Details] WHERE  [Pur_Inv_ID]=@Inv_ID and [Sup_ID]=@Sup_ID and[Itm_Sub_ID]=@Item_ID", conn);
                            Cmd.Parameters.Clear();
                            Cmd.Parameters.AddWithValue("@Inv_ID", ID);
                            Cmd.Parameters.AddWithValue("@Sup_ID", Convert.ToInt32(cbo_Supp_Name.SelectedValue.ToString()));
                            Cmd.Parameters.AddWithValue("@Item_ID", Convert.ToInt32(dgv_Pur_Inv.Rows[i].Cells[0].Value));
                            if (conn.State != ConnectionState.Open)
                            {
                                conn.Open();
                            }
                            Cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        insert_grid_into_db(y);
                        MessageBox.Show("Updated successfully");

                    }
                
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }

        }
        //-----------------------------------------------------------------------------------
        private void insert_grid_into_db(int y)
        {
            try
            {
                for (int i = 0; i < y - 1; i++)
                {
                    SqlCommand cmd_Item = new SqlCommand(" insert into [dbo].[Purchase_Inv_Details]  values (@invoicenooo,@supplierno,@item_sup_no,@price,@finalqty,@discount,@finalprice)", conn);
                    cmd_Item.Parameters.Clear();
                    cmd_Item.Parameters.AddWithValue("@invoicenooo", int.Parse(txt_Inv_No.Text));
                    cmd_Item.Parameters.AddWithValue("@supplierno", int.Parse(cbo_Supp_Name.SelectedValue.ToString()));
                    cmd_Item.Parameters.AddWithValue("@item_sup_no", int.Parse(dgv_Pur_Inv.Rows[i].Cells[0].Value.ToString()));
                    cmd_Item.Parameters.AddWithValue("@price", Convert.ToDecimal(dgv_Pur_Inv.Rows[i].Cells[4].Value.ToString()));
                    cmd_Item.Parameters.AddWithValue("@finalqty", Convert.ToInt64(dgv_Pur_Inv.Rows[i].Cells[1].Value.ToString()));
                    cmd_Item.Parameters.AddWithValue("@discount", Convert.ToDecimal(dgv_Pur_Inv.Rows[i].Cells[5].Value.ToString()));
                    cmd_Item.Parameters.AddWithValue("@finalprice", Convert.ToDecimal(dgv_Pur_Inv.Rows[i].Cells[6].Value.ToString()));


                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    cmd_Item.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }
       
        private void btn_Execute_Click(object sender, EventArgs e)
        {
            try
            {

                if (new_or_edit == "Add" ||new_or_edit == "Edit")
                {

                    int y = (dgv_Pur_Inv.RowCount);
                    Decimal Sumprice = 0;
                    for (int i = 1; i < y; i++)
                    {


                        decimal x = Convert.ToInt64(dgv_Pur_Inv.Rows[i - 1].Cells[6].Value);
                        Sumprice = Sumprice + x;
                    }
                    txt_Total_Cost.Text = Sumprice.ToString();
                }
                //else if (new_or_edit == "Edit")
                //{
                //    int y = (dgv_Pur_Inv.RowCount);
                //    decimal Sumprice = 0;
                //    for (int i = 1; i < y; i++)
                //    {


                //        decimal x = Convert.ToInt16(dgv_Pur_Inv.Rows[i - 1].Cells[6].Value);
                //        Sumprice = Sumprice + x;
                //    }
                //    txt_Total_Cost.Text = Sumprice.ToString();
                //}
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_Discount.Text) == "")
                {
                    txt_Discount.Text = "0";
                }
                if (Convert.ToDecimal(txt_Discount.Text) != 0)
                {
                    decimal After_Discount = (Convert.ToDecimal(txt_Total_Cost.Text))-((Convert.ToDecimal(txt_Total_Cost.Text)) * (Convert.ToDecimal(txt_Discount.Text)) / 100);
                    txt_Total_Cost_Disc.Text = After_Discount.ToString();
                }
                else
                {
                    txt_Total_Cost_Disc.Text = txt_Total_Cost.Text;
                }
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void btn_Del_Itm_Click(object sender, EventArgs e)
        {
            try
            {
                int rowcount = dgv_Pur_Inv.Rows.Count - 1;
                if (rowcount > 0)
                {
                    dgv_Pur_Inv.Rows.Remove(dgv_Pur_Inv.CurrentRow);
                }
                else
                {
                    MessageBox.Show("no rows found to delete");
                }
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        

        
    }
}
