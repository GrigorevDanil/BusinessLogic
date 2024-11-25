namespace BusinessLogic.Presentation.Dialogs
{
    partial class ProductResourceDialog
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
            quantity = new TextBox();
            label2 = new Label();
            resorces = new ComboBox();
            SuspendLayout();
            // 
            // button
            // 
            button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button.BackColor = Color.FromArgb(174, 252, 167);
            button.Location = new Point(12, 225);
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
            cancel.Location = new Point(328, 225);
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
            label1.Size = new Size(103, 27);
            label1.TabIndex = 3;
            label1.Text = "Ресурс*";
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 50;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Подсказка";
            // 
            // quantity
            // 
            quantity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            quantity.Font = new Font("Consolas", 16F);
            quantity.Location = new Point(12, 121);
            quantity.MaxLength = 500;
            quantity.Name = "quantity";
            quantity.PlaceholderText = "Введите количество..";
            quantity.Size = new Size(334, 39);
            quantity.TabIndex = 1;
            toolTip1.SetToolTip(quantity, "Количество продукта, обязательное поле");
            quantity.KeyPress += int_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(155, 27);
            label2.TabIndex = 5;
            label2.Text = "Количество*";
            // 
            // resorces
            // 
            resorces.DisplayMember = "Title";
            resorces.DropDownStyle = ComboBoxStyle.DropDownList;
            resorces.Font = new Font("Consolas", 16F);
            resorces.FormattingEnabled = true;
            resorces.Location = new Point(12, 39);
            resorces.Name = "resorces";
            resorces.Size = new Size(583, 40);
            resorces.TabIndex = 6;
            // 
            // ProductResourceDialog
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(607, 295);
            Controls.Add(resorces);
            Controls.Add(label2);
            Controls.Add(quantity);
            Controls.Add(label1);
            Controls.Add(cancel);
            Controls.Add(button);
            Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProductResourceDialog";
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
        public TextBox quantity;
        public ComboBox resorces;
    }
}