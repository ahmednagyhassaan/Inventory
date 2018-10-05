using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory
{
    public partial class frm_Find_Order_Purchase : Form
    {
        public frm_Find_Order_Purchase()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
        private void frm_Find_Order_Purchase_Load(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {


        }

        private void btn_View_Edit_inv_Click(object sender, EventArgs e)
        {
            int currentID = Convert.ToInt32(dgv_search.CurrentRow.Cells[0].Value);
            frm_Purchase_Order f2 = new frm_Purchase_Order();
            f2.ShowDialog();
        }

        private void btn_Delete_Inv_Click(object sender, EventArgs e)
        {
            int currentID = Convert.ToInt32(dgv_search.CurrentRow.Cells[0].Value);
            frm_Purchase_Order f2 = new frm_Purchase_Order();
            f2.ShowDialog();
        }

        private void btn_New_Invoice_Click(object sender, EventArgs e)
        {
            frm_Purchase_Order f1 = new frm_Purchase_Order();
            f1.ShowDialog();
        }

        private void gbo_Search_By_Enter(object sender, EventArgs e)
        {

        }

        private void cbo_Way_Of_Search_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbo_Way_Of_Search.SelectedItem == "All")
            {
                gbo_Search_By.Enabled = false;
                SqlCommand cmd = new SqlCommand("select * from vSalesOrder", conn);
                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                DataTable DT = new DataTable();
                dad.Fill(DT);
                dgv_search.DataSource = DT;
            }
            else if (cbo_Way_Of_Search.SelectedItem == "Search By")
            {
                gbo_Search_By.Enabled = true;


                SqlCommand cmd1 = new SqlCommand("select * from [dbo].[Item_Category]", conn);
                conn.Open();
                SqlDataReader readitem = cmd1.ExecuteReader();
                DataTable dt1 = new DataTable();
                dt1.Load(readitem);
                conn.Close();
                //cbo_Itm_Cat.DataSource = dt1;
                //cbo_Itm_Cat.ValueMember = "Itm_Cat_ID";
                //cbo_Itm_Cat.DisplayMember = "Name";
                //cbo_Itm_Cat.SelectedIndex = -1;

                SqlCommand cmd = new SqlCommand("select * from [dbo].[Customer]", conn);
                conn.Open();
                SqlDataReader readsup = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(readsup);
                conn.Close();
              
                cbo_Supp_Name.DataSource = dt;
                cbo_Supp_Name.ValueMember = "Cust_ID";
                cbo_Supp_Name.DisplayMember = "Name";
                cbo_Supp_Name.SelectedIndex = -1;

                SqlCommand cmd2 = new SqlCommand("select * from [dbo].[Item_Subcategory]", conn);
                conn.Open();
                SqlDataReader readsitem = cmd2.ExecuteReader();
                DataTable dt2 = new DataTable();
                dt2.Load(readsitem);
                conn.Close();
                //cbo_Itm_Name.DataSource = dt2;
                //cbo_Itm_Name.DisplayMember = "Name";
                //cbo_Itm_Name.ValueMember = "Itm_Sub_ID";
                //cbo_Itm_Name.SelectedIndex = -1;



            }
        }
    }
}
