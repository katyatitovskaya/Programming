using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Address
    {
        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private string _building;
        private string _apartment;

        public int Index
        {
            get => _index;
            set
            {
                ValueValidator.CheckIntInRange(value, 1000000, 99999, nameof(Index));
                _index = value; 
            }
        }
        public string Country
        {
            get => _country;
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                _country = value;
            }
        }
        public string City
        {
            get => _city;
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                _city = value;
            }
        }
        public string Street
        {
            get => _street;
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                _street = value;
            }
        }

        public string Building
        {
            get => _building;
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                _building = value; 
            }
        }

        public string Apartment
        {
            get => _apartment;
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                _apartment = value;
            }
        }

        public Address()
        {
            Index = 666666;
            Country = "1";
            City = "1";
            Street = "1";
            Building = "1";
            Apartment = "1";
        }

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
