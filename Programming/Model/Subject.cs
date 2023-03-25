using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Subject
    {
        private string _name;
        private string _teacher;
        private int _grade;

        public string Name { get; set; }
        public string Teacher { get; set; }
        public int Grade
        {
            get { return _grade; }
            set
            {
                if (value >= 2 && value <= 5)
                    _grade = value;
                throw new ArgumentException("Оценка должна быть от 2 до 5");
            }
        }
        public Subject()
        {
        }
        public Subject(string name, string teacher, int grade)
        {
            Name = name;
            Teacher = teacher;
            Grade = grade;
        }
    }
}
