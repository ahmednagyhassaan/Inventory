using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Inventory.Employee;

namespace Inventory
{
    internal partial class frmEmpAddEdit : BaseForm
    {
        private DataTable _dt;
        private BLLEmployee _bll=new BLLEmployee();

        public frmEmpAddEdit(Mode mode, DataTable dt=null)
        {
            InitializeComponent();
            if (dt != null)
            {
                _dt = dt;
                BindProperities();
            }
            _bll.FillCmbDepartment(ref cbo_Dept_Name);
            cbo_Dept_Name.AutoCompleteCustomSource = _bll.FillAutoCompleteStringCollectionWithDeptName();
            switch (mode)
            {
                  case  Mode.Detail:
                    pnlMaster.Enabled = false;
                    break;
                default:
                    pnlMaster.Enabled = true;
                    break;
            }
        }

        private void BindProperities()
        {
            txt_ID.DataBindings.Add("Text", _dt, "Emp_ID",Enabled,DataSourceUpdateMode.Never,string.Empty);
            txt_Name.DataBindings.Add("Text", _dt, "Name", Enabled, DataSourceUpdateMode.Never, string.Empty);
            dtp_Date_Bith.DataBindings.Add("Value", _dt, "Date_Of_Birth", Enabled, DataSourceUpdateMode.Never, DateTime.MinValue);
            txt_Certification.DataBindings.Add("Text", _dt, "Certifications", Enabled, DataSourceUpdateMode.Never, string.Empty);
            txt_Address.DataBindings.Add("Text", _dt, "Address", Enabled, DataSourceUpdateMode.Never, string.Empty);
            txt_Salary.DataBindings.Add("Text", _dt, "Salary", Enabled, DataSourceUpdateMode.Never, string.Empty);
            dtp_Hire_Date.DataBindings.Add("Value", _dt, "Hire_Date", Enabled, DataSourceUpdateMode.Never, DateTime.MinValue);
            cbo_Dept_Name.DataBindings.Add("SelectedValue", _dt, "Dept_ID", Enabled, DataSourceUpdateMode.Never, string.Empty);
            txt_Phone.DataBindings.Add("Text", _dt, "phone", Enabled, DataSourceUpdateMode.Never, string.Empty);
            PicEmp.Image = _dt.Rows[0]["Pic"]==DBNull.Value? PicEmp.ErrorImage:_bll.ConvertByteArrayToImage((byte[]) _dt.Rows[0]["Pic"]);
        }

        private void btnChangePic_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                PicEmp.Image=Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnRemovePic_Click(object sender, EventArgs e)
        {
            PicEmp.Image = PicEmp.InitialImage;
        }

        private void cbo_Dept_Name_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        //{ SqlConnection con =new SqlConnection("Data Source=.;Initial Catalog=Project;Integrated Security=True");
        //    public string edit_or_add = "";
        //    public int IID;
        //    public frmEmpAddEdit(int x, string m)
        //    {
        //        IID = x;
        //        edit_or_add = m;
        //        InitializeComponent();
        //    }
        //    public frmEmpAddEdit( string m)
        //    {
        //        edit_or_add = m;
        //        InitializeComponent();
        //    }



        //    private void btn_Save_Click(object sender, EventArgs e)
        //    {    
        //        try
        //        {
        //            if (edit_or_add == "add")
        //            {
        //                insert_Methood();
        //            }
        //            else if (edit_or_add == "edit")
        //            {
        //                Update_Methood();
        //            }
        //        }
        //        catch (Exception exp)
        //        {

        //            MessageBox.Show(exp.Message);
        //        }

        //    }

