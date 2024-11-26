namespace BusinessLogic.Presentation
{
    partial class CashDesks {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			components = new System.ComponentModel.Container();
			b_calculate = new Button();
			b_back = new Button();
			toolTip1 = new ToolTip(components);
			b_save = new Button();
			lambda = new TextBox();
			w = new TextBox();
			ro = new TextBox();
			result = new Label();
			shops = new ComboBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			SuspendLayout();
			// 
			// b_calculate
			// 
			b_calculate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			b_calculate.BackColor = Color.FromArgb(192, 255, 192);
			b_calculate.Cursor = Cursors.Hand;
			b_calculate.Enabled = false;
			b_calculate.Location = new Point(16, 604);
			b_calculate.Name = "b_calculate";
			b_calculate.Size = new Size(215, 57);
			b_calculate.TabIndex = 4;
			b_calculate.Text = "✏️ Рассчитать";
			toolTip1.SetToolTip(b_calculate, "Рассчитать оптимальное количество касс");
			b_calculate.UseVisualStyleBackColor = false;
			b_calculate.Click += b_calculate_Click;
			// 
			// b_back
			// 
			b_back.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			b_back.BackColor = Color.LightCoral;
			b_back.Cursor = Cursors.Hand;
			b_back.Location = new Point(627, 604);
			b_back.Name = "b_back";
			b_back.Size = new Size(142, 57);
			b_back.TabIndex = 6;
			b_back.Text = "Назад";
			toolTip1.SetToolTip(b_back, "Вернуться назад");
			b_back.UseVisualStyleBackColor = false;
			b_back.Click += b_back_Click;
			// 
			// toolTip1
			// 
			toolTip1.AutoPopDelay = 5000;
			toolTip1.InitialDelay = 500;
			toolTip1.ReshowDelay = 50;
			toolTip1.ToolTipIcon = ToolTipIcon.Info;
			toolTip1.ToolTipTitle = "Подсказка";
			// 
			// b_save
			// 
			b_save.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			b_save.BackColor = Color.FromArgb(175, 225, 255);
			b_save.Cursor = Cursors.Hand;
			b_save.Enabled = false;
			b_save.Location = new Point(237, 604);
			b_save.Name = "b_save";
			b_save.Size = new Size(384, 57);
			b_save.TabIndex = 5;
			b_save.Text = "📁 Сохранить в файл";
			toolTip1.SetToolTip(b_save, "Сохранить результат в файл, чтобы можно было распечатать");
			b_save.UseVisualStyleBackColor = false;
			b_save.Click += b_save_Click;
			// 
			// lambda
			// 
			lambda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lambda.Location = new Point(59, 175);
			lambda.Margin = new Padding(50, 3, 50, 30);
			lambda.Name = "lambda";
			lambda.PlaceholderText = "Введите значение..";
			lambda.Size = new Size(667, 34);
			lambda.TabIndex = 1;
			toolTip1.SetToolTip(lambda, "Среднее количество покупателей в час, обязательное поле");
			lambda.TextChanged += lambda_TextChanged;
			// 
			// w
			// 
			w.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			w.Location = new Point(59, 269);
			w.Margin = new Padding(50, 3, 50, 30);
			w.Name = "w";
			w.PlaceholderText = "Введите значение..";
			w.Size = new Size(667, 34);
			w.TabIndex = 2;
			toolTip1.SetToolTip(w, "Среднее время обслуживания одного покупателя (в мминутах), обязательное поле");
			w.TextChanged += w_TextChanged;
			// 
			// ro
			// 
			ro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			ro.Location = new Point(59, 371);
			ro.Margin = new Padding(50, 3, 50, 30);
			ro.Name = "ro";
			ro.PlaceholderText = "0.7";
			ro.Size = new Size(667, 34);
			ro.TabIndex = 3;
			toolTip1.SetToolTip(ro, "Коэффициент загрузки кассира, по умолчанию стоит 0.7 (70%), не обязательное поле");
			ro.TextChanged += ro_TextChanged;
			// 
			// result
			// 
			result.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			result.Location = new Point(59, 435);
			result.Name = "result";
			result.Size = new Size(667, 144);
			result.TabIndex = 14;
			result.TextAlign = ContentAlignment.MiddleCenter;
			toolTip1.SetToolTip(result, "Тут будет выведено оптимальное количество касс");
			// 
			// shops
			// 
			shops.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			shops.DropDownStyle = ComboBoxStyle.DropDownList;
			shops.FormattingEnabled = true;
			shops.Location = new Point(59, 80);
			shops.Margin = new Padding(50, 3, 50, 30);
			shops.Name = "shops";
			shops.Size = new Size(667, 35);
			shops.TabIndex = 0;
			shops.SelectedIndexChanged += shops_SelectedIndexChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(59, 50);
			label1.Name = "label1";
			label1.Size = new Size(233, 27);
			label1.TabIndex = 8;
			label1.Text = "Выберите магазин*";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(59, 145);
			label2.Name = "label2";
			label2.Size = new Size(428, 27);
			label2.TabIndex = 9;
			label2.Text = "Средний поток покупателей в час*";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(59, 239);
			label3.Name = "label3";
			label3.Size = new Size(649, 27);
			label3.TabIndex = 11;
			label3.Text = "Средн. время обсл. одного покупателя (в минутах)*";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(59, 341);
			label4.Name = "label4";
			label4.Size = new Size(376, 27);
			label4.TabIndex = 13;
			label4.Text = "Коэффициент загрузки кассира";
			// 
			// CashDesks
			// 
			AutoScaleDimensions = new SizeF(120F, 120F);
			AutoScaleMode = AutoScaleMode.Dpi;
			ClientSize = new Size(785, 673);
			Controls.Add(result);
			Controls.Add(label4);
			Controls.Add(ro);
			Controls.Add(label3);
			Controls.Add(w);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(b_save);
			Controls.Add(shops);
			Controls.Add(lambda);
			Controls.Add(b_back);
			Controls.Add(b_calculate);
			Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "CashDesks";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Подсистема рассчёта оптимального количества касс в магазинах";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button b_calculate;
		private Button b_save;
        private Button b_back;
		private ComboBox shops;
		private TextBox lambda;
		private TextBox w;
		private TextBox ro;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label result;
        private ToolTip toolTip1;
	}
}