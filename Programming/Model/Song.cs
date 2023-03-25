using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Song
    {
        private string _name;
        private string _singer;
        private int _minutes;
        private int _seconds;

        public string Name { get; set; }
        public string Singer { get; set; }
        public int Minutes 
        {
            get { return _minutes; }
            set
            {
                if(value > 0)
                    _minutes = value;
                throw new ArgumentException("Продолжительность песни не может быть отрицательной");
            }
        }
        public int Seconds
        {
            get { return _seconds; }
            set
            {
                if (value > 0)
                    _seconds = value;
                throw new ArgumentException("Продолжительность песни не может быть отрицательной");
            }
        }
        public Song()
        {
        }
        public Song(string name, string singer, int minutes, int seconds)
        {
            Name = name;
            Singer = singer;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}
