using System.Windows.Forms;

namespace Inventory
{
    class BaseForm : Form
    {
        public override string Text
        {
            get { return base.Text.Remove(0, base.Text.IndexOf('-') + 1); }
            set { base.Text = $"{Properties.Settings.Default.ApplicationName} - {value.Trim()}"; }
        }
        public BaseForm()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Icon =Properties.Resources.Icon;
            this.Name = "BaseForm";
            this.ResumeLayout(false);

        }
    }
}
