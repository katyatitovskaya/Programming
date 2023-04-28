namespace Programming.View.Panels
{
    partial class ClassesRectanglesControl
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
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.IDlabel = new System.Windows.Forms.Label();
            this.Ylabel = new System.Windows.Forms.Label();
            this.Xlabel = new System.Windows.Forms.Label();
            this.RectYTextBox = new System.Windows.Forms.TextBox();
            this.RectXTextBox = new System.Windows.Forms.TextBox();
            this.RectIDTextBox = new System.Windows.Forms.TextBox();
            this.FindMaxWidthButton = new System.Windows.Forms.Button();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.RectWidthLabel = new System.Windows.Forms.Label();
            this.RectColorTextBox = new System.Windows.Forms.TextBox();
            this.RectLengthTextBox = new System.Windows.Forms.TextBox();
            this.RectWidthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectanglesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.IDlabel);
            this.RectanglesGroupBox.Controls.Add(this.Ylabel);
            this.RectanglesGroupBox.Controls.Add(this.Xlabel);
            this.RectanglesGroupBox.Controls.Add(this.RectYTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectXTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectIDTextBox);
            this.RectanglesGroupBox.Controls.Add(this.FindMaxWidthButton);
            this.RectanglesGroupBox.Controls.Add(this.ColorLabel);
            this.RectanglesGroupBox.Controls.Add(this.LengthLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectWidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectLengthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectWidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(399, 433);
            this.RectanglesGroupBox.TabIndex = 2;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(158, 207);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(24, 20);
            this.IDlabel.TabIndex = 13;
            this.IDlabel.Text = "ID";
            // 
            // Ylabel
            // 
            this.Ylabel.AutoSize = true;
            this.Ylabel.Location = new System.Drawing.Point(238, 268);
            this.Ylabel.Name = "Ylabel";
            this.Ylabel.Size = new System.Drawing.Size(17, 20);
            this.Ylabel.TabIndex = 12;
            this.Ylabel.Text = "Y";
            // 
            // Xlabel
            // 
            this.Xlabel.AutoSize = true;
            this.Xlabel.Location = new System.Drawing.Point(156, 268);
            this.Xlabel.Name = "Xlabel";
            this.Xlabel.Size = new System.Drawing.Size(18, 20);
            this.Xlabel.TabIndex = 11;
            this.Xlabel.Text = "X";
            // 
            // RectYTextBox
            // 
            this.RectYTextBox.Location = new System.Drawing.Point(238, 291);
            this.RectYTextBox.Name = "RectYTextBox";
            this.RectYTextBox.ReadOnly = true;
            this.RectYTextBox.Size = new System.Drawing.Size(70, 27);
            this.RectYTextBox.TabIndex = 10;
            // 
            // RectXTextBox
            // 
            this.RectXTextBox.Location = new System.Drawing.Point(157, 291);
            this.RectXTextBox.Name = "RectXTextBox";
            this.RectXTextBox.ReadOnly = true;
            this.RectXTextBox.Size = new System.Drawing.Size(70, 27);
            this.RectXTextBox.TabIndex = 9;
            // 
            // RectIDTextBox
            // 
            this.RectIDTextBox.Location = new System.Drawing.Point(157, 230);
            this.RectIDTextBox.Name = "RectIDTextBox";
            this.RectIDTextBox.ReadOnly = true;
            this.RectIDTextBox.Size = new System.Drawing.Size(150, 27);
            this.RectIDTextBox.TabIndex = 8;
            // 
            // FindMaxWidthButton
            // 
            this.FindMaxWidthButton.Location = new System.Drawing.Point(161, 345);
            this.FindMaxWidthButton.Name = "FindMaxWidthButton";
            this.FindMaxWidthButton.Size = new System.Drawing.Size(94, 29);
            this.FindMaxWidthButton.TabIndex = 7;
            this.FindMaxWidthButton.Text = "Find";
            this.FindMaxWidthButton.UseVisualStyleBackColor = true;
            this.FindMaxWidthButton.Click += new System.EventHandler(this.FindMaxWidthButton_Click);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(161, 147);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(45, 20);
            this.ColorLabel.TabIndex = 6;
            this.ColorLabel.Text = "Color";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(157, 85);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(54, 20);
            this.LengthLabel.TabIndex = 5;
            this.LengthLabel.Text = "Length";
            // 
            // RectWidthLabel
            // 
            this.RectWidthLabel.AutoSize = true;
            this.RectWidthLabel.Location = new System.Drawing.Point(158, 26);
            this.RectWidthLabel.Name = "RectWidthLabel";
            this.RectWidthLabel.Size = new System.Drawing.Size(49, 20);
            this.RectWidthLabel.TabIndex = 4;
            this.RectWidthLabel.Text = "Width";
            // 
            // RectColorTextBox
            // 
            this.RectColorTextBox.Location = new System.Drawing.Point(158, 170);
            this.RectColorTextBox.Name = "RectColorTextBox";
            this.RectColorTextBox.Size = new System.Drawing.Size(150, 27);
            this.RectColorTextBox.TabIndex = 3;
            this.RectColorTextBox.TextChanged += new System.EventHandler(this.RectColorTextBox_TextChanged);
            // 
            // RectLengthTextBox
            // 
            this.RectLengthTextBox.Location = new System.Drawing.Point(158, 108);
            this.RectLengthTextBox.Name = "RectLengthTextBox";
            this.RectLengthTextBox.Size = new System.Drawing.Size(150, 27);
            this.RectLengthTextBox.TabIndex = 2;
            this.RectLengthTextBox.TextChanged += new System.EventHandler(this.RectLengthTextBox_TextChanged);
            // 
            // RectWidthTextBox
            // 
            this.RectWidthTextBox.Location = new System.Drawing.Point(158, 48);
            this.RectWidthTextBox.Name = "RectWidthTextBox";
            this.RectWidthTextBox.Size = new System.Drawing.Size(150, 27);
            this.RectWidthTextBox.TabIndex = 1;
            this.RectWidthTextBox.TextChanged += new System.EventHandler(this.RectWidthTextBox_TextChanged);
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 20;
            this.RectanglesListBox.Location = new System.Drawing.Point(2, 26);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(150, 304);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // ClassesRectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RectanglesGroupBox);
            this.Name = "ClassesRectanglesControl";
            this.Size = new System.Drawing.Size(399, 433);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox RectanglesGroupBox;
        private Label IDlabel;
        private Label Ylabel;
        private Label Xlabel;
        private TextBox RectYTextBox;
        private TextBox RectXTextBox;
        private TextBox RectIDTextBox;
        private Button FindMaxWidthButton;
        private Label ColorLabel;
        private Label LengthLabel;
        private Label RectWidthLabel;
        private TextBox RectColorTextBox;
        private TextBox RectLengthTextBox;
        private TextBox RectWidthTextBox;
        private ListBox RectanglesListBox;
    }
}
