namespace BusinessLogic.Presentation.Dialogs
{
    public partial class UpdateEquipmentDialog : Form
    {
        private List<TextBox> rtTextBoxes = [];
        private List<TextBox> stTextBoxes = [];
        private int[] replacementYear = [];
        public UpdateEquipmentDialog()
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

        private void years_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            rtTextBoxes.Clear();
            stTextBoxes.Clear();

            int year = Convert.ToInt32(years.SelectedItem);

            year++;

            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 3,
                ColumnCount = year,
                AutoSize = true,
                AutoScroll = true,
            };

            for (int col = 0; col < year; col++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
            }

            for (int col = 0; col < year; col++)
            {
                Label label = new Label
                {
                    Text = col.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                };
                tableLayoutPanel.Controls.Add(label, col, 0);
            }

            for (int row = 1; row < 3; row++)
            {
                for (int col = 0; col < year; col++)
                {
                    TextBox textBox = new TextBox
                    {
                        Name = $"textBox_{row}_{col}"
                    };
                    textBox.KeyPress += int_Enter!;
                    tableLayoutPanel.Controls.Add(textBox, col, row);

                    if (row == 1) rtTextBoxes.Add(textBox);
                    else if (row == 2) stTextBoxes.Add(textBox);

                }
            }

            panelMain.Controls.Add(tableLayoutPanel);
        }



        private void button_Click(object sender, EventArgs e)
        {
            int[] r = rtTextBoxes.Select(tb => int.Parse(tb.Text)).ToArray();
            int[] s = stTextBoxes.Select(tb => int.Parse(tb.Text)).ToArray();
            int P = int.Parse(p_text.Text);
            int N = int.Parse(years.SelectedItem!.ToString()!);
            (int[,] F, char[,] operations) = CalculateMaxProfits(r, s, P, N);
            DetermineOptimalStrategy(F, operations, r, s, P, N);
        }

        private void buttonToFile_Click(object sender, EventArgs e)
        {
            int[] r = rtTextBoxes.Select(tb => int.Parse(tb.Text)).ToArray();
            int[] s = stTextBoxes.Select(tb => int.Parse(tb.Text)).ToArray();
            int P = int.Parse(p_text.Text);
            int N = int.Parse(years.SelectedItem!.ToString()!);
            (int[,] F, char[,] operations) = CalculateMaxProfits(r, s, P, N);
            DetermineOptimalStrategyHtml(F, operations, r, s, P, N);
        }

        (int[,], char[,]) CalculateMaxProfits(int[] r, int[] s, int P, int N)
        {
            int[,] F = new int[N + 1, N + 1];
            char[,] operations = new char[N + 1, N + 1];

            for (int k = N; k >= 1; k--)
            {
                for (int t = 1; t <= N - (N - k); t++)
                {
                    if (k == N)
                    {
                        F[k, t] = Math.Max(r[t], s[t] - P + r[0]);
                        operations[k, t] = (F[k, t] == r[t]) ? 'C' : 'З';
                    }
                    else
                    {
                        int profitKeep = r[t] + F[k + 1, t + 1];
                        int profitReplace = (t < N) ? (s[t] - P + r[0] + F[k + 1, 1]) : 0;

                        if (profitKeep >= profitReplace)
                        {
                            F[k, t] = profitKeep;
                            operations[k, t] = 'C';
                        }
                        else
                        {
                            F[k, t] = profitReplace;
                            operations[k, t] = 'З';
                        }
                    }
                }
            }

            return (F, operations);
        }


        void DetermineOptimalStrategy(int[,] F, char[,] operations, int[] r, int[] s, int P, int N)
        {
            string output =
                "Таблица - Матрица максимальных прибылей и операций:\nk/t";

            for (int i = 0; i < N; i++) output += $"\t{i + 1}";

            output += "\n";

            for (int k = 1; k <= N; k++)
            {
                output += k + "\t";
                for (int t = 1; t <= N; t++)
                {
                    output += $"{F[k, t]}\t";
                }
                output += "\n";
            }

            int currentAge = 1;
            for (int k = 1; k <= N; k++)
            {
                if (currentAge > N) break;

                char operation = operations[k, currentAge];
                int profit = F[k, currentAge];

                output += $"Год {k}: Оптимальное управление = ({operation}), F{k}({currentAge}) = {profit}\n";

                if (operation == 'З') currentAge = 1;
                else currentAge++;
            }
            MessageBox.Show(output);
        }

        void DetermineOptimalStrategyHtml(int[,] F, char[,] operations, int[] r, int[] s, int P, int N)
        {
            string htmlOutput = "<!DOCTYPE html>" +
                                "<html lang=\"ru\">" +
                                "<head>" +
                                "<meta charset=\"UTF-8\">" +
                                "<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">" +
                                "<title>Матрица максимальных прибылей и операций</title>" +
                                "<style>" +
                                "body { font-family: Arial, sans-serif; margin: 20px; }" +
                                "table { border-collapse: collapse; width: 100%; margin-top: 20px; }" +
                                "th, td { border: 1px solid #ddd; padding: 8px; text-align: center; }" +
                                "th { background-color: #f2f2f2; }" +
                                "h2 { color: #333; }" +
                                "</style>" +
                                "</head>" +
                                "<body>" +
                                "<h2>Таблица - Матрица максимальных прибылей и операций</h2>";

            htmlOutput += "<table>" +
                          "<tr><th>k/t</th>";

            for (int i = 0; i < N; i++)
            {
                htmlOutput += $"<th>{i + 1}</th>";
            }

            htmlOutput += "</tr>";

            for (int k = 1; k <= N; k++)
            {
                htmlOutput += $"<tr><td>{k}</td>";
                for (int t = 1; t <= N; t++)
                {
                    htmlOutput += $"<td>{F[k, t]}</td>";
                }
                htmlOutput += "</tr>";
            }

            htmlOutput += "</table>";

            htmlOutput += "<h3>Оптимальные стратегии по годам:</h3>";
            htmlOutput += "<ul>";

            int currentAge = 1;
            for (int k = 1; k <= N; k++)
            {
                if (currentAge > N) break;

                char operation = operations[k, currentAge];
                int profit = F[k, currentAge];

                htmlOutput += $"<li>Год {k}: Оптимальное управление = ({operation}), F{k}({currentAge}) = {profit}</li>";

                if (operation == 'З') currentAge = 1;
                else currentAge++;
            }

            htmlOutput += "</ul></body></html>";

            string filePath = "optimal_strategy.html";
            System.IO.File.WriteAllText(filePath, htmlOutput);

            System.Diagnostics.Process.Start("explorer", filePath);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
