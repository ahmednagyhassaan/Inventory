using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory
{
    public partial class frm_contact_Customer : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
        int Cust_ID;
        public frm_contact_Customer(int current_Cust)
        {
            InitializeComponent();
            Cust_ID = current_Cust;
        }

       private void txt_Bank_Account_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

       private void frm_contact_Customer_Load(object sender, EventArgs e)
        {
            try
            {
                //3yza 2lwed el text bta3 el id 

                SqlCommand CMd = new SqlCommand("declare @X int=(Select Count([Cont_Cust_ID]) from [dbo].[Contact_Customer] where [Cust_ID]=@Cust_ID)  if(@X=0) select 1  else (select max([Cont_Cust_ID])+1 from [dbo].[Contact_Customer] where [Cust_ID]=@Cust_ID)", conn);
                CMd.Parameters.AddWithValue("@Cust_ID", Cust_ID);
                txt_ID.Text = Return_One_valuestring(CMd);

                // 2lwed el grid
                Load_ELgrid();
                //fdelly el donia 3shan 2kteb kowise
                txt_Name.Text="";
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
               SqlCommand CMd = new SqlCommand("SELECT count ( [Cont_Cust_ID]) FROM [dbo].[Contact_Customer] where [Cont_Cust_ID]=@ID and  [Cust_ID]=@Cust_ID", conn);
           CMd.Parameters.Clear();
           CMd.Parameters.AddWithValue("@Cust_ID", Cust_ID);
           CMd.Parameters.AddWithValue("@ID", int.Parse(txt_ID.Text));
           int c = Return_One_valueint(CMd);
           if (c==0)
           {//mean insert
               insert_Statement();
           }
           else if (c==1)
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
           SqlCommand Cmd = new SqlCommand("SELECT [Cont_Cust_ID] ,[Name] ,[Phone]  ,[E_Mail]   ,[Fax] ,[Position] ,[Banking_Account] FROM [dbo].[Contact_Customer] WHERE  [Cust_ID] =@Cust_ID", conn);
           Cmd.Parameters.Clear();
           Cmd.Parameters.AddWithValue("@Cust_ID", Cust_ID);
           dgv_Contact.DataSource = Return_datatable_value(Cmd);
           
       }
       private void update_Statement()
       {
           try
           {
               SqlCommand Cmd = new SqlCommand("UPDATE [dbo].[Contact_Customer] SET [Phone] =@Phone ,[Name] =@Name  ,[Banking_Account] =@Banking_Account  ,[E_Mail] =@E_Mail  ,[Fax] =@Fax ,[Position]= @Position WHERE [Cont_Cust_ID] = @Cont_Cust_ID and [Cust_ID] =@Cust_ID ", conn);
               Cmd.Parameters.Clear();
               Cmd.Parameters.AddWithValue("@Cont_Cust_ID", int.Parse(txt_ID.Text));
               Cmd.Parameters.AddWithValue("@Cust_ID", Cust_ID);
               Cmd.Parameters.AddWithValue("@Phone", txt_Phone.Text);
               Cmd.Parameters.AddWithValue("@Name", txt_Name.Text);
               Cmd.Parameters.AddWithValue("@Banking_Account", txt_Bank_Account.Text);
               Cmd.Parameters.AddWithValue("@E_Mail", txt_Email.Text);
               Cmd.Parameters.AddWithValue("@Fax", txt_Fax.Text);
               Cmd.Parameters.AddWithValue("@Position", txt_position.Text);
               take_Insert_Update_Delete(Cmd);
               MessageBox.Show("Edited");
               frm_contact_Customer_Load(sender, e);

           }
           catch (Exception exp)
           {
               MessageBox.Show(exp.Message);
           }
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
                   SqlCommand Cmd = new SqlCommand("INSERT INTO [dbo].[Contact_Customer] ([Cont_Cust_ID] ,[Cust_ID]  ,[Phone]  ,[Name] ,[Banking_Account] ,[E_Mail] ,[Fax] ,[Position])  VALUES (@Cont_Cust_ID ,@Cust_ID ,@Phone , @Name  ,@Banking_Account  ,@E_Mail ,@Fax    ,@Position)", conn);
                   Cmd.Parameters.Clear();
                   Cmd.Parameters.AddWithValue("@Cont_Cust_ID", int.Parse(txt_ID.Text));
                   Cmd.Parameters.AddWithValue("@Cust_ID", Cust_ID);
                   Cmd.Parameters.AddWithValue("@Phone", txt_Phone.Text);
                   Cmd.Parameters.AddWithValue("@Name", txt_Name.Text);
                   Cmd.Parameters.AddWithValue("@Banking_Account", txt_Bank_Account.Text);
                   Cmd.Parameters.AddWithValue("@E_Mail", txt_Email.Text);
                   Cmd.Parameters.AddWithValue("@Fax", txt_Fax.Text);
                   Cmd.Parameters.AddWithValue("@Position", txt_position.Text);
                   take_Insert_Update_Delete(Cmd);
                   MessageBox.Show("Saved");
                   frm_contact_Customer_Load(sender, e);
               }
              

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
               SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[Contact_Customer] WHERE [Cust_ID]= @Cust_ID and [Cont_Cust_ID] = @Cont_Cust_ID", conn);
               cmd.Parameters.Clear();
               cmd.Parameters.AddWithValue("@Cont_Cust_ID", int.Parse(txt_ID.Text));
               cmd.Parameters.AddWithValue("@Cust_ID", Cust_ID);
               take_Insert_Update_Delete(cmd);
               MessageBox.Show("Deleted");
               frm_contact_Customer_Load(sender, e);

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
       public EventArgs e { get; set; }
       public object sender { get; set; }

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
    }
}
