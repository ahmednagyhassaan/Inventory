using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory
{
    public partial class frm_Purchase_Invoice_Details : Form
    {
        int inv_ID = 0;
        public frm_Purchase_Invoice_Details(int x)
        {
            InitializeComponent();
            inv_ID = x;
        }

        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select[Pur_Inv_ID] ,[Itm_Sub_ID],[Price], [Qty] ,[Discount],[FinalPrice] from [dbo].[Purchase_Inv_Details] WHERE  [Pur_Inv_ID]=@id", conn);
            cmd.Parameters.AddWithValue("@id", inv_ID);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dgv_AllInvoices.DataSource = dt;
        }


        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
