using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory
{
    public partial class frm_Add_Finish_To_Store : Form
    {
        public string edit_or_add = "";
        public int IID;


        private SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
        public frm_Add_Finish_To_Store()
        {
            InitializeComponent();
        }

         public frm_Add_Finish_To_Store(string m)
        {
            InitializeComponent();
            edit_or_add = m;
        }
         public frm_Add_Finish_To_Store(int x, string m)
        {
            InitializeComponent();
            edit_or_add = m;
            IID = x;
        }
        bool FormLoadFlag = false;
        DataTable GridViewData = new DataTable();
        bool OperationType = false;

        #region Form Events

        private void Frm_SampleForm_Load(object sender, EventArgs e)
        {
            try
            {
                ProjectTools.LoadCbo(cbo_Created_By, DataAccessLayer.GetDataTable("Employee", ""), "Name", "Emp_ID");
                string cmd2 = "select [Sto_ID],[Store].[Name]as st_Name FROM dbo.Store INNER JOIN dbo.Store_Category ON dbo.Store.Sto_Cat_ID =                         dbo.Store_Category.Sto_Cat_ID  where[Store].Sto_Cat_ID=[Store_Category].Sto_Cat_ID and [Store_Category].Name='Finish'";


                ProjectTools.LoadCbo(cbo_Stock_Name, DataAccessLayer.GetDataTableComplex(cmd2, ""), "st_Name", "Sto_ID");
                ProjectTools.LoadCbo(cbo_Itm_Cat, DataAccessLayer.GetDataTable("Item_Category", ""), "Name", "Itm_Cat_ID");

                txt_Add_No.Text = DataAccessLayer.NewRowID("Add_Finish_Process", "Add_Finish_ID");
                EnableHeadDetails(true, false);
                FormLoadFlag = true;

                //if (edit_or_add == "add")
                //{
                  
                 
                //}
                //else if (edit_or_add == "edit")
                //{
                //    DataRow row_Edit = DataAccessLayer.GetRowByID("Add_Finish_Process", "Add_Finish_ID", IID.ToString());
                //    txt_Add_No.Text = IID.ToString();
                //    txt_Notes.Text = row_Edit[3].ToString();
                //    cbo_Created_By.SelectedValue = row_Edit[1];


                //    dgv_Itm_Returned_Edit.Rows.Clear();
                //    dgv_Itm_Returned_Edit.DataSource = DataAccessLayer.GetDataTable("ViewFinishOrder", " where Add_Finish_ID =" + IID.ToString());
                   




                //}
            
           
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
            //Display 4
           


        }


        #endregion
        DataTable DT_Qty = new DataTable();
        private void Show_All_Finish_Details()
        {

            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
            Conn.Open();

            SqlCommand cmd1 = new SqlCommand("SELECT Add_Finish_ID, Itm_Sub_ID, Qty, Price FROM dbo.Add_Finish_Process_Details where Add_Finish_ID=@ID", Conn);
            cmd1.Parameters.AddWithValue("@ID", IID);
            SqlDataReader sdr = cmd1.ExecuteReader();
            DataTable DT_Editd = new DataTable();
            DT_Editd.Load(sdr);
            Conn.Close();
            dgv_Itm_Returned_Edit.DataSource = DT_Editd.NewRow();
            //SqlDataAdapter dad_Edit = new SqlDataAdapter(cmd);
            //DataTable DT_Edit = new DataTable();
            //dad_Edit.Fill(DT_Edit);
            DataRow row_Edit = DT_Editd.Rows[1];
            //txt_Return_no.Enabled = false;
            //txt_Inv_No.Enabled = false;
            txt_Add_No.Text = IID.ToString();
            txt_Add_No.Text = row_Edit[1].ToString();
            cbo_Itm_Name.SelectedValue = row_Edit[2];
            txt_Qty_Big_Unit.Text = row_Edit[3].ToString();
            txt_Qty_Small_Unit.Text = row_Edit[4].ToString();
            txt_Price.Text = row_Edit[6].ToString();
            //cbo_Created_By.SelectedValue = row_Edit[0];
            //dtp_Created_At.Value = Convert.ToDateTime(row_Edit[1]);
            //txt_Notes.Text = row_Edit[2].ToString();

            //SqlCommand cmd_Qty = new SqlCommand("exec show_Return_Itms @Ret_ID", Conn);
            //cmd_Qty.Parameters.AddWithValue("@Ret_ID", txt_Add_No.Text);
            //SqlDataAdapter dad_Qty = new SqlDataAdapter(cmd_Qty);

            //dad_Qty.Fill(DT_Qty);

            //dgv_Itm_Returned.DataSource = DT_Qty;
        }

        #region Buttons Events

        private void Btn_AddDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormValidate_Head())
                {
                    if (OperationType)
                        //Load THe Details Data
                        FillTheFormDetails(DataAccessLayer.GetRowsByID("Add_Finish_Process", "Add_Finish_ID", txt_Add_No.Text));

                    else
                        EnableHeadDetails(false, true);
                }
                else
                {
                    MessageBox.Show(" insert all missing data OR insert correct");
                }
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

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
                        FillTheRow(RowSelected - 1, Qty);
                    else
                    {
                        //false Add New Row
                        dgv_Itm_Returned_Edit.Rows.Add();
                        FillTheRow(dgv_Itm_Returned_Edit.Rows.Count - 2, Qty);
                    }
                }



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
                if (dgv_Itm_Returned_Edit.SelectedRows.Count > 0)
                    foreach (DataGridViewRow item in dgv_Itm_Returned_Edit.SelectedRows)
                        dgv_Itm_Returned_Edit.Rows.Remove(item);
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                //Delete the old Data
                DataAccessLayer.DeleteRowByID("Add_Finish_Process", "Add_Finish_ID", Convert.ToInt32(txt_Add_No.Text));

                //Insert the new Data
               
                DataAccessLayer.ExecuteNoneQuery(" INSERT INTO [dbo].[Add_Finish_Process] VALUES (" + txt_Add_No.Text + "," + cbo_Created_By.SelectedValue.ToString() + " ,'" + dtp_Created_At.Text.ToString() + "','" + txt_Notes.Text + "'," + cbo_Stock_Name.SelectedValue.ToString() + ")");
                foreach (DataGridViewRow item in dgv_Itm_Returned_Edit.Rows)
                    if (item.Cells[0].Value != null && item.Cells[1].Value != null && item.Cells[2].Value != null && item.Cells[4].Value != null && item.Cells[5].Value != null && item.Cells[5].Value != null)
                        DataAccessLayer.ExecuteNoneQuery("INSERT INTO [dbo].[Add_Finish_Process_Details]([Add_Finish_ID],[Itm_Sub_ID],[Qty],[Price])VALUES(" + txt_Add_No.Text + "," + item.Cells[1].Value.ToString() + "," + item.Cells[5].Value.ToString() + "," + item.Cells[6].Value.ToString() + ")");

                MessageBox.Show("added");
            }

            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                //Delete The Order Data
                if (MessageBox.Show("Are you Sure you want to Delete The Add ? ", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    DataAccessLayer.DeleteRowByID("Add_Finish_Process", "Add_Finish_ID", Convert.ToInt32(txt_Add_No.Text));
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        #endregion

        #region Functions

        private bool FormValidate_Head()
        {
            if (txt_Add_No.Text != "" && cbo_Created_By.SelectedItem != null && cbo_Stock_Name.SelectedItem != null)
                return true;
            else
                return false;
        }

        private bool FormValidate_Details()
        {
            if (cbo_Itm_Cat.SelectedItem != null && cbo_Itm_Name.SelectedItem != null && txt_Price.Text != "" && txt_Qty_Big_Unit.Text != null && txt_Qty_Small_Unit.Text != null)
                if (Convert.ToInt32(txt_Qty_Big_Unit.Text) <= 0 && Convert.ToInt32(txt_Qty_Small_Unit.Text) <= 0)
                    return false;
                else
                    return true;
            else
                return false;
        }

        private void EnableHeadDetails(bool Head, bool Details)
        {
            Grp_Main.Enabled = Head;
            gbo_Add_Itm.Enabled = Details;
        }

        #endregion

        private void cbo_Itm_Cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (FormLoadFlag)
                    ProjectTools.LoadCbo(cbo_Itm_Name, DataAccessLayer.GetDataTable("Item_Subcategory", " where Itm_Cat_ID = " + (cbo_Itm_Cat.SelectedValue).ToString()), "Name", "Itm_Sub_ID");
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void FillTheRow(int RowIndex, int Qty)
        {
            try
            {
                dgv_Itm_Returned_Edit.Rows[RowIndex].Cells[0].Value = RowIndex + 1;
                dgv_Itm_Returned_Edit.Rows[RowIndex].Cells[1].Value = cbo_Itm_Name.SelectedValue;
                dgv_Itm_Returned_Edit.Rows[RowIndex].Cells[2].Value = ((DataRowView)cbo_Itm_Name.SelectedItem)[1];
                dgv_Itm_Returned_Edit.Rows[RowIndex].Cells[3].Value = txt_Qty_Big_Unit.Text;
                dgv_Itm_Returned_Edit.Rows[RowIndex].Cells[4].Value = txt_Qty_Small_Unit.Text;
                dgv_Itm_Returned_Edit.Rows[RowIndex].Cells[5].Value = Qty;
                dgv_Itm_Returned_Edit.Rows[RowIndex].Cells[6].Value = txt_Price.Text;
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
                foreach (DataGridViewRow CurrentRow in dgv_Itm_Returned_Edit.Rows)
                {
                    if (Convert.ToInt32(CurrentRow.Cells[1].Value) == ItemID)
                    {
                        return Convert.ToInt32(CurrentRow.Cells[1].Value);
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
                if (DataAccessLayer.CheckRowByID("Add_Finish_Process", "Add_Finish_ID", txt_Add_No.Text))
                    OperationType = true; // Update
                else
                    OperationType = false; // Insert;

                if (OperationType)
                {
                    //Load The Data 
                    FillTheForm(DataAccessLayer.GetRowByID("Add_Finish_Process", "Add_Finish_ID", txt_Add_No.Text));
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
            dgv_Itm_Returned_Edit.Rows.Clear();

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
                    dgv_Itm_Returned_Edit.Rows.Add();
                    dgv_Itm_Returned_Edit.Rows[dgv_Itm_Returned_Edit.Rows.Count - 1].Cells[0].Value = dgv_Itm_Returned_Edit.Rows.Count - 1;
                    dgv_Itm_Returned_Edit.Rows[dgv_Itm_Returned_Edit.Rows.Count - 1].Cells[1].Value = item["Itm_Sub_ID"].ToString();
                    dgv_Itm_Returned_Edit.Rows[dgv_Itm_Returned_Edit.Rows.Count - 1].Cells[2].Value = item["Itm_Sub_ID"].ToString();
                    dgv_Itm_Returned_Edit.Rows[dgv_Itm_Returned_Edit.Rows.Count - 1].Cells[3].Value = item["Itm_Sub_ID"].ToString();
                    dgv_Itm_Returned_Edit.Rows[dgv_Itm_Returned_Edit.Rows.Count - 1].Cells[4].Value = item["Itm_Sub_ID"].ToString();
                    dgv_Itm_Returned_Edit.Rows[dgv_Itm_Returned_Edit.Rows.Count - 1].Cells[5].Value = item["Qty"].ToString();
                    dgv_Itm_Returned_Edit.Rows[dgv_Itm_Returned_Edit.Rows.Count - 1].Cells[6].Value = item["Price"].ToString();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void Grp_Main_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_Itm_Returned_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbo_Add_Itm_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_Delete_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_Add_No_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Itm_No_TextChanged(object sender, EventArgs e)
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
