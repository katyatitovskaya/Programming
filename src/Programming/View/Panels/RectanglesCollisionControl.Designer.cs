namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            this.RectInfoListBox = new System.Windows.Forms.ListBox();
            this.BelowRectInfoLabel = new System.Windows.Forms.Label();
            this.RectPanel = new System.Windows.Forms.Panel();
            this.AddRectButton = new System.Windows.Forms.Button();
            this.DeleteRectButton = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.RectanglesIdLabel = new System.Windows.Forms.Label();
            this.RectanglesXLabel = new System.Windows.Forms.Label();
            this.RectanglesYLabel = new System.Windows.Forms.Label();
            this.RectanglesWidthLabel = new System.Windows.Forms.Label();
            this.RectanglesHeightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RectInfoListBox
            // 
            this.RectInfoListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RectInfoListBox.FormattingEnabled = true;
            this.RectInfoListBox.ItemHeight = 20;
            this.RectInfoListBox.Location = new System.Drawing.Point(3, 34);
            this.RectInfoListBox.Name = "RectInfoListBox";
            this.RectInfoListBox.Size = new System.Drawing.Size(303, 144);
            this.RectInfoListBox.TabIndex = 1;
            this.RectInfoListBox.SelectedIndexChanged += new System.EventHandler(this.RectInfoListBox_SelectedIndexChanged);
            // 
            // BelowRectInfoLabel
            // 
            this.BelowRectInfoLabel.AutoSize = true;
            this.BelowRectInfoLabel.Location = new System.Drawing.Point(3, 9);
            this.BelowRectInfoLabel.Name = "BelowRectInfoLabel";
            this.BelowRectInfoLabel.Size = new System.Drawing.Size(84, 20);
            this.BelowRectInfoLabel.TabIndex = 2;
            this.BelowRectInfoLabel.Text = "Rectangles:";
            // 
            // RectPanel
            // 
            this.RectPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectPanel.Location = new System.Drawing.Point(312, 3);
            this.RectPanel.Name = "RectPanel";
            this.RectPanel.Size = new System.Drawing.Size(467, 461);
            this.RectPanel.TabIndex = 4;
            // 
            // AddRectButton
            // 
            this.AddRectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddRectButton.Location = new System.Drawing.Point(3, 184);
            this.AddRectButton.Name = "AddRectButton";
            this.AddRectButton.Size = new System.Drawing.Size(31, 29);
            this.AddRectButton.TabIndex = 5;
            this.AddRectButton.Text = "+";
            this.AddRectButton.UseVisualStyleBackColor = true;
            this.AddRectButton.Click += new System.EventHandler(this.AddRectButton_Click);
            // 
            // DeleteRectButton
            // 
            this.DeleteRectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteRectButton.Location = new System.Drawing.Point(40, 184);
            this.DeleteRectButton.Name = "DeleteRectButton";
            this.DeleteRectButton.Size = new System.Drawing.Size(31, 29);
            this.DeleteRectButton.TabIndex = 6;
            this.DeleteRectButton.Text = "-";
            this.DeleteRectButton.UseVisualStyleBackColor = true;
            this.DeleteRectButton.Click += new System.EventHandler(this.DeleteRectButton_Click);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IdTextBox.Location = new System.Drawing.Point(66, 254);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(125, 27);
            this.IdTextBox.TabIndex = 7;
            // 
            // XTextBox
            // 
            this.XTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.XTextBox.Location = new System.Drawing.Point(66, 287);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(125, 27);
            this.XTextBox.TabIndex = 8;
            this.XTextBox.TextChanged += new System.EventHandler(this.XTextBox_TextChanged);
            // 
            // YTextBox
            // 
            this.YTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.YTextBox.Location = new System.Drawing.Point(66, 320);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(125, 27);
            this.YTextBox.TabIndex = 9;
            this.YTextBox.TextChanged += new System.EventHandler(this.YTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WidthTextBox.Location = new System.Drawing.Point(66, 353);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(125, 27);
            this.WidthTextBox.TabIndex = 10;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HeightTextBox.Location = new System.Drawing.Point(66, 386);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(125, 27);
            this.HeightTextBox.TabIndex = 11;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(3, 223);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(139, 20);
            this.SelectedRectangleLabel.TabIndex = 12;
            this.SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // RectanglesIdLabel
            // 
            this.RectanglesIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RectanglesIdLabel.AutoSize = true;
            this.RectanglesIdLabel.Location = new System.Drawing.Point(3, 257);
            this.RectanglesIdLabel.Name = "RectanglesIdLabel";
            this.RectanglesIdLabel.Size = new System.Drawing.Size(25, 20);
            this.RectanglesIdLabel.TabIndex = 13;
            this.RectanglesIdLabel.Text = "Id:";
            // 
            // RectanglesXLabel
            // 
            this.RectanglesXLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RectanglesXLabel.AutoSize = true;
            this.RectanglesXLabel.Location = new System.Drawing.Point(3, 290);
            this.RectanglesXLabel.Name = "RectanglesXLabel";
            this.RectanglesXLabel.Size = new System.Drawing.Size(21, 20);
            this.RectanglesXLabel.TabIndex = 14;
            this.RectanglesXLabel.Text = "X:";
            // 
            // RectanglesYLabel
            // 
            this.RectanglesYLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RectanglesYLabel.AutoSize = true;
            this.RectanglesYLabel.Location = new System.Drawing.Point(4, 323);
            this.RectanglesYLabel.Name = "RectanglesYLabel";
            this.RectanglesYLabel.Size = new System.Drawing.Size(20, 20);
            this.RectanglesYLabel.TabIndex = 15;
            this.RectanglesYLabel.Text = "Y:";
            // 
            // RectanglesWidthLabel
            // 
            this.RectanglesWidthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RectanglesWidthLabel.AutoSize = true;
            this.RectanglesWidthLabel.Location = new System.Drawing.Point(4, 356);
            this.RectanglesWidthLabel.Name = "RectanglesWidthLabel";
            this.RectanglesWidthLabel.Size = new System.Drawing.Size(52, 20);
            this.RectanglesWidthLabel.TabIndex = 16;
            this.RectanglesWidthLabel.Text = "Width:";
            // 
            // RectanglesHeightLabel
            // 
            this.RectanglesHeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RectanglesHeightLabel.AutoSize = true;
            this.RectanglesHeightLabel.Location = new System.Drawing.Point(3, 389);
            this.RectanglesHeightLabel.Name = "RectanglesHeightLabel";
            this.RectanglesHeightLabel.Size = new System.Drawing.Size(57, 20);
            this.RectanglesHeightLabel.TabIndex = 17;
            this.RectanglesHeightLabel.Text = "Height:";
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RectanglesHeightLabel);
            this.Controls.Add(this.RectanglesWidthLabel);
            this.Controls.Add(this.RectanglesYLabel);
            this.Controls.Add(this.RectanglesXLabel);
            this.Controls.Add(this.RectanglesIdLabel);
            this.Controls.Add(this.SelectedRectangleLabel);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.YTextBox);
            this.Controls.Add(this.XTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.DeleteRectButton);
            this.Controls.Add(this.AddRectButton);
            this.Controls.Add(this.RectPanel);
            this.Controls.Add(this.BelowRectInfoLabel);
            this.Controls.Add(this.RectInfoListBox);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(784, 467);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox RectInfoListBox;
        private Label BelowRectInfoLabel;
        private Panel RectPanel;
        private Button AddRectButton;
        private Button DeleteRectButton;
        private TextBox IdTextBox;
        private TextBox XTextBox;
        private TextBox YTextBox;
        private TextBox WidthTextBox;
        private TextBox HeightTextBox;
        private Label SelectedRectangleLabel;
        private Label RectanglesIdLabel;
        private Label RectanglesXLabel;
        private Label RectanglesYLabel;
        private Label RectanglesWidthLabel;
        private Label RectanglesHeightLabel;
    }
}
