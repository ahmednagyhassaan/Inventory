using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace Inventory
{
    public partial class frm_Edit_Add_Finish_To_Store : Form
    {
        private bool FormLoadFlag;

        public string Edit = "";
        public int IID;

        public frm_Edit_Add_Finish_To_Store(string m)
        {
            InitializeComponent();
            Edit = m;
        }

        public frm_Edit_Add_Finish_To_Store(int x, string m)
        {
            InitializeComponent();
            Edit = m;
            IID = x;
        }
        bool OperationType = false;

        private void frm_Edit_Finish_Product_Load(object sender, EventArgs e)
        {
            ProjectTools.LoadCbo(cbo_Created_By, DataAccessLayer.GetDataTable("Employee", ""), "Name", "Emp_ID");
            string cmd2 =
                "select [Sto_ID],[Store].[Name]as st_Name FROM dbo.Store INNER JOIN dbo.Store_Category ON dbo.Store.Sto_Cat_ID =                         dbo.Store_Category.Sto_Cat_ID  where[Store].Sto_Cat_ID=[Store_Category].Sto_Cat_ID and [Store_Category].Name='Finish'";


            ProjectTools.LoadCbo(cbo_Stock_Name, DataAccessLayer.GetDataTableComplex(cmd2, ""), "st_Name", "Sto_ID");
            ProjectTools.LoadCbo(cbo_Itm_Cat, DataAccessLayer.GetDataTable("Item_Category", ""), "Name", "Itm_Cat_ID");

            txt_Add_No.Text = DataAccessLayer.NewRowID("Add_Finish_Process", "Add_Finish_ID");
            // EnableHeadDetails(true, false);
            FormLoadFlag = true;
           
            try
            {
                DataRow row_Edit = DataAccessLayer.GetRowByID("Add_Finish_Process", "Add_Finish_ID", IID.ToString());
                txt_Add_No.Text = IID.ToString();
                cbo_Created_By.SelectedValue = row_Edit[1];
                txt_Notes.Text = row_Edit[3].ToString();
                cbo_Stock_Name.SelectedValue = row_Edit[4].ToString();

                dgv_Itm_Returned.Rows.Clear();

                FillTheFormDetails(DataAccessLayer.GetRowsByID("ViewFinishOrder", "Add_Finish_ID", IID.ToString()));

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                throw;
            }

        }

        private void cbo_Itm_Cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (FormLoadFlag)
                    ProjectTools.LoadCbo(cbo_Itm_Name,
                        DataAccessLayer.GetDataTable("Item_Subcategory",
                            " where Itm_Cat_ID = " + (cbo_Itm_Cat.SelectedValue).ToString()), "Name", "Itm_Sub_ID");
            }

            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private bool FormValidate_Head()
        {
            if (txt_Add_No.Text != "" && cbo_Created_By.SelectedItem != null && cbo_Stock_Name.SelectedItem != null)
                return true;
            else
                return false;
        }

        private bool FormValidate_Details()
        {
            if (cbo_Itm_Cat.SelectedItem != null && cbo_Itm_Name.SelectedItem != null && txt_Price.Text != "" &&
                txt_Qty_Big_Unit.Text != null && txt_Qty_Small_Unit.Text != null)
                if (Convert.ToInt32(txt_Qty_Big_Unit.Text) <= 0 && Convert.ToInt32(txt_Qty_Small_Unit.Text) <= 0)
                    return false;
                else
                    return true;
            else
                return false;
        }





        int z = 0;

        private void btn_Add_Itm_Click(object sender, EventArgs e)
        {
            try
            {
                //Check if the Details is Validated
                if (FormValidate_Details())
                {
                    //Check if the item already esixt in the grid view. 
                    Hashtable Params = new Hashtable();
                    Params.Add("@Qty_Unit", Convert.ToInt32(txt_Qty_Big_Unit.Text));
                    Params.Add("@Qty_Smallest_Unit", Convert.ToInt32(txt_Qty_Small_Unit.Text));
                    Params.Add("@Itm_ID", Convert.ToInt32(cbo_Itm_Name.SelectedValue));
                    outputParams QtyParam = new outputParams() { ParamName = "Qty", ParamValue = 0 };
                    int Qty = Convert.ToInt32(DataAccessLayer.RunStoredProcedure("PRO_Itm_Qty", Params, QtyParam));
                    int RowSelected = CheckItemExistance(Convert.ToInt32(cbo_Itm_Name.SelectedValue));

                    if (RowSelected >= 0)

                        //if true Update the Qty 
                        FillTheRow(RowSelected, Qty);
                    else
                    {
                        //false Add New Row
                        //DataRow row = DT.Rows[0];   //txt_Itm_No.ToString()
                        //dgv_Itm_Returned.Rows.Add();
                        //dgv_Itm_Returned.DataSource = DataAccessLayer.GetDataTable();
                       int y = dgv_Itm_Returned.Rows.Count;
                        z =  y-1 ;
                       
                        dgv_Itm_Returned.Rows[z].Cells[0].Value = cbo_Itm_Name.SelectedValue.ToString();
                        dgv_Itm_Returned.Rows[z].Cells[1].Value = cbo_Itm_Name.SelectedText;
                        //dgv_Itm_Returned.Rows[z].Cells[3].Value = txt_Qty_Big_Unit.Text;
                        //dgv_Itm_Returned.Rows[z].Cells[4].Value = txt_Qty_Small_Unit.Text;
                        dgv_Itm_Returned.Rows[z].Cells[2].Value = Qty.ToString();
                        dgv_Itm_Returned.Rows[z].Cells[3].Value = txt_Price.Text;
                        dgv_Itm_Returned.Rows[z].Cells[4].Value = txt_Add_No.Text;
                        FillTheRow(z, Qty);
                        dgv_Itm_Returned.Rows.Add();
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }



        }
        private void EnableHeadDetails(bool Head, bool Details)
        {
            gbo_Add_Itm.Enabled = Head;
            gbo_Add_Itm.Enabled = Details;
        }

        private void FillTheRow(int RowIndex, int Qty)
        {
            try
            {
                //dgv_Itm_Returned.Rows[RowIndex].Cells[0].Value = RowIndex + 1;
                //dgv_Itm_Returned.Rows[RowIndex].Cells[0].Value = txt_Itm_No.Text;
                dgv_Itm_Returned.Rows[RowIndex].Cells[0].Value = cbo_Itm_Name.SelectedValue;
                dgv_Itm_Returned.Rows[RowIndex].Cells[1].Value = ((DataRowView)cbo_Itm_Name.SelectedItem)[1];
                //dgv_Itm_Returned.Rows[RowIndex].Cells[3].Value = txt_Qty_Big_Unit.Text;
                //dgv_Itm_Returned.Rows[RowIndex].Cells[4].Value = txt_Qty_Small_Unit.Text;
                dgv_Itm_Returned.Rows[RowIndex].Cells[2].Value = Qty.ToString();
                dgv_Itm_Returned.Rows[RowIndex].Cells[3].Value = txt_Price.Text;
                dgv_Itm_Returned.Rows[RowIndex].Cells[4].Value = txt_Add_No.Text;
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private int CheckItemExistance(int ItemID)
        {
            try
            {
                foreach (DataGridViewRow CurrentRow in dgv_Itm_Returned.Rows)
                {
                    if (Convert.ToInt32(CurrentRow.Cells[0].Value) == ItemID)
                    {
                        return Convert.ToInt32(CurrentRow.Cells[0].RowIndex);
                    }
                }
                return -1;
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
                return -1;
            }
        }

        private void txt_Add_No_Leave(object sender, EventArgs e)
        {
            //Check if the Code is New or Old to be Updated.
            try
            {
                //Display The Selected Items.
                if (DataAccessLayer.CheckRowByID("Add_Finish_Process", "Add_Finish_ID", txt_Add_No.ToString()))
                    OperationType = true; // Update
                else
                    OperationType = false; // Insert;

                if (OperationType)
                {
                    //Load The Data 
                    FillTheForm(DataAccessLayer.GetRowByID("Add_Finish_Process", "Add_Finish_ID", txt_Add_No.ToString()));
                    //Disable the ID
                    txt_Itm_No.Enabled = false;
                }
                else
                {
                    //Clear the Form
                    ClearForm();
                }
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void ClearForm()
        {

            txt_Notes.Text = string.Empty;
            dtp_Created_At.Text = DateTime.Now.ToShortDateString();
            cbo_Created_By.SelectedValue = -1;
            cbo_Stock_Name.SelectedValue = -1;
            txt_Itm_No.Text = string.Empty;
            cbo_Itm_Cat.SelectedValue = -1;
            cbo_Itm_Name.SelectedValue = -1;
            txt_Qty_Big_Unit.Text = string.Empty;
            txt_Qty_Small_Unit.Text = string.Empty;
            txt_Price.Text = string.Empty;
            dgv_Itm_Returned.Rows.Clear();

        }

        private void FillTheForm(DataRow dr)
        {
            try
            {
                cbo_Created_By.SelectedValue = dr["Emp_ID"].ToString();
                cbo_Stock_Name.SelectedValue = dr["Sto_ID"].ToString();
                dtp_Created_At.Text = Convert.ToDateTime(dr["Created_At"].ToString()).ToShortDateString();
                txt_Notes.Text = dr["Notes"].ToString();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void FillTheFormDetails(DataTable dt)
        {
            try
            {
                
                foreach (DataRow item in dt.Rows)
                {
                    dgv_Itm_Returned.Rows.Add();
                    dgv_Itm_Returned.Rows[dgv_Itm_Returned.Rows.Count - 1].Cells[0].Value =item["Itm_Sub_ID"].ToString();
                    dgv_Itm_Returned.Rows[dgv_Itm_Returned.Rows.Count - 1].Cells[1].Value =item["Name"].ToString();
                    dgv_Itm_Returned.Rows[dgv_Itm_Returned.Rows.Count - 1].Cells[2].Value = item["Qty"].ToString();
                    dgv_Itm_Returned.Rows[dgv_Itm_Returned.Rows.Count - 1].Cells[3].Value = item["Price"].ToString();
                    dgv_Itm_Returned.Rows[dgv_Itm_Returned.Rows.Count - 1].Cells[4].Value = item["Add_Finish_ID"].ToString();
                    
                }
                dgv_Itm_Returned.Rows.Add();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void Btn_AddDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormValidate_Head())
                {
                    if (OperationType)
                    {
                        
                    
                        //Load THe Details Data
                        FillTheFormDetails(DataAccessLayer.GetRowsByID("Add_Finish_Process", "Add_Finish_ID", txt_Add_No.Text));
                   
                    }
                    else
                        EnableHeadDetails(false, true);
                    
                }
                else
                {
                    MessageBox.Show("  insert all missing data OR insert correct");
                }
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

                for (int i = 0; i < dgv_Itm_Returned.Rows.Count - 1; i++)
                    DataAccessLayer.ExecuteNoneQuery("Delete From Add_Finish_Process_Details where Add_Finish_ID = " + txt_Add_No.Text + " AND Itm_Sub_ID = " + dgv_Itm_Returned.Rows[i].Cells[0].Value.ToString());

                //Delete the old Data
                DataAccessLayer.DeleteRowByID("Add_Finish_Process", "Add_Finish_ID", Convert.ToInt32(txt_Add_No.Text));

                //Insert the new Data

                DataAccessLayer.ExecuteNoneQuery(" INSERT INTO [dbo].[Add_Finish_Process] VALUES (" + txt_Add_No.Text + "," + cbo_Created_By.SelectedValue.ToString() + " ,'" + dtp_Created_At.Text.ToString() + "','" + txt_Notes.Text + "'," + cbo_Stock_Name.SelectedValue.ToString() + ")");
                foreach (DataGridViewRow item in dgv_Itm_Returned.Rows)
                    if (item.Cells[0].Value != null && item.Cells[0].Value != null && item.Cells[2].Value != null && item.Cells[3].Value != null )
                        DataAccessLayer.ExecuteNoneQuery("INSERT INTO [dbo].[Add_Finish_Process_Details]([Add_Finish_ID],[Itm_Sub_ID],[Qty],[Price])VALUES(" + txt_Add_No.Text + "," + item.Cells[0].Value.ToString() + "," + item.Cells[2].Value.ToString() + "," + item.Cells[3].Value.ToString() + ")");

                MessageBox.Show("Done Editing");
                
                this.Close();
            }

            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void btn_Del_Itm_Click(object sender, EventArgs e)
        {
            try
            {
                //Display The Selected Items.
                if (dgv_Itm_Returned.SelectedRows.Count > 0)
                    foreach (DataGridViewRow item in dgv_Itm_Returned.SelectedRows)
                        dgv_Itm_Returned.Rows.Remove(item);
                else
                    MessageBox.Show("No Rows Have Been Selected");
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to Exit ? ", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
            
        }

        private void txt_Itm_No_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Add_No_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Qty_Big_Unit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Add_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txt_Itm_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txt_Qty_Big_Unit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txt_Qty_Small_Unit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txt_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
    }
}
