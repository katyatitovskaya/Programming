using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    public class Validator
    {
        /// <summary>
        /// Проверяет, все ли символы в строке являются буквами англ алфавита. 
        /// </summary>
        /// <param name="value">Проверяемая строка. </param>
        /// <param name="name">Имя свойства, в котором присваивается значение. </param>
        /// <exception cref="ArgumentException"></exception>
        static public void AssertStringContainsOnlyLetters(string value, string name="")
        {
            if (Regex.IsMatch(value, "^[a-zA-Zа-яА-Я ]*$") == false)
            {
                throw new ArgumentException($"value in {name} " +
                    $"is suposed to contain only letters");
            }
        }
         
        /// <summary>
        /// Проеверяет, находится ли длина строки в диапазоне от 1 до указанного числа. 
        /// </summary>
        /// <param name="value">Проаеряемая строка. </param>
        /// <param name="length">Максимальная длина строки. </param>
        /// <param name="name">Имя свойства, в котором присваивается значение. </param>
        /// <exception cref="ArgumentException"></exception>
        static public void AssertStingLengthIsInRange(string value, int length, string name = "")
        {
            if (value.Length == 0 || value.Length > length)
            {
                throw new ArgumentException($"value in {name}" +
                    $"is suposed to be less than {length}");
            }
        }
         
        /// <summary>
        /// Проверяет, является ли строка ссылкой на вк.  
        /// </summary>
        /// <param name="value">Проверяемая строка. </param>
        /// <param name="name">Имя свойства, в котором присваивается значение. </param>
        /// <exception cref="ArgumentException"></exception>
        static public void AssertStringIsURL(string value, string name = "")
        {
            if(value.Contains("https://vk.com/") == false) 
            {
                throw new ArgumentException($"value in {name} " +
                    $"is supposed to contain https://vk.com/");
            }
        }

        /// <summary>
        /// Провеярет, является ли строка номером телефона. 
        /// </summary>
        /// <param name="value">Проверяемая строка. </param>
        /// <param name="name">Имя свойства, в котором присваивается значение. </param>
        /// <exception cref="ArgumentException"></exception>
        static public void AssertStringIsAPhoneNumber(string value, string name)
        {
            if (value.StartsWith("+") == false || Regex.IsMatch(value.Substring(1, value.Length-1), "^[0-9]*$") == false)
            {
                throw new ArgumentException($"value in {name} " +
                    $"is suposed to contain only digits or +");
            }
        }


        /// <summary>
        /// Проверяет, не превышает ли выбранная дата сегодняшнюю дату. 
        /// </summary>
        /// <param name="date">Проверяемая дата. </param>
        /// <param name="name">Имя свойства, в котором присваивается значение. </param>
        /// <exception cref="ArgumentException"></exception>
        static public void AssertDateIsInRange(DateTime date, string name = "")
        {
            if(date > DateTime.Now)
            {
                throw new ArgumentException($"date in {name} " +
                    $"is suposed to go before today's date");
            }
        }
    }
}
