using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит используемые цвета. 
    /// </summary>
    public class AppColors
    {
        /// <summary>
        /// Белый. 
        /// </summary>
        public static Color White = Color.White;

        /// <summary>
        /// Красный. Используется для подсвечивания текстовых полей при ошибке.
        /// </summary>
        public static Color LightPink = Color.LightPink;

        /// <summary>
        /// Красный. Используется для покраски прямоугольников при их пересечении.
        /// </summary>
        public static Color Red = Color.FromArgb(127, 255, 127, 127);

        /// <summary>
        /// Зеленый. Используется для покраски прямоугольников.
        /// </summary>
        public static Color Green = Color.FromArgb(127, 127, 255, 127);
    }
}
