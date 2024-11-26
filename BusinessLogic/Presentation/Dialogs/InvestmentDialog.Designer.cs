namespace BusinessLogic.Presentation.Dialogs
{
    partial class InvestmentDialog
    {
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button = new Button();
            cancel = new Button();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            amount = new TextBox();
            label2 = new Label();
            companies = new ComboBox();
            profit = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button
            // 
            button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button.BackColor = Color.FromArgb(174, 252, 167);
            button.Location = new Point(12, 300);
            button.Name = "button";
            button.Size = new Size(267, 58);
            button.TabIndex = 2;
            button.Text = "✔Сохранить";
            button.UseVisualStyleBackColor = false;
            button.Click += button_Click;
            // 
            // cancel
            // 
            cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancel.BackColor = Color.FromArgb(255, 192, 192);
            cancel.Location = new Point(328, 300);
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
            label1.Size = new Size(129, 27);
            label1.TabIndex = 3;
            label1.Text = "Компания*";
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 50;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Подсказка";
            // 
            // amount
            // 
            amount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            amount.Font = new Font("Consolas", 16F);
            amount.Location = new Point(12, 121);
            amount.MaxLength = 500;
            amount.Name = "amount";
            amount.PlaceholderText = "Введите вклад..";
            amount.Size = new Size(334, 39);
            amount.TabIndex = 1;
            toolTip1.SetToolTip(amount, "Количество продукта, обязательное поле");
            amount.KeyPress += int_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(90, 27);
            label2.TabIndex = 5;
            label2.Text = "Вклад*";
            // 
            // companies
            // 
            companies.DisplayMember = "Title";
            companies.DropDownStyle = ComboBoxStyle.DropDownList;
            companies.Font = new Font("Consolas", 16F);
            companies.FormattingEnabled = true;
            companies.Location = new Point(12, 39);
            companies.Name = "companies";
            companies.Size = new Size(583, 40);
            companies.TabIndex = 6;
            // 
            // profit
            // 
            profit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            profit.Font = new Font("Consolas", 16F);
            profit.Location = new Point(12, 202);
            profit.MaxLength = 500;
            profit.Name = "profit";
            profit.PlaceholderText = "Введите прибыль..";
            profit.Size = new Size(334, 39);
            profit.TabIndex = 1;
            profit.KeyPress += int_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 172);
            label3.Name = "label3";
            label3.Size = new Size(116, 27);
            label3.TabIndex = 5;
            label3.Text = "Прибыль*";
            // 
            // InvestmentDialog
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(607, 370);
            Controls.Add(companies);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(profit);
            Controls.Add(amount);
            Controls.Add(label1);
            Controls.Add(cancel);
            Controls.Add(button);
            Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "InvestmentDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "...";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button;
        private Button cancel;
        private Label label1;
        private ToolTip toolTip1;
        private Label label2;
        public TextBox amount;
        public ComboBox companies;
        public TextBox profit;
        private Label label3;
    }
}