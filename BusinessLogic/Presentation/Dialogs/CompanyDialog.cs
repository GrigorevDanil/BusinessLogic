﻿using BusinessLogic.Entities;

namespace BusinessLogic.Presentation.Dialogs
{
	public partial class CompanyDialog : Form
	{
		public CompanyDialog()
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
			if ((string.IsNullOrEmpty(title.Text) && title.Text.Length > Product.MAX_TITLE_LENGHT)
				|| string.IsNullOrEmpty(profit.Text) || !float.TryParse(profit.Text.Trim().Replace('.', ','), out float profit_value)
				|| profit_value < 0)
			{
				MessageBox.Show("Не все значения корректны");
				return;
			}

			DialogResult = DialogResult.OK;
		}
	}
}