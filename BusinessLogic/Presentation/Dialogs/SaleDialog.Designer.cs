namespace BusinessLogic.Presentation.Dialogs
{
    partial class SaleDialog {
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
			value = new TextBox();
			cancel = new Button();
			label1 = new Label();
			toolTip1 = new ToolTip(components);
			date = new DateTimePicker();
			button = new Button();
			label2 = new Label();
			SuspendLayout();
			// 
			// value
			// 
			value.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			value.Font = new Font("Consolas", 16F);
			value.Location = new Point(12, 39);
			value.MaxLength = 500;
			value.Name = "value";
			value.PlaceholderText = "Введите число..";
			value.Size = new Size(628, 39);
			value.TabIndex = 0;
			toolTip1.SetToolTip(value, "Объём продажи (в рублях), обязательное поле");
			// 
			// cancel
			// 
			cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			cancel.BackColor = Color.FromArgb(255, 192, 192);
			cancel.Location = new Point(373, 208);
			cancel.Name = "cancel";
			cancel.Size = new Size(267, 58);
			cancel.TabIndex = 3;
			cancel.Text = "❌ Назад";
			cancel.UseVisualStyleBackColor = false;
			cancel.Click += cancel_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(194, 27);
			label1.TabIndex = 3;
			label1.Text = "Объём продажи*";
			// 
			// toolTip1
			// 
			toolTip1.AutoPopDelay = 5000;
			toolTip1.InitialDelay = 500;
			toolTip1.ReshowDelay = 50;
			toolTip1.ToolTipIcon = ToolTipIcon.Info;
			toolTip1.ToolTipTitle = "Подсказка";
			// 
			// date
			// 
			date.Checked = false;
			date.Location = new Point(12, 137);
			date.Name = "date";
			date.ShowCheckBox = true;
			date.Size = new Size(628, 34);
			date.TabIndex = 1;
			toolTip1.SetToolTip(date, "Дата продажи, не обязательное поле, по умолчанию - текущая дата");
			// 
			// button
			// 
			button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			button.BackColor = Color.FromArgb(174, 252, 167);
			button.Location = new Point(12, 208);
			button.Name = "button";
			button.Size = new Size(267, 58);
			button.TabIndex = 2;
			button.Text = "✔Сохранить";
			button.UseVisualStyleBackColor = false;
			button.Click += button_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 107);
			label2.Name = "label2";
			label2.Size = new Size(168, 27);
			label2.TabIndex = 5;
			label2.Text = "Дата продажи";
			// 
			// SaleDialog
			// 
			AutoScaleDimensions = new SizeF(120F, 120F);
			AutoScaleMode = AutoScaleMode.Dpi;
			ClientSize = new Size(652, 278);
			Controls.Add(label2);
			Controls.Add(date);
			Controls.Add(button);
			Controls.Add(label1);
			Controls.Add(cancel);
			Controls.Add(value);
			Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "SaleDialog";
			StartPosition = FormStartPosition.CenterParent;
			Text = "...";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button cancel;
        private Label label1;
        private ToolTip toolTip1;
        public TextBox value;
        private Button button;
		private Label label2;
		public DateTimePicker date;
	}
}