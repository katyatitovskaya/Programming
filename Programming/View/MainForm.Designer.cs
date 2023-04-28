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
            this.SeasonChoiceResultLabel = new System.Windows.Forms.Label();
            this.SeasonChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseSeasonLabel = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.weekadayParsingControl1 = new Programming.View.Panels.WeekadayParsingControl();
            this.groupBoxEnums = new System.Windows.Forms.GroupBox();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChooseValuelabel = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.labelChooseEnum = new System.Windows.Forms.Label();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FilmsGroupBox = new System.Windows.Forms.GroupBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.filmNameLabel = new System.Windows.Forms.Label();
            this.FindMaxFilmRatingButton = new System.Windows.Forms.Button();
            this.FilmRatingTextBox = new System.Windows.Forms.TextBox();
            this.FilmGenreTextBox = new System.Windows.Forms.TextBox();
            this.FilmYearTextBox = new System.Windows.Forms.TextBox();
            this.FilmDurationTextBox = new System.Windows.Forms.TextBox();
            this.FilmNameTextBox = new System.Windows.Forms.TextBox();
            this.FilmsListBox = new System.Windows.Forms.ListBox();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl1 = new Programming.View.Panels.RectanglesCollisionControl();
            this.classesRectanglesControl1 = new Programming.View.Panels.ClassesRectanglesControl();
            this.RectanglesTabControl.SuspendLayout();
            this.Enums.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.groupBoxEnums.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.FilmsGroupBox.SuspendLayout();
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
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonChoiceResultLabel);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonChoiceComboBox);
            this.SeasonHandleGroupBox.Controls.Add(this.ChooseSeasonLabel);
            this.SeasonHandleGroupBox.Controls.Add(this.GoButton);
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(408, 207);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(381, 135);
            this.SeasonHandleGroupBox.TabIndex = 2;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // SeasonChoiceResultLabel
            // 
            this.SeasonChoiceResultLabel.AutoSize = true;
            this.SeasonChoiceResultLabel.Location = new System.Drawing.Point(6, 92);
            this.SeasonChoiceResultLabel.Name = "SeasonChoiceResultLabel";
            this.SeasonChoiceResultLabel.Size = new System.Drawing.Size(0, 20);
            this.SeasonChoiceResultLabel.TabIndex = 4;
            // 
            // SeasonChoiceComboBox
            // 
            this.SeasonChoiceComboBox.FormattingEnabled = true;
            this.SeasonChoiceComboBox.Location = new System.Drawing.Point(6, 61);
            this.SeasonChoiceComboBox.Name = "SeasonChoiceComboBox";
            this.SeasonChoiceComboBox.Size = new System.Drawing.Size(216, 28);
            this.SeasonChoiceComboBox.TabIndex = 3;
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
            this.groupBoxEnums.Controls.Add(this.IntValueTextBox);
            this.groupBoxEnums.Controls.Add(this.label1);
            this.groupBoxEnums.Controls.Add(this.ChooseValuelabel);
            this.groupBoxEnums.Controls.Add(this.ValuesListBox);
            this.groupBoxEnums.Controls.Add(this.EnumsListBox);
            this.groupBoxEnums.Controls.Add(this.labelChooseEnum);
            this.groupBoxEnums.Location = new System.Drawing.Point(3, 6);
            this.groupBoxEnums.Name = "groupBoxEnums";
            this.groupBoxEnums.Size = new System.Drawing.Size(781, 195);
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
            this.ValuesListBox.Size = new System.Drawing.Size(135, 104);
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
            this.EnumsListBox.Size = new System.Drawing.Size(135, 104);
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
            this.tableLayoutPanel1.Controls.Add(this.FilmsGroupBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.classesRectanglesControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 411);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FilmsGroupBox
            // 
            this.FilmsGroupBox.Controls.Add(this.RatingLabel);
            this.FilmsGroupBox.Controls.Add(this.GenreLabel);
            this.FilmsGroupBox.Controls.Add(this.YearLabel);
            this.FilmsGroupBox.Controls.Add(this.DurationLabel);
            this.FilmsGroupBox.Controls.Add(this.filmNameLabel);
            this.FilmsGroupBox.Controls.Add(this.FindMaxFilmRatingButton);
            this.FilmsGroupBox.Controls.Add(this.FilmRatingTextBox);
            this.FilmsGroupBox.Controls.Add(this.FilmGenreTextBox);
            this.FilmsGroupBox.Controls.Add(this.FilmYearTextBox);
            this.FilmsGroupBox.Controls.Add(this.FilmDurationTextBox);
            this.FilmsGroupBox.Controls.Add(this.FilmNameTextBox);
            this.FilmsGroupBox.Controls.Add(this.FilmsListBox);
            this.FilmsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilmsGroupBox.Location = new System.Drawing.Point(396, 3);
            this.FilmsGroupBox.Name = "FilmsGroupBox";
            this.FilmsGroupBox.Size = new System.Drawing.Size(387, 405);
            this.FilmsGroupBox.TabIndex = 0;
            this.FilmsGroupBox.TabStop = false;
            this.FilmsGroupBox.Text = "Films";
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(162, 268);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(52, 20);
            this.RatingLabel.TabIndex = 14;
            this.RatingLabel.Text = "Rating";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(162, 207);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(48, 20);
            this.GenreLabel.TabIndex = 13;
            this.GenreLabel.Text = "Genre";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(162, 147);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(37, 20);
            this.YearLabel.TabIndex = 12;
            this.YearLabel.Text = "Year";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(162, 85);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(67, 20);
            this.DurationLabel.TabIndex = 11;
            this.DurationLabel.Text = "Duration";
            // 
            // filmNameLabel
            // 
            this.filmNameLabel.AutoSize = true;
            this.filmNameLabel.Location = new System.Drawing.Point(162, 26);
            this.filmNameLabel.Name = "filmNameLabel";
            this.filmNameLabel.Size = new System.Drawing.Size(49, 20);
            this.filmNameLabel.TabIndex = 10;
            this.filmNameLabel.Text = "Name";
            // 
            // FindMaxFilmRatingButton
            // 
            this.FindMaxFilmRatingButton.Location = new System.Drawing.Point(162, 345);
            this.FindMaxFilmRatingButton.Name = "FindMaxFilmRatingButton";
            this.FindMaxFilmRatingButton.Size = new System.Drawing.Size(94, 29);
            this.FindMaxFilmRatingButton.TabIndex = 9;
            this.FindMaxFilmRatingButton.Text = "Find";
            this.FindMaxFilmRatingButton.UseVisualStyleBackColor = true;
            this.FindMaxFilmRatingButton.Click += new System.EventHandler(this.FindMaxFilmRatingButton_Click);
            // 
            // FilmRatingTextBox
            // 
            this.FilmRatingTextBox.Location = new System.Drawing.Point(162, 291);
            this.FilmRatingTextBox.Name = "FilmRatingTextBox";
            this.FilmRatingTextBox.Size = new System.Drawing.Size(150, 27);
            this.FilmRatingTextBox.TabIndex = 8;
            // 
            // FilmGenreTextBox
            // 
            this.FilmGenreTextBox.Location = new System.Drawing.Point(162, 230);
            this.FilmGenreTextBox.Name = "FilmGenreTextBox";
            this.FilmGenreTextBox.Size = new System.Drawing.Size(150, 27);
            this.FilmGenreTextBox.TabIndex = 7;
            // 
            // FilmYearTextBox
            // 
            this.FilmYearTextBox.Location = new System.Drawing.Point(162, 170);
            this.FilmYearTextBox.Name = "FilmYearTextBox";
            this.FilmYearTextBox.Size = new System.Drawing.Size(150, 27);
            this.FilmYearTextBox.TabIndex = 6;
            // 
            // FilmDurationTextBox
            // 
            this.FilmDurationTextBox.Location = new System.Drawing.Point(162, 108);
            this.FilmDurationTextBox.Name = "FilmDurationTextBox";
            this.FilmDurationTextBox.Size = new System.Drawing.Size(150, 27);
            this.FilmDurationTextBox.TabIndex = 5;
            // 
            // FilmNameTextBox
            // 
            this.FilmNameTextBox.Location = new System.Drawing.Point(162, 48);
            this.FilmNameTextBox.Name = "FilmNameTextBox";
            this.FilmNameTextBox.Size = new System.Drawing.Size(150, 27);
            this.FilmNameTextBox.TabIndex = 4;
            // 
            // FilmsListBox
            // 
            this.FilmsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FilmsListBox.FormattingEnabled = true;
            this.FilmsListBox.ItemHeight = 20;
            this.FilmsListBox.Location = new System.Drawing.Point(6, 26);
            this.FilmsListBox.Name = "FilmsListBox";
            this.FilmsListBox.Size = new System.Drawing.Size(150, 164);
            this.FilmsListBox.TabIndex = 0;
            this.FilmsListBox.SelectedIndexChanged += new System.EventHandler(this.FilmsListBox_SelectedIndexChanged);
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
            // classesRectanglesControl1
            // 
            this.classesRectanglesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classesRectanglesControl1.Location = new System.Drawing.Point(3, 3);
            this.classesRectanglesControl1.Name = "classesRectanglesControl1";
            this.classesRectanglesControl1.Size = new System.Drawing.Size(387, 405);
            this.classesRectanglesControl1.TabIndex = 1;
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
            this.SeasonHandleGroupBox.PerformLayout();
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.groupBoxEnums.ResumeLayout(false);
            this.groupBoxEnums.PerformLayout();
            this.ClassesTabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.FilmsGroupBox.ResumeLayout(false);
            this.FilmsGroupBox.PerformLayout();
            this.RectanglesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl RectanglesTabControl;
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
        private Label ChooseSeasonLabel;
        private ComboBox SeasonChoiceComboBox;
        private Label SeasonChoiceResultLabel;
        private TabPage ClassesTabPage;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox FilmsGroupBox;
        private TextBox FilmYearTextBox;
        private TextBox FilmDurationTextBox;
        private TextBox FilmNameTextBox;
        private ListBox FilmsListBox;
        private Label filmNameLabel;
        private Button FindMaxFilmRatingButton;
        private TextBox FilmRatingTextBox;
        private TextBox FilmGenreTextBox;
        private Label DurationLabel;
        private Label YearLabel;
        private Label GenreLabel;
        private Label RatingLabel;
        private TabPage RectanglesTabPage;
        private Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private Panels.WeekadayParsingControl weekadayParsingControl1;
        private Panels.ClassesRectanglesControl classesRectanglesControl1;
    }
}