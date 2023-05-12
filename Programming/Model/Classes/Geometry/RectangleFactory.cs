using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Хранит метод для создания прямоугольников. 
    /// </summary>
    public class RectangleFactory
    {
        /// <summary>
        /// Создает прямоугольник. 
        /// </summary>
        /// <param name="RectPanel">Размер канвы для ограничения координат центра прямоугольника. </param>
        /// <returns>Возвращает прямоугольник. </returns>
        public Rectangle Randomize(Panel RectPanel)
        {
            Random rand = new Random();
            return new Rectangle(Math.Round(rand.NextDouble() * 100, 1),
            Math.Round(rand.NextDouble() * 100, 1),
            "Green", rand.Next(1, RectPanel.Size.Width),
                    rand.Next(1, RectPanel.Size.Height));
        }
    }
}
