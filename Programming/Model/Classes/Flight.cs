using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит информацию о рейсах. 
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Продолжительность полета. 
        /// </summary>
        private int _duration;

        /// <summary>
        /// Возвращает и задает точку отправления. 
        /// </summary>
        public string Destination { get; set; }
        /// <summary>
        /// Возвращает и задает пункт назначения. 
        /// </summary>
        public string Departure { get; set; }
        /// <summary>
        /// Возвращает и задает продолжительность полета. Должна быть положительной. 
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
        /// Создает объект класса <see cref="Flight"/>.
        /// </summary>
        public Flight()
        {
        }
        /// <summary>
        /// Создает объект класса <see cref="Flight"/>. 
        /// </summary>
        /// <param name="departure">Точка отправления. </param>
        /// <param name="destination">Пункт назначения. </param>
        /// <param name="duration">Продолжительность полета. Должна быть положительной. </param>
        public Flight(string departure, string destination, int duration)
        {
            Departure = departure;
            Destination = destination;
            Duration = duration;
        }
    }
}
