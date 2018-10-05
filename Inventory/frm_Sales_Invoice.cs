using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory
{
    public partial class frm_Sales_Invoice : Form
    {
        public string new_or_edit = ""; int ID = 0;



        public frm_Sales_Invoice(string name)
        {
            InitializeComponent();
            new_or_edit = name;
        }

        public frm_Sales_Invoice(string name, int nom)
        {
            InitializeComponent();
            new_or_edit = name;
            ID = nom;
        }

        DataBase db = new DataBase();
        bool flage = false;
        bool flage2 = false;

        DataTable dt_grd ;

        private void frm_Sales_Invoice_Load(object sender, EventArgs e)
        {
            txt_Itm_No.Enabled = false;
            txt_DisPrice.Enabled = false;
            db.LoadCbo("select * from[dbo].[Customer]", cbo_Cust_Name, "Name", "Cust_ID");
            db.LoadCbo("select[Emp_ID],[Name] from [dbo].[Employee] where [Dept_ID]=1", cbo_Created_By, "Name", "Emp_ID");
            db.LoadCbo("select * from [dbo].[Payment_Method]", cbo_Pay_Method, "Method_Name", "Pay_Method_ID");
            db.LoadCbo("select [Sto_ID],[Name] from [dbo].[Store] where [Sto_Cat_ID]= 2", cbo_storename, "Name", "Sto_ID");
            db.LoadCbo("select Itm_Cat_ID,Name from [dbo].[Item_Category] where [Type]='true'", cbo_Itm_Cat, "Name", "Itm_Cat_ID");


            flage = true;
            flage2 = false;


          
            if (new_or_edit == "Add")
            {
                dgv_Cust_Inv.ColumnCount = 7;
                dgv_Cust_Inv.Columns[0].Name = "ItemNo";
                dgv_Cust_Inv.Columns[1].Name = "ItemCategory";
                dgv_Cust_Inv.Columns[2].Name = "ItemName";
                dgv_Cust_Inv.Columns[3].Name = "ItemTotalQty";
                dgv_Cust_Inv.Columns[4].Name = "ItemPrice";
                dgv_Cust_Inv.Columns[5].Name = "Discount";
                dgv_Cust_Inv.Columns[6].Name = "FinalPrice";
            }
                

            else if (new_or_edit == "Edit")
            {
                DataTable dt = db.ReturnTable("select[Sal_Inv_ID],[Emp_ID],[Cust_ID],[Created_At],[Discount],[Pay_Method_ID],[Paid],[Total_Cost],[Total_Cost_After_Disc],[Sto_ID],[Notes] from [dbo].[Sales_Invoice] where [Sal_Inv_ID]=" + ID);
                DataRow row = dt.Rows[0];
                cbo_Created_By.SelectedValue = row[1];
                cbo_Cust_Name.SelectedValue = row[2];
                cbo_Pay_Method.SelectedValue = row[5];
                txt_Inv_No.Text = row[0].ToString();
                txt_Notes.Text = row[10].ToString();
                txt_Paid.Text = row[6].ToString();
                txt_Total_Cost.Text = row[7].ToString();
                txt_Discount.Text = row[4].ToString();
                txt_Total_Cost_Disc.Text = row[8].ToString();
                dtp_Inv_Date.Text = row[3].ToString();
               cbo_storename.SelectedValue = row[9];

               dt_grd  = db.ReturnTable("	select * from  [dbo].[Sales_Invoice_Details] where[Sal_Inv_ID] =" + ID);
                dgv_Cust_Inv.DataSource = dt_grd;

            

            }

        }

         public int CheckItemExist (int ItmID)
        {
            try
            {
                foreach (DataGridViewRow currentrow in  dgv_Cust_Inv.Rows)
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
        private void cbo_Itm_Cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flage)
            {
                flage2 = false;
                db.LoadCbo("select * from [dbo].[Item_Subcategory]  where [Itm_Cat_ID]=" + cbo_Itm_Cat.SelectedValue, cbo_Itm_Name, "Name", "Itm_Sub_ID");
                flage2 = true;
            }

        }

        private void cbo_Itm_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flage2)
            {
                txt_Itm_No.Text = cbo_Itm_Name.SelectedValue.ToString();

                DataTable dt = db.ReturnTable("SELECT Unt.[Name],Unt.[Smallest_Unit_Name] FROM [dbo].[Units] as Unt,[dbo].[Item_Subcategory] as Itm where Itm.U_ID=Unt.U_ID and Itm.[Itm_Sub_ID]="+ cbo_Itm_Name.SelectedValue);
           

                DataRow row = dt.Rows[0];
                lbl_bigunit.Text = row[0].ToString();
                lbl_SmallUnit.Text = row[1].ToString();

            }
        }

        int incerment=0;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               //DataTable dt_cus_grd = db.ReturnTable("	select * from  [dbo].[Sales_Invoice_Details] where[Sal_Inv_ID] =" + ID);
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
                DataTable dt = db.ReturnTable("DECLARE @Qty int EXEC [dbo].[PRO_Itm_Qty] @Qty_Unit = '" + int.Parse(txt_BigQty.Text) + "',@Qty_Smallest_Unit ='" + int.Parse(txt_Smallunit.Text) + "' ,@Itm_ID = '" + cbo_Itm_Name.SelectedValue + "',@Qty = @Qty OUTPUT SELECT @Qty as Total_Quantity");
                DataRow row = dt.Rows[0];
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
                                int x = (int.Parse(txt_ItemPrice.Text) - ((int.Parse(txt_ItemPrice.Text)) * (int.Parse(txt_ItemDiscount.Text)) / 100));
                                txt_DisPrice.Text = x.ToString();
                            }
                            else
                            {
                                int x = (int.Parse(txt_ItemPrice.Text));
                                txt_DisPrice.Text = x.ToString();
                            }
                            dgv_Cust_Inv.Rows.Add();
                            dgv_Cust_Inv.Rows[incerment].Cells[0].Value = txt_Itm_No.Text;
                            dgv_Cust_Inv.Rows[incerment].Cells[3].Value = row[0];
                            dgv_Cust_Inv.Rows[incerment].Cells[1].Value = cbo_Itm_Cat.Text;
                            dgv_Cust_Inv.Rows[incerment].Cells[2].Value = cbo_Itm_Name.Text;
                            dgv_Cust_Inv.Rows[incerment].Cells[4].Value = txt_DisPrice.Text;
                            dgv_Cust_Inv.Rows[incerment].Cells[5].Value = txt_ItemDiscount.Text;
                            int y = Convert.ToInt32(row[0]);
                            decimal total = ((int.Parse(txt_DisPrice.Text)) * y);
                            dgv_Cust_Inv.Rows[incerment].Cells[6].Value = total.ToString();
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
                    dgv_Cust_Inv.Rows[selected].Cells[0].Value = txt_Itm_No.Text;
                    //int z = Convert.ToInt32(dgv_Pur_Inv.Rows[selected].Cells[1].Value);
                    //int p = Convert.ToInt32(row[0]);
                    dgv_Cust_Inv.Rows[selected].Cells[3].Value = row[0];

                    dgv_Cust_Inv.Rows[selected].Cells[1].Value = cbo_Itm_Cat.Text;
                    dgv_Cust_Inv.Rows[selected].Cells[2].Value = cbo_Itm_Name.Text;
                    dgv_Cust_Inv.Rows[selected].Cells[4].Value = txt_DisPrice.Text;
                    dgv_Cust_Inv.Rows[selected].Cells[5].Value = txt_ItemDiscount.Text;
                    int y = Convert.ToInt32(row[0]);
                    decimal total = ((int.Parse(txt_DisPrice.Text)) * y);
                    dgv_Cust_Inv.Rows[selected].Cells[6].Value = total.ToString();
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

                            DataRow newRow = dt_grd.NewRow();
                            newRow[0] = txt_Inv_No.Text;
                            newRow[1] = Convert.ToInt32(cbo_Itm_Name.SelectedValue);
                            //newRow[2] = cbo_Itm_Cat.Text;
                            //newRow[3] = cbo_Itm_Name.Text;


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
                            newRow[2] = txt_DisPrice.Text;
                            newRow[3] = row[0];
                            newRow[4] = txt_ItemDiscount.Text;
                            int y = Convert.ToInt32(row[0]);
                            decimal total = ((int.Parse(txt_DisPrice.Text)) * y);
                            newRow[5] = total.ToString();
                           
                           
                            
                            //newRow[8] = cbo_Cust_Name.SelectedValue;
                            //newRow[9] = cbo_Cust_Name.Text;

                            dt_grd.Rows.Add(newRow);
                            dgv_Cust_Inv.DataSource = dt_grd;
                        }
                    }
                }
          
             else if (selected >= 0 && new_or_edit == "Edit")
                    {
                        foreach (DataRow selrows in dt_grd.Rows)
                        {
                            if (selrows[1].ToString() == (cbo_Itm_Name.SelectedValue).ToString())
                            {


                                selrows[1] = Convert.ToInt32(cbo_Itm_Name.SelectedValue);
                                //selrows[2] = cbo_Itm_Cat.Text;
                                //selrows[3] = cbo_Itm_Name.Text;
                                
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
                                     selrows[2] = txt_DisPrice.Text;
                                     selrows[4] = txt_ItemDiscount.Text;
                                     selrows[5] = total.ToString();
                                }

                                //int z = Convert.ToInt32(selrows[4]);
                             //int p = Convert.ToInt32(row[0]);

                                selrows[3] = row[0];
                                selrows[0] = txt_Inv_No.Text;

                                //selrows[8] =  cbo_Cust_Name.SelectedValue;
                                //selrows[9] =  cbo_Cust_Name .Text;
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

        private void insert_grid_into_db(int y)
        {
            try
            {
                for (int i = 0; i < y - 1; i++)
                {
                    SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");

                    SqlCommand cmd_Item = new SqlCommand(" insert into [dbo].[Sales_Invoice_Details]  values (@invoicenooo,@item_sup_no,@price,@finalqty,@discount,@finalprice)", conn);
                   cmd_Item.Parameters.Clear();
                   cmd_Item.Parameters.AddWithValue("@invoicenooo", int.Parse(txt_Inv_No.Text));
                  
                    cmd_Item.Parameters.AddWithValue("@item_sup_no", int.Parse(dgv_Cust_Inv .Rows[i].Cells[0].Value.ToString()));
                    cmd_Item.Parameters.AddWithValue("@price", Convert.ToDecimal(dgv_Cust_Inv .Rows[i].Cells[4].Value.ToString()));
                    cmd_Item.Parameters.AddWithValue("@finalqty", Convert.ToInt64(dgv_Cust_Inv .Rows[i].Cells[3].Value.ToString()));
                    cmd_Item.Parameters.AddWithValue("@discount", Convert.ToDecimal(dgv_Cust_Inv .Rows[i].Cells[5].Value.ToString()));
                    cmd_Item.Parameters.AddWithValue("@finalprice", Convert.ToDecimal(dgv_Cust_Inv .Rows[i].Cells[6].Value.ToString()));


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


        private void insert_edit_grid_into_db(int y)
        {
            try
            {
                for (int i = 0; i < y - 1; i++)
                {
                    SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");

                    SqlCommand cmd_Item = new SqlCommand(" insert into [dbo].[Sales_Invoice_Details]  values (@invoicenooo,@item_sup_no,@price,@finalqty,@discount,@finalprice)", conn);
                    cmd_Item.Parameters.Clear();
                    cmd_Item.Parameters.AddWithValue("@invoicenooo", int.Parse(txt_Inv_No.Text));

                    cmd_Item.Parameters.AddWithValue("@item_sup_no", int.Parse(dgv_Cust_Inv.Rows[i].Cells[1].Value.ToString()));
                    cmd_Item.Parameters.AddWithValue("@price", Convert.ToDecimal(dgv_Cust_Inv.Rows[i].Cells[2].Value.ToString()));
                    cmd_Item.Parameters.AddWithValue("@finalqty", Convert.ToInt64(dgv_Cust_Inv.Rows[i].Cells[3].Value.ToString()));
                    cmd_Item.Parameters.AddWithValue("@discount", Convert.ToDecimal(dgv_Cust_Inv.Rows[i].Cells[4].Value.ToString()));
                    cmd_Item.Parameters.AddWithValue("@finalprice", Convert.ToDecimal(dgv_Cust_Inv.Rows[i].Cells[5].Value.ToString()));


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
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                int y = (dgv_Cust_Inv.RowCount);
                if (txt_Inv_No.Text ==  string.Empty)
                {
                    MessageBox.Show("please you Must Enter Invoice Nomber");
                }
                else if (cbo_Pay_Method.SelectedItem == null)
                    {
                        MessageBox.Show("please Select Payment Method");
                    }
                   
                else if ( cbo_Cust_Name.Text ==  string.Empty)
                    {
                        MessageBox.Show("please Select Supplier Name");
                    }
                else if (cbo_storename.SelectedItem == null)
                    {
                        MessageBox.Show("please Select Store Name");
                    }
                else if (cbo_Created_By.SelectedItem == null)
                    {
                        MessageBox.Show("please Select Employee Name");
                    }
                else if (txt_Inv_No.Text ==  string.Empty)
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
                            

                            decimal x = Convert.ToInt64(dgv_Cust_Inv.Rows[i - 1].Cells[6].Value);
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


                    SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");

                    SqlCommand cmd = new SqlCommand("insert into[dbo].[Sales_Invoice]   values (@invoiceno,@empname,@cusstomerno,@invdate,@discount,@paymethodno,@Paid,@totalcost,@totcostfinal,@storeid,@notes)", Conn);
                        cmd.Parameters.AddWithValue("@invoiceno", int.Parse(txt_Inv_No.Text));
                       cmd.Parameters.AddWithValue("@cusstomerno", int.Parse(cbo_Cust_Name .SelectedValue.ToString()));
                        cmd.Parameters.AddWithValue("@paymethodno", int.Parse(cbo_Pay_Method.SelectedValue.ToString()));
                        cmd.Parameters.AddWithValue("@empname", cbo_Created_By.SelectedValue);
                        cmd.Parameters.AddWithValue("@invdate", Convert.ToDateTime(dtp_Inv_Date.Text));
                        cmd.Parameters.AddWithValue("@Paid", Convert.ToDecimal(txt_Paid.Text));
                        cmd.Parameters.AddWithValue("@totalcost", Convert.ToDecimal(txt_Total_Cost.Text));
                        cmd.Parameters.AddWithValue("@discount", Convert.ToDecimal(txt_Discount.Text));
                        cmd.Parameters.AddWithValue("@totcostfinal", Convert.ToDecimal(txt_Total_Cost_Disc.Text));
                        cmd.Parameters.AddWithValue("@storeid", int.Parse(cbo_storename.SelectedValue.ToString()));
                        cmd.Parameters.AddWithValue("@notes", txt_Notes.Text);

                        if (Conn.State != ConnectionState.Open)
                        {
                           Conn.Open();
                        }
                        cmd.ExecuteNonQuery();
                        Conn.Close();


                        insert_grid_into_db(y);
                        MessageBox.Show("added successfully");
                    }


                    else if (new_or_edit == "Edit")
                    {SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");

                        SqlCommand cmd = new SqlCommand("UPDATE [dbo].[Sales_Invoice] SET [Sal_Inv_ID] = @invoiceno,[Cust_ID] = @cus_no,[Pay_Method_ID] = @paymethodno,[Emp_ID] = @empid ,[Created_At] = @invdate,[Paid] = @Paid,[Total_Cost] = @totalcost,[Discount] = @discount,[Total_Cost_After_Disc] = @totcostfinal ,[Sto_ID] = @storeid,[Notes] = @notes  WHERE [Sal_Inv_ID]= @invoiceno ", Conn);
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@invoiceno", ID);
                      cmd.Parameters.AddWithValue("@cus_no", int.Parse( cbo_Cust_Name .SelectedValue.ToString()));
                        cmd.Parameters.AddWithValue("@paymethodno", int.Parse(cbo_Pay_Method.SelectedValue.ToString()));
                        cmd.Parameters.AddWithValue("@empid", cbo_Created_By.SelectedValue);
                        cmd.Parameters.AddWithValue("@invdate", Convert.ToDateTime(dtp_Inv_Date.Text.ToString()));
                        cmd.Parameters.AddWithValue("@Paid", Convert.ToDecimal(txt_Paid.Text));
                        cmd.Parameters.AddWithValue("@totalcost", Convert.ToDecimal(txt_Total_Cost.Text));
                        cmd.Parameters.AddWithValue("@discount", Convert.ToDecimal(txt_Discount.Text));
                        cmd.Parameters.AddWithValue("@totcostfinal", Convert.ToDecimal(txt_Total_Cost_Disc.Text));
                        cmd.Parameters.AddWithValue("@storeid", int.Parse(cbo_storename.SelectedValue.ToString()));
                        cmd.Parameters.AddWithValue("@notes", txt_Notes.Text);
                        if (Conn.State != ConnectionState.Open)
                        {
                            Conn.Open();
                        }
                        cmd.ExecuteNonQuery();
                        Conn.Close();
                        for (int i = 0; i < y; i++)
                        {


                            SqlCommand Cmd = new SqlCommand(" DELETE FROM [dbo].[Sales_Invoice_Details] WHERE  [Sal_Inv_ID]=@Inv_ID  and[Itm_Sub_ID]=@Item_ID", Conn);
                            Cmd.Parameters.Clear();
                            Cmd.Parameters.AddWithValue("@Inv_ID", ID);
                         
                            Cmd.Parameters.AddWithValue("@Item_ID", Convert.ToInt32(dgv_Cust_Inv.Rows[i].Cells[1].Value));
                            if (Conn.State != ConnectionState.Open)
                            {
                                Conn.Open();
                            }
                            Cmd.ExecuteNonQuery();
                            Conn.Close();
                        }
                        insert_edit_grid_into_db(y);
                        MessageBox.Show("Updated successfully");

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

                if (new_or_edit == "Add" )
                {

                    int y = (dgv_Cust_Inv.RowCount);
                    Decimal Sumprice = 0;
                    for (int i = 1; i < y; i++)
                    {


                        decimal x = Convert.ToInt64(dgv_Cust_Inv.Rows[i - 1].Cells[6].Value);
                        Sumprice = Sumprice + x;
                    }
                    txt_Total_Cost.Text = Sumprice.ToString();
                }
                else if(new_or_edit == "Edit")
                {

                    int y = (dgv_Cust_Inv.RowCount);
                    Decimal Sumprice = 0;
                    for (int i = 1; i < y; i++)
                    {


                        decimal x = Convert.ToInt64(dgv_Cust_Inv.Rows[i - 1].Cells[5].Value);
                        Sumprice = Sumprice + x;
                    }
                    txt_Total_Cost.Text = Sumprice.ToString();
                }
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void btn_exefinalprice_Click(object sender, EventArgs e)
        {
            try
            {
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
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void gbo_Add_Itm_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        }

       

     

     

    }


