using System.DirectoryServices;
using System.Drawing.Text;
using System.Windows.Forms;
using Programming.Model.Class;
using Programming.Model.Classes;
using Programming.Model.Classes.Geometry;
using Programming.Model.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private Model.Classes.Geometry.Rectangle[] _rectangles = new Model.Classes.Geometry.Rectangle[5];
        private Model.Classes.Geometry.Rectangle _currentRectangle = new Model.Classes.Geometry.Rectangle();
        private Film[] _films = new Film[5];
        private Film _currentFilm = new Film();
       
        public MainForm() 
        {

            InitializeComponent();
            
            object[] enums = new object[] { typeof(Seasons),
            typeof(PhoneMakers), 
            typeof(EducationForm),
            typeof(Colors),
            typeof(Genre),
            typeof(Weekday) };
            
            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.DisplayMember = nameof(Type.Name);
            EnumsListBox.SelectedIndex = 0;
            ValuesListBox.SelectedIndex = 0;
           

            var seasonValues = Enum.GetValues(typeof(Seasons));
            foreach (var season in seasonValues)
            {
                SeasonChoiceComboBox.Items.Add(season);
            }
            string[] colorsNames = Enum.GetNames(typeof(Colors));
            string[] filmNames = Enum.GetNames(typeof(FilmNames));
            string[] filmGenres = Enum.GetNames(typeof(Genre));

            Random rand = new Random();
            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = new Model.Classes.Geometry.Rectangle(rand.Next(1, 200),
                    rand.Next(1, 200),
                    colorsNames[rand.Next(0, colorsNames.Length)], rand.Next(1, 100),
                    rand.Next(1, 100));
                RectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }
            for (int i = 0; i < _films.Length; i++)
            {
                _films[i] = new Film(filmNames[rand.Next(1, filmNames.Length)], rand.Next(300), rand.Next(1900, 2023),
                    filmGenres[rand.Next(1, filmGenres.Length)], Math.Round(rand.NextDouble() * 10, 1));
                FilmsListBox.Items.Add($"Film {i + 1}");
            }
            
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEnum = (Type)EnumsListBox.SelectedItem;
            var enumValues = Enum.GetValues(selectedEnum);
            ValuesListBox.Items.Clear();
            foreach (var enumValue in enumValues)
            {
                ValuesListBox.Items.Add(enumValue);
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var number = (int)(Enum.Parse((Type)(EnumsListBox.SelectedItem), ValuesListBox.Text));
            IntValueTextBox.Text = number.ToString();
        }

       

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (SeasonChoiceComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите время года");
                return;
            }
            string chosenSeason = SeasonChoiceComboBox.SelectedItem.ToString();
            switch (chosenSeason)
            {
                case "Winter":
                    SeasonHandleGroupBox.BackColor = Color.Transparent;
                    groupBoxEnums.BackColor = Color.Transparent;
                    WeekdayParsingGroupBox.BackColor = Color.Transparent;
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case "Spring":
                    SeasonHandleGroupBox.BackColor = Color.YellowGreen;
                    groupBoxEnums.BackColor = Color.YellowGreen;
                    WeekdayParsingGroupBox.BackColor = Color.YellowGreen;
                    break;
                case "Summer":
                    SeasonHandleGroupBox.BackColor = Color.Transparent;
                    groupBoxEnums.BackColor = Color.Transparent;
                    WeekdayParsingGroupBox.BackColor = Color.Transparent;
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case "Autumn":
                    SeasonChoiceResultLabel.Text = "";
                    SeasonHandleGroupBox.BackColor = Color.Orange;
                    groupBoxEnums.BackColor = Color.Orange;
                    WeekdayParsingGroupBox.BackColor = Color.Orange;
                    break;
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[value];
            RectWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectLengthTextBox.Text = _currentRectangle.Length.ToString();
            RectColorTextBox.Text = _currentRectangle.Color.ToString();
            RectXTextBox.Text = _currentRectangle.Centre.X.ToString();
            RectYTextBox.Text = _currentRectangle.Centre.Y.ToString();
            RectIDTextBox.Text = _currentRectangle.Id.ToString();
            RectLengthTextBox.TextChanged += RectLengthTextBox_TextChanged;
            RectWidthTextBox.TextChanged += RectWidthTextBox_TextChanged;
            RectColorTextBox.TextChanged += RectColorTextBox_TextChanged;
        }

        private void RectColorTextBox_TextChanged(object? sender, EventArgs e)
        {
            _currentRectangle.Color = RectColorTextBox.Text;
        }

        private void RectLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double newLength = Convert.ToDouble(RectLengthTextBox.Text);
                _currentRectangle.Length = newLength;
                RectLengthTextBox.BackColor = Color.White;
            }
            catch
            {
                RectLengthTextBox.BackColor = Color.LightPink;
            }
        }

        private void RectWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double newWidth = Convert.ToDouble(RectWidthTextBox.Text);
                _currentRectangle.Width = newWidth;
                RectWidthTextBox.BackColor = Color.White;
            }
            catch
            {
                RectWidthTextBox.BackColor = Color.LightPink;
            }
        }
        private int FindRectangleWithMaxWidth()
        {
            double maxWidth = _rectangles[0].Width;
            int maxWidthIndex = 0;

            for (int i = 0; i < _rectangles.Length; i++)
            {
                if (_rectangles[i].Width > maxWidth)
                {
                    maxWidth = _rectangles[i].Width;
                    maxWidthIndex = i;
                }
            }
            return maxWidthIndex;
        }

        private void FindMaxWidthButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth();
        }

        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = FilmsListBox.SelectedIndex;
            _currentFilm = _films[value];
            FilmNameTextBox.Text = _currentFilm.Name;
            FilmDurationTextBox.Text = _currentFilm.Duration.ToString();
            FilmYearTextBox.Text = _currentFilm.Year.ToString();
            FilmGenreTextBox.Text = _currentFilm.Genre;
            FilmRatingTextBox.Text = _currentFilm.Rating.ToString();
            FilmNameTextBox.TextChanged += FilmNameTextBox_TextChanged;
            FilmDurationTextBox.TextChanged += FilmDurationTextBox_TextChanged;
            FilmYearTextBox.TextChanged += FilmYearTextBox_TextChanged;
            FilmGenreTextBox.TextChanged += FilmGenreTextBox_TextChanged;
            FilmRatingTextBox.TextChanged += FilmRatingTextBox_TextChanged;
        }

        private void FilmRatingTextBox_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                double newRating = Convert.ToDouble(FilmRatingTextBox.Text);
                _currentFilm.Rating = newRating;
                FilmRatingTextBox.BackColor = Color.White;
            }
            catch
            {
                FilmRatingTextBox.BackColor = Color.LightPink;
            }
        }
        private void FilmGenreTextBox_TextChanged(object? sender, EventArgs e)
        {
            _currentFilm.Genre = FilmGenreTextBox.Text;
        }

        private void FilmNameTextBox_TextChanged(object? sender, EventArgs e)
        {
            _currentFilm.Name = FilmNameTextBox.Text;
        }
        private void FilmYearTextBox_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                int newYear = Convert.ToInt32(FilmYearTextBox.Text);
                _currentFilm.Year = newYear;
                FilmYearTextBox.BackColor = Color.White;
            }
            catch
            {
                FilmYearTextBox.BackColor = Color.LightPink;
            }
        }

        private void FilmDurationTextBox_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                int newDuration = Convert.ToInt32(FilmDurationTextBox.Text);
                _currentFilm.Duration = newDuration;
                FilmDurationTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                FilmDurationTextBox.BackColor = Color.LightPink;
            }
        }
        private int FindFilmWithMaxRating()
        {
            double maxRating = _films[0].Rating;
            int maxRatingIndex = 0;

            for (int i = 0; i < _films.Length; i++)
            {
                if (_films[i].Rating > maxRating)
                {
                    maxRating = _films[i].Rating;
                    maxRatingIndex = i;
                }
            }
            return maxRatingIndex;
        }

        private void FindMaxFilmRatingButton_Click(object sender, EventArgs e)
        {
            FilmsListBox.SelectedIndex = FindFilmWithMaxRating();
        }

       
    }
}