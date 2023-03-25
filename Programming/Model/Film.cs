using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Film
    {
        private string _name;
        private int _duration;
        private int _year;
        private string _genre;
        private double _rating;

        public string Name { get; set; }
        public int Duration
        {
            get { return _duration; }
            set 
            {
                if (value<0)
                    throw new ArgumentException("Продолжительность должна быть больше нуля");
                _duration = value; 
            }
        }
        public int Year
        {
            get { return _year; }
            set
            {
                if(value >= 1990 && value <= 2023) 
                    _year = value;
                throw new ArgumentException("Фильм должен был выйти в период с 1990 по 2023");
            }
        }
        public string Genre { get; set; }
        public double Rating
        {
            get { return _rating; }
            set
            {
                if(value >= 0 && value <= 10)
                    _rating = value;
                throw new ArgumentException("Число находится вне диапазона рейтинга");
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
