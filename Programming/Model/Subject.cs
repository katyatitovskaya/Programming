using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Subject
    {
        private int _grade;

        public string Name { get; set; }
        public string Teacher { get; set; }
        public int Grade
        {
            get { return _grade; }
            set
            {
                Validator.AssertValueInRange(value, 2, 5);
                _grade = value;
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
