namespace BusinessLogic.Presentation.Dialogs
{
    partial class UpdateEquipmentDialog
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
            cancel = new Button();
            toolTip1 = new ToolTip(components);
            button = new Button();
            label2 = new Label();
            p_text = new TextBox();
            label1 = new Label();
            years = new ComboBox();
            panelMain = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonToFile = new Button();
            SuspendLayout();
            // 
            // cancel
            // 
            cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancel.BackColor = Color.FromArgb(255, 192, 192);
            cancel.Location = new Point(694, 313);
            cancel.Name = "cancel";
            cancel.Size = new Size(267, 58);
            cancel.TabIndex = 2;
            cancel.Text = "❌ Назад";
            cancel.UseVisualStyleBackColor = false;
            cancel.Click += cancel_Click;
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
            button.Location = new Point(12, 313);
            button.Name = "button";
            button.Size = new Size(267, 58);
            button.TabIndex = 5;
            button.Text = "✔Решить";
            button.UseVisualStyleBackColor = false;
            button.Click += button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 26);
            label2.Name = "label2";
            label2.Size = new Size(428, 27);
            label2.TabIndex = 3;
            label2.Text = "Стоимость нового оборудования, P";
            // 
            // p_text
            // 
            p_text.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            p_text.Location = new Point(459, 19);
            p_text.Name = "p_text";
            p_text.Size = new Size(125, 39);
            p_text.TabIndex = 6;
            p_text.KeyPress += int_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(389, 27);
            label1.TabIndex = 7;
            label1.Text = "Период эксплуатации (в годах)";
            // 
            // years
            // 
            years.DropDownStyle = ComboBoxStyle.DropDownList;
            years.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            years.FormattingEnabled = true;
            years.Items.AddRange(new object[] { "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            years.Location = new Point(459, 64);
            years.Name = "years";
            years.Size = new Size(125, 40);
            years.TabIndex = 8;
            years.SelectedIndexChanged += years_SelectedIndexChanged;
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.Location = new Point(141, 116);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(727, 152);
            panelMain.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 116);
            label3.Name = "label3";
            label3.Size = new Size(25, 27);
            label3.TabIndex = 7;
            label3.Text = "t";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 151);
            label4.Name = "label4";
            label4.Size = new Size(64, 27);
            label4.TabIndex = 7;
            label4.Text = "r(t)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 189);
            label5.Name = "label5";
            label5.Size = new Size(64, 27);
            label5.TabIndex = 7;
            label5.Text = "s(t)";
            // 
            // buttonToFile
            // 
            buttonToFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonToFile.BackColor = Color.FromArgb(175, 225, 255);
            buttonToFile.Location = new Point(300, 313);
            buttonToFile.Name = "buttonToFile";
            buttonToFile.Size = new Size(375, 58);
            buttonToFile.TabIndex = 5;
            buttonToFile.Text = "✔Решить и вывести в файл";
            buttonToFile.UseVisualStyleBackColor = false;
            buttonToFile.Click += buttonToFile_Click;
            // 
            // UpdateEquipmentDialog
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(973, 383);
            Controls.Add(panelMain);
            Controls.Add(years);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(p_text);
            Controls.Add(buttonToFile);
            Controls.Add(button);
            Controls.Add(label2);
            Controls.Add(cancel);
            Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UpdateEquipmentDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Стратегия обновления оборудования";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button cancel;
        private ToolTip toolTip1;
        private Button button;
        private Label label2;
        private TextBox p_text;
        private Label label1;
        private ComboBox years;
        private Panel panelMain;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonToFile;
    }
}