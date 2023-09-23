namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SelectedCustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomerAddressRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.CustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CustomersGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveCustomerButton = new System.Windows.Forms.Button();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SelectedCustomerGroupBox.SuspendLayout();
            this.CustomersGroupBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.0625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.9375F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CustomersGroupBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 411);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.SelectedCustomerGroupBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(310, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.91829F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.08171F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(473, 405);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // SelectedCustomerGroupBox
            // 
            this.SelectedCustomerGroupBox.Controls.Add(this.CustomerAddressRichTextBox);
            this.SelectedCustomerGroupBox.Controls.Add(this.CustomerNameTextBox);
            this.SelectedCustomerGroupBox.Controls.Add(this.CustomerIDTextBox);
            this.SelectedCustomerGroupBox.Controls.Add(this.AddressLabel);
            this.SelectedCustomerGroupBox.Controls.Add(this.FullNameLabel);
            this.SelectedCustomerGroupBox.Controls.Add(this.CustomerIDLabel);
            this.SelectedCustomerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedCustomerGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SelectedCustomerGroupBox.Name = "SelectedCustomerGroupBox";
            this.SelectedCustomerGroupBox.Size = new System.Drawing.Size(467, 163);
            this.SelectedCustomerGroupBox.TabIndex = 0;
            this.SelectedCustomerGroupBox.TabStop = false;
            this.SelectedCustomerGroupBox.Text = "Selected Customer";
            // 
            // CustomerAddressRichTextBox
            // 
            this.CustomerAddressRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerAddressRichTextBox.Location = new System.Drawing.Point(104, 92);
            this.CustomerAddressRichTextBox.Name = "CustomerAddressRichTextBox";
            this.CustomerAddressRichTextBox.Size = new System.Drawing.Size(357, 65);
            this.CustomerAddressRichTextBox.TabIndex = 5;
            this.CustomerAddressRichTextBox.Text = "";
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerNameTextBox.Location = new System.Drawing.Point(104, 59);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(357, 27);
            this.CustomerNameTextBox.TabIndex = 4;
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerIDTextBox.Location = new System.Drawing.Point(104, 26);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.Size = new System.Drawing.Size(147, 27);
            this.CustomerIDTextBox.TabIndex = 3;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(6, 95);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(65, 20);
            this.AddressLabel.TabIndex = 2;
            this.AddressLabel.Text = "Address:";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(6, 62);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(79, 20);
            this.FullNameLabel.TabIndex = 1;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Location = new System.Drawing.Point(6, 29);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(27, 20);
            this.CustomerIDLabel.TabIndex = 0;
            this.CustomerIDLabel.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 230);
            this.panel1.TabIndex = 1;
            // 
            // CustomersGroupBox
            // 
            this.CustomersGroupBox.Controls.Add(this.CustomersListBox);
            this.CustomersGroupBox.Controls.Add(this.tableLayoutPanel3);
            this.CustomersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersGroupBox.Location = new System.Drawing.Point(3, 3);
            this.CustomersGroupBox.Name = "CustomersGroupBox";
            this.CustomersGroupBox.Size = new System.Drawing.Size(301, 405);
            this.CustomersGroupBox.TabIndex = 1;
            this.CustomersGroupBox.TabStop = false;
            this.CustomersGroupBox.Text = "Customers";
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 20;
            this.CustomersListBox.Location = new System.Drawing.Point(6, 24);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(282, 304);
            this.CustomersListBox.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.RemoveCustomerButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.AddCustomerButton, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 335);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(282, 64);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // RemoveCustomerButton
            // 
            this.RemoveCustomerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveCustomerButton.Location = new System.Drawing.Point(144, 3);
            this.RemoveCustomerButton.Name = "RemoveCustomerButton";
            this.RemoveCustomerButton.Size = new System.Drawing.Size(135, 58);
            this.RemoveCustomerButton.TabIndex = 0;
            this.RemoveCustomerButton.Text = "Remove";
            this.RemoveCustomerButton.UseVisualStyleBackColor = true;
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddCustomerButton.Location = new System.Drawing.Point(3, 3);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(135, 58);
            this.AddCustomerButton.TabIndex = 1;
            this.AddCustomerButton.Text = "Add";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(786, 411);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.SelectedCustomerGroupBox.ResumeLayout(false);
            this.SelectedCustomerGroupBox.PerformLayout();
            this.CustomersGroupBox.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox SelectedCustomerGroupBox;
        private GroupBox CustomersGroupBox;
        private ListBox CustomersListBox;
        private RichTextBox CustomerAddressRichTextBox;
        private TextBox CustomerNameTextBox;
        private TextBox CustomerIDTextBox;
        private Label AddressLabel;
        private Label FullNameLabel;
        private Label CustomerIDLabel;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button AddCustomerButton;
        private Button RemoveCustomerButton;
    }
}
