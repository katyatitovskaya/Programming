using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        public int Hours
        {
            get => _hours;
            set
            {
                if (value < 0 || value > 24)
                    throw new ArgumentException("Число находится вне диапазона");
                _hours = value;
            }
        }
        public int Minutes
        {
            get => _minutes;
            set
            {
                if (value < 0 || value > 60)
                    throw new ArgumentException("Число находится вне диапазона");
                _minutes = value;
            }
        }
        public int Seconds
        {
            get => _seconds;
            set
            {
                if (value >= 0 || value <= 59)
                    throw new ArgumentException("Число находится вне диапазона");
                _seconds = value;
            }
        }
        public Time()
        {
        }
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}
