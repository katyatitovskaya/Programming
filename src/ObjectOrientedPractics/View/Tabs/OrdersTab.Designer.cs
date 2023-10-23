namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            this.components = new System.ComponentModel.Container();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SelectedOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.CreatedTextBox = new System.Windows.Forms.TextBox();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.DeliveryAddressGroupBox = new System.Windows.Forms.GroupBox();
            this.addressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.OrderItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderItemsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.OrdersGroupBox = new System.Windows.Forms.GroupBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SelectedOrderGroupBox.SuspendLayout();
            this.DeliveryAddressGroupBox.SuspendLayout();
            this.OrderItemsGroupBox.SuspendLayout();
            this.OrdersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(ObjectOrientedPractics.Model.Order);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.68275F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.31725F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.OrdersGroupBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1020, 534);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.SelectedOrderGroupBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DeliveryAddressGroupBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.OrderItemsGroupBox, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(458, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.37879F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.28788F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(559, 528);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // SelectedOrderGroupBox
            // 
            this.SelectedOrderGroupBox.Controls.Add(this.StatusLabel);
            this.SelectedOrderGroupBox.Controls.Add(this.IDLabel);
            this.SelectedOrderGroupBox.Controls.Add(this.StatusComboBox);
            this.SelectedOrderGroupBox.Controls.Add(this.CreatedTextBox);
            this.SelectedOrderGroupBox.Controls.Add(this.CreatedLabel);
            this.SelectedOrderGroupBox.Controls.Add(this.IDTextBox);
            this.SelectedOrderGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedOrderGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectedOrderGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SelectedOrderGroupBox.Name = "SelectedOrderGroupBox";
            this.SelectedOrderGroupBox.Size = new System.Drawing.Size(553, 128);
            this.SelectedOrderGroupBox.TabIndex = 0;
            this.SelectedOrderGroupBox.TabStop = false;
            this.SelectedOrderGroupBox.Text = "Selected Order";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(6, 89);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(57, 20);
            this.StatusLabel.TabIndex = 26;
            this.StatusLabel.Text = "Status:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(3, 23);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(29, 20);
            this.IDLabel.TabIndex = 24;
            this.IDLabel.Text = "ID:";
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(83, 86);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(151, 28);
            this.StatusComboBox.TabIndex = 21;
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            // 
            // CreatedTextBox
            // 
            this.CreatedTextBox.Location = new System.Drawing.Point(83, 53);
            this.CreatedTextBox.Name = "CreatedTextBox";
            this.CreatedTextBox.ReadOnly = true;
            this.CreatedTextBox.Size = new System.Drawing.Size(151, 27);
            this.CreatedTextBox.TabIndex = 23;
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(3, 56);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(67, 20);
            this.CreatedLabel.TabIndex = 25;
            this.CreatedLabel.Text = "Created:";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(83, 20);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(151, 27);
            this.IDTextBox.TabIndex = 22;
            // 
            // DeliveryAddressGroupBox
            // 
            this.DeliveryAddressGroupBox.Controls.Add(this.addressControl);
            this.DeliveryAddressGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeliveryAddressGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeliveryAddressGroupBox.Location = new System.Drawing.Point(3, 137);
            this.DeliveryAddressGroupBox.Name = "DeliveryAddressGroupBox";
            this.DeliveryAddressGroupBox.Size = new System.Drawing.Size(553, 169);
            this.DeliveryAddressGroupBox.TabIndex = 1;
            this.DeliveryAddressGroupBox.TabStop = false;
            this.DeliveryAddressGroupBox.Text = "Delivery Address";
            // 
            // addressControl
            // 
            this.addressControl.Address = null;
            this.addressControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressControl.Enabled = false;
            this.addressControl.Location = new System.Drawing.Point(3, 23);
            this.addressControl.Name = "addressControl";
            this.addressControl.Size = new System.Drawing.Size(547, 143);
            this.addressControl.TabIndex = 27;
            // 
            // OrderItemsGroupBox
            // 
            this.OrderItemsGroupBox.Controls.Add(this.OrderItemsListBox);
            this.OrderItemsGroupBox.Controls.Add(this.label2);
            this.OrderItemsGroupBox.Controls.Add(this.AmountLabel);
            this.OrderItemsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderItemsGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderItemsGroupBox.Location = new System.Drawing.Point(3, 312);
            this.OrderItemsGroupBox.Name = "OrderItemsGroupBox";
            this.OrderItemsGroupBox.Size = new System.Drawing.Size(553, 213);
            this.OrderItemsGroupBox.TabIndex = 2;
            this.OrderItemsGroupBox.TabStop = false;
            this.OrderItemsGroupBox.Text = "Order Items";
            // 
            // OrderItemsListBox
            // 
            this.OrderItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderItemsListBox.Enabled = false;
            this.OrderItemsListBox.FormattingEnabled = true;
            this.OrderItemsListBox.ItemHeight = 20;
            this.OrderItemsListBox.Location = new System.Drawing.Point(6, 26);
            this.OrderItemsListBox.Name = "OrderItemsListBox";
            this.OrderItemsListBox.Size = new System.Drawing.Size(541, 104);
            this.OrderItemsListBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount:";
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountLabel.Location = new System.Drawing.Point(493, 154);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(54, 28);
            this.AmountLabel.TabIndex = 1;
            this.AmountLabel.Text = "0.00";
            // 
            // OrdersGroupBox
            // 
            this.OrdersGroupBox.Controls.Add(this.DataGridView);
            this.OrdersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrdersGroupBox.Location = new System.Drawing.Point(3, 3);
            this.OrdersGroupBox.Name = "OrdersGroupBox";
            this.OrdersGroupBox.Size = new System.Drawing.Size(449, 528);
            this.OrdersGroupBox.TabIndex = 1;
            this.OrdersGroupBox.TabStop = false;
            this.OrdersGroupBox.Text = "Orders";
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AutoGenerateColumns = false;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.CustomerName,
            this.strAddress,
            this.amountDataGridViewTextBoxColumn,
            this.orderStatusDataGridViewTextBoxColumn});
            this.DataGridView.DataSource = this.orderBindingSource;
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(3, 23);
            this.DataGridView.MultiSelect = false;
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 29;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(443, 502);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Created";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Customer FullName";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 125;
            // 
            // strAddress
            // 
            this.strAddress.DataPropertyName = "strAddress";
            this.strAddress.HeaderText = "Address";
            this.strAddress.MinimumWidth = 6;
            this.strAddress.Name = "strAddress";
            this.strAddress.ReadOnly = true;
            this.strAddress.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderStatusDataGridViewTextBoxColumn
            // 
            this.orderStatusDataGridViewTextBoxColumn.DataPropertyName = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.HeaderText = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderStatusDataGridViewTextBoxColumn.Name = "orderStatusDataGridViewTextBoxColumn";
            this.orderStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // OrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OrdersTab";
            this.Size = new System.Drawing.Size(1020, 534);
            this.Load += new System.EventHandler(this.OrdersTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.SelectedOrderGroupBox.ResumeLayout(false);
            this.SelectedOrderGroupBox.PerformLayout();
            this.DeliveryAddressGroupBox.ResumeLayout(false);
            this.OrderItemsGroupBox.ResumeLayout(false);
            this.OrderItemsGroupBox.PerformLayout();
            this.OrdersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource orderBindingSource;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox SelectedOrderGroupBox;
        private Label StatusLabel;
        private Label IDLabel;
        private ComboBox StatusComboBox;
        private TextBox CreatedTextBox;
        private Label CreatedLabel;
        private TextBox IDTextBox;
        private GroupBox DeliveryAddressGroupBox;
        private Controls.AddressControl addressControl;
        private GroupBox OrderItemsGroupBox;
        private Label label2;
        private Label AmountLabel;
        private GroupBox OrdersGroupBox;
        private DataGridView DataGridView;
        private ListBox OrderItemsListBox;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn strAddress;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderStatusDataGridViewTextBoxColumn;
    }
}
