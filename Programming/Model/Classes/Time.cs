using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о времени. 
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Часы.
        /// </summary>
        private int _hours;
        /// <summary>
        /// Минуты. 
        /// </summary>
        private int _minutes;
        /// <summary>
        /// Секунды.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Возвращает и задает часы. Значение должно входить в диапазон от 0 до 24. 
        /// </summary>
        public int Hours
        {
            get => _hours;
            set
            {
                Validator.AssertValueInRange(value, 0, 24, nameof(Hours));
                _hours = value;
            }
        }
        /// <summary>
        /// Возвращает и задает минуты. Значение должно входить в диапазон от 0 до 60. 
        /// </summary>
        public int Minutes
        {
            get => _minutes;
            set
            {
                Validator.AssertValueInRange(value, 0, 60, nameof(Minutes));
                _minutes = value;
            }
        }
        /// <summary>
        /// Возвращает и задает секунды. Значение должно входить в диапазон от 0 до 60. 
        /// </summary>
        public int Seconds
        {
            get => _seconds;
            set
            {
                Validator.AssertValueInRange(value, 0, 60, nameof(Seconds));
                _seconds = value;
            }
        }
        /// <summary>
        /// Создает объект класса <see cref="Time"/>. 
        /// </summary>
        public Time()
        {
        }
        /// <summary>
        /// Создает объект класса <see cref="Time"/>.
        /// </summary>
        /// <param name="hours">Часы. Значение должно входить в диапазон от 0 до 24. </param>
        /// <param name="minutes">Минуты. Значение должно входить в диапазон от 0 до 60. </param>
        /// <param name="seconds">Секунды.  Значение должно входить в диапазон от 0 до 60. </param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}
