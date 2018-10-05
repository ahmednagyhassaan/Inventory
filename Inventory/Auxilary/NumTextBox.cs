using System.Windows.Forms;

namespace Inventory
{
    class NumTextBox : TextBox
    {
        public NumTextBox()
        {
            this.KeyPress+=TextBox_KeyPress;
        }

        private void TextBox_KeyPress(object sender,KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar));
        }
    }
}
