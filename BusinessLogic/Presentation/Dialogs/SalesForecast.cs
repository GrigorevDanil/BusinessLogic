using BusinessLogic.Entities;
using BusinessLogic.Repositories;
using System.Windows.Forms.DataVisualization.Charting;

namespace BusinessLogic.Presentation.Dialogs
{
    public partial class SalesForecast : Form
    {
		private Chart chart;

        public SalesForecast(List<Sale> sales)
        {
            InitializeComponent();
			CreateChart();

			sales.Sort(delegate (Sale first, Sale second) {
				return first.Date.CompareTo(second.Date);
			});

			PlotData(sales);
			ForecastSales(sales);
        }

		private void CreateChart() {
			chart = new() {
				Parent = this,
				Size = new Size(Width, Height - 100),
				Location = new Point(-20, 0),
				BackColor = Color.Transparent,
				Padding = new Padding(0),
				Margin = new Padding(0),
				BorderlineWidth = 0
			};
		}

		private void PlotData(List<Sale> sales) {
			chart.Series.Clear();

			chart.ChartAreas.Add(new ChartArea("Default"));
			chart.Legends.Add("Фактические продажи");

			Series actualSeries = new("Фактические продажи") {
				ChartType = SeriesChartType.Line,
				Color = Color.Blue,
				BorderWidth = 3
			};

			for (int i = 0; i < sales.Count; i++)
				actualSeries.Points.AddXY(sales[i].Date.ToDateTime(TimeOnly.MinValue), sales[i].Value);

			chart.Series.Add(actualSeries);
			chart.ChartAreas[0].AxisX.LabelStyle.Format = "MMM yyyy";
		}

		private void ForecastSales(List<Sale> sales) {
			double[] xValues = new double[sales.Count];

			for (int i = 0; i < sales.Count; i++)
				xValues[i] = sales[i].Date.ToDateTime(TimeOnly.MinValue).ToOADate();

			LinearRegression(xValues, sales.Select(s => s.Value).ToArray(), out double intercept, out double slope);

			chart.Legends.Add("Прогноз продаж");

			Series forecastSeries = new("Прогноз продаж") {
				ChartType = SeriesChartType.Line,
				Color = Color.Red,
				BorderDashStyle = ChartDashStyle.Dash,
				BorderWidth = 3
			};

			DateTime lastDate = sales[^1].Date.ToDateTime(TimeOnly.MinValue);

			forecastSeries.Points.AddXY(sales[^1].Date.ToDateTime(TimeOnly.MinValue), sales[^1].Value);
			forecastSeries.Points.AddXY(lastDate.AddYears(2), slope * lastDate.AddYears(2).ToOADate() + intercept);

			chart.Series.Add(forecastSeries);
		}

		private void LinearRegression(double[] xVals, double[] yVals, out double intercept, out double slope) {
			double xAvg = 0, yAvg = 0;

			for (int i = 0; i < xVals.Length; i++) {
				xAvg += xVals[i];
				yAvg += yVals[i];
			}

			xAvg /= xVals.Length;
			yAvg /= yVals.Length;

			double sumNum = 0, sumDen = 0;

			for (int i = 0; i < xVals.Length; i++) {
				sumNum += (xVals[i] - xAvg) * (yVals[i] - yAvg);
				sumDen += Math.Pow(xVals[i] - xAvg, 2);
			}

			slope = sumNum / sumDen;
			intercept = yAvg - slope * xAvg;
		}

		private void back_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
