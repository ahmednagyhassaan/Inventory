using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Inventory
{
    public partial class frm_Finish_Item_Search : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
        public frm_Finish_Item_Search()
        {
            InitializeComponent();
        }
        private void cbo_Cat_Load()
        {

            SqlCommand CMd = new SqlCommand("SELECT [Itm_Cat_ID],[Name] ,[Notes] FROM [dbo].[Item_Category] where [Type] ='true'", conn);
            cbo_Type.DataSource = Return_datatable_value(CMd);
            cbo_Type.ValueMember = "Itm_Cat_ID";
            cbo_Type.DisplayMember = "Name";
            cbo_Type.SelectedIndex = -1;

        }

        private void frm_Finish_Item_Search_Load(object sender, EventArgs e)
        {
            gbx_Search.Enabled = false;

        }

        private void cbo_Store_Search_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbo_FTtem_Search.Text == "Search by ")
            {
                gbx_Search.Enabled = true;
                cbo_Cat_Load();
            }
            else
            {
                gbx_Search.Enabled = false;
            }
        }
        public DataTable Return_datatable_value(SqlCommand CMD)
        {
            SqlDataAdapter dad = new SqlDataAdapter(CMD);
            DataTable DT = new DataTable();
            dad.Fill(DT);
            return DT;
        }
        private void cbo_FTtem_Search_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_FTtem_Search.SelectedItem =="All")
            {
                gbx_Search.Enabled = false;
                SqlCommand CMd = new SqlCommand("SELECT        dbo.Item_Subcategory.Itm_Sub_ID, dbo.Item_Category.Name AS category, dbo.Item_Subcategory.Name AS [item name], dbo.Units.Name AS big_Unit,   dbo.Units.Smallest_Unit_Name, dbo.Item_Subcategory.Price, dbo.Item_Subcategory.Min_At_Store FROM            dbo.Item_Subcategory INNER JOIN    dbo.Units ON dbo.Item_Subcategory.U_ID = dbo.Units.U_ID INNER JOIN    dbo.Item_Category ON dbo.Item_Subcategory.Itm_Cat_ID = dbo.Item_Category.Itm_Cat_ID where [Type]='true'", conn);
                 dgv_Store_Search.DataSource = Return_datatable_value(CMd);
               
            }
            if (cbo_FTtem_Search.SelectedItem == "items At Stores")
            {
                gbx_Search.Enabled = false;
                SqlCommand CMd = new SqlCommand("SELECT        dbo.Store_Category.Name AS StoreType , dbo.Store.Name AS StoreName, dbo.Item_Category.Name AS ItemType ,dbo.Item_Subcategory.Name AS ItemName , dbo.Item_Subcategory.Itm_Sub_ID   ,dbo.Current_Store.Qty,    dbo.Units.Smallest_Unit_Name,'or'as OOR, dbo.Current_Store.Qty / dbo.Units.Qty AS bySmallUnit, dbo.Units.Name AS bigUnit,dbo.Current_Store.Qty %dbo.Units.Qty AS byBigUnit,dbo.Units.Smallest_Unit_Name FROM      dbo.Current_Store INNER JOIN    dbo.Item_Subcategory ON dbo.Current_Store.Itm_Sub_ID = dbo.Item_Subcategory.Itm_Sub_ID INNER JOIN    dbo.Item_Category ON dbo.Item_Subcategory.Itm_Cat_ID = dbo.Item_Category.Itm_Cat_ID INNER JOIN     dbo.Store ON dbo.Current_Store.Sto_ID = dbo.Store.Sto_ID INNER JOIN  dbo.Store_Category ON dbo.Store.Sto_Cat_ID = dbo.Store_Category.Sto_Cat_ID INNER JOIN   dbo.Units ON dbo.Item_Subcategory.U_ID = dbo.Units.U_ID  ", conn);
                dgv_Store_Search.DataSource = Return_datatable_value(CMd);
                
            }
                        if (cbo_FTtem_Search.SelectedItem == "items Almost finished")
            {
                gbx_Search.Enabled = false;
                SqlCommand CMd = new SqlCommand("SELECT        dbo.Store_Category.Name AS StoreType , dbo.Store.Name AS StoreName, dbo.Item_Category.Name AS ItemType ,dbo.Item_Subcategory.Name AS ItemName , dbo.Item_Subcategory.Itm_Sub_ID   ,dbo.Current_Store.Qty,    dbo.Units.Smallest_Unit_Name,'or'as OOR, dbo.Current_Store.Qty / dbo.Units.Qty AS bySmallUnit, dbo.Units.Name AS bigUnit,dbo.Current_Store.Qty %dbo.Units.Qty AS byBigUnit,dbo.Units.Smallest_Unit_Name FROM      dbo.Current_Store INNER JOIN    dbo.Item_Subcategory ON dbo.Current_Store.Itm_Sub_ID = dbo.Item_Subcategory.Itm_Sub_ID INNER JOIN    dbo.Item_Category ON dbo.Item_Subcategory.Itm_Cat_ID = dbo.Item_Category.Itm_Cat_ID INNER JOIN     dbo.Store ON dbo.Current_Store.Sto_ID = dbo.Store.Sto_ID INNER JOIN  dbo.Store_Category ON dbo.Store.Sto_Cat_ID = dbo.Store_Category.Sto_Cat_ID INNER JOIN   dbo.Units ON dbo.Item_Subcategory.U_ID = dbo.Units.U_ID WHERE        dbo.Current_Store.Qty < dbo.Item_Subcategory.Min_At_Store ", conn);
                dgv_Store_Search.DataSource = Return_datatable_value(CMd);
              
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string Sqlstatment = "SELECT        dbo.Item_Subcategory.Itm_Sub_ID, dbo.Item_Category.Name AS category , dbo.Item_Subcategory.Name AS [itemname], dbo.Units.Name AS big_Unit,   dbo.Units.Smallest_Unit_Name, dbo.Item_Subcategory.Price, dbo.Item_Subcategory.Min_At_Store FROM            dbo.Item_Subcategory INNER JOIN    dbo.Units ON dbo.Item_Subcategory.U_ID = dbo.Units.U_ID INNER JOIN    dbo.Item_Category ON dbo.Item_Subcategory.Itm_Cat_ID = dbo.Item_Category.Itm_Cat_ID where [Type]='true' and 1=1";
            SqlCommand sql = new SqlCommand(Sqlstatment, conn);
            if (txt_ID.Text != string.Empty)
            {
                Sqlstatment += "  and  Itm_Sub_ID= @Itm_Sub_ID";
                sql.Parameters.AddWithValue("@Itm_Sub_ID", txt_ID.Text);
            }
            if (cbo_Type.SelectedItem != null)
            {
                Sqlstatment += "  and  dbo.Item_Category.Name = @category ";
                sql.Parameters.AddWithValue("@category", cbo_Type.Text);
            }
            if (txt_Name.Text != string.Empty)
            {
                Sqlstatment += "  and  dbo.Item_Subcategory.Name like  @item_name";
                sql.Parameters.AddWithValue("@item_name", txt_Name.Text +"%");
            }
            if (txt_mini.Text != string.Empty)
            {
                Sqlstatment += "   and  Min_At_Store >= @Min_At_Store ";
                sql.Parameters.AddWithValue("@Min_At_Store", txt_mini.Text);
            }
            sql.CommandText = Sqlstatment;
            dgv_Store_Search.DataSource = Return_datatable_value(sql);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_Add_Finish_Item f = new frm_Add_Finish_Item("add");
            f.Show();
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            
            try
            {
                int currentID = Convert.ToInt32(dgv_Store_Search.CurrentRow.Cells[0].Value);
                frm_Add_Finish_Item f2 = new frm_Add_Finish_Item(currentID, "edit");
                f2.Show();
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }

        }

        private void tn_FItem_Details_Click(object sender, EventArgs e)
        {
            try
            {
                int currentID = Convert.ToInt32(dgv_Store_Search.CurrentRow.Cells[0].Value);
                frm_Add_Finish_Item f2 = new frm_Add_Finish_Item(currentID, "view");
                f2.ShowDialog();
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
