using BusinessLogic.Entities;

namespace BusinessLogic.Presentation.Dialogs
{
    public partial class ShopDialog : Form
    {
        public ShopDialog()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(title.Text) && title.Text.Length > Warehouse.MAX_TITLE_LENGHT))
            {
                MessageBox.Show("Не все значения корректны");
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
