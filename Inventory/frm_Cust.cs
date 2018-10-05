using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory
{
    public partial class frm_Cust : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
        public frm_Cust(int x , string m )
        {
            IID = x;
            edit_or_add = m;
            InitializeComponent();
        }

        public frm_Cust(string m)
        {
            edit_or_add = m;

            InitializeComponent();
        }
        public string  edit_or_add ="";
        public int IID;

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (edit_or_add == "add")
                {

                    Boolean PK_Test = primary_Test();
                    // first if ::: must enter  ID and First name at least 
                    if (string.IsNullOrWhiteSpace(txt_ID.Text) || string.IsNullOrWhiteSpace(txt_Name.Text))
                    {
                        MessageBox.Show("you must enter  ID and First name at least");
                    }
                    else
                    {

                        if (PK_Test == true)
                        {
                            MessageBox.Show("This ID Is Already Exist");
                        }
                        else
                        {
                            try
                            {
                                most_inseert();
                                phone();
                                MessageBox.Show("Saved");
                                this.Close();
                                frm_Find_Cust f = new frm_Find_Cust();
                                f.Show();
                            }
                            catch (Exception exp)
                            {

                                MessageBox.Show(exp.Message);
                            }
               

                        }   
                    }
                }
                else if (edit_or_add == "edit")
                {
                    try
                    {
                        most_edit();
                        //delete and then insert
                        Delete_All_Phones();
                        // insertohm mn 2wel w gdeed
                        phone();
                        MessageBox.Show("Edited");
                        this.Close();
                        frm_Find_Cust f = new frm_Find_Cust();
                        f.Show();
                        
                    }
                    catch (Exception exp)
                    {

                        MessageBox.Show(exp.Message);
                    }
               



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
           
        }

        private void Delete_All_Phones()
        {            try
            {
                SqlCommand cmdd = new SqlCommand("DELETE FROM [dbo].[Customer_Phone] WHERE [Cust_ID]=@Cust_ID", con);
                cmdd.Parameters.AddWithValue("@Cust_ID", txt_ID.Text);
                if (con.State != ConnectionState.Open)
                    con.Open();
                cmdd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }

        }

        private void most_edit()
        {            try
            {
                SqlCommand cmdd = new SqlCommand("UPDATE [dbo].[Customer] SET [Name] =@Name ,[Country] = @Country,[Post_Code]=@post_Code ,[City]=@City ,[Address]=@Address  ,[E_Mail] = @Email,[Banking_Account] = @Bank_Account,[Fax] =@Fax ,[Note] = @Notes WHERE [Cust_ID] =@ID", con);
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

        private Boolean primary_Test()
        {
            // to sure id  mosh hytkrr PK constraint
            SqlCommand cmd6 = new SqlCommand("SELECT * FROM [dbo].[Customer] where [Cust_ID]= @Cust_ID", con);
            cmd6.Parameters.AddWithValue("@Cust_ID", txt_ID.Text);
            if (con.State != ConnectionState.Open)
                con.Open();
            IDataReader dr = cmd6.ExecuteReader();
            Boolean PK_Test;
            if (dr.Read() == true)
            {
                PK_Test = true;

            }
            else
            {
                PK_Test = false;
            }

            con.Close();
            return PK_Test;
        }

        private void phone()
        {
            SqlCommand Cmd;
            if (!string.IsNullOrWhiteSpace(txt_Phone1.Text))
            {
                Cmd = new SqlCommand("INSERT INTO [dbo].[Customer_Phone] VALUES (@IDphone, @Phone1)", con);
                Cmd.Parameters.AddWithValue("@IDphone", txt_ID.Text);
                Cmd.Parameters.AddWithValue("@Phone1", txt_Phone1.Text);

                if (con.State != ConnectionState.Open)
                    con.Open();
                Cmd.ExecuteNonQuery();
                con.Close();

            }
            if (!string.IsNullOrWhiteSpace(txt_Phone2.Text))
            {
                Cmd = new SqlCommand("INSERT INTO [dbo].[Customer_Phone] VALUES (@IDphone2,@Phone2)", con);
                Cmd.Parameters.AddWithValue("@IDphone2", txt_ID.Text);
                Cmd.Parameters.AddWithValue("@Phone2", txt_Phone2.Text);

                if (con.State != ConnectionState.Open)
                    con.Open();
                Cmd.ExecuteNonQuery();
                con.Close();
                
            }
            if (!string.IsNullOrWhiteSpace(txt_Phone3.Text))
            {
                Cmd = new SqlCommand("INSERT INTO [dbo].[Customer_Phone] VALUES (@IDphone3,@Phone3)", con);
                Cmd.Parameters.AddWithValue("@IDphone3", txt_ID.Text);
                Cmd.Parameters.AddWithValue("@Phone3", txt_Phone3.Text);

                if (con.State != ConnectionState.Open)
                    con.Open();
                Cmd.ExecuteNonQuery();
                con.Close();
            }

        }

        private void most_inseert()
        {
            SqlCommand cmdd = new SqlCommand("INSERT INTO [dbo].[Customer] (Cust_ID,Name,Country,E_Mail,Banking_Account,Fax,Note,City,Address ,Post_Code, Valid) VALUES(@ID,@Name,@Country,@Email,@Bank_Account,@Fax,@Notes ,@City,@Address ,@Post_Code ,'True')", con);
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
            //dr.Close();
            cmdd.ExecuteNonQuery();
            con.Close();
        }

        private void frm_Add_Cust_Load(object sender, EventArgs e)
        {
            if (edit_or_add=="add")
            {
            
                SqlCommand cmd = new SqlCommand("declare @X int=(Select Count([Cust_ID]) from [dbo].[Customer])  if(@X=0) select 1  else (select max([Cust_ID])+1 from [dbo].[Customer])", con);
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
                
                txt_Country.Enabled = false;
                txt_City .Enabled = false;
                txt_Address .Enabled = false;
                txt_Phone1.Enabled = false;
                txt_Phone2.Enabled = false;
                txt_Phone3.Enabled = false;
                txt_Bank_Account.Enabled = false;
                txt_Email.Enabled = false;
                txt_Notes.Enabled = false;
                txt_Fax.Enabled = false;
                txt_Name.Enabled = false;
                txt_Post_Code.Enabled = false;
            
                Show_All_Details();
                Show_Phone();
                
                


            }
            else if (edit_or_add == "edit")
            {
                Show_All_Details();
                Show_Phone();


            }

        }

        private void Show_Phone()
        {
            

            // msh shghala
            SqlCommand cmd_P1 = new SqlCommand("PRO_Phone_Customer @ID", con);
            cmd_P1.Parameters.AddWithValue("@ID", IID);
            SqlDataAdapter dad_P = new SqlDataAdapter(cmd_P1);
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

        private void Show_All_Details()
        {
            SqlCommand cmd = new SqlCommand("select * from [dbo].[Customer] where [Cust_ID]=@ID", con);
            cmd.Parameters.AddWithValue("@ID", IID);
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            dad.Fill(DT);
            DataRow row = DT.Rows[0];
            txt_ID.Enabled = false;
            txt_ID.Text = row[0].ToString();
            txt_Bank_Account.Text = row[7].ToString();
            txt_Country.Text = row[2].ToString();
            txt_Fax.Text = row[8].ToString();
            txt_Email.Text = row[6].ToString();
            txt_Notes.Text = row[9].ToString();
            txt_City.Text = row[3].ToString();
            txt_Address.Text = row[4].ToString();
            txt_Name.Text = row[1].ToString();
            txt_Post_Code.Text = row[5].ToString();
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

        private void txt_Fax_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("You should enter numbers Only ", txt_Fax, 20000);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gbo_Cust_Info_Enter(object sender, EventArgs e)
        {

        }

        private void gbo_Phone_Enter(object sender, EventArgs e)
        {

        }

        //private void frm_Add_Cust_form_Closing(object sender, FormClosingEventArgs e)
        //{
        //    frm_Find_Cust f = new frm_Find_Cust();
        //    f.Show();
        //}

      




    }
}
