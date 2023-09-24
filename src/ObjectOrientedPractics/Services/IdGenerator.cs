using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет метод генерации индивидуального идентификатора. 
    /// </summary>
    internal static class IdGenerator
    {
        /// <summary>
        /// Индивидуальный идентификатор.
        /// </summary>
        private static int _id;

        /// <summary>
        /// Создает новый идентификатор. 
        /// </summary>
        /// <returns>Индифидуальный идентификатор.</returns>
        public static int GetNextID()
        {
            return _id++;
        }
    }
}
