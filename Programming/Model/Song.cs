using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Song
    {
        private int _minutes;
        private int _seconds;

        public string Name { get; set; }
        public string Singer { get; set; }
        public int Minutes 
        {
            get => _minutes;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _minutes = value;
            }
        }
        public int Seconds
        {
            get => _seconds;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _seconds = value;
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
