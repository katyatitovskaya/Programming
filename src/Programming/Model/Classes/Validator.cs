using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит методы валидации значений. 
    /// </summary>
    public class Validator
    {
        /// <summary>
        /// Проверяет, является ли значение положительным 
        /// </summary>
        /// <param name="value"> Проверяемое значение. </param>
        /// <param name="name">Имя свойства, в котором присваивается значение. </param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertOnPositiveValue(int value, string name = "")
        {
            
            if (value <= 0)
                throw new ArgumentException(
                    $"Exception is thrown:{name} value is not supposed to be negative");
        }
        
        /// <summary>
        /// Проверяет, является ли значение положительным 
        /// </summary>
        /// <param name="value"> Проверяемое значение. </param>
        /// <param name="name">Имя свойства, в котором присваивается значение. </param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertOnPositiveValue(double value, string name = "")
        {
            if (value <= 0)
                throw new ArgumentException(
                    $"Exception is thrown:{name} value is not supposed to be negative");
        }
        
        /// <summary>
        /// Проверяет, входит ли значение в указанный диапазон. 
        /// </summary>
        /// <param name="value">Проверяемое значение. </param>
        /// <param name="min">Нижняя граница диапазона. </param>
        /// <param name="max">Верхняя граница диапазона. </param>
        /// <param name="name">Имя свойства, в котором присваивается значение.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertValueInRange(int value, int min, int max, string name = "")
        {
            if (value < min || value > max)
                throw new ArgumentException($"Exception is thrown:{name} value " +
                    $"is suposed to be between {min} and {max}");
        }
        
        /// <summary>
        /// Проверяет, входит ли значение в указанный диапазон. 
        /// </summary>
        /// <param name="value">Проверяемое значение. </param>
        /// <param name="min">Нижняя граница диапазона. </param>
        /// <param name="max">Верхняя граница диапазона. </param>
        /// <param name="name">Имя свойства, в котором присваивается значение.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertValueInRange(
            double value, double min, double max, string name = "")
        {
            if (value < min || value > max)
                throw new ArgumentException($"Exception is thrown:{name} value " +
                    $"is suposed to be between {min} and {max}");
        }
    }
}
