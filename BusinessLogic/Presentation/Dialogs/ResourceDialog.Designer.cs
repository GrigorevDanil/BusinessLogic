namespace BusinessLogic.Presentation.Dialogs
{
    partial class ResourceDialog
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
            title = new TextBox();
            cancel = new Button();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            units = new TextBox();
            label3 = new Label();
            button = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            title.Font = new Font("Consolas", 16F);
            title.Location = new Point(12, 39);
            title.MaxLength = 500;
            title.Multiline = true;
            title.Name = "title";
            title.PlaceholderText = "Введите название..";
            title.Size = new Size(583, 167);
            title.TabIndex = 0;
            toolTip1.SetToolTip(title, "Название ресурса, обязательное поле");
            // 
            // cancel
            // 
            cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancel.BackColor = Color.FromArgb(255, 192, 192);
            cancel.Location = new Point(328, 313);
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
            label1.Size = new Size(233, 27);
            label1.TabIndex = 3;
            label1.Text = "Название ресурса*";
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 50;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Подсказка";
            // 
            // units
            // 
            units.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            units.Font = new Font("Consolas", 16F);
            units.Location = new Point(12, 239);
            units.MaxLength = 500;
            units.Name = "units";
            units.PlaceholderText = "Укажите ед. изм..";
            units.Size = new Size(334, 39);
            units.TabIndex = 6;
            toolTip1.SetToolTip(units, "Название единиц измерения, обязательное поле");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 209);
            label3.Name = "label3";
            label3.Size = new Size(246, 27);
            label3.TabIndex = 7;
            label3.Text = "Единицы измерения*";
            // 
            // button
            // 
            button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button.BackColor = Color.FromArgb(174, 252, 167);
            button.Location = new Point(12, 313);
            button.Name = "button";
            button.Size = new Size(267, 58);
            button.TabIndex = 8;
            button.Text = "✔ Сохранить";
            button.UseVisualStyleBackColor = false;
            button.Click += button_Click;
            // 
            // ResourceDialog
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(607, 383);
            Controls.Add(button);
            Controls.Add(label3);
            Controls.Add(units);
            Controls.Add(label1);
            Controls.Add(cancel);
            Controls.Add(title);
            Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ResourceDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "...";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button cancel;
        private Label label1;
        private ToolTip toolTip1;
        private Label label3;
        private Button button;
        public TextBox title;
        public TextBox units;
    }
}