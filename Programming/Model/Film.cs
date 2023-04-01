using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Film
    {
        private string _name;
        private int _duration;
        private int _year;
        private string _genre;
        private double _rating;

        public string Name { get; set; }
        public int Duration
        {
            get => _duration;
            set 
            {
                if (value < 0)
                    throw new ArgumentException("Продолжительность должна быть больше нуля");
                _duration = value; 
            }
        }
        public int Year
        {
            get => _year;
            set
            {
                if(value < 1900 || value > 2023) 
                   throw new ArgumentException("Фильм должен был выйти в период с 1990 по 2023");
                _year = value;
            }
        }
        public string Genre { get; set; }
        public double Rating
        {
            get => _rating;
            set
            {
                if(value < 0 || value > 10)
                    throw new ArgumentException("Число находится вне диапазона рейтинга");
                _rating = value;
            }
        }
        public Film()
        {
        }

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
