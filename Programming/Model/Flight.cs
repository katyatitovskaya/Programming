using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Flight
    {
        private string _departure;
        private string _destination;
        private int _duration;

        public string Destination { get; set; }
        public string Departure { get; set; }
        public int Duration 
        { 
            get { return _duration; }
            set
            {
                if (value > 0)
                    _duration = value;
                throw new ArgumentException("Время полета не может быть отрицательным");
            }
        }
    }
}
