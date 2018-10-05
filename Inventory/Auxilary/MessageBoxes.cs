using System.Windows.Forms;

namespace Inventory
{
    class MessageBoxes
    {
        public void SuccessMsgBox(string messageText)
        {
            MessageBox.Show(messageText, Properties.Settings.Default.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ErrorMsgBox(string messageText)
        {
            MessageBox.Show(messageText, Properties.Settings.Default.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
