using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory
{
    public partial class frm_Find_Supplier : Form
    {
       SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
        public frm_Find_Supplier()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
           frm_Supplier f1 = new frm_Supplier("add");
            f1.Show();
            this.Close();
        }

        private void cbo_Way_Of_Search_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbo_Way_Of_Search.SelectedItem == "All")
            {
                txt_City.Text = "";
                txt_Country.Text = "";
                txt_ID.Text = "";
                txt_Name.Text = "";
                grb_Search.Enabled = false;
                SqlCommand cmd = new SqlCommand("SELECT [Sup_ID] ,[Name],[Country],[City] ,[Address] ,[E_Mail] ,[BankAccount] ,[Fax] ,[Notes],[Post_Code] from [dbo].[Supplier] where Valid= 'True'", Conn);
                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                DataTable DT = new DataTable();
                dad.Fill(DT);
                dgv_Sup_Find.DataSource = DT;
            }
            else if (cbo_Way_Of_Search.SelectedItem == "Search By")
            {
                grb_Search.Enabled = true;
                txt_City.Text = "";
                txt_Country.Text = "";
                txt_ID.Text = "";
                txt_Name.Text = "";
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {


            String Sql_Cmd_Text = "SELECT [Sup_ID] ,[Name],[Country],[City] ,[Address] ,[E_Mail] ,[BankAccount] ,[Fax] ,[Notes],[Post_Code] from [dbo].[Supplier] where Valid= 'True'";
            SqlCommand cmd = new SqlCommand("", Conn);

            if (txt_ID.Text != string.Empty)
            {
                Sql_Cmd_Text += " AND [Sup_ID]=@ID";
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
                cmd.Parameters.AddWithValue("@Country", txt_Country.Text +"%");
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
            dgv_Sup_Find.DataSource = DT5;
        }

       
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                int currentIID = Convert.ToInt32(dgv_Sup_Find.CurrentRow.Cells[0].Value);


                frm_Supplier f2 = new frm_Supplier(currentIID, "edit");
                f2.Show();
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show(" you must select  supplier  first");
            }
                
              
                    
                
                
        }

        private void btn_View_Details_Click(object sender, EventArgs e)
        {
            try
            {
                int currentIID = Convert.ToInt32(dgv_Sup_Find.CurrentRow.Cells[0].Value);
                frm_Supplier f1 = new frm_Supplier(currentIID, "view");
                f1.ShowDialog();
                
            }
            catch (Exception)
            {

                MessageBox.Show(" you must select  supplier  first");
            }
               
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                //// delete supplier phones
                int currentIID = Convert.ToInt32(dgv_Sup_Find.CurrentRow.Cells[0].Value);
                SqlCommand CMDD = new SqlCommand("DELETE FROM [dbo].[Supplier_Phone] WHERE [Sup_ID]= @Sup_ID", Conn);
                CMDD.Parameters.AddWithValue("@Sup_ID", currentIID);
                if (Conn.State != ConnectionState.Open)
                    Conn.Open();
                CMDD.ExecuteNonQuery();
                Conn.Close();
                //delete contacts
                SqlCommand CMDDD = new SqlCommand("DELETE FROM [dbo].[Contact_Supplier] WHERE [Sup_ID]= @Sup_ID", Conn);
                CMDDD.Parameters.AddWithValue("@Sup_ID", currentIID);
                if (Conn.State != ConnectionState.Open)
                    Conn.Open();
                CMDDD.ExecuteNonQuery();
                Conn.Close();
                //////then delete supplier
                try
                {
                    SqlCommand CMD = new SqlCommand("DELETE FROM [dbo].[Supplier] WHERE [Sup_ID]= @Sup_ID", Conn);
                    CMD.Parameters.AddWithValue("@Sup_ID", currentIID);
                    if (Conn.State != ConnectionState.Open)
                        Conn.Open();
                    CMD.ExecuteNonQuery();
                    Conn.Close();
                    // message for use delete is done
                    MessageBox.Show("deleted");
                    //3shan yshelhaly mn el gride 
                    int Rows_Count = dgv_Sup_Find.Rows.Count - 1;
                    if (Rows_Count > 0)
                    {
                        dgv_Sup_Find.Rows.Remove(dgv_Sup_Find.CurrentRow);
                    }
                }
                  catch (Exception)
                {
                    try
                    {
                        int current_Sup = Convert.ToInt32(dgv_Sup_Find.CurrentRow.Cells[0].Value);
                        SqlCommand CM = new SqlCommand("UPDATE [dbo].[Supplier]  SET [Valid] ='false'  WHERE Sup_ID= @Sup_ID", Conn);
                        CM.Parameters.AddWithValue("@Sup_ID", current_Sup);
                        if (Conn.State != ConnectionState.Open)
                            Conn.Open();
                        CM.ExecuteNonQuery();
                        Conn.Close();
                        MessageBox.Show(" deleted , note :::this Supplier may be  related with  Purchase  invoices");
                        int Rows_Count = dgv_Sup_Find.Rows.Count - 1;
                        if (Rows_Count > 0)
                        {
                           dgv_Sup_Find.Rows.Remove(dgv_Sup_Find.CurrentRow);
                        }
                    }
                    catch (Exception exp)
                    {

                        MessageBox.Show(exp.Message);
                    }

                }

                

            }
            catch (Exception )
            {

                MessageBox.Show(" you must select  supplier  first");
            }
        }

        private void txt_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void frm_Find_Supplier_Load(object sender, EventArgs e)
        {

        }

        private void btn_View_Inv_Click(object sender, EventArgs e)
        {

        }

        private void btn_Contact_Click(object sender, EventArgs e)
        {
            try
            {
                int currentID = Convert.ToInt32(dgv_Sup_Find.CurrentRow.Cells[0].Value);
                frm_contact_Supplier f1 = new frm_contact_Supplier(currentID);
                f1.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(" you must select Supplier first");
            }
        }

      

    }
}
