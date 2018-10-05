using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory
{
    public partial class frm_Find_Add_Finish_To_Store : Form
        
        
    {



        bool FormLoadFlag = false;
       // MyDB mydb = new MyDB();
        public frm_Find_Add_Finish_To_Store()
        {
            InitializeComponent();
        }
        DataTable datagridview = new DataTable();

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            frm_Add_Finish_To_Store f1 = new frm_Add_Finish_To_Store("add");
            f1.ShowDialog();
        }

        private void Finish_Product_Load(object sender, EventArgs e)
        {
            try
            {
                ProjectTools.LoadCbo(cbo_Created_By, DataAccessLayer.GetDataTable("Employee", ""), "Name", "Emp_ID");
                string cmd = "select [Sto_ID],[Store].[Name]as st_Name FROM dbo.Store INNER JOIN dbo.Store_Category ON dbo.Store.Sto_Cat_ID = dbo.Store_Category.Sto_Cat_ID  where[Store].Sto_Cat_ID=[Store_Category].Sto_Cat_ID and [Store_Category].Name='Finish'";
                ProjectTools.LoadCbo(cbo_Stock_Name, DataAccessLayer.GetDataTableComplex(cmd,""), "st_Name", "Sto_ID");
                ProjectTools.LoadCbo(cbo_Itm_Cat, DataAccessLayer.GetDataTable("Item_Category", ""), "Name", "Itm_Cat_ID");
                FormLoadFlag = true;


               // txt_Add_No.Text = DataAccessLayer.NewRowID("Add_Finish_Process", "Add_Finish_ID");
                //EnableHeadDetails(true, false);
                FormLoadFlag = true;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                throw;
            }
         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbo_Way_Of_Search_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_Way_Of_Search.SelectedItem == "All")
                {
                    grb_Search.Enabled = false;
                    string cmd1 = "SELECT DISTINCT (dbo.Add_Finish_Process.Add_Finish_ID), dbo.Add_Finish_Process.Created_At, dbo.Employee.Name AS Employee_Name, dbo.Add_Finish_Process.Notes, dbo.Store_Category.Name AS Store_Name FROM Add_Finish_Process INNER JOIN Store ON Add_Finish_Process.Sto_ID =Store.Sto_ID INNER JOIN Store_Category ON Store.Sto_Cat_ID = Store_Category.Sto_Cat_ID INNER JOIN Employee ON dbo.Add_Finish_Process.Emp_ID = dbo.Employee.Emp_ID INNER JOIN Add_Finish_Process_Details ON Add_Finish_Process.Add_Finish_ID = Add_Finish_Process_Details.Add_Finish_ID INNER JOIN Item_Subcategory ON Add_Finish_Process_Details.Itm_Sub_ID = dbo.Item_Subcategory.Itm_Sub_ID INNER JOIN Item_Category On Item_Subcategory.Itm_Cat_ID = Item_Category.Itm_Cat_ID";
                    dgv_Search_Finish_Product.DataSource = DataAccessLayer.GetDataTableComplex(cmd1,"");
                    




                }
                else if (cbo_Way_Of_Search.SelectedItem == "Search By")
                {
                    grb_Search.Enabled = true;
                    

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                throw;
            }
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormValidate_Details())
                {
                    string Sqlstatment = "SELECT DISTINCT (dbo.Add_Finish_Process.Add_Finish_ID), dbo.Add_Finish_Process.Created_At, dbo.Employee.Name AS Employee_Name, dbo.Add_Finish_Process.Notes,  dbo.Store.Name AS Store_Name FROM Add_Finish_Process INNER JOIN Store ON Add_Finish_Process.Sto_ID =Store.Sto_ID INNER JOIN Store_Category ON Store.Sto_Cat_ID = Store_Category.Sto_Cat_ID INNER JOIN Employee ON dbo.Add_Finish_Process.Emp_ID = dbo.Employee.Emp_ID INNER JOIN Add_Finish_Process_Details ON Add_Finish_Process.Add_Finish_ID = Add_Finish_Process_Details.Add_Finish_ID INNER JOIN Item_Subcategory ON Add_Finish_Process_Details.Itm_Sub_ID = dbo.Item_Subcategory.Itm_Sub_ID INNER JOIN Item_Category On Item_Subcategory.Itm_Cat_ID = Item_Category.Itm_Cat_ID  INNER JOIN dbo.Store as sto ON dbo.Add_Finish_Process.Sto_ID = dbo.Store.Sto_ID where Add_Finish_Process.Created_At between @from and  @to AND  1 = 1";
                    //check if No is not Null
                    //Add_Finish_Process.Created_At between '@from' and ' @to'

                    SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
                    Conn.Open();
                    SqlCommand sql = new SqlCommand(Sqlstatment, Conn);
                    if (txt_Add_No.Text != string.Empty)
                    {
                        Sqlstatment += " AND Add_Finish_Process.Add_Finish_ID=@Add_Finish_ID";
                        sql.Parameters.AddWithValue("@Add_Finish_ID", txt_Add_No.Text);
                    }
                    if (cbo_Created_By.SelectedItem != null)
                    {
                        Sqlstatment += " AND Employee.Name= @EmployeeName";
                        sql.Parameters.AddWithValue("@EmployeeName", cbo_Created_By.Text);
                    }
                    if (cbo_Stock_Name.SelectedItem != null)
                    {
                        Sqlstatment += " AND Store.Name= @StoreName";
                        sql.Parameters.AddWithValue("@StoreName", cbo_Stock_Name.Text);
                    }
                    if (cbo_Itm_Cat.SelectedItem != null)
                    {
                        Sqlstatment += " AND Item_Category.Name=@item_cat";
                        sql.Parameters.AddWithValue("@item_cat", cbo_Itm_Cat.Text);
                    }
                    if (cbo_Itm_Name.SelectedItem != null)
                    {
                        Sqlstatment += " AND Item_Subcategory.Name = @item_sub_cat";
                        sql.Parameters.AddWithValue("@item_sub_cat", cbo_Itm_Name.Text);
                    }

                    if (dtp_Created_From.Text != null)
                    {
                        //Sqlstatment += " AND Add_Finish_Process.Created_At = @from";
                        sql.Parameters.AddWithValue("@from", Convert.ToDateTime(dtp_Created_From.Value.ToString()));
                    }


                    if (dtp_Created_To.Text != null)
                    {
                        // Sqlstatment += " AND Add_Finish_Process.Created_At = @to";
                        sql.Parameters.AddWithValue("@to", Convert.ToDateTime(dtp_Created_To.Value.ToString()));
                    }

                        //sql.Parameters.AddWithValue("@from", Convert.ToDateTime(dtp_Created_From.Text));
                        //sql.Parameters.AddWithValue("@to", Convert.ToDateTime(dtp_Created_To.Text));


                        sql.CommandText = Sqlstatment;
                        SqlDataReader sdr = sql.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(sdr);
                        Conn.Close();

                        dgv_Search_Finish_Product.DataSource = dt;
                        //object[] parameters = new object[] { txt_Add_No.Text, cbo_Created_By.Text, cbo_Stock_Name.Text, dtp_Created_From.Text, dtp_Created_To.Text };
                        //string g =
                        //    "select * from search_for_final_products where Add_Finish_ID=@Add_Finish_ID or Employee_Name= @EmployeeName or Store_Name= @StoreName or  Created_At between @from and  @to";
                        //mydb.ReturnTable(g, parameters);

                        //dgv_Search_Finish_Product.DataSource = DataAccessLayer.GetDataTableComplex(sql, "Add_Finish_ID=@Add_Finish_ID");

                        //mydb.ExcuteQueryByParameters(sql, txt_Add_No.ToString()[0], cbo_Stock_Name.SelectedValue.ToString()[1], cbo_Itm_Cat.SelectedValue.ToString()[2], cbo_Itm_Name.SelectedValue.ToString()[3], cbo_Created_By.SelectedValue.ToString()[4]);

                    }

                }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message); 
                throw;
            }
        }
        private bool FormValidate_Details()
        {
            if (cbo_Itm_Cat.SelectedItem !=null || cbo_Itm_Name.SelectedItem != null || txt_Add_No.Text
               != null)
              return true;
            else
                return false;
        }

        private void cbo_Itm_Cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (FormLoadFlag)
                    ProjectTools.LoadCbo(cbo_Itm_Name, DataAccessLayer.GetDataTable("Item_Subcategory", " where Itm_Cat_ID = " + (cbo_Itm_Cat.SelectedValue).ToString()), "Name", "Itm_Sub_ID");
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

                try
                {
                    int currentID = Convert.ToInt32(dgv_Search_Finish_Product.CurrentRow.Cells[0].Value);
                    frm_Edit_Add_Finish_To_Store f2 = new frm_Edit_Add_Finish_To_Store(currentID, "Edit");
                    f2.ShowDialog();
                }
               
            
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }

        }

        private void dgv_Search_Finish_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgv_Search_Finish_Product.Rows.Clear();
            //string sel = "select * from Add_Finish_Process_Details  ";
            //    dgv_Search_Finish_Product.DataSource=DataAccessLayer.GetDataTable(sel," where Add_Finish_ID = " + (cbo_Itm_Cat.SelectedValue).ToString()
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you Sure you want to Delete selection? ", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int currentID = Convert.ToInt32(dgv_Search_Finish_Product.CurrentRow.Cells[0].Value);
                    DataTable data = DataAccessLayer.GetRowsByID("Add_Finish_Process_Details", "Add_Finish_ID", currentID.ToString());

                    foreach (DataRow ITEM in data.Rows)
                    {

                        DataAccessLayer.ExecuteNoneQuery(
                     "Delete From Add_Finish_Process_Details where Add_Finish_ID =" + currentID.ToString() + " AND Itm_Sub_ID = " + ITEM[1]);
                    }
                    DataAccessLayer.ExecuteNoneQuery(
                   "Delete From Add_Finish_Process where Add_Finish_ID =" + dgv_Search_Finish_Product.CurrentRow.Cells[0].Value.ToString());
                    #region reload grid
                    string cmd1 = "SELECT DISTINCT (dbo.Add_Finish_Process.Add_Finish_ID), dbo.Add_Finish_Process.Created_At, dbo.Employee.Name AS Employee_Name, dbo.Add_Finish_Process.Notes, dbo.Store_Category.Name AS Store_Name FROM Add_Finish_Process INNER JOIN Store ON Add_Finish_Process.Sto_ID =Store.Sto_ID INNER JOIN Store_Category ON Store.Sto_Cat_ID = Store_Category.Sto_Cat_ID INNER JOIN Employee ON dbo.Add_Finish_Process.Emp_ID = dbo.Employee.Emp_ID INNER JOIN Add_Finish_Process_Details ON Add_Finish_Process.Add_Finish_ID = Add_Finish_Process_Details.Add_Finish_ID INNER JOIN Item_Subcategory ON Add_Finish_Process_Details.Itm_Sub_ID = dbo.Item_Subcategory.Itm_Sub_ID INNER JOIN Item_Category On Item_Subcategory.Itm_Cat_ID = Item_Category.Itm_Cat_ID";
                    dgv_Search_Finish_Product.DataSource = DataAccessLayer.GetDataTableComplex(cmd1, "");
                    #endregion

                    MessageBox.Show("Deleted");
                }
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Add_No_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Add_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void dtp_Created_From_ValueChanged(object sender, EventArgs e)
        {

        }


      
    }
}

