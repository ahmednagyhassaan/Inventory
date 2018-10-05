using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Inventory
{
    public partial class frm_Transferring_From_To : Form
    {

        SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");

        public frm_Transferring_From_To()
        {
            InitializeComponent();
        }
        public string edit_or_add = "";
        public int IID;
        public frm_Transferring_From_To(string m)
        {
            InitializeComponent();
            edit_or_add = m;
        }
        public frm_Transferring_From_To(int x, string m)
        {
            InitializeComponent();
            edit_or_add = m;
            IID = x;
        }

        private void gbo_Add_Itm_Enter(object sender, EventArgs e)
        {

        }
        DataTable DT_Qty = new DataTable();
        Hashtable dt = new Hashtable();
        private void frm_Transferring_From_To_Load(object sender, EventArgs e)
        {
            Load_Cbo_Emp();
            Load_Cbo_Sto_Type_From();

            if (edit_or_add == "add")
            {
                grd_Create_Columns();
                Load_Order_ID();
            }
            else if (edit_or_add == "edit")
            {
                Show_Details();
            }
            else if (edit_or_add == "View")
            {
                gbo_Transfer.Enabled = false;
                gbo_Add_Itm.Enabled = false;
                btn_Load_items.Enabled = false;
                btn_Save.Enabled = false;
                Show_Details();
                dgv_Itm_Transfered.Enabled = false;
            }


        }

        private void Show_Details()
        {
            //SqlCommand cmd = new SqlCommand("SELECT [Tran_ID] ,[Emp_ID] ,[Created_At] ,[Notes] ,[Sto_ID_From] ,[Sto_ID_To] FROM [dbo].[Transfering_From_To] where [Tran_ID]=@Tran_ID", Conn);
            SqlCommand cmd = new SqlCommand("SELECT [Tran_ID] ,[Emp_ID] ,[Created_At] ,[Notes] ,[Sto_ID_From] ,[Sto_Name_From] ,[Sto_Cat_ID_From] ,[Sto_Cat_Name_From] ,[Sto_ID_To] ,[Sto_Name_To] ,[Sto_Cat_Name_To] ,[Sto_Cat_ID_To] FROM [dbo].[Store_Category_View] where [Tran_ID]=@Tran_ID", Conn);

            cmd.Parameters.AddWithValue("@Tran_ID", IID);
            SqlDataAdapter dad_Edit = new SqlDataAdapter(cmd);
            DataTable DT_Edit = new DataTable();
            dad_Edit.Fill(DT_Edit);
            DataRow row_Edit = DT_Edit.Rows[0];
            txt_Transfer_No.Enabled = false;
            txt_Transfer_No.Text = IID.ToString();
            cbo_Created_By.SelectedValue = row_Edit[1];
            dtp_Created_At.Value = Convert.ToDateTime(row_Edit[2]);
            txt_Notes.Text = row_Edit[3].ToString();

            cbo_Sto_Type_From.SelectedValue = row_Edit[6];
            cbo_Sto_Type_From.Enabled = false;
            cbo_Sto_Type_To.SelectedValue = row_Edit[11];
            cbo_Sto_Type_To.Enabled = false;
            cbo_Sto_Name_From.SelectedValue = row_Edit[4];
            cbo_Sto_Name_From.Enabled = false;
            cbo_Sto_Name_To.SelectedValue = row_Edit[8];
            cbo_Sto_Name_To.Enabled = false;

            SqlCommand cmd_Qty = new SqlCommand("exec [dbo].[show_Transfer_Itms] @Tran_ID", Conn);
            cmd_Qty.Parameters.AddWithValue("@Tran_ID", txt_Transfer_No.Text);
            SqlDataAdapter dad_Qty = new SqlDataAdapter(cmd_Qty);
            dad_Qty.Fill(DT_Qty);
            dgv_Itm_Transfered.DataSource = DT_Qty;
            foreach (DataRow item in DT_Qty.Rows)
            {
                dt.Add(item["Itm_ID"].ToString(), item["Total_Qty"].ToString());
            }
        }
        private void grd_Create_Columns()
        {
            dgv_Itm_Transfered.ColumnCount = 7;
            dgv_Itm_Transfered.Columns[0].Name = "Item_ID";
            dgv_Itm_Transfered.Columns[1].Name = "Item_Name";
            dgv_Itm_Transfered.Columns[2].Name = "Big_Unit";
            dgv_Itm_Transfered.Columns[3].Name = "B_Qty";
            dgv_Itm_Transfered.Columns[4].Name = "Small_Unit";
            dgv_Itm_Transfered.Columns[5].Name = "S_Qty";
            dgv_Itm_Transfered.Columns[6].Name = "Total_Qty";
        }

        private void Load_Cbo_Sto_Type_From()
        {
            String Query = "SELECT [Sto_Cat_ID],[Name] FROM [dbo].[Store_Category]";
            SqlCommand Cmd = new SqlCommand(Query, Conn);
            SqlDataAdapter dad = new SqlDataAdapter(Cmd);
            DataTable DT = new DataTable();
            dad.Fill(DT);
            DataRow row = DT.Rows[0];
            cbo_Sto_Type_From.DataSource = DT;
            cbo_Sto_Type_From.ValueMember = "Sto_Cat_ID";
            cbo_Sto_Type_From.DisplayMember = "Name";
            cbo_Sto_Type_From.SelectedIndex = -1;
            flag_Name_From = true;
            flag_Type_To = true;
        }

        private void Load_Cbo_Emp()
        {
            String Query = "SELECT [Emp_ID],[Name] FROM [dbo].[Employee]";
            SqlCommand Cmd = new SqlCommand(Query, Conn);
            SqlDataAdapter dad = new SqlDataAdapter(Cmd);
            DataTable DT = new DataTable();
            dad.Fill(DT);
            DataRow row = DT.Rows[0];
            cbo_Created_By.DataSource = DT;
            cbo_Created_By.ValueMember = "Emp_ID";
            cbo_Created_By.DisplayMember = "Name";
            cbo_Created_By.SelectedIndex = -1;

        }

        private void Load_Order_ID()
        {
            String Query = "declare @X int=(Select Count([Tran_ID]) from [dbo].[Transfering_From_To])  if(@X=0) select 1  else (Select max([Tran_ID])+1 from [dbo].[Transfering_From_To])";
            SqlCommand Cmd = new SqlCommand(Query, Conn);
            SqlDataAdapter dad = new SqlDataAdapter(Cmd);
            DataTable DT = new DataTable();
            dad.Fill(DT);
            DataRow row = DT.Rows[0];
            txt_Transfer_No.Text = row[0].ToString();
        }

        private void dgv_Itm_Transfered_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Load_Cbo_Sto_Name_From()
        {
            String Query_St = "SELECT [Sto_ID],[Name] FROM [dbo].[Store] where [Sto_Cat_ID]=@Sto_Cat_ID";
            SqlCommand Cmd_St = new SqlCommand(Query_St, Conn);
            Cmd_St.Parameters.AddWithValue("@Sto_Cat_ID", cbo_Sto_Type_From.SelectedValue);
            SqlDataAdapter dad_St = new SqlDataAdapter(Cmd_St);
            DataTable DT_St = new DataTable();
            dad_St.Fill(DT_St);
            //DataRow row_St = DT_St.Rows[0];
            cbo_Sto_Name_From.DataSource = DT_St;
            cbo_Sto_Name_From.ValueMember = "Sto_ID";
            cbo_Sto_Name_From.DisplayMember = "Name";
            cbo_Sto_Name_From.SelectedIndex = -1;
            flag_Name_From = true;
        }
        bool flag_Name_From = false;
        bool flag_Type_To = false;

        private void cbo_Sto_Type_From_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(cbo_Created_By.SelectedIndex==-1)

            if (flag_Name_From == true)
            {
                Load_Cbo_Sto_Name_From();

            }

            if (flag_Type_To == true)
            {
                Load_Cbo_Sto_Type_To();
            }



        }

        private void Load_Cbo_Sto_Type_To()
        {
            String Query_St_To = "SELECT dbo.Store_Category.Sto_Cat_ID as Sto_ID , dbo.Store_Category.Name as Name FROM dbo.Store_Category, dbo.Store_Transfer WHERE dbo.Store_Category.Sto_Cat_ID = dbo.Store_Transfer.Store_To and dbo.Store_Transfer.Store_From = @Sto_Cat_ID_From";
            SqlCommand Cmd_St_To = new SqlCommand(Query_St_To, Conn);
            Cmd_St_To.Parameters.AddWithValue("@Sto_Cat_ID_From", cbo_Sto_Type_From.SelectedValue);
            SqlDataAdapter dad_St_To = new SqlDataAdapter(Cmd_St_To);
            DataTable DT_St_To = new DataTable();
            dad_St_To.Fill(DT_St_To);
            //DataRow row_St = DT_St.Rows[0];
            cbo_Sto_Type_To.DataSource = DT_St_To;
            cbo_Sto_Type_To.ValueMember = "Sto_ID";
            cbo_Sto_Type_To.DisplayMember = "Name";
            cbo_Sto_Type_To.SelectedIndex = -1;
            flag_Type_To = true;
            flag_Name_To = true;
        }

        private void btn_Load_items_Click(object sender, EventArgs e)
        {
            if (cbo_Sto_Name_From.SelectedIndex > -1 && cbo_Sto_Name_To.SelectedIndex > -1)
            {
                gbo_Add_Itm.Enabled = true;
                String Query = "SELECT Itm.[Itm_Sub_ID] as Itm_Sub_ID ,Itm.[Name] as Name FROM [dbo].[Item_Subcategory] as Itm , [dbo].[Current_Store] as Sto where Itm.[Itm_Sub_ID]=Sto.[Itm_Sub_ID] AND Sto.[Sto_ID]=@Sto_ID";
                SqlCommand Cmd = new SqlCommand(Query, Conn);
                Cmd.Parameters.AddWithValue("@Sto_ID", cbo_Sto_Name_From.SelectedValue);
                SqlDataAdapter dad = new SqlDataAdapter(Cmd);
                DataTable DT = new DataTable();
                dad.Fill(DT);
                cbo_Itm_Name.DataSource = DT;
                cbo_Itm_Name.ValueMember = "Itm_Sub_ID";
                cbo_Itm_Name.DisplayMember = "Name";
                cbo_Itm_Name.SelectedIndex = -1;
                flag_Unit = true;
                btn_Load_items.Enabled = false;
                groupBox1.Enabled = false;
            }

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
        int Row_incremental = 0;
        private void btn_Add_Itm_Click(object sender, EventArgs e)
        {
            if (!FormValidate_Details())
            {
                MessageBox.Show(" you must select from itm box and  insert data into Qty ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Add_to_Grid();
            }

        }

        private void Add_to_Grid()
        {
            SqlCommand Cmd = new SqlCommand("DECLARE	@Qty int EXEC	[dbo].[PRO_Itm_Qty] @Qty_Unit = @Qty_Unitt,@Qty_Smallest_Unit = @Qty_Smallest_Unitt,@Itm_ID = @Itm_IDD,@Qty = @Qty OUTPUT SELECT	@Qty as Total_Quantity", Conn);
            Cmd.Parameters.AddWithValue("@Qty_Unitt", int.Parse(txt_Qty_Big_Unit.Text));
            Cmd.Parameters.AddWithValue("@Qty_Smallest_Unitt", int.Parse(txt_Qty_Small_Unit.Text));
            Cmd.Parameters.AddWithValue("@Itm_IDD", cbo_Itm_Name.SelectedValue);
            SqlDataAdapter dad = new SqlDataAdapter(Cmd);
            DataTable DT = new DataTable();
            dad.Fill(DT);
            DataRow row = DT.Rows[0];
            ///////////////////////////////////////////////////////////////////////////////////

            SqlCommand Cmdd = new SqlCommand("exec [dbo].[Max_Qty_for_Transfer] @Sto_ID ,@Itm_Sub_ID", Conn);
            Cmdd.Parameters.Clear();
            Cmdd.Parameters.AddWithValue("@Sto_ID", cbo_Sto_Name_From.SelectedValue);
            Cmdd.Parameters.AddWithValue("@Itm_Sub_ID", cbo_Itm_Name.SelectedValue);
            SqlDataAdapter dadd = new SqlDataAdapter(Cmdd);
            DataTable DTT = new DataTable();
            dadd.Fill(DTT);
            DataRow roww = DTT.Rows[0];
            int x = (int)row[0];
            int y = (int)roww[0];
            /////////////////////////////////////////////////////////////////


            int RowSelected = CheckItemExistance(Convert.ToInt32(cbo_Itm_Name.SelectedValue));
            if (RowSelected >= 0 && edit_or_add == "add")
            {
                if (x > y)
                {
                    String text = "max qty to Add" + "  " + roww[0] + "  " + roww[4] + "    or  " + roww[1] + "  " + roww[2] + "  " + roww[3] + "  " + roww[4];
                    MessageBox.Show(text);
                }
                else
                {

                    dgv_Itm_Transfered.Rows[RowSelected].Cells[0].Value = cbo_Itm_Name.SelectedValue;
                    dgv_Itm_Transfered.Rows[RowSelected].Cells[1].Value = cbo_Itm_Name.Text;
                    dgv_Itm_Transfered.Rows[RowSelected].Cells[2].Value = lbl_Big_Unit.Text;
                    dgv_Itm_Transfered.Rows[RowSelected].Cells[3].Value = txt_Qty_Big_Unit.Text;
                    dgv_Itm_Transfered.Rows[RowSelected].Cells[4].Value = lbl_Small_Unit.Text;
                    dgv_Itm_Transfered.Rows[RowSelected].Cells[5].Value = txt_Qty_Small_Unit.Text;
                    dgv_Itm_Transfered.Rows[RowSelected].Cells[6].Value = row[0];

                }

            }
            if (RowSelected == -1 && edit_or_add == "add")
            {
                if (x > y)
                {
                    String text = "max qty to Add" + "  " + roww[0] + "  " + roww[4] + "    or  " + roww[1] + "  " + roww[2] + "  " + roww[3] + "  " + roww[4];
                    MessageBox.Show(text);
                }
                else
                {

                    dgv_Itm_Transfered.Rows.Add();
                    dgv_Itm_Transfered.Rows[Row_incremental].Cells[0].Value = cbo_Itm_Name.SelectedValue;
                    dgv_Itm_Transfered.Rows[Row_incremental].Cells[1].Value = cbo_Itm_Name.Text;
                    dgv_Itm_Transfered.Rows[Row_incremental].Cells[2].Value = lbl_Big_Unit.Text;
                    dgv_Itm_Transfered.Rows[Row_incremental].Cells[3].Value = txt_Qty_Big_Unit.Text;
                    dgv_Itm_Transfered.Rows[Row_incremental].Cells[4].Value = lbl_Small_Unit.Text;
                    dgv_Itm_Transfered.Rows[Row_incremental].Cells[5].Value = txt_Qty_Small_Unit.Text;
                    dgv_Itm_Transfered.Rows[Row_incremental].Cells[6].Value = row[0];

                    Row_incremental++;
                }

            }
            else if (RowSelected == -1 && edit_or_add == "edit")
            {
                if (x > y)
                {
                    String text = "max qty to Add" + "  " + roww[0] + "  " + roww[4] + "    or  " + roww[1] + "  " + roww[2] + "  " + roww[3] + "  " + roww[4];
                    MessageBox.Show(text);
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

        private void btn_Del_Itm_Click(object sender, EventArgs e)
        {
            int Rows_Count = dgv_Itm_Transfered.Rows.Count - 1;
            if (Rows_Count > 0)
            {
                dgv_Itm_Transfered.Rows.Remove(dgv_Itm_Transfered.CurrentRow);
            }
        }


        bool flag_Name_To = false;


        private void cbo_Sto_Type_To_SelectedIndexChanged(object sender, EventArgs e)
        {

            // if (flag_Name_To==true)
            if (cbo_Sto_Type_To.SelectedValue != null)
            {
                if (flag_Name_To == true)
                {
                    String Query_St = "SELECT [Sto_ID],[Name] FROM [dbo].[Store] where [Sto_Cat_ID]=@Sto_Cat_ID";
                    SqlCommand Cmd_St = new SqlCommand(Query_St, Conn);
                    Cmd_St.Parameters.AddWithValue("@Sto_Cat_ID", cbo_Sto_Type_To.SelectedValue);
                    SqlDataAdapter dad_St = new SqlDataAdapter(Cmd_St);
                    DataTable DT_St = new DataTable();
                    dad_St.Fill(DT_St);
                    //DataRow row_St = DT_St.Rows[0];
                    cbo_Sto_Name_To.DataSource = DT_St;
                    cbo_Sto_Name_To.ValueMember = "Sto_ID";
                    cbo_Sto_Name_To.DisplayMember = "Name";
                    cbo_Sto_Name_To.SelectedIndex = -1;
                    flag_Name_To = true;
                }
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbo_Created_By.SelectedIndex == -1 || cbo_Sto_Name_From.SelectedIndex == -1 || cbo_Sto_Name_To.SelectedIndex == -1)
                {
                    MessageBox.Show("You must Choose Employee and Store_From Name and Store_To_Name");
                }
                else
                {
                    if (edit_or_add == "add")
                    {
                        Insert_Transferring_And_Items();
                        frm_Find_Transferring_From_To f = new frm_Find_Transferring_From_To();
                        this.Close();
                        f.Show();
                    }
                    else if (edit_or_add == "edit")
                    {
                        Update_Transferring_Without_Items();

                        // first delete Transferring details (items)
                        Delete_All_Items();
                        ////then insertohm mn 2wel w gdeed 
                        Insert_FromDGV_ToDB();
                        MessageBox.Show("Edited");
                        frm_Find_Transferring_From_To f = new frm_Find_Transferring_From_To();
                        this.Close();
                        f.Show();

                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void Delete_All_Items()
        {
            int Rows_Count = dgv_Itm_Transfered.Rows.Count - 1;
            for (int i = 0; i < Rows_Count; i++)
            {
                SqlCommand Cmd_Item = new SqlCommand("DELETE FROM [dbo].[Transfering_Details] WHERE  [Tran_ID] = @Tran_ID and [Itm_Sub_ID]=@Itm_Sub_ID", Conn);
                Cmd_Item.Parameters.Clear();
                Cmd_Item.Parameters.AddWithValue("@Tran_ID", int.Parse(txt_Transfer_No.Text));
                Cmd_Item.Parameters.AddWithValue("@Itm_Sub_ID", int.Parse(dgv_Itm_Transfered.Rows[i].Cells[0].Value.ToString()));

                if (Conn.State != ConnectionState.Open)
                    Conn.Open();
                Cmd_Item.ExecuteNonQuery();
                Conn.Close();

            }
        }

        private void Update_Transferring_Without_Items()
        {
            try
            {
                SqlCommand Cmd = new SqlCommand("UPDATE [dbo].[Transfering_From_To] SET [Emp_ID] = @Emp_ID ,[Created_At] = @Created_At ,[Notes] = @Notes ,[Sto_ID_From] = @Sto_ID_From ,[Sto_ID_To] = @Sto_ID_To WHERE [Tran_ID] = @Tran_ID", Conn);
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@Tran_ID", int.Parse(txt_Transfer_No.Text));
                Cmd.Parameters.AddWithValue("@Emp_ID", int.Parse(cbo_Created_By.SelectedValue.ToString()));
                Cmd.Parameters.AddWithValue("@Created_At", Convert.ToDateTime(dtp_Created_At.Text));
                Cmd.Parameters.AddWithValue("@Notes", txt_Notes.Text);
                Cmd.Parameters.AddWithValue("@Sto_ID_From", int.Parse(cbo_Sto_Name_From.SelectedValue.ToString()));
                Cmd.Parameters.AddWithValue("@Sto_ID_To", int.Parse(cbo_Sto_Name_To.SelectedValue.ToString()));

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

        private void Insert_Transferring_And_Items()
        {
            SqlCommand Cmd = new SqlCommand("INSERT INTO [dbo].[Transfering_From_To] VALUES (@Tran_ID ,@Emp_ID ,@Created_At ,@Notes ,@Sto_ID_From ,@Sto_ID_To)", Conn);
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Tran_ID", int.Parse(txt_Transfer_No.Text));
            Cmd.Parameters.AddWithValue("@Emp_ID", int.Parse(cbo_Created_By.SelectedValue.ToString()));
            Cmd.Parameters.AddWithValue("@Created_At", Convert.ToDateTime(dtp_Created_At.Text));
            Cmd.Parameters.AddWithValue("@Notes", txt_Notes.Text);
            Cmd.Parameters.AddWithValue("@Sto_ID_From", cbo_Sto_Name_From.SelectedValue);
            Cmd.Parameters.AddWithValue("@Sto_ID_To", cbo_Sto_Name_To.SelectedValue);

            if (Conn.State != ConnectionState.Open)
                Conn.Open();
            Cmd.ExecuteNonQuery();
            Conn.Close();
            Insert_FromDGV_ToDB();
            MessageBox.Show("Added");
        }

        private void Insert_FromDGV_ToDB()
        {
            int Rows_Count = dgv_Itm_Transfered.Rows.Count - 1;
            for (int i = 0; i < Rows_Count; i++)
            {
                SqlCommand Cmd_Item = new SqlCommand("INSERT INTO [dbo].[Transfering_Details] VALUES (@Tran_ID ,@Itm_Sub_ID ,@Qty)", Conn);
                Cmd_Item.Parameters.AddWithValue("@Tran_ID", int.Parse(txt_Transfer_No.Text));
                Cmd_Item.Parameters.AddWithValue("@Itm_Sub_ID", int.Parse(dgv_Itm_Transfered.Rows[i].Cells[0].Value.ToString()));
                Cmd_Item.Parameters.AddWithValue("@Qty", int.Parse(dgv_Itm_Transfered.Rows[i].Cells[6].Value.ToString()));
                if (Conn.State != ConnectionState.Open)
                    Conn.Open();
                Cmd_Item.ExecuteNonQuery();
                Conn.Close();
            }
        }

        private void cbo_Sto_Name_To_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_Sto_Name_From_SelectedIndexChanged(object sender, EventArgs e)
        {
            //btn_Load_items.Enabled = true;

        }
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
                foreach (DataGridViewRow CurrentRow in dgv_Itm_Transfered.Rows)
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

        private void txt_Transfer_No_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
