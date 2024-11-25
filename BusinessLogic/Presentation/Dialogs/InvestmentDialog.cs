namespace BusinessLogic.Presentation.Dialogs
{
    public partial class InvestmentDialog : Form
    {
        public InvestmentDialog()
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
            if (companies.SelectedIndex < 0
                || string.IsNullOrEmpty(amount.Text) || !int.TryParse(amount.Text, out int val)
                || string.IsNullOrEmpty(profit.Text) || !int.TryParse(profit.Text, out int val1))
            {
                MessageBox.Show("Не все значения корректны");
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
