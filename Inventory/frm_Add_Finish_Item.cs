using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Inventory
{
    public partial class frm_Add_Finish_Item : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");

        public bool Flag_consist_Cat = false;

        public frm_Add_Finish_Item(string m)
        {
            InitializeComponent();
            edit_or_add = m;
        }
        public frm_Add_Finish_Item(int x , string m)
        {
            InitializeComponent();
            edit_or_add = m;
            IID = x;
        }
        public string edit_or_add = "";
        public int IID;

        private void frm_Add_Finish_Item_Load(object sender, EventArgs e)
        {
            cbo_Cat_Load();
            cbo_unit_load();
            cbo_consist_pure_cat_Load();
            if (edit_or_add == "add")
            {
                dgv_Consist.ColumnCount = 3;
                dgv_Consist.Columns[0].Name = "ItemID";
                dgv_Consist.Columns[1].Name = "Item Name";
                dgv_Consist.Columns[2].Name = "Qty";
            }
            if (edit_or_add == "view")
            {
                Show_Details();
                groupBox1.Enabled = false;
                
            }
            if (edit_or_add == "edit")
            {
                Show_Details();
            

            }
           
        }
        DataTable color_DT;
        DataTable size_DT;
        DataTable consist_DT;
        private void Show_Details()
        {
            //Show colors
            SqlCommand CMd = new SqlCommand("SELECT  [Color] FROM [dbo].[Item_Color] where [Itm_Sub_ID]=@Itm_Sub_ID", conn);
            CMd.Parameters.Clear();
            CMd.Parameters.AddWithValue("@Itm_Sub_ID", IID);
            color_DT=Return_datatable_value(CMd);
            lst_Colors.DataSource =color_DT ;
            lst_Colors.DisplayMember = "Color";

            //show sizes
            SqlCommand CMdd = new SqlCommand("SELECT [Size] FROM [dbo].[Item_Size] where [Itm_Sub_ID]=@Itm_Sub_ID", conn);
            CMdd.Parameters.Clear();
            CMdd.Parameters.AddWithValue("@Itm_Sub_ID", IID);
            size_DT = Return_datatable_value(CMdd);
            lst_Sizes.DataSource = size_DT;
            lst_Sizes.DisplayMember = "Size";
            //show consist of 
            SqlCommand CMddd = new SqlCommand("SELECT        dbo.Finish_Pure_Item.Itm_Sub_ID_Pure, dbo.Item_Category.Name AS Category, dbo.Item_Subcategory.Name , dbo.Finish_Pure_Item.Qty  FROM            dbo.Finish_Pure_Item INNER JOIN dbo.Item_Subcategory ON dbo.Finish_Pure_Item.Itm_Sub_ID_Pure = dbo.Item_Subcategory.Itm_Sub_ID INNER JOIN    dbo.Item_Category ON dbo.Item_Subcategory.Itm_Cat_ID = dbo.Item_Category.Itm_Cat_ID   WHERE        (dbo.Finish_Pure_Item.Itm_Sub_ID_Finish = @Itm_Sub_ID)", conn);
            CMddd.Parameters.Clear();
            CMddd.Parameters.AddWithValue("@Itm_Sub_ID", IID);
             consist_DT= Return_datatable_value(CMddd);
             dgv_Consist.DataSource=consist_DT;
            //show b2y el shasha
            SqlCommand CMdddd = new SqlCommand("SELECT [Name] ,[Min_At_Store] ,[Itm_Cat_ID] ,[U_ID] ,[Price]  FROM [dbo].[Item_Subcategory] where [Itm_Sub_ID]= @Itm_Sub_ID", conn);
            CMdddd.Parameters.Clear();
            CMdddd.Parameters.AddWithValue("@Itm_Sub_ID", IID);
            DataTable dt = new DataTable();
            dt = Return_datatable_value(CMdddd);
            DataRow row_show = dt.Rows[0];
            Cbo_Type.SelectedValue = row_show[2];
            txt_Name.Text = row_show[0].ToString();
            txt_Min_At_Store.Text = row_show[1].ToString();
            cbo_Units.SelectedValue = row_show[3];
            txt_Price.Text = row_show[4].ToString();
        }
  
        private void cbo_unit_load()
        {
           
            SqlCommand CMd = new SqlCommand("SELECT [U_ID] ,[Name] ,[Qty] ,[Smallest_Unit_Name] FROM [dbo].[Units]", conn);
            cbo_Units.DataSource = Return_datatable_value(CMd);
            cbo_Units.ValueMember = "U_ID";
            cbo_Units.DisplayMember = "Name";
            cbo_Units.SelectedIndex = -1;
          
        }
        private void cbo_consist_pure_cat_Load()
        {
            Flag_consist_Cat = false;
            SqlCommand CMd = new SqlCommand("SELECT [Itm_Cat_ID],[Name] ,[Notes] FROM [dbo].[Item_Category] where [Type] ='false'", conn);
            cbo_consist_Cat.DataSource = Return_datatable_value(CMd);
            cbo_consist_Cat.ValueMember = "Itm_Cat_ID";
            cbo_consist_Cat.DisplayMember = "Name";
            cbo_consist_Cat.SelectedIndex = -1;
            Flag_consist_Cat = true;
   
        }
        private void cbo_Cat_Load()
        {
            
            SqlCommand CMd = new SqlCommand("SELECT [Itm_Cat_ID],[Name] ,[Notes] FROM [dbo].[Item_Category] where [Type] ='true'", conn);
            Cbo_Type.DataSource = Return_datatable_value(CMd);
            Cbo_Type.ValueMember = "Itm_Cat_ID";
            Cbo_Type.DisplayMember = "Name";
            Cbo_Type.SelectedIndex = -1;
         
        }
        private void cbo_consist_Cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //hylood el combo elly motamed 3leeh 

            if (Flag_consist_Cat)
            {
                SqlCommand CMd = new SqlCommand("SELECT [Itm_Sub_ID] ,[Name] FROM [dbo].[Item_Subcategory] where [Itm_Cat_ID] =@Itm_Cat_ID", conn);
                CMd.Parameters.Clear();
                CMd.Parameters.AddWithValue("@Itm_Cat_ID", cbo_consist_Cat.SelectedValue);
                cbo_consist_item.DataSource = Return_datatable_value(CMd);
                cbo_consist_item.ValueMember = "Itm_Sub_ID";
                cbo_consist_item.DisplayMember = "Name";
                cbo_consist_item.SelectedIndex = -1;



            }

        }

        private int CheckItemExistance(int ItemID)
        {
            try
            {
                foreach (DataGridViewRow CurrentRow in dgv_Consist.Rows)
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
        public void take_Insert_Update_Delete(SqlCommand CMD)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            CMD.ExecuteNonQuery();
            conn.Close();
        }
        public int existstance_color()
        {
            int exist = 0;
            int x = ((lst_Colors.Items.Count));
            for (int i = x; i > 0; i--)
            {
                String m = lst_Colors.Items[i - 1].ToString();
                if (cbo_Colors.Text == m)
                {
                    exist++;
                }

            }
            return exist;
        }
        public int existstance_Size()
        {
            int exist = 0;
            int x = ((lst_Sizes.Items.Count));
            for (int i = x; i > 0; i--)
            {
                String m = lst_Sizes.Items[i - 1].ToString();
                if (txt_Size.Text == m)
                {
                    exist++;
                }

            }
            return exist;
        }



        private void btn_Type_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("To Add New Type", btn_Type, 2000);
        }
        private void btn_Type_Click_1(object sender, EventArgs e)
        {
            frm_Item_Type f = new frm_Item_Type();
            f.Show();
            this.Close();
        }
        private void btn_New_Unit_Click(object sender, EventArgs e)
        {
            frm_new_unit f = new frm_new_unit();
            f.Show();
            this.Close();
        }

        public DataTable Return_datatable_value(SqlCommand CMD)
        {
            SqlDataAdapter dad = new SqlDataAdapter(CMD);
            DataTable DT = new DataTable();
            dad.Fill(DT);
            return DT;
        }

        private void txt_consist_Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
        int Row_incremental = 0;
        private void button10_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cbo_consist_Cat.Text) || String.IsNullOrWhiteSpace(cbo_consist_item.Text) || String.IsNullOrWhiteSpace(txt_consist_Qty.Text))
            {
                MessageBox.Show("you must enter all fields");
            }
            else
            {
                int RowSelected = CheckItemExistance(Convert.ToInt32(cbo_consist_item.SelectedValue));
                if (RowSelected >= 0 && edit_or_add == "add")
                {
                    dgv_Consist.Rows[RowSelected].Cells[0].Value = cbo_consist_item.SelectedValue;
                    dgv_Consist.Rows[RowSelected].Cells[1].Value = cbo_consist_Cat.Text + "  " + cbo_consist_item.Text;
                    dgv_Consist.Rows[RowSelected].Cells[2].Value = txt_consist_Qty.Text;
                }
                else if (RowSelected == -1 && edit_or_add == "add")
                {
                    dgv_Consist.Rows.Add();
                    dgv_Consist.Rows[Row_incremental].Cells[0].Value = cbo_consist_item.SelectedValue;
                    dgv_Consist.Rows[Row_incremental].Cells[1].Value = cbo_consist_Cat.Text + "  " + cbo_consist_item.Text;
                    dgv_Consist.Rows[Row_incremental].Cells[2].Value = txt_consist_Qty.Text;
                    Row_incremental++;
                }
                //else if (RowSelected >= 0 && edit_or_add == "edit")
                //{
                //}
                //else if (RowSelected == -1 && edit_or_add == "edit")
                //{
                //}

                
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
           
            if (String.IsNullOrWhiteSpace(cbo_Colors.Text))
            {
                MessageBox.Show("you must select color first");
            }
            else
            {
                  int y=  existstance_color();
                  if (y == 0 && edit_or_add == "add")
                  {
                    lst_Colors.Items.Add(cbo_Colors.Text);  
                  }
                  if (y == 0 && edit_or_add == "edit")
                  {
                      DataRow row1 = color_DT.NewRow();
                      row1[0] = cbo_Colors.Text;
                      color_DT.Rows.Add(row1);
                  }
                  
          
            }
            
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_Size.Text))
            {
                MessageBox.Show("you must select size first");
            }
            else
            {
                int y = existstance_Size();
                if (y == 0 && edit_or_add == "add")
                {
                    lst_Sizes.Items.Add(txt_Size.Text);
                }
                if (y == 0 && edit_or_add == "edit")
                {
                    DataRow row1 = size_DT.NewRow();
                    row1[0] = cbo_Colors.Text;
                    size_DT.Rows.Add(row1);
                }
             
            }





        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (lst_Colors.SelectedIndex < 0)
            {
                MessageBox.Show("you must select color first");
            }
            else
            {
                lst_Colors.Items.RemoveAt(lst_Colors.SelectedIndex);
            }
            //int Rows_Count = dgv_Itm_Returned.Rows.Count - 1;
            //if (Rows_Count > 0)
            //{
            //    dgv_Itm_Returned.Rows.Remove(dgv_Itm_Returned.CurrentRow);
            //}

            
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (lst_Sizes.SelectedIndex < 0)
            {
                MessageBox.Show("you must select size first");
            }
            else
            {
                lst_Sizes.Items.RemoveAt(lst_Sizes.SelectedIndex);
            }
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
             
                 try 
	              {
                      insert_Item_Subcategory_Table();
                      insert_ConsistOf();
                      insert_colors();
                      insert_sizes();

                      MessageBox.Show("Added");
                      this.Close();
                      frm_Finish_Item_Search f = new frm_Finish_Item_Search();
                      f.Show();
		
	              }
	            catch (Exception exp)
	             {

                     MessageBox.Show(exp.Message);
	             }

        }

        private void insert_sizes()
        {
            int x = ((lst_Sizes.Items.Count));
            for (int i = x; i > 0; i--)
            {
                String m = lst_Sizes.Items[i - 1].ToString();
                SqlCommand CMd = new SqlCommand("declare @x int set @x=(select MAX([Itm_Sub_ID]) from [dbo].[Item_Subcategory]) INSERT INTO [dbo].[Item_Size] ([Itm_Sub_ID]  ,[Size])  VALUES (@x ,@Size)", conn);
                CMd.Parameters.Clear();
                CMd.Parameters.AddWithValue("@Size", m);
                take_Insert_Update_Delete(CMd);


            }
        }
        private void insert_colors()
        {
            int x = ((lst_Colors.Items.Count));
            for (int i = x; i > 0; i--)
            {
                String m = lst_Colors.Items[i - 1].ToString();
                SqlCommand CMd = new SqlCommand("declare @x int set @x=(select MAX([Itm_Sub_ID]) from [dbo].[Item_Subcategory]) INSERT INTO [dbo].[Item_Color] ([Itm_Sub_ID] ,[Color])  VALUES  (@x  , @Color)", conn);
                CMd.Parameters.Clear();
                CMd.Parameters.AddWithValue("@Color", m);
                take_Insert_Update_Delete(CMd);


            }
        }
        private void insert_ConsistOf()
        {
            int Rows_Count = dgv_Consist.Rows.Count;
            for (int i = 0; i < Rows_Count -1; i++)
            {
                SqlCommand Cmd_Item = new SqlCommand("declare @x int set @x=(select MAX([Itm_Sub_ID]) from [dbo].[Item_Subcategory]) INSERT INTO [dbo].[Finish_Pure_Item] ([Itm_Sub_ID_Finish] ,[Itm_Sub_ID_Pure] ,[Qty]) VALUES (@x ,@Itm_Sub_ID_Pure ,@Qty) ", conn);
                Cmd_Item.Parameters.AddWithValue("@Itm_Sub_ID_Pure", int.Parse(dgv_Consist.Rows[i].Cells[0].Value.ToString()));
                Cmd_Item.Parameters.AddWithValue("@Qty", int.Parse(dgv_Consist.Rows[i].Cells[2].Value.ToString()));
                take_Insert_Update_Delete(Cmd_Item);


            }
        }
        private void insert_Item_Subcategory_Table()
        {
            SqlCommand CMd = new SqlCommand(" declare @x int  declare @c int  set @c=(select count([Itm_Sub_ID]) from [dbo].[Item_Subcategory]) if @c=0 begin set @x=1 end   else begin  set @x=(select MAX([Itm_Sub_ID])+1 from [dbo].[Item_Subcategory]) end INSERT INTO [dbo].[Item_Subcategory] ([Itm_Sub_ID]  ,[Name]   ,[Min_At_Store]   ,[Itm_Cat_ID]   ,[U_ID] ,[Price]) VALUES  ( @x  , @Name , @Min_At_Store   , @Itm_Cat_ID  , @U_ID  , @Price)", conn);
            CMd.Parameters.Clear();
            CMd.Parameters.AddWithValue("@Name", txt_Name.Text);
            CMd.Parameters.AddWithValue("@Min_At_Store", txt_Min_At_Store.Text);
            CMd.Parameters.AddWithValue("@Itm_Cat_ID", Cbo_Type.SelectedValue);
            CMd.Parameters.AddWithValue("@U_ID", cbo_Units.SelectedValue);
            CMd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txt_Price.Text));
            take_Insert_Update_Delete(CMd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Rows_Count =dgv_Consist.Rows.Count - 1;
            if (Rows_Count > 0)
            {
                dgv_Consist.Rows.Remove(dgv_Consist.CurrentRow);
            }
        }

    



    }
}