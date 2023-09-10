using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Item
    {
        private string _name;
        private string _info; 
        private double _price;


        public int Id { get; }

        public static int NewId { get; set; }   
        public string Name
        {
            get => _name;
            set
            {
                Services.Validator.CheckStringLength(value, 200, nameof(Name));
                _name = value;
            }
        }
        public string Info
        {
            get => _info;
            set
            {
                Services.Validator.CheckStringLength(value, 1000, nameof(Info));
                _info = value;
            }
        }
        public double Price
        {
            get => _price;
            set
            {
                Services.Validator.CheckPriceInRange(value, 100000, nameof(Price));
                _price = value;
            }
        }
        public Item()
        {
        }
        public Item(string name, string info, double price)
        {
            Name = name;
            Info = info;
            Price = price;
            Id = NewId;
            NewId++;
        }
    }
}
