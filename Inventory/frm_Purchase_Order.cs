using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Inventory
{
    public partial class frm_Purchase_Order : Form
    {
        public frm_Purchase_Order()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
        bool flage = false;
        bool xx = false;

        private void txt()
        {
            String Query = "select max([Pur_Ord_ID])+1 from [dbo].[Purchase_Order]  ";
            SqlCommand Cmd = new SqlCommand(Query, conn);
            SqlDataAdapter dad = new SqlDataAdapter(Cmd);
            DataTable DT = new DataTable();
            dad.Fill(DT);
            DataRow row = DT.Rows[0];
            string  x = row[0].ToString();
            if (x == "")
                 txt_Ord_No.Text = "1";
            else
            txt_Ord_No.Text = row[0].ToString();
       txt_Ord_No.Enabled = true;
        }
        private void frm_Purchase_Order_Load(object sender, EventArgs e)
        {
            txt();
            SqlCommand cmd = new SqlCommand("select * from [dbo].[Supplier]", conn);
            conn.Open();
            SqlDataReader readsup = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(readsup);
            conn.Close();
            cbo_Supp_Name.DataSource = dt;
            cbo_Supp_Name.ValueMember = "Sup_ID";
            cbo_Supp_Name.DisplayMember = "Name";
            cbo_Supp_Name.SelectedIndex = -1;


            SqlCommand cmd4 = new SqlCommand("select[Emp_ID],[Name] from [dbo].[Employee] where [Dept_ID]=2", conn);
            conn.Open();
            SqlDataReader reademp = cmd4.ExecuteReader();
            DataTable dt4 = new DataTable();
            dt4.Load(reademp);
            conn.Close();
            cbo_Created_By.DataSource = dt4;
            cbo_Created_By.ValueMember = "Emp_ID";
            cbo_Created_By.DisplayMember = "Name";
            cbo_Created_By.SelectedIndex = -1;

            SqlCommand cmd1 = new SqlCommand("select * from [dbo].[Item_Category] where [Type]='false'", conn);
            conn.Open();
            SqlDataReader readitem = cmd1.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(readitem);
            conn.Close();
            cbo_Itm_Cat.DataSource = dt1;
            cbo_Itm_Cat.ValueMember = "Itm_Cat_ID";
            cbo_Itm_Cat.DisplayMember = "Name";
            cbo_Itm_Cat.SelectedIndex = -1;
            flage = true;

            cbo_Itm_Name.SelectedIndex = -1;
        }

      

        private void cbo_Itm_Cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            if (flage == true)
            {//الكومبو بوكس بتاع اىتم نيم
                xx = false;
                SqlCommand cmd2 = new SqlCommand("select * from  [dbo].[Item_Subcategory] where [Itm_Cat_ID]=" + cbo_Itm_Cat.SelectedValue, conn);

                conn.Open();
                SqlDataReader readsitem = cmd2.ExecuteReader();
                DataTable dt2 = new DataTable();
                dt2.Load(readsitem);
                conn.Close();
                cbo_Itm_Name.DataSource = dt2;
                cbo_Itm_Name.DisplayMember = "Name";
                cbo_Itm_Name.ValueMember = "Itm_Sub_ID";

                cbo_Itm_Name.SelectedIndex = -1;
                xx = true;
            }
        }
        int incerment = 0;
        private void CheckItemExistance(int ItemID)
        {
            try
            {
               
              
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
                
            }
        }
        private void btn_Add_Itm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_Itm_No.Text) || String.IsNullOrWhiteSpace(Txt_Price.Text) || String.IsNullOrWhiteSpace(txt_Qty.Text) ||  cbo_Itm_Cat.Text == "Select Here" || cbo_Itm_Name.Text == "Select Here")
            {
                MessageBox.Show("Please fill all data");
                return;
            }

    int x = cbo_Created_By.SelectedIndex;
    int s = cbo_Itm_Name.SelectedIndex;
    int d = cbo_Itm_Cat.SelectedIndex;
            foreach (DataGridViewRow CurrentRow in dgv_Pur_Ord.Rows)
            {
                if (Convert.ToInt32(CurrentRow.Cells[0].Value) == int.Parse(txt_Itm_No.Text))
                {
                    MessageBox.Show("This Item already exist");
                    return;
                }
            }
            dgv_Pur_Ord.Rows.Add();

            dgv_Pur_Ord.Rows[incerment].Cells[0].Value = txt_Itm_No.Text;

            dgv_Pur_Ord.Rows[incerment].Cells[1].Value = cbo_Itm_Cat.Text;
            dgv_Pur_Ord.Rows[incerment].Cells[2].Value = cbo_Itm_Name.Text;
            dgv_Pur_Ord.Rows[incerment].Cells[3].Value = txt_Qty.Text;
            dgv_Pur_Ord.Rows[incerment].Cells[4].Value = Txt_Price.Text;

            incerment++;
        }

        private void btn_Del_Itm_Click(object sender, EventArgs e)
        {
            int Rows_Count = dgv_Pur_Ord.Rows.Count - 1;
            if (Rows_Count > 0)
            {
                dgv_Pur_Ord.Rows.Remove(dgv_Pur_Ord.CurrentRow);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {


            try
            {


                if (String.IsNullOrWhiteSpace(txt_Ord_No.Text) || String.IsNullOrWhiteSpace(Txt_Price.Text) || String.IsNullOrWhiteSpace(txt_Qty.Text) || cbo_Supp_Name.SelectedIndex == -1 || cbo_Created_By.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill all data");
                    return;
                }


                SqlCommand Cmd = new SqlCommand("INSERT INTO [dbo].[Purchase_Order] ([Pur_Ord_ID],[Emp_ID],[Sup_ID],[Created_At],notes)VALUES (@Pur_Ord_ID,@Emp_ID,@Sup_ID,@Created_At,@Notes)", conn);
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@Pur_Ord_ID", int.Parse(txt_Ord_No.Text));
                Cmd.Parameters.AddWithValue("@Emp_ID", int.Parse(cbo_Created_By.SelectedValue.ToString()));
               // Cmd.Parameters.AddWithValue("@Valid", (Check_Box_Vaild.CheckState));

                Cmd.Parameters.AddWithValue("@Sup_ID", int.Parse(cbo_Supp_Name.SelectedValue.ToString()));
                Cmd.Parameters.AddWithValue("@Created_At", Convert.ToDateTime(dtp_Ord_Date.Text));
                Cmd.Parameters.AddWithValue("@Notes", txt_Notes.Text);



                if (conn.State != ConnectionState.Open)
                    conn.Open();
                Cmd.ExecuteNonQuery();
                conn.Close();


                int Rows_Count = dgv_Pur_Ord.Rows.Count - 1;
                for (int i = 0; i < Rows_Count; i++)
                {//INSERT INTO [dbo].[Purchase_Order_Details]
                    // ([Pur_Ord_ID]
                    // ,[Itm_Sub_ID]
                    //,[Qty]
                    //,[Price])

                    SqlCommand Cmd_Item = new SqlCommand(" INSERT INTO [dbo].[Purchase_Order_Details] VALUES  (@Pur_Ord_ID  ,@Itm_Sub_ID ,@Qty,@Price)", conn);
                    Cmd_Item.Parameters.AddWithValue("@Pur_Ord_ID ", int.Parse(txt_Ord_No.Text));
                    Cmd_Item.Parameters.AddWithValue("@Itm_Sub_ID", int.Parse(dgv_Pur_Ord.Rows[i].Cells[0].Value.ToString()));
                    Cmd_Item.Parameters.AddWithValue("@Qty", int.Parse(dgv_Pur_Ord.Rows[i].Cells[3].Value.ToString()));
                    Cmd_Item.Parameters.AddWithValue("@Price", int.Parse(dgv_Pur_Ord.Rows[i].Cells[4].Value.ToString()));

                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    Cmd_Item.ExecuteNonQuery();
                    conn.Close();





                }
                MessageBox.Show("added");




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbo_Itm_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (xx == true)
            { txt_Itm_No.Text = cbo_Itm_Name.SelectedValue.ToString(); }
        }
    }
}
