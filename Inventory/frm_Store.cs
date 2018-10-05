using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory
{
    public partial class frm_Add_Store : Form
    {
        public string edit_or_add = "";
        public int IID;
        public frm_Add_Store(string m)
        {
            InitializeComponent();
            edit_or_add = m;
        }
        public frm_Add_Store(int x, string m)
        {
            InitializeComponent();
            edit_or_add = m;
            IID = x;
        }

        
        SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
        SqlDataAdapter dad = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataRow dr;

        private void frm_Add_Store_Load(object sender, EventArgs e)
        {
        
            Load_Cbo_Type();
            if (edit_or_add == "add")
            {
                Load_Store_ID();
            }
            else if (edit_or_add == "edit")
            {
                Show_Details();
            }
        }
        private void Show_Details()
        {
            SqlCommand cmd = new SqlCommand("SELECT [Sto_ID] ,[Sto_Cat_ID] ,[Capacity] ,[Area] ,[Address] ,[Phone] ,[Name] FROM [dbo].[Store] where [Sto_ID]=@Sto_ID", Conn);
            cmd.Parameters.AddWithValue("@Sto_ID", IID);
            SqlDataAdapter dad_Edit = new SqlDataAdapter(cmd);
            DataTable DT_Edit = new DataTable();
            dad_Edit.Fill(DT_Edit);
            DataRow row_Edit = DT_Edit.Rows[0];
            txt_ID.Enabled = false;
            txt_ID.Text = IID.ToString();
            cbo_Type.SelectedValue = row_Edit[1];
            txt_Capacity.Text = row_Edit[2].ToString();
            txt_Area.Text = row_Edit[3].ToString();
            txt_Address.Text = row_Edit[4].ToString();
            txt_Phone.Text = row_Edit[5].ToString();
            txt_Name.Text = row_Edit[6].ToString();

        }

        private void Load_Cbo_Type()
        {
            String Query = "SELECT [Sto_Cat_ID] ,[Name] FROM [dbo].[Store_Category]";
            SqlCommand Cmd = new SqlCommand(Query, Conn);
            SqlDataAdapter dad = new SqlDataAdapter(Cmd);
            DataTable DT = new DataTable();
            dad.Fill(DT);
            DataRow row = DT.Rows[0];
            cbo_Type.DataSource = DT;
            cbo_Type.ValueMember = "Sto_Cat_ID";
            cbo_Type.DisplayMember = "Name";
            cbo_Type.SelectedIndex = -1;

        }

        private void Load_Store_ID()
        {
            String Query = "select max([Sto_ID])+1 from [dbo].[Store]";
            SqlCommand Cmd = new SqlCommand(Query, Conn);
            SqlDataAdapter dad = new SqlDataAdapter(Cmd);
            DataTable DT = new DataTable();
            dad.Fill(DT);
            DataRow row = DT.Rows[0];
            txt_ID.Text = row[0].ToString();
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (edit_or_add == "add")
                {
                    if (cbo_Type.SelectedIndex==-1 || String.IsNullOrWhiteSpace(txt_Name.Text))
                    {
                        MessageBox.Show("you must enter at least Type and name");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Store] ([Sto_ID] ,[Sto_Cat_ID] ,[Capacity] ,[Area] ,[Address] ,[Phone] ,[Name],[Valid]) VALUES(@Sto_ID,@Sto_Cat_ID,@Capacity,@Area,@Address,@Phone,@Name,'True')", Conn);
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@Sto_ID", int.Parse(txt_ID.Text));
                        cmd.Parameters.AddWithValue("@Sto_Cat_ID", cbo_Type.SelectedValue);
                        cmd.Parameters.AddWithValue("@Capacity", txt_Capacity.Text);
                        cmd.Parameters.AddWithValue("@Area", txt_Area.Text);
                        cmd.Parameters.AddWithValue("@Address", txt_Address.Text);
                        cmd.Parameters.AddWithValue("@Phone", txt_Phone.Text);
                        cmd.Parameters.AddWithValue("@Name", txt_Name.Text);

                        if (Conn.State != ConnectionState.Open)
                            Conn.Open();
                        cmd.ExecuteNonQuery();
                        Conn.Close();

                        MessageBox.Show("Store is added");
                        frm_Find_Store f = new frm_Find_Store();
                        f.Show();
                        this.Close();
                    }
                    
                }
                else if (edit_or_add == "edit")
                {
                    SqlCommand cmd = new SqlCommand("UPDATE [dbo].[Store] SET [Sto_Cat_ID] = @Sto_Cat_ID ,[Capacity] = @Capacity ,[Area] = @Area ,[Address] = @Address ,[Phone] = @Phone ,[Name] = @Name WHERE [Sto_ID]=@Sto_ID", Conn);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Sto_ID", int.Parse(txt_ID.Text));
                    cmd.Parameters.AddWithValue("@Sto_Cat_ID", cbo_Type.SelectedValue);
                    cmd.Parameters.AddWithValue("@Capacity", txt_Capacity.Text);
                    cmd.Parameters.AddWithValue("@Area", txt_Area.Text);
                    cmd.Parameters.AddWithValue("@Address", txt_Address.Text);
                    cmd.Parameters.AddWithValue("@Phone", txt_Phone.Text);
                    cmd.Parameters.AddWithValue("@Name", txt_Name.Text);

                    if (Conn.State != ConnectionState.Open)
                        Conn.Open();
                    cmd.ExecuteNonQuery();
                    Conn.Close();

                    MessageBox.Show("Store is edited");
                    frm_Find_Store f = new frm_Find_Store();
                    f.Show();
                    this.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Cbo_Type_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        private void txt_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlCommand Cmd = new SqlCommand("DELETE FROM [dbo].[Store] WHERE [Sto_ID]=@Sto_ID", Conn);
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Sto_ID", int.Parse(txt_ID.Text));
            if (Conn.State != ConnectionState.Open)
                Conn.Open();
            Cmd.ExecuteNonQuery();
            Conn.Close();
        }

        private void btn_Cat_delete_Click(object sender, EventArgs e)
        {
            SqlCommand Cmd = new SqlCommand("DELETE FROM [dbo].[Store_Category] WHERE [Sto_Cat_ID]=@Sto_Cat_ID", Conn);
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Sto_Cat_ID", cbo_Type.SelectedValue);
            if (Conn.State != ConnectionState.Open)
                Conn.Open();
            Cmd.ExecuteNonQuery();
            Conn.Close();
        }

        private void txt_Capacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txt_Area_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Find_Store f = new frm_Find_Store();
            f.Show();
            this.Close();
        }

        private void frm_Add_Store_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_Find_Store f = new frm_Find_Store();
            f.Show();
        }


    }
}
