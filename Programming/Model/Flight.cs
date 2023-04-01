using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Flight
    {
        private int _duration;

        public string Destination { get; set; }
        public string Departure { get; set; }
        public int Duration 
        { 
            get => _duration;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Время полета не может быть отрицательным");
                _duration = value;
            }
        }
        public Flight()
        {
        }
        public Flight(string departure, string destination, int duration)
        {
            Departure = departure;
            Destination = destination;
            Duration = duration;
        }
    }
}