        //    private void Update_Methood()
        //    {
        //         try
        //        {
        //            if (cbo_Dept_Name.SelectedItem == null || String.IsNullOrWhiteSpace(txt_Name.Text))
        //            {
        //                MessageBox.Show("you must enter at least Employee Name and Departement");
        //            }
        //            else
        //            {
        //                String command = string.Empty;
        //                SqlCommand cmddd = new SqlCommand(command, con);
        //                cmddd.Parameters.Clear();
        //                if (String.IsNullOrWhiteSpace(txt_Salary.Text))
        //                {
        //                    command = "UPDATE [dbo].[Employee] SET [Name] =@Name ,[Address] =@Address ,[Certifications] =@Certifications ,[Dept_ID] =@Dept_ID  ,[Date_Of_Birth] =@Date_Of_Birth  ,[Hire_Date] =@Hire_Date ,[phone]= phone WHERE [Emp_ID]=@Emp_ID";
        //                }
        //                else
        //                {
        //                    command = "UPDATE [dbo].[Employee] SET [Name] =@Name ,[Address] =@Address ,[Certifications] =@Certifications  ,[Salary] =@Salary ,[Dept_ID] =@Dept_ID  ,[Date_Of_Birth] =@Date_Of_Birth  ,[Hire_Date] =@Hire_Date ,[phone]= phone WHERE [Emp_ID]=@Emp_ID";
        //                    cmddd.Parameters.AddWithValue("@Salary", Convert.ToDecimal(txt_Salary.Text));

        //                }
        //                cmddd.Parameters.AddWithValue("@Emp_ID", txt_ID.Text);
        //                cmddd.Parameters.AddWithValue("@Name", txt_Name.Text);
        //                cmddd.Parameters.AddWithValue("@Address", txt_Address.Text);
        //                cmddd.Parameters.AddWithValue("@Certifications", txt_Certification.Text);

        //                cmddd.Parameters.AddWithValue("@Dept_ID", cbo_Dept_Name.SelectedValue);
        //                cmddd.Parameters.AddWithValue("@Date_Of_Birth ", Convert.ToDateTime(dtp_Date_Bith.Text));
        //                cmddd.Parameters.AddWithValue("@Hire_Date", Convert.ToDateTime(dtp_Hire_Date.Text));
        //                cmddd.Parameters.AddWithValue("@phone", txt_Phone.Text);
        //                cmddd.CommandText = command;
        //                if (con.State != ConnectionState.Open)
        //                    con.Open();
        //                //dr.Close();
        //                cmddd.ExecuteNonQuery();
        //                con.Close();
        //                MessageBox.Show("Edited");
        //                FrmEmpSearchDelete f = new FrmEmpSearchDelete();
        //                f.Show();
        //                this.Close();
        //            }
        //        }
        //        catch (Exception exp)
        //        {

        //            MessageBox.Show(exp.Message);
        //        }
        //    }

        //    private void insert_Methood()
        //    {
        //        try
        //        {
        //            if (cbo_Dept_Name.SelectedItem==null ||String.IsNullOrWhiteSpace(txt_Name.Text))
        //            {
        //                MessageBox.Show("you must enter at least Employee Name and Departement");
        //            }
        //            else
        //            {
        //                String commandd;
        //                if (String.IsNullOrWhiteSpace(txt_Salary.Text))
        //                {
        //                    commandd = "INSERT INTO [dbo].[Employee]([Emp_ID],[Name],[Address] ,[Certifications],[Dept_ID],[Date_Of_Birth] ,[Hire_Date] ,[phone],[Still_Work]) VALUES (@Emp_ID , @Name , @Address , @Certifications  ,  @Dept_ID , @Date_Of_Birth , @Hire_Date ,@phone,'true')";

        //                }
        //                else
        //                {
        //                    commandd = "INSERT INTO [dbo].[Employee]([Emp_ID],[Name],[Address] ,[Certifications],[Salary],[Dept_ID],[Date_Of_Birth] ,[Hire_Date] ,[phone],[Still_Work]) VALUES (@Emp_ID , @Name , @Address , @Certifications  , @Salary , @Dept_ID , @Date_Of_Birth , @Hire_Date ,@phone,'true')";
        //                }
        //                SqlCommand cmdd = new SqlCommand(commandd, con);
        //                cmdd.Parameters.AddWithValue("@Emp_ID", int.Parse(txt_ID.Text));
        //                cmdd.Parameters.AddWithValue("@Name", txt_Name.Text);
        //                cmdd.Parameters.AddWithValue("@Address", txt_Address.Text);
        //                cmdd.Parameters.AddWithValue("@Certifications", txt_Certification.Text);
        //                cmdd.Parameters.AddWithValue("@Salary", txt_Salary.Text);
        //                cmdd.Parameters.AddWithValue("@Dept_ID", cbo_Dept_Name.SelectedValue);
        //                cmdd.Parameters.AddWithValue("@Date_Of_Birth ", Convert.ToDateTime(dtp_Date_Bith.Text));
        //                cmdd.Parameters.AddWithValue("@Hire_Date", Convert.ToDateTime(dtp_Hire_Date.Text));
        //                cmdd.Parameters.AddWithValue("@phone", txt_Phone.Text);
        //                if (con.State != ConnectionState.Open)
        //                    con.Open();
        //                //dr.Close();
        //                cmdd.ExecuteNonQuery();
        //                con.Close();
        //                MessageBox.Show("Added");

