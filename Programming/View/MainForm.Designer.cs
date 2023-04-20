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
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.IDlabel = new System.Windows.Forms.Label();
            this.Ylabel = new System.Windows.Forms.Label();
            this.Xlabel = new System.Windows.Forms.Label();
            this.RectYTextBox = new System.Windows.Forms.TextBox();
            this.RectXTextBox = new System.Windows.Forms.TextBox();
            this.RectIDTextBox = new System.Windows.Forms.TextBox();
            this.FindMaxWidthButton = new System.Windows.Forms.Button();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.RectWidthLabel = new System.Windows.Forms.Label();
            this.RectColorTextBox = new System.Windows.Forms.TextBox();
            this.RectLengthTextBox = new System.Windows.Forms.TextBox();
            this.RectWidthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.BelowRectInfoLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.RectanglesHeightLabel = new System.Windows.Forms.Label();
            this.RectanglesWidthLabel = new System.Windows.Forms.Label();
            this.RectanglesYLabel = new System.Windows.Forms.Label();
            this.RectanglesXLabel = new System.Windows.Forms.Label();
            this.RectanglesIdLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.RectInfoListBox = new System.Windows.Forms.ListBox();
            this.RectPanel = new System.Windows.Forms.Panel();
            this.DeleteRectButton = new System.Windows.Forms.Button();
            this.AddRectButton = new System.Windows.Forms.Button();
            this.RectanglesTabControl.SuspendLayout();
            this.Enums.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.groupBoxEnums.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.FilmsGroupBox.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
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
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseLabel);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseButton);
            this.WeekdayParsingGroupBox.Controls.Add(this.TypeValueLabel);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseTextBox);
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(6, 207);
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
            this.tableLayoutPanel1.Controls.Add(this.RectanglesGroupBox, 0, 0);
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
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.IDlabel);
            this.RectanglesGroupBox.Controls.Add(this.Ylabel);
            this.RectanglesGroupBox.Controls.Add(this.Xlabel);
            this.RectanglesGroupBox.Controls.Add(this.RectYTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectXTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectIDTextBox);
            this.RectanglesGroupBox.Controls.Add(this.FindMaxWidthButton);
            this.RectanglesGroupBox.Controls.Add(this.ColorLabel);
            this.RectanglesGroupBox.Controls.Add(this.LengthLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectWidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectLengthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectWidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesGroupBox.Location = new System.Drawing.Point(3, 3);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(387, 405);
            this.RectanglesGroupBox.TabIndex = 1;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(158, 207);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(24, 20);
            this.IDlabel.TabIndex = 13;
            this.IDlabel.Text = "ID";
            // 
            // Ylabel
            // 
            this.Ylabel.AutoSize = true;
            this.Ylabel.Location = new System.Drawing.Point(238, 268);
            this.Ylabel.Name = "Ylabel";
            this.Ylabel.Size = new System.Drawing.Size(17, 20);
            this.Ylabel.TabIndex = 12;
            this.Ylabel.Text = "Y";
            // 
            // Xlabel
            // 
            this.Xlabel.AutoSize = true;
            this.Xlabel.Location = new System.Drawing.Point(156, 268);
            this.Xlabel.Name = "Xlabel";
            this.Xlabel.Size = new System.Drawing.Size(18, 20);
            this.Xlabel.TabIndex = 11;
            this.Xlabel.Text = "X";
            // 
            // RectYTextBox
            // 
            this.RectYTextBox.Location = new System.Drawing.Point(238, 291);
            this.RectYTextBox.Name = "RectYTextBox";
            this.RectYTextBox.ReadOnly = true;
            this.RectYTextBox.Size = new System.Drawing.Size(70, 27);
            this.RectYTextBox.TabIndex = 10;
            // 
            // RectXTextBox
            // 
            this.RectXTextBox.Location = new System.Drawing.Point(157, 291);
            this.RectXTextBox.Name = "RectXTextBox";
            this.RectXTextBox.ReadOnly = true;
            this.RectXTextBox.Size = new System.Drawing.Size(70, 27);
            this.RectXTextBox.TabIndex = 9;
            // 
            // RectIDTextBox
            // 
            this.RectIDTextBox.Location = new System.Drawing.Point(157, 230);
            this.RectIDTextBox.Name = "RectIDTextBox";
            this.RectIDTextBox.ReadOnly = true;
            this.RectIDTextBox.Size = new System.Drawing.Size(150, 27);
            this.RectIDTextBox.TabIndex = 8;
            // 
            // FindMaxWidthButton
            // 
            this.FindMaxWidthButton.Location = new System.Drawing.Point(161, 345);
            this.FindMaxWidthButton.Name = "FindMaxWidthButton";
            this.FindMaxWidthButton.Size = new System.Drawing.Size(94, 29);
            this.FindMaxWidthButton.TabIndex = 7;
            this.FindMaxWidthButton.Text = "Find";
            this.FindMaxWidthButton.UseVisualStyleBackColor = true;
            this.FindMaxWidthButton.Click += new System.EventHandler(this.FindMaxWidthButton_Click);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(161, 147);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(45, 20);
            this.ColorLabel.TabIndex = 6;
            this.ColorLabel.Text = "Color";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(157, 85);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(54, 20);
            this.LengthLabel.TabIndex = 5;
            this.LengthLabel.Text = "Length";
            // 
            // RectWidthLabel
            // 
            this.RectWidthLabel.AutoSize = true;
            this.RectWidthLabel.Location = new System.Drawing.Point(158, 26);
            this.RectWidthLabel.Name = "RectWidthLabel";
            this.RectWidthLabel.Size = new System.Drawing.Size(49, 20);
            this.RectWidthLabel.TabIndex = 4;
            this.RectWidthLabel.Text = "Width";
            // 
            // RectColorTextBox
            // 
            this.RectColorTextBox.Location = new System.Drawing.Point(158, 170);
            this.RectColorTextBox.Name = "RectColorTextBox";
            this.RectColorTextBox.Size = new System.Drawing.Size(150, 27);
            this.RectColorTextBox.TabIndex = 3;
            // 
            // RectLengthTextBox
            // 
            this.RectLengthTextBox.Location = new System.Drawing.Point(158, 108);
            this.RectLengthTextBox.Name = "RectLengthTextBox";
            this.RectLengthTextBox.Size = new System.Drawing.Size(150, 27);
            this.RectLengthTextBox.TabIndex = 2;
            // 
            // RectWidthTextBox
            // 
            this.RectWidthTextBox.Location = new System.Drawing.Point(158, 48);
            this.RectWidthTextBox.Name = "RectWidthTextBox";
            this.RectWidthTextBox.Size = new System.Drawing.Size(150, 27);
            this.RectWidthTextBox.TabIndex = 1;
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 20;
            this.RectanglesListBox.Location = new System.Drawing.Point(2, 26);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(150, 164);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.BelowRectInfoLabel);
            this.RectanglesTabPage.Controls.Add(this.SelectedRectangleLabel);
            this.RectanglesTabPage.Controls.Add(this.RectanglesHeightLabel);
            this.RectanglesTabPage.Controls.Add(this.RectanglesWidthLabel);
            this.RectanglesTabPage.Controls.Add(this.RectanglesYLabel);
            this.RectanglesTabPage.Controls.Add(this.RectanglesXLabel);
            this.RectanglesTabPage.Controls.Add(this.RectanglesIdLabel);
            this.RectanglesTabPage.Controls.Add(this.HeightTextBox);
            this.RectanglesTabPage.Controls.Add(this.WidthTextBox);
            this.RectanglesTabPage.Controls.Add(this.YTextBox);
            this.RectanglesTabPage.Controls.Add(this.XTextBox);
            this.RectanglesTabPage.Controls.Add(this.IdTextBox);
            this.RectanglesTabPage.Controls.Add(this.RectInfoListBox);
            this.RectanglesTabPage.Controls.Add(this.RectPanel);
            this.RectanglesTabPage.Controls.Add(this.DeleteRectButton);
            this.RectanglesTabPage.Controls.Add(this.AddRectButton);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 29);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RectanglesTabPage.Size = new System.Drawing.Size(792, 417);
            this.RectanglesTabPage.TabIndex = 2;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // BelowRectInfoLabel
            // 
            this.BelowRectInfoLabel.AutoSize = true;
            this.BelowRectInfoLabel.Location = new System.Drawing.Point(8, 11);
            this.BelowRectInfoLabel.Name = "BelowRectInfoLabel";
            this.BelowRectInfoLabel.Size = new System.Drawing.Size(84, 20);
            this.BelowRectInfoLabel.TabIndex = 0;
            this.BelowRectInfoLabel.Text = "Rectangles:";
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(10, 215);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(139, 20);
            this.SelectedRectangleLabel.TabIndex = 0;
            this.SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // RectanglesHeightLabel
            // 
            this.RectanglesHeightLabel.AutoSize = true;
            this.RectanglesHeightLabel.Location = new System.Drawing.Point(10, 381);
            this.RectanglesHeightLabel.Name = "RectanglesHeightLabel";
            this.RectanglesHeightLabel.Size = new System.Drawing.Size(57, 20);
            this.RectanglesHeightLabel.TabIndex = 0;
            this.RectanglesHeightLabel.Text = "Height:";
            // 
            // RectanglesWidthLabel
            // 
            this.RectanglesWidthLabel.AutoSize = true;
            this.RectanglesWidthLabel.Location = new System.Drawing.Point(8, 345);
            this.RectanglesWidthLabel.Name = "RectanglesWidthLabel";
            this.RectanglesWidthLabel.Size = new System.Drawing.Size(52, 20);
            this.RectanglesWidthLabel.TabIndex = 0;
            this.RectanglesWidthLabel.Text = "Width:";
            // 
            // RectanglesYLabel
            // 
            this.RectanglesYLabel.AutoSize = true;
            this.RectanglesYLabel.Location = new System.Drawing.Point(8, 315);
            this.RectanglesYLabel.Name = "RectanglesYLabel";
            this.RectanglesYLabel.Size = new System.Drawing.Size(20, 20);
            this.RectanglesYLabel.TabIndex = 0;
            this.RectanglesYLabel.Text = "Y:";
            // 
            // RectanglesXLabel
            // 
            this.RectanglesXLabel.AutoSize = true;
            this.RectanglesXLabel.Location = new System.Drawing.Point(8, 282);
            this.RectanglesXLabel.Name = "RectanglesXLabel";
            this.RectanglesXLabel.Size = new System.Drawing.Size(21, 20);
            this.RectanglesXLabel.TabIndex = 0;
            this.RectanglesXLabel.Text = "X:";
            // 
            // RectanglesIdLabel
            // 
            this.RectanglesIdLabel.AutoSize = true;
            this.RectanglesIdLabel.Location = new System.Drawing.Point(8, 249);
            this.RectanglesIdLabel.Name = "RectanglesIdLabel";
            this.RectanglesIdLabel.Size = new System.Drawing.Size(25, 20);
            this.RectanglesIdLabel.TabIndex = 0;
            this.RectanglesIdLabel.Text = "Id:";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(70, 378);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(125, 27);
            this.HeightTextBox.TabIndex = 7;
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(70, 345);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(125, 27);
            this.WidthTextBox.TabIndex = 6;
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(70, 312);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(125, 27);
            this.YTextBox.TabIndex = 5;
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(70, 279);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(125, 27);
            this.XTextBox.TabIndex = 4;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(70, 246);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(125, 27);
            this.IdTextBox.TabIndex = 0;
            // 
            // RectInfoListBox
            // 
            this.RectInfoListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RectInfoListBox.FormattingEnabled = true;
            this.RectInfoListBox.ItemHeight = 20;
            this.RectInfoListBox.Location = new System.Drawing.Point(8, 40);
            this.RectInfoListBox.Name = "RectInfoListBox";
            this.RectInfoListBox.Size = new System.Drawing.Size(303, 124);
            this.RectInfoListBox.TabIndex = 0;
            this.RectInfoListBox.SelectedIndexChanged += new System.EventHandler(this.RectInfoListBox_SelectedIndexChanged);
            // 
            // RectPanel
            // 
            this.RectPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectPanel.Location = new System.Drawing.Point(317, 6);
            this.RectPanel.Name = "RectPanel";
            this.RectPanel.Size = new System.Drawing.Size(467, 405);
            this.RectPanel.TabIndex = 3;
            // 
            // DeleteRectButton
            // 
            this.DeleteRectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteRectButton.Location = new System.Drawing.Point(45, 175);
            this.DeleteRectButton.Name = "DeleteRectButton";
            this.DeleteRectButton.Size = new System.Drawing.Size(31, 29);
            this.DeleteRectButton.TabIndex = 2;
            this.DeleteRectButton.Text = "-";
            this.DeleteRectButton.UseVisualStyleBackColor = true;
            this.DeleteRectButton.Click += new System.EventHandler(this.DeleteRectButton_Click);
            // 
            // AddRectButton
            // 
            this.AddRectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddRectButton.Location = new System.Drawing.Point(8, 175);
            this.AddRectButton.Name = "AddRectButton";
            this.AddRectButton.Size = new System.Drawing.Size(31, 29);
            this.AddRectButton.TabIndex = 1;
            this.AddRectButton.Text = "+";
            this.AddRectButton.UseVisualStyleBackColor = true;
            this.AddRectButton.Click += new System.EventHandler(this.AddRectButton_Click);
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
            this.WeekdayParsingGroupBox.PerformLayout();
            this.groupBoxEnums.ResumeLayout(false);
            this.groupBoxEnums.PerformLayout();
            this.ClassesTabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.FilmsGroupBox.ResumeLayout(false);
            this.FilmsGroupBox.PerformLayout();
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.RectanglesTabPage.ResumeLayout(false);
            this.RectanglesTabPage.PerformLayout();
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
        private Button ParseButton;
        private Label TypeValueLabel;
        private TextBox ParseTextBox;
        private Label ChooseSeasonLabel;
        private ComboBox SeasonChoiceComboBox;
        private Label ParseLabel;
        private Label SeasonChoiceResultLabel;
        private TabPage ClassesTabPage;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox FilmsGroupBox;
        private GroupBox RectanglesGroupBox;
        private TextBox FilmYearTextBox;
        private TextBox FilmDurationTextBox;
        private TextBox FilmNameTextBox;
        private ListBox FilmsListBox;
        private TextBox RectColorTextBox;
        private TextBox RectLengthTextBox;
        private TextBox RectWidthTextBox;
        private ListBox RectanglesListBox;
        private Label ColorLabel;
        private Label LengthLabel;
        private Label RectWidthLabel;
        private Button FindMaxWidthButton;
        private Label filmNameLabel;
        private Button FindMaxFilmRatingButton;
        private TextBox FilmRatingTextBox;
        private TextBox FilmGenreTextBox;
        private Label DurationLabel;
        private Label YearLabel;
        private Label GenreLabel;
        private Label RatingLabel;
        private TextBox RectYTextBox;
        private TextBox RectXTextBox;
        private TextBox RectIDTextBox;
        private Label IDlabel;
        private Label Ylabel;
        private Label Xlabel;
        private TabPage RectanglesTabPage;
        private Panel RectPanel;
        private Button DeleteRectButton;
        private Button AddRectButton;
        private ListBox RectInfoListBox;
        private Label RectanglesHeightLabel;
        private Label RectanglesWidthLabel;
        private Label RectanglesYLabel;
        private Label RectanglesXLabel;
        private Label RectanglesIdLabel;
        private TextBox HeightTextBox;
        private TextBox WidthTextBox;
        private TextBox YTextBox;
        private TextBox XTextBox;
        private TextBox IdTextBox;
        private Label BelowRectInfoLabel;
        private Label SelectedRectangleLabel;
    }
}