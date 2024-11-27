using System.Globalization;

namespace BusinessLogic.Presentation.Dialogs
{
    public partial class SaleDialog : Form
    {
        public SaleDialog()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
		private void button_Click(object sender, EventArgs e)
		{
            if (!double.TryParse(value.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out double _))
            {
                MessageBox.Show("Не все значения корректны");
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
