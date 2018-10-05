using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory
{
    public partial class frm_contact_Supplier : Form
    {
        int Sup_ID;
       
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
        public frm_contact_Supplier(int current_Sup)
        {
            InitializeComponent();
            Sup_ID = current_Sup;
        }

        private void frm_contact_Supplier_Load(object sender, EventArgs e)
        {
            try
            {
               
                //3yza 2lwed el text bta3 el id 

                SqlCommand CMd = new SqlCommand("declare @X int=(Select Count([Cont_Sup_ID]) from [dbo].[Contact_Supplier] where [Sup_ID]=@Sup_ID)  if(@X=0) select 1  else (select max([Cont_Sup_ID])+1 from [dbo].[Contact_Supplier] where [Sup_ID]=@Sup_ID)", conn);
                CMd.Parameters.Clear();
                CMd.Parameters.AddWithValue("@Sup_ID", Sup_ID);
                txt_ID.Text = Return_One_valuestring(CMd);

                // 2lwed el grid
                Load_ELgrid();
                //fdelly el donia 3shan 2kteb kowise
                txt_Name.Text = "";
                txt_Phone.Text = "";
                txt_position.Text = "";
                txt_Fax.Text = "";
                txt_Email.Text = "";
                txt_Bank_Account.Text = "";

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
                //check if add or edit 
                SqlCommand CMd = new SqlCommand("SELECT count ( [Cont_Sup_ID]) FROM [dbo].[Contact_Supplier] where [Cont_Sup_ID]=@ID and [Sup_ID]=@Sup_ID", conn);
                CMd.Parameters.Clear();
                CMd.Parameters.AddWithValue("@Sup_ID", Sup_ID);
                CMd.Parameters.AddWithValue("@ID", int.Parse(txt_ID.Text));
                int c = Return_One_valueint(CMd);
                if (c == 0)
                {//mean insert
                    insert_Statement();
                }
                else if (c == 1)
                {//mean update 
                    update_Statement();
                    btn_Delete.Enabled = false;
                }
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            delete_Statement();
        }


        private void Load_ELgrid()
        {
            SqlCommand Cmd = new SqlCommand("SELECT [Cont_Sup_ID] ,[Name]  ,[Office_Phone] ,[E_Mail]  ,[Fax]   ,[Job_Position] ,[bank_Account] FROM [dbo].[Contact_Supplier] where [Sup_ID]=@Sup_ID", conn);
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Sup_ID", Sup_ID);
            dgv_Contact.DataSource = Return_datatable_value(Cmd);

        }
        private void insert_Statement()
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txt_Name.Text))
                {
                    MessageBox.Show("you must enter his/here name at least");
                }
                else
                {
                    SqlCommand Cmd = new SqlCommand("INSERT INTO [dbo].[Contact_Supplier]  ([Cont_Sup_ID]  ,[Sup_ID]  ,[Name] ,[E_Mail] ,[Fax]  ,[Job_Position] ,[bank_Account],[Office_Phone]) VALUES ( @Cont_Sup_ID    , @Sup_ID , @Name , @E_Mail , @Fax   , @Job_Position  , @bank_Account , @Office_Phone)", conn);
                    Cmd.Parameters.Clear();
                    Cmd.Parameters.AddWithValue("@Cont_Sup_ID", int.Parse(txt_ID.Text));
                    Cmd.Parameters.AddWithValue("@Sup_ID", Sup_ID);
                    Cmd.Parameters.AddWithValue("@Office_Phone", txt_Phone.Text);
                    Cmd.Parameters.AddWithValue("@Name", txt_Name.Text);
                    Cmd.Parameters.AddWithValue("@bank_Account", txt_Bank_Account.Text);
                    Cmd.Parameters.AddWithValue("@E_Mail", txt_Email.Text);
                    Cmd.Parameters.AddWithValue("@Fax", txt_Fax.Text);
                    Cmd.Parameters.AddWithValue("@Job_Position ", txt_position.Text);
                    take_Insert_Update_Delete(Cmd);
                    MessageBox.Show("Saved");
                    frm_contact_Supplier_Load(sender, e);
                }


            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }



        }
        private void update_Statement()
        {
            try
            {
                SqlCommand Cmd = new SqlCommand("UPDATE [dbo].[Contact_Supplier]  SET   [Name] = @Name  ,[E_Mail] = @E_Mail  ,[Fax] = @Fax  ,[Job_Position] = @Job_Position ,[bank_Account] = @bank_Account ,[Office_Phone] = @Office_Phone  WHERE [Cont_Sup_ID] = @Cont_Sup_ID and [Sup_ID] = @Sup_ID ", conn);
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@Cont_Sup_ID", int.Parse(txt_ID.Text));
                Cmd.Parameters.AddWithValue("@Sup_ID", Sup_ID);
                Cmd.Parameters.AddWithValue("@Office_Phone", txt_Phone.Text);
                Cmd.Parameters.AddWithValue("@Name", txt_Name.Text);
                Cmd.Parameters.AddWithValue("@bank_Account", txt_Bank_Account.Text);
                Cmd.Parameters.AddWithValue("@E_Mail", txt_Email.Text);
                Cmd.Parameters.AddWithValue("@Fax", txt_Fax.Text);
                Cmd.Parameters.AddWithValue("@Job_Position", txt_position.Text);
                take_Insert_Update_Delete(Cmd);
                MessageBox.Show("Edited");
                frm_contact_Supplier_Load(sender, e);

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void delete_Statement()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[Contact_Supplier] WHERE [Cont_Sup_ID] = @Cont_Sup_ID and [Sup_ID] = @Sup_ID", conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Cont_Sup_ID", int.Parse(txt_ID.Text));
                cmd.Parameters.AddWithValue("@Sup_ID", Sup_ID);
                take_Insert_Update_Delete(cmd);
                MessageBox.Show("Deleted");
                frm_contact_Supplier_Load(sender, e);

            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

    
        public int Return_One_valueint(SqlCommand CMD)
        {
            SqlDataAdapter dad = new SqlDataAdapter(CMD);
            DataTable DT = new DataTable();
            dad.Fill(DT);
            DataRow row = DT.Rows[0];
            int x = (int)row[0];
            return x;
        }
        public String Return_One_valuestring(SqlCommand CMD)
        {
            SqlDataAdapter dad = new SqlDataAdapter(CMD);
            DataTable DT = new DataTable();
            dad.Fill(DT);
            DataRow row = DT.Rows[0];
            String x = row[0].ToString();
            return x;
        }
        public DataTable Return_datatable_value(SqlCommand CMD)
        {
            SqlDataAdapter dad = new SqlDataAdapter(CMD);
            DataTable DT = new DataTable();
            dad.Fill(DT);
            return DT;
        }
        public void take_Insert_Update_Delete(SqlCommand CMD)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            CMD.ExecuteNonQuery();
            conn.Close();
        }

      

        public object sender { get; set; }

        public EventArgs e { get; set; }

        private void dgv_Contact_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_ID.Text = dgv_Contact.CurrentRow.Cells[0].Value.ToString();
           txt_Name.Text = dgv_Contact.CurrentRow.Cells[1].Value.ToString();
           txt_Phone.Text = dgv_Contact.CurrentRow.Cells[2].Value.ToString();
           txt_Email.Text = dgv_Contact.CurrentRow.Cells[3].Value.ToString();
           txt_Fax.Text = dgv_Contact.CurrentRow.Cells[4].Value.ToString();
           txt_position.Text = dgv_Contact.CurrentRow.Cells[5].Value.ToString();
           txt_Bank_Account.Text = dgv_Contact.CurrentRow.Cells[6].Value.ToString();
           btn_Delete.Enabled = true;
        }

        private void txt_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txt_Fax_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
  
  
    
    }
}
