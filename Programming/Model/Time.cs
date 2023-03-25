using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        public int Hours
        {
            get { return _hours; }
            set
            {
                if (value >= 0 && value <= 23)
                    _hours = value;
                throw new ArgumentException("Число находится вне диапазона");
            }
        }
        public int Minutes
        {
            get { return _minutes; }
            set
            {
                if (value >= 0 && value <= 59)
                    _minutes = value;
                throw new ArgumentException("Число находится вне диапазона");
            }
        }
        public int Seconds
        {
            get { return _seconds; }
            set
            {
                if (value >= 0 && value <= 59)
                    _seconds = value;
                throw new ArgumentException("Число находится вне диапазона");
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
