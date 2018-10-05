using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory
{
    public partial class frm_Sales_Order : Form
    {
        public string edit_or_add = "";
        public int IID;
        DataTable DT_Qty = new DataTable();


        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
        bool flage = false;
        bool xx = false;


        
        public frm_Sales_Order(string m)
        {
            InitializeComponent();
            edit_or_add = m;
        }
       
        public frm_Sales_Order(int x, string m)
        {
            InitializeComponent();
            edit_or_add = m;
            IID = x;
        }




        private void MaxIDtxt()
        {
            String Query = "select max([Sal_Ord_ID])+1 from [dbo].[Sales_Order]  ";
            SqlCommand Cmd = new SqlCommand(Query, conn);
            SqlDataAdapter dad = new SqlDataAdapter(Cmd);
            DataTable DT = new DataTable();
            dad.Fill(DT);
            DataRow row = DT.Rows[0];
            txt_Ord_No.Text = row[0].ToString();
            txt_Ord_No.Enabled = false;
        }

      

        private void Orders__Sales_Load(object sender, EventArgs e)
        {
            
            
            SqlCommand cmd = new SqlCommand("select * from [dbo].[Customer]", conn);
            conn.Open();
            SqlDataReader readsup = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(readsup);
            conn.Close();
            cbo_Cust_Name.DataSource = dt;
            cbo_Cust_Name.ValueMember = "Cust_ID";
            cbo_Cust_Name.DisplayMember = "Name";
            cbo_Cust_Name.SelectedIndex = -1;


          

            SqlCommand cmd4 = new SqlCommand("select[Emp_ID],[Name] from [dbo].[Employee]", conn);
            conn.Open();
            SqlDataReader reademp = cmd4.ExecuteReader();
            DataTable dt4 = new DataTable();
            dt4.Load(reademp);
            conn.Close();
            cbo_Created_By.DataSource = dt4;
            cbo_Created_By.ValueMember = "Emp_ID";
            cbo_Created_By.DisplayMember = "Name";
            cbo_Created_By.SelectedIndex = -1;



            SqlCommand cmd1 = new SqlCommand("select * from [dbo].[Item_Category]", conn);
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


            if (edit_or_add == "add")
            {

                MaxIDtxt();
            }
            else if (edit_or_add == "edit")
            {
                Show_All_Return_Details();



            }
        
        }
       
        public void Show_All_Return_Details()
        {
           //  [0],[1],[2],3],[4] from Sales_Order where [Sal_Ord_ID]
            SqlCommand cmd = new SqlCommand("select [Sal_Ord_ID],[Emp_ID],[Cust_ID],[Created_At],[Notes] from Sales_Order where [Sal_Ord_ID]=@ID", conn);
            cmd.Parameters.AddWithValue("@ID", IID);
            SqlDataAdapter dad_Edit = new SqlDataAdapter(cmd);
            DataTable DT_Edit = new DataTable();
            dad_Edit.Fill(DT_Edit);


            txt_Ord_No.Text = IID.ToString();
            cbo_Cust_Name.SelectedValue = DT_Edit.Rows[0][2];
            cbo_Created_By.SelectedValue = DT_Edit.Rows[0][1];
            dtp_Ord_Date.Value = Convert.ToDateTime(DT_Edit.Rows[0][3]);
            txt_Notes.Text = DT_Edit.Rows[0][4].ToString();



            SqlCommand cmd_Qty = new SqlCommand("exec SPshow_Sales_orderDetail @Order_ID", conn);
            cmd_Qty.Parameters.AddWithValue("@Order_ID", txt_Ord_No.Text);
            SqlDataAdapter dad_Qty = new SqlDataAdapter(cmd_Qty);

            dad_Qty.Fill(DT_Qty);

            dgv_sales_Ord.DataSource = DT_Qty;
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
                //cmd2.Parameters.AddWithValue("@Itm_Cat_ID", cbo_Itm_Cat.SelectedValue);
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
       
        
             private void btn_Add_Itm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_Itm_No.Text) || String.IsNullOrWhiteSpace(txt_Qty.Text) ||  cbo_Itm_Cat.SelectedIndex==-1|| cbo_Itm_Name.SelectedIndex==-1)
            {
                MessageBox.Show("Please fill all data");
                return;
            }

    int x = cbo_Created_By.SelectedIndex;
    int s = cbo_Itm_Name.SelectedIndex;
    int d = cbo_Itm_Cat.SelectedIndex;
            foreach (DataGridViewRow CurrentRow in dgv_sales_Ord.Rows)
            {
                if (Convert.ToInt32(CurrentRow.Cells[0].Value) == int.Parse(txt_Itm_No.Text))
                {
                    MessageBox.Show("This Item already exist");
                    return;
                }
            }
            dgv_sales_Ord.Rows.Add();

            dgv_sales_Ord.Rows[incerment].Cells[0].Value = txt_Itm_No.Text;

            dgv_sales_Ord.Rows[incerment].Cells[1].Value =cbo_Itm_Cat.Text ;
            dgv_sales_Ord.Rows[incerment].Cells[2].Value = cbo_Itm_Name.Text;
            dgv_sales_Ord.Rows[incerment].Cells[3].Value = txt_Qty.Text;

            incerment++;

        }

      

        private void cbo_Itm_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (xx == true)
            { txt_Itm_No.Text = cbo_Itm_Name.SelectedValue.ToString(); }
        }

        private void btn_Del_Itm_Click(object sender, EventArgs e)
        {
            int Rows_Count = dgv_sales_Ord.Rows.Count - 1;
            if (Rows_Count > 0)
            {
                dgv_sales_Ord.Rows.Remove(dgv_sales_Ord.CurrentRow);
            }
        }


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_Ord_No.Text) || String.IsNullOrWhiteSpace(txt_Qty.Text) || cbo_Cust_Name.SelectedIndex==-1 || cbo_Created_By.SelectedIndex==-1)
            {
                MessageBox.Show("Please fill all data");
                return;
            }// insert into[dbo].[Sales_Order] values([Sal_Ord_ID],[Emp_ID],[Cust_ID],[Created_At])
            //insert into[dbo].[Sales_Order_Details]values([Sal_Ord_ID],[Itm_Sub_ID],[Qty])


            //SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");

            try
            {//[Sal_Ord_ID],[Emp_ID],[Cust_ID],[Created_At]Notes]))
                SqlCommand Cmd = new SqlCommand("INSERT INTO[dbo].[Sales_Order] VALUES (@Sal_Ord_ID,@Emp_ID,@Cust_ID,@Created_At,@Notes)", conn);
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@Sal_Ord_ID", int.Parse(txt_Ord_No.Text));
                Cmd.Parameters.AddWithValue("@Emp_ID", int.Parse(cbo_Created_By.SelectedValue.ToString()));

                Cmd.Parameters.AddWithValue("@Cust_ID", int.Parse(cbo_Cust_Name.SelectedValue.ToString()));
                Cmd.Parameters.AddWithValue("@Created_At", Convert.ToDateTime(dtp_Ord_Date.Text));
                Cmd.Parameters.AddWithValue("@Notes", txt_Notes.Text);



                if (conn.State != ConnectionState.Open)
                    conn.Open();
                Cmd.ExecuteNonQuery();
                conn.Close();


                int Rows_Count = dgv_sales_Ord.Rows.Count - 1;
                for (int i = 0; i < Rows_Count; i++)
                {//[Sal_Ord_ID],[Itm_Sub_ID],[Qty])
                    SqlCommand Cmd_Item = new SqlCommand("  INSERT INTO [dbo].[Sales_Order_Details] VALUES  (@Sal_Ord_ID  ,@Itm_Sub_ID ,@Qty)", conn);
                    Cmd_Item.Parameters.AddWithValue("@Sal_Ord_ID", int.Parse(txt_Ord_No.Text));
                    Cmd_Item.Parameters.AddWithValue("@Itm_Sub_ID", int.Parse(dgv_sales_Ord.Rows[i].Cells[0].Value.ToString()));
                    Cmd_Item.Parameters.AddWithValue("@Qty", int.Parse(dgv_sales_Ord.Rows[i].Cells[3].Value.ToString()));
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













            }
        }

        





        

