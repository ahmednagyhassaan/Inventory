using System.ComponentModel;

namespace Inventory
{
    internal class BaseForm : System.Windows.Forms.Form
    {
        public override string Text
        {
            get { return base.Text.Remove(0, base.Text.IndexOf('-')+1); }
            set { base.Text = $"{Properties.Settings.Default.ApplicationName} - {value.Trim()}"; }
        }
    }
}

