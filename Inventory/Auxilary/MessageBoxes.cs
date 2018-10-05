using System.Windows.Forms;

namespace Inventory.Auxilary
{
    class MessageBoxes
    {
        public void SuccessMsgBox(string Text)
        {
            MessageBox.Show(Text, "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
