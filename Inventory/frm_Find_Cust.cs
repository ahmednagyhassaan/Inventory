using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory
{
    public partial class frm_Find_Cust : Form
    {
        SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
        public frm_Find_Cust()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_Cust f1 = new frm_Cust("add");
            f1.Show();
            this.Close();
        }

        private void frm_Find_Cust_Load(object sender, EventArgs e)
        {
           

        }

        private void cbo_Way_Of_Search_SelectedValueChanged(object sender, EventArgs e)
        {
              try
            {
                grid_Load();
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void grid_Load()
        {
            if (cbo_Way_Of_Search.SelectedItem == "All")
            {
                txt_City.Text = "";
                txt_Country.Text = "";
                txt_ID.Text = "";
                txt_Name.Text = "";
                grb_Search.Enabled = false;
                SqlCommand cmd = new SqlCommand("SELECT [Cust_ID],[Name],[Country],[City],[Address] ,[Post_Code],[E_Mail],[Banking_Account] ,[Fax] ,[Note]  FROM [dbo].[Customer] where Valid= 'True'", Conn);
                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                DataTable DT = new DataTable();
                dad.Fill(DT);
                dgv_Cust_Find.DataSource = DT;
            }
            else if (cbo_Way_Of_Search.SelectedItem == "Search By")
            {
                txt_City.Text = "";
                txt_Country.Text = "";
                txt_ID.Text = "";
                txt_Name.Text = "";
                grb_Search.Enabled = true;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            String Sql_Cmd_Text = "SELECT [Cust_ID],[Name],[Country],[City],[Address] ,[Post_Code],[E_Mail],[Banking_Account] ,[Fax] ,[Note]  FROM [dbo].[Customer] where Valid= 'True'";
            SqlCommand cmd = new SqlCommand("", Conn);

            if (txt_ID.Text != string.Empty)
            {
                Sql_Cmd_Text += " AND [Cust_ID]=@ID";
                cmd.Parameters.AddWithValue("@ID", int.Parse(txt_ID.Text));
            }
            if (txt_Name.Text != string.Empty)
            {
                Sql_Cmd_Text += " AND [Name] like @Name";
                cmd.Parameters.AddWithValue("@Name", txt_Name.Text + "%");
            }
            if (txt_Country.Text != string.Empty)
            {
                Sql_Cmd_Text += " AND  [Country]  like @Country";
                cmd.Parameters.AddWithValue("@Country", txt_Country.Text + "%");
            }
            if (txt_Country.Text != string.Empty)
            {
                Sql_Cmd_Text += " AND  [City]   like @City ";
                cmd.Parameters.AddWithValue("@City", txt_City.Text + "%");
            }
            cmd.CommandText = Sql_Cmd_Text;
            SqlDataAdapter dadd = new SqlDataAdapter(cmd);
            DataTable DT5 = new DataTable();
            dadd.Fill(DT5);
            dgv_Cust_Find.DataSource = DT5;




        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            
            try
            {
                int currentID = Convert.ToInt32(dgv_Cust_Find.CurrentRow.Cells[0].Value);
                frm_Cust f1 = new frm_Cust(currentID, "edit");
                f1.Show();
                this.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(" you must select Customer first");
            }
        }

        private void btn_View_Inv_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
           try
            {
                //// delete supplier phones
                int current_Cust = Convert.ToInt32(dgv_Cust_Find.CurrentRow.Cells[0].Value);
                SqlCommand CMDD = new SqlCommand("DELETE FROM [dbo].[Customer_Phone]  WHERE  [Cust_ID]= @Cust_ID", Conn);
                CMDD.Parameters.AddWithValue("@Cust_ID", current_Cust);
                if (Conn.State != ConnectionState.Open)
                    Conn.Open();
                CMDD.ExecuteNonQuery();
                Conn.Close();
               //delete contacts
                SqlCommand CMDDD = new SqlCommand("DELETE FROM [dbo].[Contact_Customer] WHERE [Cust_ID]= @Cust_ID", Conn);
                CMDDD.Parameters.AddWithValue("@Cust_ID", current_Cust);
                if (Conn.State != ConnectionState.Open)
                    Conn.Open();
                CMDDD.ExecuteNonQuery();
                Conn.Close();

                //////then delete supplier
                try
                {
                    SqlCommand CCMD = new SqlCommand("DELETE FROM [dbo].[Customer]  WHERE [Cust_ID]= @Cust_ID", Conn);
                    CCMD.Parameters.AddWithValue("@Cust_ID", current_Cust);
                    if (Conn.State != ConnectionState.Open)
                        Conn.Open();
                    CCMD.ExecuteNonQuery();
                    Conn.Close();
                    // message for use delete is done
                    MessageBox.Show("deleted");
                    //3shan yshelhaly mn el gride 
                    int Rows_Count = dgv_Cust_Find.Rows.Count - 1;
                    if (Rows_Count > 0)
                    {
                        dgv_Cust_Find.Rows.Remove(dgv_Cust_Find.CurrentRow);
                    }

                }
                catch (Exception )
                {
                    

                    try
                    {
                        int current_Custt = Convert.ToInt32(dgv_Cust_Find.CurrentRow.Cells[0].Value);
                        SqlCommand CM = new SqlCommand("UPDATE [dbo].[Customer]  SET [Valid] ='false'  WHERE [Cust_ID]= @Cust_ID", Conn);
                        CM.Parameters.AddWithValue("@Cust_ID", current_Custt);
                        if (Conn.State != ConnectionState.Open)
                            Conn.Open();
                        CM.ExecuteNonQuery();
                        Conn.Close();
                        MessageBox.Show(" deleted , note :::this customer may be  related with  sales invoices or returns");
                        int Rows_Count = dgv_Cust_Find.Rows.Count - 1;
                        if (Rows_Count > 0)
                        {
                            dgv_Cust_Find.Rows.Remove(dgv_Cust_Find.CurrentRow);
                        }
                    }
                    catch (Exception exp)
                    {

                        MessageBox.Show(exp.Message);
                    }
                }

            }
            catch (Exception exp)
            {

                MessageBox.Show("you must select Customer first");
            }
        }

        private void btn_View_Details_Click(object sender, EventArgs e)
        {
            try
            {
              int currentID = Convert.ToInt32(dgv_Cust_Find.CurrentRow.Cells[0].Value);
            frm_Cust f1 = new frm_Cust(currentID, "view");
            f1.Show();
            }
            catch (Exception exp)
            {

                MessageBox.Show(" you must select  Customer first");
            }
        }

        private void txt_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void btn_Contact_Click(object sender, EventArgs e)
        {
            try
            {
                int currentID = Convert.ToInt32(dgv_Cust_Find.CurrentRow.Cells[0].Value);
                frm_contact_Customer f1 = new frm_contact_Customer(currentID);
                f1.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(" you must select Customer first");
            }
        }

     
     
    }
}
