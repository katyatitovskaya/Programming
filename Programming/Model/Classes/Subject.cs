using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит информацию о учебных дисциплинах. 
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Оценка за дисциплину. 
        /// </summary>
        private int _grade;
        /// <summary>
        /// Возвращает и задает название дисциплины. 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Возвращает и задает имя преподавателя. 
        /// </summary>
        public string Teacher { get; set; }
        /// <summary>
        /// Возвращает и задает оценку. Должна входить в диапазон от 2 до 5. 
        /// </summary>
        public int Grade
        {
            get { return _grade; }
            set
            {
                Validator.AssertValueInRange(value, 2, 5, nameof(Grade));
                _grade = value;
            }
        }
        /// <summary>
        /// Создает объект класса <see cref="Subject"/>.
        /// </summary>
        public Subject()
        {
        }
        /// <summary>
        /// Создает объект класса <see cref="Subject"/>.
        /// </summary>
        /// <param name="name">Название дисциплины. </param>
        /// <param name="teacher">Имя преподавателя. </param>
        /// <param name="grade">Оценка. </param>
        public Subject(string name, string teacher, int grade)
        {
            Name = name;
            Teacher = teacher;
            Grade = grade;
        }
    }
}
