using System.Windows.Forms;

namespace Inventory.Auxilary
{
    class MessageBoxes
    {
        public void SuccessMsgBox(string text)
        {
            MessageBox.Show(text, "Inventory1ss", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
