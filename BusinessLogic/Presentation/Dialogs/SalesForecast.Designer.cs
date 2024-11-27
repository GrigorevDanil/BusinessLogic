namespace BusinessLogic.Presentation.Dialogs
{
    partial class SalesForecast {
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
			back = new Button();
			toolTip1 = new ToolTip(components);
			SuspendLayout();
			// 
			// back
			// 
			back.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			back.BackColor = Color.FromArgb(255, 192, 192);
			back.Location = new Point(632, 695);
			back.Name = "back";
			back.Size = new Size(267, 58);
			back.TabIndex = 3;
			back.Text = "Назад";
			back.UseVisualStyleBackColor = false;
			back.Click += back_Click;
			// 
			// toolTip1
			// 
			toolTip1.AutoPopDelay = 5000;
			toolTip1.InitialDelay = 500;
			toolTip1.ReshowDelay = 50;
			toolTip1.ToolTipIcon = ToolTipIcon.Info;
			toolTip1.ToolTipTitle = "Подсказка";
			// 
			// SalesForecast
			// 
			AutoScaleDimensions = new SizeF(120F, 120F);
			AutoScaleMode = AutoScaleMode.Dpi;
			ClientSize = new Size(911, 765);
			Controls.Add(back);
			Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "SalesForecast";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Прогноз продаж";
			ResumeLayout(false);
		}

		#endregion
		private Button back;
        private ToolTip toolTip1;
    }
}