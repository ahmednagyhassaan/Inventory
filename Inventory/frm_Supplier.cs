using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory
{
    public partial class frm_Supplier : Form
    {  SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
        public String edit_or_add="";
        public int IID=0;
        public frm_Supplier(int x , string m )
        {
            InitializeComponent();
             IID = x;
            edit_or_add = m;
          
        }
           public frm_Supplier( string m )
        {
            InitializeComponent();
           
            edit_or_add = m;
           
        }

        private void frm_Add_Supplier_Load(object sender, EventArgs e)
        {

            try
            {  

                if (edit_or_add == "add")
                {
                    SqlCommand cmd = new SqlCommand("declare @X int=(Select Count([Sup_ID]) from [dbo].[Supplier])  if(@X=0) select 1  else (select max([Sup_ID])+1 from [dbo].[Supplier])", con);
                    SqlDataAdapter dad = new SqlDataAdapter(cmd);
                    DataTable DT = new DataTable();
                    dad.Fill(DT);
                    DataRow row = DT.Rows[0];
                    txt_ID.Text = row[0].ToString();
                    txt_Bank_Account.Text = "";
                    txt_Country.Text = "";
                    txt_Fax.Text = "";
                    txt_Email.Text = "";
                    txt_Notes.Text = "";
                    txt_Phone1.Text = "";
                    txt_Phone2.Text = "";
                    txt_Phone3.Text = "";
                    txt_City.Text = "";
                    txt_Address.Text = "";
                    txt_Name.Text = "";
                    txt_ID.Enabled = false;
                }
                else if (edit_or_add == "view")
                {
                    txt_ID.Enabled = false;
                    txt_Country.Enabled = false;
                    txt_City.Enabled = false;
                    txt_Address.Enabled = false;
                    txt_Phone1.Enabled = false;
                    txt_Phone2.Enabled = false;
                    txt_Phone3.Enabled = false;
                    txt_Bank_Account.Enabled = false;
                    txt_Email.Enabled = false;
                    txt_Notes.Enabled = false;
                    txt_Fax.Enabled = false;
                    txt_Name.Enabled = false;
                    txt_Post_Code.Enabled = false;
                    show_Main_Info();
                    SqlCommand cmd_P = new SqlCommand("EXECUTE [dbo].[PRO_Phone_Supplier] @ID", con);
                    cmd_P.Parameters.AddWithValue("@ID", txt_ID.Text);
                    SqlDataAdapter dad_P = new SqlDataAdapter(cmd_P);
                    DataTable DT_P = new DataTable();
                    dad_P.Fill(DT_P);
                    DataRow row_P = DT_P.Rows[0];
                    int x = int.Parse(row_P[0].ToString());
                    if (x == 1)
                    {
                        txt_Phone1.Text = row_P[1].ToString();
                    }
                    else if (x == 2)
                    {
                        txt_Phone1.Text = row_P[1].ToString();
                        txt_Phone2.Text = row_P[2].ToString();
                    }
                    else if (x == 3)
                    {
                        txt_Phone1.Text = row_P[1].ToString();
                        txt_Phone2.Text = row_P[2].ToString();
                        txt_Phone3.Text = row_P[3].ToString();
                    }

                }
                else if (edit_or_add == "edit")
                {
                    show_Main_Info();
                    // msh shghala
                    SqlCommand cmd_P = new SqlCommand("EXECUTE [dbo].[PRO_Phone_Supplier] @ID", con);
                    cmd_P.Parameters.AddWithValue("@ID",txt_ID.Text);
                    SqlDataAdapter dad_P = new SqlDataAdapter(cmd_P);
                    DataTable DT_P = new DataTable();
                    dad_P.Fill(DT_P);
                    DataRow row_P = DT_P.Rows[0];
                    int x = int.Parse(row_P[0].ToString());
                    if (x == 1)
                    {
                        txt_Phone1.Text = row_P[1].ToString();
                    }
                    else if (x == 2)
                    {
                        txt_Phone1.Text = row_P[1].ToString();
                        txt_Phone2.Text = row_P[2].ToString();
                    }
                    else if (x == 3)
                    {
                        txt_Phone1.Text = row_P[1].ToString();
                        txt_Phone2.Text = row_P[2].ToString();
                        txt_Phone3.Text = row_P[3].ToString();
                    }

                   

                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
           
        }

        private void show_Main_Info()
        {
            SqlCommand cmd = new SqlCommand("SELECT [Sup_ID] ,[Name] ,[Country] ,[City],[Address] ,[E_Mail] ,[BankAccount],[Fax],[Notes] FROM [dbo].[Supplier] where [Sup_ID]=@ID", con);
            cmd.Parameters.AddWithValue("@ID", IID);
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            dad.Fill(DT);
            DataRow row = DT.Rows[0];
            txt_ID.Enabled = false;
            txt_ID.Text = row[0].ToString();
            txt_Bank_Account.Text = row[6].ToString();
            txt_Country.Text = row[2].ToString();
            txt_Fax.Text = row[7].ToString();
            txt_Email.Text = row[5].ToString();
            txt_Notes.Text = row[8].ToString();
            txt_City.Text = row[3].ToString();
            txt_Address.Text = row[4].ToString();
            txt_Name.Text = row[1].ToString();
            txt_Post_Code.Text = row[5].ToString();
        }
        private void phone()
        {
            if (!string.IsNullOrWhiteSpace(txt_Phone1.Text))
            {
                SqlCommand Cmd_Phone1 = new SqlCommand("INSERT INTO [dbo].[Supplier_Phone] ([Sup_ID],[Phone]) VALUES( @IDphone , @Phone1)", con);
                Cmd_Phone1.Parameters.AddWithValue("@IDphone",int.Parse( txt_ID.Text));
                Cmd_Phone1.Parameters.AddWithValue("@Phone1", txt_Phone1.Text);

                if (con.State != ConnectionState.Open)
                    con.Open();
                Cmd_Phone1.ExecuteNonQuery();
                con.Close();

            }
            if (!string.IsNullOrWhiteSpace(txt_Phone2.Text))
            {
                SqlCommand Cmd_Phone2 = new SqlCommand("INSERT INTO [dbo].[Supplier_Phone] ([Sup_ID],[Phone]) VALUES( @IDphone2 , @Phone2)", con);
                Cmd_Phone2.Parameters.AddWithValue("@IDphone2", txt_ID.Text);
                Cmd_Phone2.Parameters.AddWithValue("@Phone2", txt_Phone2.Text);

                if (con.State != ConnectionState.Open)
                    con.Open();
                Cmd_Phone2.ExecuteNonQuery();
                con.Close();

            }
            if (!string.IsNullOrWhiteSpace(txt_Phone3.Text))
            {
                SqlCommand Cmd_Phone3 = new SqlCommand("INSERT INTO [dbo].[Supplier_Phone] ([Sup_ID],[Phone]) VALUES( @IDphone3 , @Phone3)", con);
                Cmd_Phone3.Parameters.AddWithValue("@IDphone3", txt_ID.Text);
                Cmd_Phone3.Parameters.AddWithValue("@Phone3", txt_Phone3.Text);

                if (con.State != ConnectionState.Open)
                    con.Open();
                Cmd_Phone3.ExecuteNonQuery();
                con.Close();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (edit_or_add == "add")
                {

                    if (string.IsNullOrWhiteSpace(txt_ID.Text) || string.IsNullOrWhiteSpace(txt_Name.Text))
                    {
                        MessageBox.Show("you must enter  ID and First name at least");
                    }
                    else
                    {
                        Most_Insert();
                        phone();
                        MessageBox.Show("Added");
                        this.Close();
                        frm_Find_Supplier f = new frm_Find_Supplier();
                        f.Show();
                        

                    }
                }
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }

            //DELETE FROM [dbo].[Supplier_Phone] WHERE [Sup_ID]=@Sup_ID


            if (edit_or_add == "edit")
            {
            try
            {
                most_edit();
                Delete_All_Phones();
                phone();
                MessageBox.Show("Edited");
                this.Close();
                frm_Find_Supplier f = new frm_Find_Supplier();
                f.Show();
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }

             
            }

        }
        private void most_edit()
        {
            try
            {
                SqlCommand cmdd = new SqlCommand("UPDATE [dbo].[Supplier] SET [Name] =@Name ,[Country] = @Country,[Post_Code]=@post_Code ,[City]=@City ,[Address]=@Address  ,[E_Mail] = @Email,[BankAccount] = @Bank_Account,[Fax] =@Fax ,[Notes] = @Notes where [Sup_ID]=@ID", con);
                cmdd.Parameters.AddWithValue("@ID", txt_ID.Text);
                cmdd.Parameters.AddWithValue("@Name", txt_Name.Text);
                cmdd.Parameters.AddWithValue("@Country", txt_Country.Text);
                cmdd.Parameters.AddWithValue("@post_Code", txt_Post_Code.Text);
                cmdd.Parameters.AddWithValue("@City", txt_City.Text);
                cmdd.Parameters.AddWithValue("@Address", txt_Address.Text);
                cmdd.Parameters.AddWithValue("@Email", txt_Email.Text);
                cmdd.Parameters.AddWithValue("@Bank_Account", txt_Bank_Account.Text);
                cmdd.Parameters.AddWithValue("@Fax", txt_Fax.Text);
                cmdd.Parameters.AddWithValue("@Notes", txt_Notes.Text);
                if (con.State != ConnectionState.Open)
                    con.Open();
                //dr.Close();
                cmdd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }

        }
        private void Delete_All_Phones()
        {
            SqlCommand Cmd_Phone_Delete = new SqlCommand("DELETE FROM [dbo].[Supplier_Phone] WHERE [Sup_ID]=@Sup_ID", con);
            Cmd_Phone_Delete.Parameters.AddWithValue("@Sup_ID", txt_ID.Text);
            if (con.State != ConnectionState.Open)
                con.Open();

            Cmd_Phone_Delete.ExecuteNonQuery();
            con.Close();
        }

        private void Most_Insert()
        {

            SqlCommand cmdd = new SqlCommand("INSERT INTO [dbo].[Supplier] ([Sup_ID] ,[Name] ,[Country]  ,[City]   ,[Address]  ,[E_Mail]  ,[BankAccount] ,[Fax] ,[Notes] ,[Post_Code],[Valid]) VALUES( @ID , @Name , @Country , @City , @Address , @Email , @Bank_Account , @Fax , @Notes,@Post_Code,'True' )", con);
            cmdd.Parameters.AddWithValue("@ID", txt_ID.Text);
            cmdd.Parameters.AddWithValue("@Name", txt_Name.Text);
            cmdd.Parameters.AddWithValue("@Country", txt_Country.Text);
            cmdd.Parameters.AddWithValue("@City", txt_City.Text);
            cmdd.Parameters.AddWithValue("@Address", txt_Address.Text);
            cmdd.Parameters.AddWithValue("@Post_Code", txt_Post_Code.Text);
            cmdd.Parameters.AddWithValue("@Email", txt_Email.Text);
            cmdd.Parameters.AddWithValue("@Bank_Account", txt_Bank_Account.Text);
            cmdd.Parameters.AddWithValue("@Fax", txt_Fax.Text);
            cmdd.Parameters.AddWithValue("@Notes", txt_Notes.Text);
            if (con.State != ConnectionState.Open)
                con.Open();

            cmdd.ExecuteNonQuery();
            con.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Phone1_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
    }
}
