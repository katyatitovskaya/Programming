using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит информацию о песнях. 
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Продолжительность песни. 
        /// </summary>
        private int _duration;
        /// <summary>
        /// Возвращает и задает название песни.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Возвращает и задает имя исполнителя. 
        /// </summary>
        public string Singer { get; set; }
        /// <summary>
        /// Возвращает и задает продолжительность песни. Должна быть положительной. 
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
        /// Создает объект класса <see cref="Song"/>.
        /// </summary>
        public Song()
        {
        }
        /// <summary>
        /// Создает объект класса <see cref="Song"/>.
        /// </summary>
        /// <param name="name">Название песни. </param>
        /// <param name="singer">Имя исполнителя. </param>
        /// <param name="duration">Продолжительность песни. Должна быть положительной. </param>
        public Song(string name, string singer, int duration)
        {
            Name = name;
            Singer = singer;
            Duration= duration;
        }
    }
}