        //                FrmEmpSearchDelete f = new FrmEmpSearchDelete();
        //                f.Show();
        //                this.Close();
        //            }

        //        }
        //        catch (Exception exp)
        //        {

        //            MessageBox.Show(exp.Message);
        //        }
        //    }

        //    private void btn_Close_Click(object sender, EventArgs e)
        //    {
        //        this.Close();
        //    }

        //    private void frm_Add_Emp_Load(object sender, EventArgs e)
        //    {
        //        try
        //        {
        //            Load_cbo();
        //            if (edit_or_add == "add")
        //            {
        //                ID_Method();
        //                txt_ID.Enabled = false;


        //            }
        //            else if (edit_or_add == "edit")
        //            {

        //                Show_All_Details();
        //            }
        //        }
        //        catch (Exception exp)
        //        {

        //            MessageBox.Show(exp.Message);
        //        }
        //    }

        //    private void Load_cbo()
        //    {
        //        SqlCommand cmd = new SqlCommand("SELECT [Dept_ID],[Name] ,[Manager_ID] FROM [dbo].[Department]", con);
        //        SqlDataAdapter dad = new SqlDataAdapter(cmd);
        //        DataTable DT = new DataTable();
        //        dad.Fill(DT);
        //        cbo_Dept_Name.DataSource = DT;
        //        cbo_Dept_Name.ValueMember = "Dept_ID";
        //        cbo_Dept_Name.DisplayMember = "Name";
        //        cbo_Dept_Name.SelectedIndex = -1;
        //    }

        //    private void Show_All_Details()
        //    {
        //        SqlCommand cmd = new SqlCommand("SELECT [Emp_ID], [Name] ,[Address] ,[Certifications] ,[Salary] ,[Dept_ID]  , Date_Of_Birth    , Hire_Date ,[Manager_ID]   ,    [Still_Work] ,[phone]  FROM [dbo].[Employee] where [Emp_ID]=@Emp_ID", con);
        //        cmd.Parameters.AddWithValue("@Emp_ID", IID);
        //        SqlDataAdapter dad = new SqlDataAdapter(cmd);
        //        DataTable DT = new DataTable();
        //        dad.Fill(DT);
        //        DataRow row = DT.Rows[0];
        //        txt_ID.Enabled = false;
        //        txt_ID.Text = row[0].ToString();
        //        txt_Name.Text = row[1].ToString();
        //        txt_Address.Text = row[2].ToString();
        //        txt_Certification.Text = row[3].ToString();
        //        txt_Salary.Text = row[4].ToString();
        //        cbo_Dept_Name.SelectedValue = row[5];
        //        try
        //        {
        //            dtp_Date_Bith.Value = Convert.ToDateTime(row[6]);
        //        }
        //        catch (Exception)
        //        {

        //        }
        //        try
        //        {
        //            dtp_Hire_Date.Value = Convert.ToDateTime(row[6]);
        //        }
        //        catch (Exception)
        //        {

        //        }

        //        txt_Phone.Text = row[10].ToString();
        //    }

        //    private void ID_Method()
        //    {
        //        SqlCommand cmd = new SqlCommand("declare @X int=(Select Count([Emp_ID]) from [dbo].[Employee])  if(@X=0) select 1  else (select max([Emp_ID])+1 from [dbo].[Employee])", con);
        //        SqlDataAdapter dad = new SqlDataAdapter(cmd);
        //        DataTable DT = new DataTable();
        //        dad.Fill(DT);
        //        DataRow row = DT.Rows[0];
        //        txt_ID.Text = row[0].ToString();
        //    }

        //    private void txt_Salary_KeyPress(object sender, KeyPressEventArgs e)
        //    {
        //        const char Delete = (char)8;
        //        e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        //    }


    }
}