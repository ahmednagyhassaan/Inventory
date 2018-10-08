using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory
{
    internal partial class frm_Login : BaseForm
    {
        private DAL_New _dal;
        private MessageBoxes _msgBoxes;
        public frm_Login()
        {
            InitializeComponent();
            _dal = new DAL_New();
            _msgBoxes=new MessageBoxes();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlParameter a = new SqlParameter("@name", txtName.Text);
            SqlParameter b = new SqlParameter("@password", txtPassword.Text);
            SqlParameter[] c = new SqlParameter[2] { a, b };
            DataTable dt;
            try
            {
                //DataTable dt = _dal.ExecuteQuery("select * from dbo,login"); //لو محبتش احط مجموعة من المتغيرات
                //السطر اللى فوق عملنا استدعاء لدالة  اكس عن طريق ()
                //(object.اسم الدالة () 

                dt = _dal.ExecuteQuery("select count(*) as count from[dbo].[Login] where [Name]=@name and[Password]=@password collate Arabic_CS_AS", c);
                int count = (int)dt.Rows[0][0];

                if (count != 0)
                {
                    this.DialogResult = DialogResult.OK;
                    Frm_Main f = new Frm_Main(txtName.Text);

                }
                else
                {
                    _msgBoxes.ErrorMsgBox("Wrong Name or Password");
                }

            }
            catch (Exception ex)
            {
                _msgBoxes.ErrorMsgBox(ex.Message);
            }
        }

    }
}
