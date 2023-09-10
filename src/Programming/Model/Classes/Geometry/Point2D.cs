using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Хранит координаты центра фигур. 
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Координата Х. 
        /// </summary>
        private int _x;

        /// <summary>
        /// Координата Y.
        /// </summary>
        private int _y;

        /// <summary>
        /// Возвращает и задает координату Х центра фигуры. Должна быть положительной. 
        /// </summary>
        public int X
        {
            get => _x;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(X));
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задает координату Y центра фигуры. Должна быть положительной. 
        /// </summary>
        public int Y
        {
            get => _y;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Y));
                _y = value;
            }
        }

        /// <summary>
        ///Создает объект класса <see cref="Point2D"/>.
        /// </summary>
        public Point2D()
        {
        }

        /// <summary>
        /// Создает объект класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Координата Х. Должна быть положительной. </param>
        /// <param name="y">Координата Y. Должна быть положительной. </param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
