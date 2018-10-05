using System;
using System.Windows.Forms;


namespace Inventory
{
    public partial class Frm_Main : Form
    {
        //string User_Name;
        public Frm_Main(string n)
        {
            InitializeComponent();
            lbl_User_Name.Text = n;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Find_Supplier form_Search_Supplier = new frm_Find_Supplier();
            form_Search_Supplier.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_Find_Supplier form_Search_Supplier = new frm_Find_Supplier();
            form_Search_Supplier.ShowDialog();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_Supplier f1 = new frm_Supplier("add");
            f1.ShowDialog();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_Find_Supplier form_Search_Supplier = new frm_Find_Supplier();
            form_Search_Supplier.ShowDialog();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Find_Cust form_Search_Customer = new frm_Find_Cust();
            form_Search_Customer.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frm_Find_Cust form_Search_Customer = new frm_Find_Cust();
            form_Search_Customer.ShowDialog();
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frm_Cust f1 = new frm_Cust("add");
            f1.ShowDialog();
        }

        private void deleteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frm_Find_Cust form_Search_Customer = new frm_Find_Cust();
            form_Search_Customer.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_Find_Store form_Search_Store = new frm_Find_Store();
            form_Search_Store.ShowDialog();
        }

        private void searchEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Find_Store form_Search_Store = new frm_Find_Store();
            form_Search_Store.ShowDialog();
        }

        private void deleteToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frm_Find_Store form_Search_Store = new frm_Find_Store();
            form_Search_Store.ShowDialog();
        }

        private void addToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frm_Add_Store frm1 = new frm_Add_Store("add");
            frm1.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frm_Main_Purch ff = new frm_Main_Purch();
            ff.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frm_Main_Sales fff = new frm_Main_Sales();
            fff.ShowDialog();
        }

        
        private void btn_Calculator_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process p = System.Diagnostics.Process.Start("calc.exe");
            //p.WaitForInputIdle();
            //NativeMethods.SetParent(p.MainWindowHandle, this.Handle);

            System.Diagnostics.Process.Start("calc");
        }

        private void searchEditToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frmEmpSearchDelete f = new frmEmpSearchDelete();
            f.Show();
        }

        private void deleteToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            frmEmpSearchDelete f = new frmEmpSearchDelete();
            f.Show();
        }

        private void addToolStripMenuItem11_Click(object sender, EventArgs e)
        {

            frmEmpAddEdit fae = new frmEmpAddEdit("add");
            fae.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            frmEmpSearchDelete f = new frmEmpSearchDelete();
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frm_Find_Return f = new frm_Find_Return();
            f.Show();
        }

        private void searchEditToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frm_Find_Return f = new frm_Find_Return();
            f.Show();
        }

        private void deleteToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            frm_Find_Return f = new frm_Find_Return();
            f.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Find_Return f = new frm_Find_Return();
            f.Show();
        }

        private void addToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            frm_Returns f = new frm_Returns("add");
            f.Show();
        }

        private void addToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            frm_Transferring_From_To f = new frm_Transferring_From_To("add");
            f.Show();
        }

        private void searchEditToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frm_Find_Transferring_From_To f = new frm_Find_Transferring_From_To();
            f.Show();
        }

        private void deleteToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            frm_Find_Transferring_From_To f = new frm_Find_Transferring_From_To();
            f.Show();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Find_Transferring_From_To f = new frm_Find_Transferring_From_To();
            f.Show();
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_Find_Store form_Search_Store = new frm_Find_Store();
            form_Search_Store.ShowDialog();
        }

        private void editToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frm_Find_Supplier form_Search_Supplier = new frm_Find_Supplier();
            form_Search_Supplier.ShowDialog();
        }

        private void editToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frm_Find_Cust form_Search_Customer = new frm_Find_Cust();
            form_Search_Customer.ShowDialog();
        }

        private void editToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmEmpSearchDelete f = new frmEmpSearchDelete();
            f.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frm_Find_Transferring_From_To f = new frm_Find_Transferring_From_To();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm_Find_Add_Finish_To_Store f = new frm_Find_Add_Finish_To_Store();
            f.Show();
        }

        private void addFinalProductToStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            frm_Add_Finish_To_Store f = new frm_Add_Finish_To_Store();
            f.Show();
        }

        private void editToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frm_Find_Add_Finish_To_Store f = new frm_Find_Add_Finish_To_Store();
            f.Show();
        }

        private void deleteToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            frm_Find_Add_Finish_To_Store f=new frm_Find_Add_Finish_To_Store();
            f.Show();
        }

        private void searchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_Find_Add_Finish_To_Store f = new frm_Find_Add_Finish_To_Store();
            f.Show();
        }

        private void addToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frm_Purchase_Invoice f = new frm_Purchase_Invoice("Add");
            f.Show();
        }

        private void editToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frm_Find_Purchase_Invoice f = new frm_Find_Purchase_Invoice();
            f.Show();
        }

        private void searchEditToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_Find_Purchase_Invoice f = new frm_Find_Purchase_Invoice();
            f.Show();
        }

        private void deleteToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frm_Find_Purchase_Invoice f = new frm_Find_Purchase_Invoice();
            f.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frm_Purchase_Order f = new frm_Purchase_Order();
            f.Show();
        }

        private void searchEditToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Find_Order_Purchase f = new frm_Find_Order_Purchase();
            f.Show();
        }

        private void deleteToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frm_Find_Order_Purchase f = new frm_Find_Order_Purchase();
            f.Show();
        }

        private void editToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frm_Find_Order_Purchase f = new frm_Find_Order_Purchase();
            f.Show();
        }

        private void addToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frm_Sales_Order f = new frm_Sales_Order("add");
            f.Show();
        }

        private void searchEditToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frm_Find_Order_Sales f = new frm_Find_Order_Sales();
            f.Show();
        }

        private void deleteToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frm_Find_Order_Sales f = new frm_Find_Order_Sales();
            f.Show();
        }

        private void editToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            frm_Find_Order_Sales f = new frm_Find_Order_Sales();
            f.Show();
        }

        private void addToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frm_Sales_Invoice fsinv = new frm_Sales_Invoice("fsinv");
            fsinv.Show();
        }

        private void searchEditToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frm_Find_Cus_Invoices fndcust = new frm_Find_Cus_Invoices();
            fndcust.Show();
        }

        private void deleteToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frm_Find_Cus_Invoices fndcust = new frm_Find_Cus_Invoices();
            fndcust.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_Finish_Item_Search f = new frm_Finish_Item_Search();
            f.Show();
        }

        private void lbl_User_Name_Click(object sender, EventArgs e)
        {

        }
    }
}
