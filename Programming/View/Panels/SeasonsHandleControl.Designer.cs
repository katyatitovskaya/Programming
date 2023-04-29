namespace Programming.View.Panels
{
    partial class SeasonsHandleControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SeasonChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseSeasonLabel = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SeasonChoiceComboBox
            // 
            this.SeasonChoiceComboBox.FormattingEnabled = true;
            this.SeasonChoiceComboBox.Location = new System.Drawing.Point(13, 42);
            this.SeasonChoiceComboBox.Name = "SeasonChoiceComboBox";
            this.SeasonChoiceComboBox.Size = new System.Drawing.Size(216, 28);
            this.SeasonChoiceComboBox.TabIndex = 6;
            // 
            // ChooseSeasonLabel
            // 
            this.ChooseSeasonLabel.AutoSize = true;
            this.ChooseSeasonLabel.Location = new System.Drawing.Point(13, 16);
            this.ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            this.ChooseSeasonLabel.Size = new System.Drawing.Size(110, 20);
            this.ChooseSeasonLabel.TabIndex = 5;
            this.ChooseSeasonLabel.Text = "Choose season:";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(243, 41);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(94, 29);
            this.GoButton.TabIndex = 4;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // ChangeSeasonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SeasonChoiceComboBox);
            this.Controls.Add(this.ChooseSeasonLabel);
            this.Controls.Add(this.GoButton);
            this.Name = "ChangeSeasonControl";
            this.Size = new System.Drawing.Size(563, 329);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox SeasonChoiceComboBox;
        private Label ChooseSeasonLabel;
        private Button GoButton;
    }
}
