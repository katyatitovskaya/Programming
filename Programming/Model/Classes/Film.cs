using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит информацию о фильмах. 
    /// </summary>
    public class Film
    {
        /// <summary>
        /// Продолжительность фильма. 
        /// </summary>
        private int _duration;
        /// <summary>
        /// Год выхода фильма. 
        /// </summary>
        private int _year;
        /// <summary>
        /// Рейтинг фильма. 
        /// </summary>
        private double _rating;

        /// <summary>
        /// Возвращает и задает имя фильма. 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Возвращает и задает продолжительность фильма. Должно быть положительной. 
        /// </summary>
        public int Duration
        {
            get => _duration;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Duration));
                _duration = value;
            }
        }
        /// <summary>
        /// Возвращает и задает год выхода фильма. Должен входить в диапазон от 1900 до нынешнего года. 
        /// </summary>
        public int Year
        {
            get => _year;
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(Year));
                _year = value;
            }
        }
        /// <summary>
        /// Возвращает и задает жанр фильма. 
        /// </summary>
        public string Genre { get; set; }
        /// <summary>
        /// Возвращает и задает рейтинг фильма. Должен входить в диапазон от 0 до 10.
        /// </summary>
        public double Rating
        {
            get => _rating;
            set
            {
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
        }
        /// <summary>
        /// Создает объект класса <see cref="Film"/>.
        /// </summary>
        public Film()
        {
        }
        /// <summary>
        /// Создает объект класса <see cref=">Film"/>.
        /// </summary>
        /// <param name="name">Название фильма. </param>
        /// <param name="duration">Продолжительность фильма. Значение должно быть положительным.</param>
        /// <param name="year">Год выхода фильма. Значение должно входить в диапазон от 1900 до нынешнего года. </param>
        /// <param name="genre">Жанр фильма. </param>
        /// <param name="rating">Рейтинг фильма. Должен входить в диапазон от 0 до 10. </param>
        public Film(string name, int duration, int year, string genre, double rating)
        {
            Name = name;
            Duration = duration;
            Year = year;
            Genre = genre;
            Rating = rating;
        }
    }
}
