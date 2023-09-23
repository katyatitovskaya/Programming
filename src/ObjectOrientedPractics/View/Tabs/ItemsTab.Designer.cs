namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.SelectedItemGroupBox = new System.Windows.Forms.GroupBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.DescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.NameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.ItemsGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SelectedItemGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.51852F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.48148F));
            this.tableLayoutPanel1.Controls.Add(this.ItemsGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SelectedItemGroupBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(810, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ItemsGroupBox
            // 
            this.ItemsGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.ItemsGroupBox.Controls.Add(this.ItemsListBox);
            this.ItemsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ItemsGroupBox.Name = "ItemsGroupBox";
            this.ItemsGroupBox.Size = new System.Drawing.Size(306, 420);
            this.ItemsGroupBox.TabIndex = 0;
            this.ItemsGroupBox.TabStop = false;
            this.ItemsGroupBox.Text = "Items";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.RemoveButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.AddButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 353);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(300, 64);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveButton.Location = new System.Drawing.Point(153, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(144, 58);
            this.RemoveButton.TabIndex = 8;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(144, 58);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 20;
            this.ItemsListBox.Location = new System.Drawing.Point(6, 26);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(294, 324);
            this.ItemsListBox.TabIndex = 0;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // SelectedItemGroupBox
            // 
            this.SelectedItemGroupBox.Controls.Add(this.DescriptionLabel);
            this.SelectedItemGroupBox.Controls.Add(this.NameLabel);
            this.SelectedItemGroupBox.Controls.Add(this.CostLabel);
            this.SelectedItemGroupBox.Controls.Add(this.IDLabel);
            this.SelectedItemGroupBox.Controls.Add(this.DescriptionRichTextBox);
            this.SelectedItemGroupBox.Controls.Add(this.NameRichTextBox);
            this.SelectedItemGroupBox.Controls.Add(this.CostTextBox);
            this.SelectedItemGroupBox.Controls.Add(this.IDTextBox);
            this.SelectedItemGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedItemGroupBox.Location = new System.Drawing.Point(315, 3);
            this.SelectedItemGroupBox.Name = "SelectedItemGroupBox";
            this.SelectedItemGroupBox.Size = new System.Drawing.Size(492, 420);
            this.SelectedItemGroupBox.TabIndex = 0;
            this.SelectedItemGroupBox.TabStop = false;
            this.SelectedItemGroupBox.Text = "Selected Item";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(6, 211);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(88, 20);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = "Description:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(6, 90);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(52, 20);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Name:";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(6, 59);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(41, 20);
            this.CostLabel.TabIndex = 5;
            this.CostLabel.Text = "Cost:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(6, 26);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(27, 20);
            this.IDLabel.TabIndex = 4;
            this.IDLabel.Text = "ID:";
            // 
            // DescriptionRichTextBox
            // 
            this.DescriptionRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionRichTextBox.Location = new System.Drawing.Point(6, 234);
            this.DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            this.DescriptionRichTextBox.Size = new System.Drawing.Size(449, 120);
            this.DescriptionRichTextBox.TabIndex = 3;
            this.DescriptionRichTextBox.Text = "";
            this.DescriptionRichTextBox.TextChanged += new System.EventHandler(this.DescriptionRichTextBox_TextChanged);
            // 
            // NameRichTextBox
            // 
            this.NameRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameRichTextBox.Location = new System.Drawing.Point(6, 113);
            this.NameRichTextBox.Name = "NameRichTextBox";
            this.NameRichTextBox.Size = new System.Drawing.Size(449, 95);
            this.NameRichTextBox.TabIndex = 2;
            this.NameRichTextBox.Text = "";
            this.NameRichTextBox.TextChanged += new System.EventHandler(this.NameRichTextBox_TextChanged);
            // 
            // CostTextBox
            // 
            this.CostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CostTextBox.Location = new System.Drawing.Point(67, 59);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(125, 27);
            this.CostTextBox.TabIndex = 1;
            this.CostTextBox.TextChanged += new System.EventHandler(this.CostTextBox_TextChanged);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDTextBox.Location = new System.Drawing.Point(67, 26);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(125, 27);
            this.IDTextBox.TabIndex = 0;
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(810, 426);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ItemsGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.SelectedItemGroupBox.ResumeLayout(false);
            this.SelectedItemGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox ItemsGroupBox;
        private ListBox ItemsListBox;
        private GroupBox SelectedItemGroupBox;
        private Label DescriptionLabel;
        private Label NameLabel;
        private Label CostLabel;
        private Label IDLabel;
        private RichTextBox DescriptionRichTextBox;
        private RichTextBox NameRichTextBox;
        private TextBox CostTextBox;
        private TextBox IDTextBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Button RemoveButton;
        private Button AddButton;
    }
}
