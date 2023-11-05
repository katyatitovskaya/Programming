namespace ObjectOrientedPractics
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.customersTab = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.itemsTab = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.CartsTabPage = new System.Windows.Forms.TabPage();
            this.cartsTab = new ObjectOrientedPractics.View.Tabs.CartsTab();
            this.OrdersTabPage = new System.Windows.Forms.TabPage();
            this.ordersTab = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            this.DiscountsTabPage = new System.Windows.Forms.TabPage();
            this.discountsTab1 = new ObjectOrientedPractics.View.Tabs.DiscountsTab();
            this.tabPage2.SuspendLayout();
            this.ItemsTabPage.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.CartsTabPage.SuspendLayout();
            this.OrdersTabPage.SuspendLayout();
            this.DiscountsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.customersTab);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1224, 620);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // customersTab
            // 
            this.customersTab.Customers = null;
            this.customersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersTab.Location = new System.Drawing.Point(3, 3);
            this.customersTab.Name = "customersTab";
            this.customersTab.Size = new System.Drawing.Size(1218, 614);
            this.customersTab.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.itemsTab);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 29);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabPage.Size = new System.Drawing.Size(1224, 620);
            this.ItemsTabPage.TabIndex = 0;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab
            // 
            this.itemsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTab.Items = null;
            this.itemsTab.Location = new System.Drawing.Point(3, 3);
            this.itemsTab.Name = "itemsTab";
            this.itemsTab.Size = new System.Drawing.Size(1218, 614);
            this.itemsTab.TabIndex = 0;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ItemsTabPage);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.CartsTabPage);
            this.TabControl.Controls.Add(this.OrdersTabPage);
            this.TabControl.Controls.Add(this.DiscountsTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1232, 653);
            this.TabControl.TabIndex = 0;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // CartsTabPage
            // 
            this.CartsTabPage.Controls.Add(this.cartsTab);
            this.CartsTabPage.Location = new System.Drawing.Point(4, 29);
            this.CartsTabPage.Name = "CartsTabPage";
            this.CartsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CartsTabPage.Size = new System.Drawing.Size(1224, 620);
            this.CartsTabPage.TabIndex = 2;
            this.CartsTabPage.Text = "Carts";
            this.CartsTabPage.UseVisualStyleBackColor = true;
            // 
            // cartsTab
            // 
            this.cartsTab.Customers = null;
            this.cartsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartsTab.Items = null;
            this.cartsTab.Location = new System.Drawing.Point(3, 3);
            this.cartsTab.Name = "cartsTab";
            this.cartsTab.Size = new System.Drawing.Size(1218, 614);
            this.cartsTab.TabIndex = 0;
            // 
            // OrdersTabPage
            // 
            this.OrdersTabPage.Controls.Add(this.ordersTab);
            this.OrdersTabPage.Location = new System.Drawing.Point(4, 29);
            this.OrdersTabPage.Name = "OrdersTabPage";
            this.OrdersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersTabPage.Size = new System.Drawing.Size(1224, 620);
            this.OrdersTabPage.TabIndex = 3;
            this.OrdersTabPage.Text = "Orders";
            this.OrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // ordersTab
            // 
            this.ordersTab.Customers = null;
            this.ordersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersTab.Location = new System.Drawing.Point(3, 3);
            this.ordersTab.Name = "ordersTab";
            this.ordersTab.Size = new System.Drawing.Size(1218, 614);
            this.ordersTab.TabIndex = 0;
            // 
            // DiscountsTabPage
            // 
            this.DiscountsTabPage.Controls.Add(this.discountsTab1);
            this.DiscountsTabPage.Location = new System.Drawing.Point(4, 29);
            this.DiscountsTabPage.Name = "DiscountsTabPage";
            this.DiscountsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DiscountsTabPage.Size = new System.Drawing.Size(1224, 620);
            this.DiscountsTabPage.TabIndex = 4;
            this.DiscountsTabPage.Text = "tabPage1";
            this.DiscountsTabPage.UseVisualStyleBackColor = true;
            // 
            // discountsTab1
            // 
            this.discountsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discountsTab1.Items = null;
            this.discountsTab1.Location = new System.Drawing.Point(3, 3);
            this.discountsTab1.Name = "discountsTab1";
            this.discountsTab1.Size = new System.Drawing.Size(1218, 614);
            this.discountsTab1.TabIndex = 0;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 653);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1250, 700);
            this.Name = "Mainform";
            this.Text = "Object Oriented Practics";
            this.tabPage2.ResumeLayout(false);
            this.ItemsTabPage.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.CartsTabPage.ResumeLayout(false);
            this.OrdersTabPage.ResumeLayout(false);
            this.DiscountsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage2;
        private TabPage ItemsTabPage;
        private TabControl TabControl;
        private View.Tabs.ItemsTab itemsTab;
        private View.Tabs.CustomersTab customersTab;
        private TabPage CartsTabPage;
        private View.Tabs.CartsTab cartsTab;
        private TabPage OrdersTabPage;
        private View.Tabs.OrdersTab ordersTab;
        private TabPage DiscountsTabPage;
        private View.Tabs.DiscountsTab discountsTab1;
    }
}