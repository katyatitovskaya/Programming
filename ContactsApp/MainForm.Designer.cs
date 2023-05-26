namespace ContactsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.SelectedContactGroupBox = new System.Windows.Forms.GroupBox();
            this.BirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.VKcomTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.VKcomLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.BirthDayLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.AddContactButton = new System.Windows.Forms.Button();
            this.CreateContactButton = new System.Windows.Forms.Button();
            this.DeleteContactButton = new System.Windows.Forms.Button();
            this.SelectedContactGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.ItemHeight = 20;
            this.ContactsListBox.Location = new System.Drawing.Point(12, 12);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(332, 424);
            this.ContactsListBox.TabIndex = 0;
            this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.ContactsListBox_SelectedIndexChanged);
            // 
            // SelectedContactGroupBox
            // 
            this.SelectedContactGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedContactGroupBox.Controls.Add(this.BirthdayDateTimePicker);
            this.SelectedContactGroupBox.Controls.Add(this.VKcomTextBox);
            this.SelectedContactGroupBox.Controls.Add(this.PhoneNumberTextBox);
            this.SelectedContactGroupBox.Controls.Add(this.FullNameTextBox);
            this.SelectedContactGroupBox.Controls.Add(this.VKcomLabel);
            this.SelectedContactGroupBox.Controls.Add(this.PhoneLabel);
            this.SelectedContactGroupBox.Controls.Add(this.BirthDayLabel);
            this.SelectedContactGroupBox.Controls.Add(this.FullNameLabel);
            this.SelectedContactGroupBox.Location = new System.Drawing.Point(350, 12);
            this.SelectedContactGroupBox.Name = "SelectedContactGroupBox";
            this.SelectedContactGroupBox.Size = new System.Drawing.Size(573, 193);
            this.SelectedContactGroupBox.TabIndex = 1;
            this.SelectedContactGroupBox.TabStop = false;
            this.SelectedContactGroupBox.Text = "Selected Contact";
            // 
            // BirthdayDateTimePicker
            // 
            this.BirthdayDateTimePicker.Location = new System.Drawing.Point(127, 62);
            this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
            this.BirthdayDateTimePicker.Size = new System.Drawing.Size(250, 27);
            this.BirthdayDateTimePicker.TabIndex = 7;
            // 
            // VKcomTextBox
            // 
            this.VKcomTextBox.Location = new System.Drawing.Point(127, 128);
            this.VKcomTextBox.Name = "VKcomTextBox";
            this.VKcomTextBox.Size = new System.Drawing.Size(250, 27);
            this.VKcomTextBox.TabIndex = 6;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(127, 95);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(250, 27);
            this.PhoneNumberTextBox.TabIndex = 5;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(127, 26);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(440, 27);
            this.FullNameTextBox.TabIndex = 4;
            // 
            // VKcomLabel
            // 
            this.VKcomLabel.AutoSize = true;
            this.VKcomLabel.Location = new System.Drawing.Point(63, 131);
            this.VKcomLabel.Name = "VKcomLabel";
            this.VKcomLabel.Size = new System.Drawing.Size(58, 20);
            this.VKcomLabel.TabIndex = 3;
            this.VKcomLabel.Text = "vk.com:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(68, 98);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(53, 20);
            this.PhoneLabel.TabIndex = 2;
            this.PhoneLabel.Text = "Phone:";
            // 
            // BirthDayLabel
            // 
            this.BirthDayLabel.AutoSize = true;
            this.BirthDayLabel.Location = new System.Drawing.Point(24, 67);
            this.BirthDayLabel.Name = "BirthDayLabel";
            this.BirthDayLabel.Size = new System.Drawing.Size(97, 20);
            this.BirthDayLabel.TabIndex = 1;
            this.BirthDayLabel.Text = "Date of Birth:";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(42, 29);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(79, 20);
            this.FullNameLabel.TabIndex = 0;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // AddContactButton
            // 
            this.AddContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddContactButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddContactButton.BackgroundImage")));
            this.AddContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddContactButton.Location = new System.Drawing.Point(12, 454);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(40, 40);
            this.AddContactButton.TabIndex = 2;
            this.AddContactButton.UseVisualStyleBackColor = true;
            this.AddContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
            // 
            // CreateContactButton
            // 
            this.CreateContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateContactButton.BackgroundImage = global::ContactsApp.Properties.Resources.EditIcon;
            this.CreateContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateContactButton.Location = new System.Drawing.Point(58, 454);
            this.CreateContactButton.Name = "CreateContactButton";
            this.CreateContactButton.Size = new System.Drawing.Size(40, 40);
            this.CreateContactButton.TabIndex = 3;
            this.CreateContactButton.UseVisualStyleBackColor = true;
            // 
            // DeleteContactButton
            // 
            this.DeleteContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteContactButton.BackgroundImage = global::ContactsApp.Properties.Resources.RemoveUserIcon;
            this.DeleteContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteContactButton.Location = new System.Drawing.Point(104, 454);
            this.DeleteContactButton.Name = "DeleteContactButton";
            this.DeleteContactButton.Size = new System.Drawing.Size(40, 40);
            this.DeleteContactButton.TabIndex = 4;
            this.DeleteContactButton.UseVisualStyleBackColor = true;
            this.DeleteContactButton.Click += new System.EventHandler(this.DeleteContactButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 506);
            this.Controls.Add(this.DeleteContactButton);
            this.Controls.Add(this.CreateContactButton);
            this.Controls.Add(this.AddContactButton);
            this.Controls.Add(this.SelectedContactGroupBox);
            this.Controls.Add(this.ContactsListBox);
            this.Name = "MainForm";
            this.Text = "ContactsApp";
            this.SelectedContactGroupBox.ResumeLayout(false);
            this.SelectedContactGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox ContactsListBox;
        private GroupBox SelectedContactGroupBox;
        private DateTimePicker BirthdayDateTimePicker;
        private TextBox VKcomTextBox;
        private TextBox PhoneNumberTextBox;
        private TextBox FullNameTextBox;
        private Label VKcomLabel;
        private Label PhoneLabel;
        private Label BirthDayLabel;
        private Label FullNameLabel;
        private Button AddContactButton;
        private Button CreateContactButton;
        private Button DeleteContactButton;
    }
}