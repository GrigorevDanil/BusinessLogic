using BusinessLogic.Entities;
using System.Text;

namespace BusinessLogic.Presentation
{
	public partial class CashDesks : Form {
		private int resultValue = 0;

		public CashDesks(List<Shop> shopsList) {
			InitializeComponent();
			
			shops.DisplayMember = "Title";
			shops.ValueMember = "Id";
			shops.DataSource = shopsList;
		}

		/// <param name="λ">Средний поток покупателей в час</param>
		/// <param name="W">Среднее время обслуживания одного покупателя</param>
		/// <param name="ρ">Коэффициент загрузки кассира</param>
		/// <returns>Оптимальное количество касс, не менее 1</returns>
		private int Calculate(double λ, double W, double ρ) => Math.Max((int)Math.Ceiling(λ * (W / 60) / (1 - ρ)), 1);

		private void b_calculate_Click(object sender, EventArgs e) {
			double λ = double.Parse(lambda.Text.Trim().Replace(',', '.'));
			double W = double.Parse(w.Text.Trim().Replace(',', '.'));
		    double ρ = string.IsNullOrWhiteSpace(ro.Text.Trim()) ? 0.7 : double.Parse(ro.Text.Trim().Replace(',', '.'));
			resultValue = Calculate(λ, W, ρ);
			result.Text = $"Оптимальное количество касс: {resultValue} шт.";
			CheckValues();
		}

		private void b_save_Click(object sender, EventArgs e) {
			FolderBrowserDialog dialog = new();

			if (dialog.ShowDialog() != DialogResult.OK)
				return;

			Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

			DateTime now = DateTime.Now;
			string path = dialog.SelectedPath + "\\" + now.ToShortDateString() + "-" + now.ToShortTimeString().Replace(':', '-') + ".html";
			string content = File.ReadAllText("Resources/ШаблонМагазин.html", System.Text.Encoding.GetEncoding(1251));

			content = content.Replace("$date$", now.ToShortDateString()).Replace("$shop$", ((Shop)shops.SelectedItem).Title).Replace("$count$", resultValue.ToString());

			File.Create(path).Close();
			File.WriteAllText(path, content, System.Text.Encoding.GetEncoding(1251));

			MessageBox.Show("Отчёт успешно сохранён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void b_back_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.Cancel;
		}

		private void CheckValues() {
			if (shops.SelectedItem is not Shop) {
				b_calculate.Enabled = b_save.Enabled = false;
				return;
			}

			resultValue = 0;

			b_calculate.Enabled = double.TryParse(lambda.Text.Trim().Replace(',', '.'), out double _) &&
				double.TryParse(w.Text.Trim().Replace(',', '.'), out double _) &&
				(string.IsNullOrWhiteSpace(ro.Text.Trim()) || double.TryParse(ro.Text.Trim().Replace(',', '.'), out double _));
			b_save.Enabled = resultValue > 0;
		}

		#region Events

		private void shops_SelectedIndexChanged(object sender, EventArgs e) {
			CheckValues();
		}

		private void lambda_TextChanged(object sender, EventArgs e) {
			CheckValues();
		}

		private void w_TextChanged(object sender, EventArgs e) {
			CheckValues();
		}

		private void ro_TextChanged(object sender, EventArgs e) {
			CheckValues();
		}

		#endregion
	}
}
