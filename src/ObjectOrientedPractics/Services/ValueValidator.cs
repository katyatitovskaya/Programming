using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Хранит методы валидации значений. 
    /// </summary>
    public class ValueValidator
    {
        /// <summary>
        /// Проверяет, находится ли длина строки в указанном диапазоне.  
        /// </summary>
        /// <param name="value">Проверяемая строка. </param>
        /// <param name="maxLength">Максимальная допустимая длина строки. </param>
        /// <param name="propertyName">Имя свойства, в котором присваивается значение. </param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength || value.Length <= 0)
            {
                throw new ArgumentException($"Length of {propertyName} " +
                    $"is supposed to be less than {maxLength}");
            }
        }

        /// <summary>
        /// Проверяет, находится ли цена в указанном диапазоне. 
        /// </summary>
        /// <param name="value">Проверяемое значение. </param>
        /// <param name="maxValue">Максимальное допустимое значение. </param>
        /// <param name="name">Имя свойства, в котором присваивается цена. </param>
        /// <exception cref="ArgumentException"></exception>
        public static void CheckPriceInRange(double value, int maxValue, string name)
        {
            if(value > maxValue || value < 0)
            {
                throw new ArgumentException($"{name} is not supposed " +
                    $"to be less than 0 or more than {maxValue}");
            }
        }
    }
}
