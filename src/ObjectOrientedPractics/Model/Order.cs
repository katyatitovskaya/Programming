using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Order
    {
        private string _date;
        private Address _address;
        private double _amount;
        private List<Item> _items;

        public string Date { get; }

        public int Id { get; }

        public List<Item> Items { get; set; }
        public double Amount
        {
            get
            {
                if (Items == null || Items.Count == 0)
                {
                    return 0.0;
                }
                else
                {
                    double total = 0.0;
                    for (int i = 0; i < Items.Count; i++)
                    {
                        total = total + Items[i].Price;
                    }
                    return total;
                }
            }
        }
        public Address Address
        {
            get => _address;
            set
            {
                if (value != null)
                {
                    _address = value;
                }
            }
        }

        public OrderStatus OrderStatus { get; set; }
        public Order()
        {
            Address = new Address();
            Items = new List<Item>();
            OrderStatus = OrderStatus.New;
            Date = DateTime.Now.ToLongDateString();
            Id = Services.IdGenerator.GetNextID();
        }

        public Order(Address address, List<Item> items)
        {
            Address = address;
            Items = items;
            OrderStatus = OrderStatus.New;
            Date = DateTime.Now.ToLongDateString();
            Id = Services.IdGenerator.GetNextID();
        }
    }
}
