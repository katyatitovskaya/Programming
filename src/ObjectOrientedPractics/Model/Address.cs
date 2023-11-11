using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит информацию об адресе. 
    /// </summary>
    public class Address: ICloneable
    {
        /// <summary>
        /// Почтовый индекс. 
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна. 
        /// </summary>
        private string _country;

        /// <summary>
        /// Город. 
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица. 
        /// </summary>
        private string _street;

        /// <summary>
        /// Здание. 
        /// </summary>
        private string _building;

        /// <summary>
        /// Квартира. 
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задает почтовый индекс. 
        /// Должен являться шестизначным числом. 
        /// </summary>
        public int Index
        {
            get => _index;
            set
            {
                ValueValidator.CheckIntInRange(value, 1000000, 99999, nameof(Index));
                _index = value;
                
            }
        }

        /// <summary>
        /// Возвращает и задает страну. 
        /// Должна быть короче 50 символов. 
        /// </summary>
        public string Country
        {
            get => _country;
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                _country = value;
            }
        }

        /// <summary>
        /// Возвращает и задает город. 
        /// Должен быть короче 50 символов. 
        /// </summary>
        public string City
        {
            get => _city;
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                _city = value;
            }
        }

        /// <summary>
        /// Возвращает и задает улицу. 
        /// Должна быть короче 100 символов. 
        /// </summary>
        public string Street
        {
            get => _street;
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                _street = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер здания. 
        /// Должен быть короче 10 символов. 
        /// </summary>
        public string Building
        {
            get => _building;
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                _building = value; 
            }
        }

        /// <summary>
        /// Возвращает и задает номер квартиры.
        /// Должен быть короче 10 символов. 
        /// </summary>
        public string Apartment
        {
            get => _apartment;
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                _apartment = value;
            }
        }

        public object Clone()
        {
            return new Address(Index, Country, City, Street, Building, Apartment);
        }

        /// <summary>
        /// Создает объект класса <see cref="Address"/>. 
        /// </summary>
        public Address()
        {
        }

        /// <summary>
        /// Создает объект класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс. </param>
        /// <param name="country">Страна. </param>
        /// <param name="city">Город. </param>
        /// <param name="street">Улица. </param>
        /// <param name="building">Здание. </param>
        /// <param name="apartment">Квартира. </param>
        public Address(int index, string country, string city, string street, 
            string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}
