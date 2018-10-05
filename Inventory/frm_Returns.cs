using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
namespace Inventory
{
    public partial class frm_Returns : Form
    {
        public string edit_or_add = "";
        public int IID;
        public frm_Returns(string m)
        {
            InitializeComponent();
            edit_or_add = m;
        }
        public frm_Returns(int x, string m)
        {
            InitializeComponent();
            edit_or_add = m;
            IID = x;
        }




        SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");

        private void frm_Returns_Load(object sender, EventArgs e)
        {
            cbo_Create_By_Load();
            cbo_Returns_Stores_Load();

            if (edit_or_add == "add")
            {
                grd_Create_Columns();
                txt_Return_ID();
            }
            else if (edit_or_add == "edit")
            {
                Show_All_Return_Details();



            }
            else if (edit_or_add == "view")
            {
                Show_All_Return_Details();
                dgv_Itm_Returned.Enabled = false;
                btn_Load_items.Enabled = false;
                cbo_Created_By.Enabled = false;
                cbo_Store.Enabled = false;
                txt_Notes.Enabled = false;
                dtp_Created_At.Enabled = false;
            }


        }
        DataTable DT_Qty = new DataTable();
        Hashtable dt = new Hashtable();
        private void Show_All_Return_Details()
        {

            SqlCommand cmd = new SqlCommand("SELECT [Emp_ID],[Created_At],[Notes],[Sto_ID] ,[Sal_Inv_ID] FROM [dbo].[Add_Returns] where [Ret_ID]=@ID", Conn);
            cmd.Parameters.AddWithValue("@ID", IID);
            SqlDataAdapter dad_Edit = new SqlDataAdapter(cmd);
            DataTable DT_Edit = new DataTable();
            dad_Edit.Fill(DT_Edit);
            DataRow row_Edit = DT_Edit.Rows[0];
            txt_Return_no.Enabled = false;
            txt_Inv_No.Enabled = false;
            txt_Return_no.Text = IID.ToString();
            txt_Inv_No.Text = row_Edit[4].ToString();
            cbo_Store.SelectedValue = row_Edit[3];
            cbo_Created_By.SelectedValue = row_Edit[0];
            dtp_Created_At.Value = Convert.ToDateTime(row_Edit[1]);
            txt_Notes.Text = row_Edit[2].ToString();

            SqlCommand cmd_Qty = new SqlCommand("exec show_Return_Itms @Ret_ID", Conn);
            cmd_Qty.Parameters.AddWithValue("@Ret_ID", txt_Return_no.Text);
            SqlDataAdapter dad_Qty = new SqlDataAdapter(cmd_Qty);

            dad_Qty.Fill(DT_Qty);

            dgv_Itm_Returned.DataSource = DT_Qty;
            foreach (DataRow item in DT_Qty.Rows)
            {
                dt.Add(item["Itm_ID"].ToString() , item["Total_Qty"].ToString());
            }

        }

        private void grd_Create_Columns()
        {
            dgv_Itm_Returned.ColumnCount = 7;
            dgv_Itm_Returned.Columns[0].Name = "Item_ID";
            dgv_Itm_Returned.Columns[1].Name = "Item_Name";
            dgv_Itm_Returned.Columns[2].Name = "Big_Unit";
            dgv_Itm_Returned.Columns[3].Name = "B_Qty";
            dgv_Itm_Returned.Columns[4].Name = "Small_Unit";
            dgv_Itm_Returned.Columns[5].Name = "S_Qty";
            dgv_Itm_Returned.Columns[6].Name = "Total_Qty";
        }

        private void cbo_Returns_Stores_Load()
        {
            SqlCommand Cmd = new SqlCommand("select [Sto_ID],[Store].[Name]as st_Name from [dbo].[Store], [dbo].[Store_Category]  where[Store].Sto_Cat_ID=[Store_Category].Sto_Cat_ID and [Store_Category].Name='returns'", Conn);
            SqlDataAdapter dad = new SqlDataAdapter(Cmd);
            DataTable DT = new DataTable();
            dad.Fill(DT);
            cbo_Store.DataSource = DT;
            cbo_Store.ValueMember = "Sto_ID";
            cbo_Store.DisplayMember = "st_Name";
            cbo_Store.SelectedIndex = -1;
        }

