using System;
using System.Windows.Forms;

namespace Inventory
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
          frm_Login ob1 = new frm_Login();
            if (ob1.ShowDialog() == DialogResult.OK)
            {
               
                Application.Run(new Frm_Main(ob1.txtName.Text));
            }

        }
    }
}
