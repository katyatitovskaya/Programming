using Programming.Model.Classes;
using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class FilmsListBoxControl : UserControl
    {
        private Film[] _films = new Film[5];
        private Film _currentFilm = new Film();
        public FilmsListBoxControl()
        {
            InitializeComponent();

            string[] filmNames = Enum.GetNames(typeof(FilmNames));
            string[] filmGenres = Enum.GetNames(typeof(Genre));
            Random rand = new Random();
            for (int i = 0; i < _films.Length; i++)
            {
                _films[i] = new Film(filmNames[rand.Next(1, filmNames.Length)], rand.Next(300), rand.Next(1900, 2023),
                    filmGenres[rand.Next(1, filmGenres.Length)], Math.Round(rand.NextDouble() * 10, 1));
                FilmsListBox.Items.Add($"Film {i + 1}");
            }
        }
        /// <summary>
        /// Обновляет значения в текстовых полях при изменении выбранного объекта из списка. 
        /// </summary>
        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = FilmsListBox.SelectedIndex;
            _currentFilm = _films[value];
            FilmNameTextBox.Text = _currentFilm.Name;
            FilmDurationTextBox.Text = _currentFilm.Duration.ToString();
            FilmYearTextBox.Text = _currentFilm.Year.ToString();
            FilmGenreTextBox.Text = _currentFilm.Genre;
            FilmRatingTextBox.Text = _currentFilm.Rating.ToString();
            
        }
        /// <summary>
        /// Проверяет и сохраняет значение в текстовом поле при изменении.
        /// </summary>
        private void FilmRatingTextBox_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                double newRating = Convert.ToDouble(FilmRatingTextBox.Text);
                _currentFilm.Rating = newRating;
                FilmRatingTextBox.BackColor = AppColors.White;
            }
            catch
            {
                FilmRatingTextBox.BackColor = AppColors.LightPink;
            }
        }
        /// <summary>
        /// Сохраняет значение в текстовом поле при изменении.
        /// </summary>
        private void FilmGenreTextBox_TextChanged(object? sender, EventArgs e)
        {
            _currentFilm.Genre = FilmGenreTextBox.Text;
        }
        /// <summary>
        /// Сохраняет значение в текстовом поле при изменении.
        /// </summary>
        private void FilmNameTextBox_TextChanged(object? sender, EventArgs e)
        {
            _currentFilm.Name = FilmNameTextBox.Text;
        }
        /// <summary>
        /// Проверяет и сохраняет значение в текстовом поле при изменении.
        /// </summary>
        private void FilmYearTextBox_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                int newYear = Convert.ToInt32(FilmYearTextBox.Text);
                _currentFilm.Year = newYear;
                FilmYearTextBox.BackColor = AppColors.White;
            }
            catch
            {
                FilmYearTextBox.BackColor = AppColors.LightPink;
            }
        }
        /// <summary>
        /// Проверяет и сохраняет значение в текстовом поле при изменении.
        /// </summary>
        private void FilmDurationTextBox_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                int newDuration = Convert.ToInt32(FilmDurationTextBox.Text);
                _currentFilm.Duration = newDuration;
                FilmDurationTextBox.BackColor = AppColors.White;
            }
            catch (ArgumentException)
            {
                FilmDurationTextBox.BackColor = AppColors.LightPink;
            }
        }
        /// <summary>
        /// Ищет фильм с наивысшим рейтингом. 
        /// </summary>
        /// <returns>Возвращает индекс фильма с наивысшим рейтингом. </returns>
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
        /// <summary>
        /// Выбирает фильм из списка с макстмальным рейтингом при нажатии на кнопку. 
        /// </summary>
        private void FindMaxFilmRatingButton_Click(object sender, EventArgs e)
        {
            FilmsListBox.SelectedIndex = FindFilmWithMaxRating();
        }
    }
}
