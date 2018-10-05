using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory
{
    public partial class frm_Find_Order_Sales : Form
    {
        public frm_Find_Order_Sales()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_Sales_Order f1 = new frm_Sales_Order("add");
            f1.ShowDialog();


        }

        private void Frm_Find_Invoice_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
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


          
            
                SqlCommand cmd = new SqlCommand("select * from [dbo].[Customer]", conn);
                conn.Open();
                SqlDataReader readsup = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(readsup);
                conn.Close();
                cbo_CUST_Name.DataSource = dt;
            
                cbo_CUST_Name.ValueMember = "Cust_ID";
                cbo_CUST_Name.DisplayMember = "Name";
                cbo_CUST_Name.SelectedIndex = -1;

                SqlCommand cmd2 = new SqlCommand("select * from [dbo].[Employee]", conn);
                conn.Open();
                SqlDataReader readsitem = cmd2.ExecuteReader();
                DataTable dt2 = new DataTable();
                dt2.Load(readsitem);
                conn.Close();
                cbo_employee.DataSource = dt2;
                cbo_employee.DisplayMember = "Name";
                cbo_employee.ValueMember = "Emp_ID";
                cbo_employee.SelectedIndex = -1;


               

            }

        }

        private void cbo_Way_Of_Search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      
              
        private void btn_Search_Click(object sender, EventArgs e)
        {
          
         
           
            SqlCommand cmd = new SqlCommand("select * from vSalesOrder  where Customer=@Customer or Notes=@notes or Employee=@employee  or ID=@Sal_Ord_ID or Created   between @from and  @to ", conn);
         // select [Sal_Ord_ID],[Emp_ID],[Cust_ID],[Created_At],[Notes] from Sales_Order
            cmd.Parameters.AddWithValue("@Customer", cbo_CUST_Name.Text);
            cmd.Parameters.AddWithValue("@notes",txt_note.Text);
            cmd.Parameters.AddWithValue("@employee", cbo_employee.Text);   

            cmd.Parameters.AddWithValue("@Sal_Ord_ID", txt_ord_No.Text);
        
            cmd.Parameters.AddWithValue("@from", Convert.ToDateTime(dtp_Inv_Date_From.Text));
            cmd.Parameters.AddWithValue("@to", Convert.ToDateTime(dtp_Inv_Date_To.Text));
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            dad.Fill(DT);
            dgv_search.DataSource = DT;
         
        }

        private void btn_Delete_ord_Click(object sender, EventArgs e)
        {
            int Rows_Count = dgv_search.Rows.Count - 1;
            if (Rows_Count > 0)
            {
                dgv_search.Rows.Remove(dgv_search.CurrentRow);

            }
        }

        private void btn_View_Edit_ord_Click(object sender, EventArgs e)
        {
            int currentID = Convert.ToInt32(dgv_search.CurrentRow.Cells[0].Value);
            frm_Sales_Order f2 = new frm_Sales_Order(currentID , "edit");
                

            f2.ShowDialog();
        }
    }
}

