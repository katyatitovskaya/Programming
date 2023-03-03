namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Enums = new System.Windows.Forms.TabPage();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseSeasonLabel = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.ParseLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.TypeValueLabel = new System.Windows.Forms.Label();
            this.ParseTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxEnums = new System.Windows.Forms.GroupBox();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChooseValuelabel = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.labelChooseEnum = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.Enums.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.groupBoxEnums.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Enums);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(800, 450);
            this.TabControl.TabIndex = 0;
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.SeasonHandleGroupBox);
            this.Enums.Controls.Add(this.WeekdayParsingGroupBox);
            this.Enums.Controls.Add(this.groupBoxEnums);
            this.Enums.Location = new System.Drawing.Point(4, 29);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(3);
            this.Enums.Size = new System.Drawing.Size(792, 417);
            this.Enums.TabIndex = 0;
            this.Enums.Text = "Enums";
            this.Enums.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonChoiceComboBox);
            this.SeasonHandleGroupBox.Controls.Add(this.ChooseSeasonLabel);
            this.SeasonHandleGroupBox.Controls.Add(this.GoButton);
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(408, 274);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(381, 135);
            this.SeasonHandleGroupBox.TabIndex = 2;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // SeasonChoiceComboBox
            // 
            this.SeasonChoiceComboBox.FormattingEnabled = true;
            this.SeasonChoiceComboBox.Location = new System.Drawing.Point(6, 61);
            this.SeasonChoiceComboBox.Name = "SeasonChoiceComboBox";
            this.SeasonChoiceComboBox.Size = new System.Drawing.Size(216, 28);
            this.SeasonChoiceComboBox.TabIndex = 3;
            this.SeasonChoiceComboBox.SelectedIndexChanged += new System.EventHandler(this.SeasonChoiceComboBox_SelectedIndexChanged);
            // 
            // ChooseSeasonLabel
            // 
            this.ChooseSeasonLabel.AutoSize = true;
            this.ChooseSeasonLabel.Location = new System.Drawing.Point(6, 35);
            this.ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            this.ChooseSeasonLabel.Size = new System.Drawing.Size(110, 20);
            this.ChooseSeasonLabel.TabIndex = 2;
            this.ChooseSeasonLabel.Text = "Choose season:";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(236, 60);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(94, 29);
            this.GoButton.TabIndex = 0;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseLabel);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseButton);
            this.WeekdayParsingGroupBox.Controls.Add(this.TypeValueLabel);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseTextBox);
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(6, 274);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(396, 135);
            this.WeekdayParsingGroupBox.TabIndex = 1;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // ParseLabel
            // 
            this.ParseLabel.AutoSize = true;
            this.ParseLabel.Location = new System.Drawing.Point(6, 90);
            this.ParseLabel.Name = "ParseLabel";
            this.ParseLabel.Size = new System.Drawing.Size(0, 20);
            this.ParseLabel.TabIndex = 3;
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(234, 60);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(94, 29);
            this.ParseButton.TabIndex = 2;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // TypeValueLabel
            // 
            this.TypeValueLabel.AutoSize = true;
            this.TypeValueLabel.Location = new System.Drawing.Point(6, 37);
            this.TypeValueLabel.Name = "TypeValueLabel";
            this.TypeValueLabel.Size = new System.Drawing.Size(158, 20);
            this.TypeValueLabel.TabIndex = 1;
            this.TypeValueLabel.Text = "Type value for parsing:";
            // 
            // ParseTextBox
            // 
            this.ParseTextBox.Location = new System.Drawing.Point(6, 60);
            this.ParseTextBox.Name = "ParseTextBox";
            this.ParseTextBox.Size = new System.Drawing.Size(213, 27);
            this.ParseTextBox.TabIndex = 0;
            // 
            // groupBoxEnums
            // 
            this.groupBoxEnums.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEnums.Controls.Add(this.IntValueTextBox);
            this.groupBoxEnums.Controls.Add(this.label1);
            this.groupBoxEnums.Controls.Add(this.ChooseValuelabel);
            this.groupBoxEnums.Controls.Add(this.ValuesListBox);
            this.groupBoxEnums.Controls.Add(this.EnumsListBox);
            this.groupBoxEnums.Controls.Add(this.labelChooseEnum);
            this.groupBoxEnums.Location = new System.Drawing.Point(3, 6);
            this.groupBoxEnums.Name = "groupBoxEnums";
            this.groupBoxEnums.Size = new System.Drawing.Size(781, 262);
            this.groupBoxEnums.TabIndex = 0;
            this.groupBoxEnums.TabStop = false;
            this.groupBoxEnums.Text = "Enumerations";
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(363, 46);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.Size = new System.Drawing.Size(140, 27);
            this.IntValueTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Int Value:";
            // 
            // ChooseValuelabel
            // 
            this.ChooseValuelabel.AutoSize = true;
            this.ChooseValuelabel.Location = new System.Drawing.Point(187, 23);
            this.ChooseValuelabel.Name = "ChooseValuelabel";
            this.ChooseValuelabel.Size = new System.Drawing.Size(101, 20);
            this.ChooseValuelabel.TabIndex = 3;
            this.ChooseValuelabel.Text = "Choose Value:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 20;
            this.ValuesListBox.Location = new System.Drawing.Point(187, 46);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(135, 184);
            this.ValuesListBox.TabIndex = 2;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 20;
            this.EnumsListBox.Location = new System.Drawing.Point(6, 46);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(135, 184);
            this.EnumsListBox.TabIndex = 1;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // labelChooseEnum
            // 
            this.labelChooseEnum.AutoSize = true;
            this.labelChooseEnum.Location = new System.Drawing.Point(6, 23);
            this.labelChooseEnum.Name = "labelChooseEnum";
            this.labelChooseEnum.Size = new System.Drawing.Size(149, 20);
            this.labelChooseEnum.TabIndex = 0;
            this.labelChooseEnum.Text = "Choose Enumeration:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.TabControl.ResumeLayout(false);
            this.Enums.ResumeLayout(false);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.SeasonHandleGroupBox.PerformLayout();
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.groupBoxEnums.ResumeLayout(false);
            this.groupBoxEnums.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl TabControl;
        private TabPage Enums;
        private GroupBox groupBoxEnums;
        private ListBox EnumsListBox;
        private Label labelChooseEnum;
        private TextBox IntValueTextBox;
        private Label label1;
        private Label ChooseValuelabel;
        private ListBox ValuesListBox;
        private GroupBox SeasonHandleGroupBox;
        private Button GoButton;
        private GroupBox WeekdayParsingGroupBox;
        private Button ParseButton;
        private Label TypeValueLabel;
        private TextBox ParseTextBox;
        private Label ChooseSeasonLabel;
        private ComboBox SeasonChoiceComboBox;
        private Label ParseLabel;
    }
}