        private void Show_Customer_Name()
        {

            try
            {

                if (existss == "*")
                {
                    SqlCommand Cmd = new SqlCommand("select  [Name] from [dbo].[Sales_Invoice] ,[dbo].[Customer] where [Customer].Cust_ID=[Sales_Invoice].Cust_ID and [Sal_Inv_ID]=@inv_NUM2", Conn);
                    Cmd.Parameters.AddWithValue("@inv_NUM2", int.Parse(txt_Inv_No.Text));
                    SqlDataAdapter dad = new SqlDataAdapter(Cmd);
                    DataTable DT = new DataTable();
                    dad.Fill(DT);
                    DataRow row = DT.Rows[0];
                    txt_Customer.Text = row[0].ToString();

                }
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }


        }

        private void txt_Return_ID()
        {
            try
            {
                String Query = " declare @X int=(Select Count([Ret_ID]) from[dbo].[Add_Returns])  if(@X=0) select 1  else (Select max([Ret_ID])+1 from[dbo].[Add_Returns])";
                SqlCommand Cmd = new SqlCommand(Query, Conn);
                SqlDataAdapter dad = new SqlDataAdapter(Cmd);
                DataTable DT = new DataTable();
                dad.Fill(DT);
                DataRow row = DT.Rows[0];
                txt_Return_no.Text = row[0].ToString();
                txt_Return_no.Enabled = false;
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void cbo_Create_By_Load()
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbo_Created_By.Text == "" || cbo_Store.Text == "")
                {
                    MessageBox.Show("you should complete all fields ");
                }
                else
                {

                    if (existss != "*")
                    {
                        MessageBox.Show("invalid sales invoice no ");
                    }
                    else if (existss == "*")
                    {
                        if (edit_or_add == "add")
                        {
                            insert_Returns_And_Its_Items();
                            frm_Find_Return f = new frm_Find_Return();
                            f.Show();
                            this.Close();

                        }
                        else if (edit_or_add == "edit")
                        {
                            try
                            {
                                update_Returns_Without_Its_Items();

                                // first delete return details (items)
                                Delete_all_Return_Items();
                                //then insertohm mn 2wel w gdeed 
                                Insert_fromDGV_toDB();
                                MessageBox.Show("Edited");
                                gbo_Add_Itm.Enabled = false;
                                btn_Load_items.Enabled = true;
                                txt_Inv_No.Text = "";

                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }

            }

            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }





            //foreach (DataGridViewRow item in dgv_Itm_Returned.Rows)
            //{
            //    string sql = "Insert Into Add_Returns_Details values( " + txt_Return_no.ToString() + " , " + item.Cells[0].ToString() + " , " + item.Cells[6].ToString() + ")";
            //    SqlCommand Cmd = new SqlCommand(sql, Conn);
            //    if (Conn.State != ConnectionState.Open)
            //        Conn.Open();
            //    Cmd.ExecuteNonQuery();
            //    Conn.Close();
            //}

        }

        private void Delete_all_Return_Items()
        {
            /// hgeeb kol el items elly mwgoda  gwa el return w 27othm fe data table  3shan 2lf 3leehom 2ms7hom wa7ed wa7ed
            int currentID = Convert.ToInt32(txt_Return_no.Text);
            SqlCommand Cmd = new SqlCommand("SELECT [Ret_ID] ,[Itm_Sub_ID] ,[Qty] FROM [dbo].[Add_Returns_Details] where [Ret_ID]=@Ret_ID", Conn);
            Cmd.Parameters.AddWithValue("@Ret_ID", currentID);
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
            //int Rows_Count = dgv_Itm_Returned.Rows.Count;
            //for (int i = 0; i < Rows_Count; i++)
            //{
            //    SqlCommand Cmd_Item = new SqlCommand("DELETE FROM [dbo].[Add_Returns_Details] WHERE  [Ret_ID]=@Ret_ID and [Itm_Sub_ID]=@Itm_Sub_ID", Conn);
            //    Cmd_Item.Parameters.AddWithValue("@Ret_ID", int.Parse(txt_Return_no.Text));
            //    Cmd_Item.Parameters.AddWithValue("@Itm_Sub_ID", int.Parse(dgv_Itm_Returned.Rows[i].Cells[0].Value.ToString()));

            //    if (Conn.State != ConnectionState.Open)
            //        Conn.Open();
            //    Cmd_Item.ExecuteNonQuery();
            //    Conn.Close();

            //}
        }

        private void update_Returns_Without_Its_Items()
        {
            try
            {
                SqlCommand Cmd = new SqlCommand("UPDATE [dbo].[Add_Returns] SET [Emp_ID] = @Emp_ID ,[Created_At] =@Created_At  ,[Notes] =@Notes   ,[Sto_ID] =@Sto_ID  ,[Sal_Inv_ID] = @Sal_Inv_ID  WHERE  [Ret_ID]=@Rett_ID", Conn);
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@Rett_ID", int.Parse(txt_Return_no.Text));
                Cmd.Parameters.AddWithValue("@Emp_ID", int.Parse(cbo_Created_By.SelectedValue.ToString()));
                Cmd.Parameters.AddWithValue("@Created_At", Convert.ToDateTime(dtp_Created_At.Text));
                Cmd.Parameters.AddWithValue("@Notes", txt_Notes.Text);
                Cmd.Parameters.AddWithValue("@Sto_ID", int.Parse(cbo_Store.SelectedValue.ToString()));
                Cmd.Parameters.AddWithValue("@Sal_Inv_ID", int.Parse(txt_Inv_No.Text));

                if (Conn.State != ConnectionState.Open)
                    Conn.Open();
                Cmd.ExecuteNonQuery();
                Conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void insert_Returns_And_Its_Items()
        {
            try
            {
                SqlCommand Cmd = new SqlCommand("INSERT INTO [dbo].[Add_Returns] VALUES (@Rett_ID,@Emp_ID,@Created_At,@Notes,@Sto_ID,@Sal_Inv_ID)", Conn);
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@Rett_ID", int.Parse(txt_Return_no.Text));
                Cmd.Parameters.AddWithValue("@Emp_ID", cbo_Created_By.SelectedValue);
                Cmd.Parameters.AddWithValue("@Created_At", Convert.ToDateTime(dtp_Created_At.Text));
                Cmd.Parameters.AddWithValue("@Notes", txt_Notes.Text);
                Cmd.Parameters.AddWithValue("@Sto_ID", cbo_Store.SelectedValue);
                Cmd.Parameters.AddWithValue("@Sal_Inv_ID", int.Parse(txt_Inv_No.Text));

                if (Conn.State != ConnectionState.Open)
                    Conn.Open();
                Cmd.ExecuteNonQuery();
                Conn.Close();


                Insert_fromDGV_toDB();
                MessageBox.Show("added");



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Insert_fromDGV_toDB()
        {
            int Rows_Count = dgv_Itm_Returned.Rows.Count;
            for (int i = 0; i < Rows_Count; i++)
            {
                SqlCommand Cmd_Item = new SqlCommand("  INSERT INTO [dbo].[Add_Returns_Details] VALUES  (@Ret_ID  ,@Itm_Sub_ID ,@Qty)", Conn);
                Cmd_Item.Parameters.AddWithValue("@Ret_ID", int.Parse(txt_Return_no.Text));
                Cmd_Item.Parameters.AddWithValue("@Itm_Sub_ID", int.Parse(dgv_Itm_Returned.Rows[i].Cells[0].Value.ToString()));
                Cmd_Item.Parameters.AddWithValue("@Qty", int.Parse(dgv_Itm_Returned.Rows[i].Cells[6].Value.ToString()));
                if (Conn.State != ConnectionState.Open)
                    Conn.Open();
                Cmd_Item.ExecuteNonQuery();
                Conn.Close();


            }
        }
        String existss;


        private void txt_Inv_No_TextChanged(object sender, EventArgs e)
        {

            if (!String.IsNullOrWhiteSpace(txt_Inv_No.Text))
            {
                txt_Customer.Text = "";
                SqlCommand Cmd = new SqlCommand("exec Exist_Invoice @inv_NUM ", Conn);
                Cmd.Parameters.AddWithValue("@inv_NUM", int.Parse(txt_Inv_No.Text));
                SqlDataAdapter dad = new SqlDataAdapter(Cmd);
                DataTable DT = new DataTable();
                dad.Fill(DT);
                DataRow row = DT.Rows[0];
                existss = row[0].ToString();
                if (existss == "*")
                {
                    lbl_Exist_Invoice.ForeColor = Color.Green;
                }
                else
                {
                    lbl_Exist_Invoice.ForeColor = Color.Red;
                }
                lbl_Exist_Invoice.Text = existss;
                Show_Customer_Name();
            }
            else
            {
                txt_Customer.Text = "";
                lbl_Exist_Invoice.Text = "";
            }
        }

        private void dgv_Itm_Returned_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_Customer_TextChanged(object sender, EventArgs e)
        {

        }
        int Row_incremental = 0;
        private bool FormValidate_Details()
        {
            if (String.IsNullOrWhiteSpace(txt_Qty_Big_Unit.Text) || String.IsNullOrWhiteSpace(txt_Qty_Small_Unit.Text) || String.IsNullOrWhiteSpace(cbo_Itm_Name.Text))
                return false;

            else
                return true;
        }

        private int CheckItemExistance(int ItemID)
        {
            try
            {
                foreach (DataGridViewRow CurrentRow in dgv_Itm_Returned.Rows)
                {
                    if (Convert.ToInt32(CurrentRow.Cells[0].Value) == ItemID)
                    {
                        return Convert.ToInt32(CurrentRow.Cells[0].RowIndex);
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

        private void btn_Add_Itm_Click(object sender, EventArgs e)
        {
            if (!FormValidate_Details())
            {
                MessageBox.Show(" you must select from itm box and  insert data into Qty ");
            }
            else
            {  ///labels
                SqlCommand Cmd = new SqlCommand("DECLARE	@Qty int EXEC	[dbo].[PRO_Itm_Qty] @Qty_Unit = @Qty_Unitt,@Qty_Smallest_Unit = @Qty_Smallest_Unitt,@Itm_ID = @Itm_IDD,@Qty = @Qty OUTPUT SELECT	@Qty as Total_Quantity", Conn);
                Cmd.Parameters.AddWithValue("@Qty_Unitt", int.Parse(txt_Qty_Big_Unit.Text));
                Cmd.Parameters.AddWithValue("@Qty_Smallest_Unitt", int.Parse(txt_Qty_Small_Unit.Text));
                Cmd.Parameters.AddWithValue("@Itm_IDD", cbo_Itm_Name.SelectedValue);
                SqlDataAdapter dad = new SqlDataAdapter(Cmd);
                DataTable DT = new DataTable();
                dad.Fill(DT);
                DataRow row = DT.Rows[0];


                ///////////////////////////////////////////////////////////////////////////////////

                ///max Qty at roow[0]
                SqlCommand Cmdd = new SqlCommand("[Max_Qty_for_Return] @Sal_Inv_ID ,@Itm_Sub_ID", Conn);
                Cmdd.Parameters.AddWithValue("@Sal_Inv_ID", txt_Inv_No.Text);
                Cmdd.Parameters.AddWithValue("@Itm_Sub_ID", cbo_Itm_Name.SelectedValue);
                SqlDataAdapter dadd = new SqlDataAdapter(Cmdd);
                DataTable DTTT = new DataTable();
                dadd.Fill(DTTT);
                DataRow roow = DTTT.Rows[0];
                int x = (int)row[0];
                int y = (int)roow[0];
                ////////////////////////////////////////////////////////////////////////////

                //el shasha add be el item mwgood fe el grid
                int RowSelected = CheckItemExistance(Convert.ToInt32(cbo_Itm_Name.SelectedValue));
                if (RowSelected >= 0 && edit_or_add == "add")
                {


                    if (x > y)
                    {
                        String teext = "max qty to Add" + "  " + roow[0] + "  " + roow[4] + "    or  " + roow[1] + "  " + roow[2] + "  " + roow[3] + "  " + roow[4];
                        MessageBox.Show(teext);
                    }
                    else
                    {
                        dgv_Itm_Returned.Rows[RowSelected].Cells[0].Value = cbo_Itm_Name.SelectedValue;
                        dgv_Itm_Returned.Rows[RowSelected].Cells[1].Value = cbo_Itm_Name.Text;
                        dgv_Itm_Returned.Rows[RowSelected].Cells[2].Value = lbl_Big_Unit.Text;
                        dgv_Itm_Returned.Rows[RowSelected].Cells[3].Value = txt_Qty_Big_Unit.Text;
                        dgv_Itm_Returned.Rows[RowSelected].Cells[4].Value = lbl_Small_Unit.Text;
                        dgv_Itm_Returned.Rows[RowSelected].Cells[5].Value = txt_Qty_Small_Unit.Text;
                        dgv_Itm_Returned.Rows[RowSelected].Cells[6].Value = row[0];

                    }

                }
                //el shasha add be el item msh mwgood fe el grid
                if (RowSelected == -1 && edit_or_add == "add")
                {
                    if (x > y)
                    {
                        String teext = "max qty to Add" + "  " + roow[0] + "  " + roow[4] + "    or  " + roow[1] + "  " + roow[2] + "  " + roow[3] + "  " + roow[4];
                        MessageBox.Show(teext);
                    }
                    else
                    {
                        dgv_Itm_Returned.Rows.Add();
                        dgv_Itm_Returned.Rows[Row_incremental].Cells[0].Value = cbo_Itm_Name.SelectedValue;
                        dgv_Itm_Returned.Rows[Row_incremental].Cells[1].Value = cbo_Itm_Name.Text;
                        dgv_Itm_Returned.Rows[Row_incremental].Cells[2].Value = lbl_Big_Unit.Text;
                        dgv_Itm_Returned.Rows[Row_incremental].Cells[3].Value = txt_Qty_Big_Unit.Text;
                        dgv_Itm_Returned.Rows[Row_incremental].Cells[4].Value = lbl_Small_Unit.Text;
                        dgv_Itm_Returned.Rows[Row_incremental].Cells[5].Value = txt_Qty_Small_Unit.Text;
                        dgv_Itm_Returned.Rows[Row_incremental].Cells[6].Value = row[0];

                        Row_incremental++;
                    }

                }
                //el shasha edit be el item msh mwgood fe el grid
                else if (RowSelected == -1 && edit_or_add == "edit")
                {
                    if (x > y)
                    {
                        String teext = "max qty to Add" + "  " + roow[0] + "  " + roow[4] + "    or  " + roow[1] + "  " + roow[2] + "  " + roow[3] + "  " + roow[4];
                        MessageBox.Show(teext);
                    }
                    else
                    {
                        DataRow row1 = DT_Qty.NewRow();
                        row1[0] = cbo_Itm_Name.SelectedValue;
                        row1[1] = cbo_Itm_Name.Text;
                        row1[2] = lbl_Big_Unit.Text;
                        row1[3] = txt_Qty_Big_Unit.Text;
                        row1[4] = lbl_Small_Unit.Text;
                        row1[5] = txt_Qty_Small_Unit.Text;
                        row1[6] = row[0];
                        DT_Qty.Rows.Add(row1);
                    }
                }
                //el shasha edit be el item  mwgood fe el grid
                else if (RowSelected >= 0 && edit_or_add == "edit")
                {
                    foreach (DataRow item in DT_Qty.Rows)
                    {

                        if (item[0].ToString() == cbo_Itm_Name.SelectedValue.ToString())
                        {
                            Int16 Qty = Convert.ToInt16(dt[item["Itm_ID"].ToString()]);
                            int Total = Qty + y;
                            if (x <= Total)
                            {
                                item[0] = cbo_Itm_Name.SelectedValue;
                                item[1] = cbo_Itm_Name.Text;
                                item[2] = lbl_Big_Unit.Text;
                                item[3] = txt_Qty_Big_Unit.Text;
                                item[4] = lbl_Small_Unit.Text;
                                item[5] = txt_Qty_Small_Unit.Text;
                                item[6] = row[0];
                            }
                            else
                            {
                                MessageBox.Show("Max Quantity is " + Total);
                            }

                        }
                    }
                }




            }



        }

        private void btn_Del_Itm_Click(object sender, EventArgs e)
        {
            int Rows_Count = dgv_Itm_Returned.Rows.Count - 1;
            if (Rows_Count > 0)
            {
                dgv_Itm_Returned.Rows.Remove(dgv_Itm_Returned.CurrentRow);
            }


            //////////txt_Notes.Text =Rows_Count.ToString();
            ////for bl3dad da
            //txt_Notes.Text = dgv_Itm_Returned.Rows[0].Cells[0].Value.ToString();
        }

        private void btn_Load_items_Click(object sender, EventArgs e)
        {

            if (existss == "*")
            {
                gbo_Add_Itm.Enabled = true;
                String Query = "exec [dbo].[PRO_Sales_Inv] @INV_No";
                SqlCommand Cmd = new SqlCommand(Query, Conn);
                Cmd.Parameters.AddWithValue("@INV_No", int.Parse(txt_Inv_No.Text));
                SqlDataAdapter dad = new SqlDataAdapter(Cmd);
                DataTable DT = new DataTable();
                dad.Fill(DT);
                cbo_Itm_Name.DataSource = DT;
                cbo_Itm_Name.ValueMember = "Itm_Sub_ID";
                cbo_Itm_Name.DisplayMember = "Name";
                cbo_Itm_Name.SelectedIndex = -1;
                flag_Unit = true;
                btn_Load_items.Enabled = false;
                txt_Inv_No.Enabled = false;
            }
            else
            {
                MessageBox.Show("not exists invoice No ");
            }
        }

        private void txt_Qty_TextChanged(object sender, EventArgs e)
        {

        }
        bool flag_Unit = false;
        private void cbo_Itm_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag_Unit == true)
            {
                txt_Qty_Big_Unit.Enabled = true;
                txt_Qty_Small_Unit.Enabled = true;
                SqlCommand Cmd = new SqlCommand("SELECT Unt.[Name],Unt.[Smallest_Unit_Name] FROM [dbo].[Units] as Unt,[dbo].[Item_Subcategory] as Itm where Itm.U_ID=Unt.U_ID and Itm.[Itm_Sub_ID]=@Itm_Sub_ID", Conn);
                Cmd.Parameters.AddWithValue("@Itm_Sub_ID", cbo_Itm_Name.SelectedValue);
                SqlDataAdapter dad = new SqlDataAdapter(Cmd);
                DataTable DT = new DataTable();
                dad.Fill(DT);
                DataRow row = DT.Rows[0];
                lbl_Big_Unit.Text = row[0].ToString();
                lbl_Small_Unit.Text = row[1].ToString();
                //flag_Unit = true;
            }



        }

        private void txt_Notes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Inv_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txt_Qty_Big_Unit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txt_Qty_Small_Unit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }






    }
}
