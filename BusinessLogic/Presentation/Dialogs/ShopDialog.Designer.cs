﻿namespace BusinessLogic.Presentation.Dialogs
{
    partial class ShopDialog
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
            title.Size = new Size(583, 261);
            title.TabIndex = 0;
            toolTip1.SetToolTip(title, "Название магазина, обязательное поле");
            // 
            // cancel
            // 
            cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancel.BackColor = Color.FromArgb(255, 192, 192);
            cancel.Location = new Point(328, 314);
            cancel.Name = "cancel";
            cancel.Size = new Size(267, 58);
            cancel.TabIndex = 2;
            cancel.Text = "❌ Назад";
            cancel.UseVisualStyleBackColor = false;
            cancel.Click += cancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(246, 27);
            label1.TabIndex = 3;
            label1.Text = "Название магазина*";
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 50;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Подсказка";
            // 
            // button
            // 
            button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button.BackColor = Color.FromArgb(174, 252, 167);
            button.Location = new Point(12, 314);
            button.Name = "button";
            button.Size = new Size(267, 58);
            button.TabIndex = 5;
            button.Text = "✔Сохранить";
            button.UseVisualStyleBackColor = false;
            button.Click += button_Click;
            // 
            // ShopDialog
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(607, 384);
            Controls.Add(button);
            Controls.Add(label1);
            Controls.Add(cancel);
            Controls.Add(title);
            Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ShopDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "...";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button cancel;
        private Label label1;
        private ToolTip toolTip1;
        public TextBox title;
        private Button button;
    }
}