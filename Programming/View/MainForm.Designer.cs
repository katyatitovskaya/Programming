namespace Programming.View
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
            this.RectanglesTabControl = new System.Windows.Forms.TabControl();
            this.Enums = new System.Windows.Forms.TabPage();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.weekadayParsingControl1 = new Programming.View.Panels.WeekadayParsingControl();
            this.groupBoxEnums = new System.Windows.Forms.GroupBox();
            this.enumsControl1 = new Programming.View.Panels.EnumsControl();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.classesRectanglesControl1 = new Programming.View.Panels.ClassesRectanglesControl();
            this.classesFilmsControl1 = new Programming.View.Panels.ClassesFilmsControl();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl1 = new Programming.View.Panels.RectanglesCollisionControl();
            this.changeSeasonControl1 = new Programming.View.Panels.ChangeSeasonControl();
            this.RectanglesTabControl.SuspendLayout();
            this.Enums.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.groupBoxEnums.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // RectanglesTabControl
            // 
            this.RectanglesTabControl.Controls.Add(this.Enums);
            this.RectanglesTabControl.Controls.Add(this.ClassesTabPage);
            this.RectanglesTabControl.Controls.Add(this.RectanglesTabPage);
            this.RectanglesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesTabControl.Location = new System.Drawing.Point(0, 0);
            this.RectanglesTabControl.Name = "RectanglesTabControl";
            this.RectanglesTabControl.SelectedIndex = 0;
            this.RectanglesTabControl.Size = new System.Drawing.Size(800, 450);
            this.RectanglesTabControl.TabIndex = 0;
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
            this.SeasonHandleGroupBox.Controls.Add(this.changeSeasonControl1);
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(408, 207);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(381, 135);
            this.SeasonHandleGroupBox.TabIndex = 2;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WeekdayParsingGroupBox.Controls.Add(this.weekadayParsingControl1);
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(6, 207);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(396, 135);
            this.WeekdayParsingGroupBox.TabIndex = 1;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // weekadayParsingControl1
            // 
            this.weekadayParsingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekadayParsingControl1.Location = new System.Drawing.Point(3, 23);
            this.weekadayParsingControl1.Name = "weekadayParsingControl1";
            this.weekadayParsingControl1.Size = new System.Drawing.Size(390, 109);
            this.weekadayParsingControl1.TabIndex = 0;
            // 
            // groupBoxEnums
            // 
            this.groupBoxEnums.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEnums.Controls.Add(this.enumsControl1);
            this.groupBoxEnums.Location = new System.Drawing.Point(3, 6);
            this.groupBoxEnums.Name = "groupBoxEnums";
            this.groupBoxEnums.Size = new System.Drawing.Size(781, 195);
            this.groupBoxEnums.TabIndex = 0;
            this.groupBoxEnums.TabStop = false;
            this.groupBoxEnums.Text = "Enumerations";
            // 
            // enumsControl1
            // 
            this.enumsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enumsControl1.Location = new System.Drawing.Point(3, 23);
            this.enumsControl1.Name = "enumsControl1";
            this.enumsControl1.Size = new System.Drawing.Size(775, 169);
            this.enumsControl1.TabIndex = 0;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.tableLayoutPanel1);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 29);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(792, 417);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.classesRectanglesControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.classesFilmsControl1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 411);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // classesRectanglesControl1
            // 
            this.classesRectanglesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classesRectanglesControl1.Location = new System.Drawing.Point(3, 3);
            this.classesRectanglesControl1.Name = "classesRectanglesControl1";
            this.classesRectanglesControl1.Size = new System.Drawing.Size(387, 405);
            this.classesRectanglesControl1.TabIndex = 1;
            // 
            // classesFilmsControl1
            // 
            this.classesFilmsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classesFilmsControl1.Location = new System.Drawing.Point(396, 3);
            this.classesFilmsControl1.Name = "classesFilmsControl1";
            this.classesFilmsControl1.Size = new System.Drawing.Size(387, 405);
            this.classesFilmsControl1.TabIndex = 2;
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.rectanglesCollisionControl1);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 29);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RectanglesTabPage.Size = new System.Drawing.Size(792, 417);
            this.RectanglesTabPage.TabIndex = 2;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(3, 3);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(786, 411);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // changeSeasonControl1
            // 
            this.changeSeasonControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeSeasonControl1.Location = new System.Drawing.Point(3, 23);
            this.changeSeasonControl1.Name = "changeSeasonControl1";
            this.changeSeasonControl1.Size = new System.Drawing.Size(375, 109);
            this.changeSeasonControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RectanglesTabControl);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.RectanglesTabControl.ResumeLayout(false);
            this.Enums.ResumeLayout(false);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.groupBoxEnums.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.RectanglesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl RectanglesTabControl;
        private TabPage Enums;
        private GroupBox SeasonHandleGroupBox;
        private GroupBox WeekdayParsingGroupBox;
        private TabPage ClassesTabPage;
        private TableLayoutPanel tableLayoutPanel1;
        private TabPage RectanglesTabPage;
        private Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private Panels.WeekadayParsingControl weekadayParsingControl1;
        private Panels.ClassesRectanglesControl classesRectanglesControl1;
        private Panels.ClassesFilmsControl classesFilmsControl1;
        private GroupBox groupBoxEnums;
        private Panels.EnumsControl enumsControl1;
        private Panels.ChangeSeasonControl changeSeasonControl1;
    }
}