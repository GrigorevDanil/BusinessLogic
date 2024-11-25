namespace BusinessLogic.Presentation.Dialogs
{
    public partial class DistanceDialog : Form
    {
        public DistanceDialog()
        {
            InitializeComponent();
        }

        private void int_Enter(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (warehouses.SelectedIndex < 0
                || string.IsNullOrEmpty(length.Text) || !int.TryParse(length.Text, out int val))
            {
                MessageBox.Show("Не все значения корректны");
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
