using System.Windows.Forms;

namespace Inventory.CustomControls
{
    class NameTextBox : TextBox
    {
        public NameTextBox()
        {
            KeyPress+=TextBox_KeyPress;
        }

        private void TextBox_KeyPress(object sender,KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)|| char.IsWhiteSpace(e.KeyChar)|| !(char.IsSymbol(e.KeyChar)||char.IsNumber(e.KeyChar)));
        }
    }
}
