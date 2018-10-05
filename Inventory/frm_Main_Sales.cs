using System;
using System.Windows.Forms;

namespace Inventory
{
    public partial class frm_Main_Sales : Form
    {
        public frm_Main_Sales()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Find_Order_Sales f = new frm_Find_Order_Sales();
            f.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_Find_Cus_Invoices c = new frm_Find_Cus_Invoices();
            c.Show();
            

        }
    }
}
