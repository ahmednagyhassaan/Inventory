using System;
using System.Windows.Forms;

namespace Inventory
{
    public partial class frm_Main_Purch : Form
    {
        public frm_Main_Purch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Find_Order_Purchase f = new frm_Find_Order_Purchase();
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_Find_Purchase_Invoice f = new frm_Find_Purchase_Invoice();
            f.Show();
            this.Close();
        }
    }
}
