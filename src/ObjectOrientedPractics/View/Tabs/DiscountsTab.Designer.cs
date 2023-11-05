namespace ObjectOrientedPractics.View.Tabs
{
    partial class DiscountsTab
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
            this.ProductsAmountLabel = new System.Windows.Forms.Label();
            this.DiscountAmountLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductsAmounttextLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductsAmountLabel
            // 
            this.ProductsAmountLabel.AutoSize = true;
            this.ProductsAmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductsAmountLabel.Location = new System.Drawing.Point(538, 59);
            this.ProductsAmountLabel.Name = "ProductsAmountLabel";
            this.ProductsAmountLabel.Size = new System.Drawing.Size(24, 28);
            this.ProductsAmountLabel.TabIndex = 0;
            this.ProductsAmountLabel.Text = "0";
            // 
            // DiscountAmountLabel
            // 
            this.DiscountAmountLabel.AutoSize = true;
            this.DiscountAmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DiscountAmountLabel.Location = new System.Drawing.Point(538, 124);
            this.DiscountAmountLabel.Name = "DiscountAmountLabel";
            this.DiscountAmountLabel.Size = new System.Drawing.Size(24, 28);
            this.DiscountAmountLabel.TabIndex = 1;
            this.DiscountAmountLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(425, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Discount Amount:";
            // 
            // ProductsAmounttextLabel
            // 
            this.ProductsAmounttextLabel.AutoSize = true;
            this.ProductsAmounttextLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductsAmounttextLabel.Location = new System.Drawing.Point(425, 39);
            this.ProductsAmounttextLabel.Name = "ProductsAmounttextLabel";
            this.ProductsAmounttextLabel.Size = new System.Drawing.Size(137, 20);
            this.ProductsAmounttextLabel.TabIndex = 3;
            this.ProductsAmounttextLabel.Text = "Products Amount:";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InfoLabel.Location = new System.Drawing.Point(3, 59);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(42, 20);
            this.InfoLabel.TabIndex = 4;
            this.InfoLabel.Text = "Info:";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(203, 82);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(94, 29);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(103, 82);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(94, 29);
            this.ApplyButton.TabIndex = 6;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(3, 82);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(94, 29);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // DiscountsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.ProductsAmounttextLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DiscountAmountLabel);
            this.Controls.Add(this.ProductsAmountLabel);
            this.Name = "DiscountsTab";
            this.Size = new System.Drawing.Size(565, 169);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ProductsAmountLabel;
        private Label DiscountAmountLabel;
        private Label label3;
        private Label ProductsAmounttextLabel;
        private Label InfoLabel;
        private Button UpdateButton;
        private Button ApplyButton;
        private Button CalculateButton;
    }
}
