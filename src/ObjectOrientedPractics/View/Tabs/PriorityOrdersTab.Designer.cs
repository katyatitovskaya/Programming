namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            this.SelectedOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.CreatedTextBox = new System.Windows.Forms.TextBox();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.PriorityOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.DeliveryAddressGroupBox = new System.Windows.Forms.GroupBox();
            this.addressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.OrderItmesGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderItemsListBox = new System.Windows.Forms.ListBox();
            this.AmountTextLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.ClearOrderButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.DeliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.DeliveryTimeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SelectedOrderGroupBox.SuspendLayout();
            this.PriorityOptionsGroupBox.SuspendLayout();
            this.DeliveryAddressGroupBox.SuspendLayout();
            this.OrderItmesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DeliveryAddressGroupBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.OrderItmesGroupBox, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.05639F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.19237F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.75124F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 603);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.SelectedOrderGroupBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.PriorityOptionsGroupBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(756, 127);
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
            this.SelectedOrderGroupBox.Size = new System.Drawing.Size(372, 121);
            this.SelectedOrderGroupBox.TabIndex = 0;
            this.SelectedOrderGroupBox.TabStop = false;
            this.SelectedOrderGroupBox.Text = "Selected Order";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(9, 89);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(57, 20);
            this.StatusLabel.TabIndex = 32;
            this.StatusLabel.Text = "Status:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(6, 23);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(29, 20);
            this.IDLabel.TabIndex = 30;
            this.IDLabel.Text = "ID:";
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(86, 86);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(151, 28);
            this.StatusComboBox.TabIndex = 27;
            // 
            // CreatedTextBox
            // 
            this.CreatedTextBox.Location = new System.Drawing.Point(86, 53);
            this.CreatedTextBox.Name = "CreatedTextBox";
            this.CreatedTextBox.ReadOnly = true;
            this.CreatedTextBox.Size = new System.Drawing.Size(151, 27);
            this.CreatedTextBox.TabIndex = 29;
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(6, 56);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(67, 20);
            this.CreatedLabel.TabIndex = 31;
            this.CreatedLabel.Text = "Created:";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(86, 20);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(151, 27);
            this.IDTextBox.TabIndex = 28;
            // 
            // PriorityOptionsGroupBox
            // 
            this.PriorityOptionsGroupBox.Controls.Add(this.DeliveryTimeLabel);
            this.PriorityOptionsGroupBox.Controls.Add(this.DeliveryTimeComboBox);
            this.PriorityOptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriorityOptionsGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PriorityOptionsGroupBox.Location = new System.Drawing.Point(381, 3);
            this.PriorityOptionsGroupBox.Name = "PriorityOptionsGroupBox";
            this.PriorityOptionsGroupBox.Size = new System.Drawing.Size(372, 121);
            this.PriorityOptionsGroupBox.TabIndex = 1;
            this.PriorityOptionsGroupBox.TabStop = false;
            this.PriorityOptionsGroupBox.Text = "Priority Options";
            // 
            // DeliveryAddressGroupBox
            // 
            this.DeliveryAddressGroupBox.Controls.Add(this.addressControl);
            this.DeliveryAddressGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeliveryAddressGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeliveryAddressGroupBox.Location = new System.Drawing.Point(3, 136);
            this.DeliveryAddressGroupBox.Name = "DeliveryAddressGroupBox";
            this.DeliveryAddressGroupBox.Size = new System.Drawing.Size(756, 164);
            this.DeliveryAddressGroupBox.TabIndex = 1;
            this.DeliveryAddressGroupBox.TabStop = false;
            this.DeliveryAddressGroupBox.Text = "Delivery Address";
            // 
            // addressControl
            // 
            this.addressControl.Address = null;
            this.addressControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressControl.Location = new System.Drawing.Point(3, 23);
            this.addressControl.Name = "addressControl";
            this.addressControl.Size = new System.Drawing.Size(750, 138);
            this.addressControl.TabIndex = 0;
            // 
            // OrderItmesGroupBox
            // 
            this.OrderItmesGroupBox.Controls.Add(this.AddItemButton);
            this.OrderItmesGroupBox.Controls.Add(this.RemoveItemButton);
            this.OrderItmesGroupBox.Controls.Add(this.ClearOrderButton);
            this.OrderItmesGroupBox.Controls.Add(this.OrderItemsListBox);
            this.OrderItmesGroupBox.Controls.Add(this.AmountTextLabel);
            this.OrderItmesGroupBox.Controls.Add(this.AmountLabel);
            this.OrderItmesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderItmesGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderItmesGroupBox.Location = new System.Drawing.Point(3, 306);
            this.OrderItmesGroupBox.Name = "OrderItmesGroupBox";
            this.OrderItmesGroupBox.Size = new System.Drawing.Size(756, 294);
            this.OrderItmesGroupBox.TabIndex = 2;
            this.OrderItmesGroupBox.TabStop = false;
            this.OrderItmesGroupBox.Text = "Order Items";
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
            this.OrderItemsListBox.Size = new System.Drawing.Size(744, 164);
            this.OrderItemsListBox.TabIndex = 6;
            // 
            // AmountTextLabel
            // 
            this.AmountTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountTextLabel.AutoSize = true;
            this.AmountTextLabel.Location = new System.Drawing.Point(679, 193);
            this.AmountTextLabel.Name = "AmountTextLabel";
            this.AmountTextLabel.Size = new System.Drawing.Size(71, 20);
            this.AmountTextLabel.TabIndex = 5;
            this.AmountTextLabel.Text = "Amount:";
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountLabel.Location = new System.Drawing.Point(696, 213);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(54, 28);
            this.AmountLabel.TabIndex = 4;
            this.AmountLabel.Text = "0.00";
            // 
            // ClearOrderButton
            // 
            this.ClearOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearOrderButton.Location = new System.Drawing.Point(635, 244);
            this.ClearOrderButton.Name = "ClearOrderButton";
            this.ClearOrderButton.Size = new System.Drawing.Size(115, 35);
            this.ClearOrderButton.TabIndex = 12;
            this.ClearOrderButton.Text = "Clear Order";
            this.ClearOrderButton.UseVisualStyleBackColor = true;
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveItemButton.Location = new System.Drawing.Point(125, 244);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(115, 35);
            this.RemoveItemButton.TabIndex = 13;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddItemButton.Location = new System.Drawing.Point(3, 244);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(115, 35);
            this.AddItemButton.TabIndex = 15;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            // 
            // DeliveryTimeComboBox
            // 
            this.DeliveryTimeComboBox.FormattingEnabled = true;
            this.DeliveryTimeComboBox.Location = new System.Drawing.Point(122, 45);
            this.DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            this.DeliveryTimeComboBox.Size = new System.Drawing.Size(244, 28);
            this.DeliveryTimeComboBox.TabIndex = 0;
            // 
            // DeliveryTimeLabel
            // 
            this.DeliveryTimeLabel.AutoSize = true;
            this.DeliveryTimeLabel.Location = new System.Drawing.Point(6, 48);
            this.DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            this.DeliveryTimeLabel.Size = new System.Drawing.Size(110, 20);
            this.DeliveryTimeLabel.TabIndex = 1;
            this.DeliveryTimeLabel.Text = "Delivery Time:";
            // 
            // PriorityOrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PriorityOrdersTab";
            this.Size = new System.Drawing.Size(762, 603);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.SelectedOrderGroupBox.ResumeLayout(false);
            this.SelectedOrderGroupBox.PerformLayout();
            this.PriorityOptionsGroupBox.ResumeLayout(false);
            this.PriorityOptionsGroupBox.PerformLayout();
            this.DeliveryAddressGroupBox.ResumeLayout(false);
            this.OrderItmesGroupBox.ResumeLayout(false);
            this.OrderItmesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox SelectedOrderGroupBox;
        private Label StatusLabel;
        private Label IDLabel;
        private ComboBox StatusComboBox;
        private TextBox CreatedTextBox;
        private Label CreatedLabel;
        private TextBox IDTextBox;
        private GroupBox PriorityOptionsGroupBox;
        private GroupBox DeliveryAddressGroupBox;
        private Controls.AddressControl addressControl;
        private GroupBox OrderItmesGroupBox;
        private ListBox OrderItemsListBox;
        private Label AmountTextLabel;
        private Label AmountLabel;
        private Button RemoveItemButton;
        private Button ClearOrderButton;
        private Button AddItemButton;
        private Label DeliveryTimeLabel;
        private ComboBox DeliveryTimeComboBox;
    }
}
