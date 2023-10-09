using ObjectOrientedPractics.View.Tabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Model.Address _address;
        public Model.Address Address
        {
            get => _address;
            set
            {
                _address= value;
                PostIndexTextBox.Text = _address.Index.ToString();
                CountryTextBox.Text = _address.Country;
                CityTextBox.Text = _address.City;
                StreetTextBox.Text = _address.Street;
                BuildingTextBox.Text = _address.Building;
                ApartmentTextBox.Text = _address.Apartment;
            }
        }
        public AddressControl()
        {
            InitializeComponent();
        }

        private void AddressControl_Load(object sender, EventArgs e)
        {

        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            PostIndexTextBox.BackColor= Color.White;
            try
            {
                int newIndex = Convert.ToInt32(PostIndexTextBox.Text);
                Address.Index = newIndex;
            }
            catch
            {
                PostIndexTextBox.BackColor = Color.LightPink;
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            CountryTextBox.BackColor = Color.White;
            try
            {
                Address.Country = CountryTextBox.Text;
            }
            catch
            {
                CountryTextBox.BackColor = Color.LightPink;
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            CityTextBox.BackColor = Color.White;
            try
            {
                Address.City = CityTextBox.Text;
            }
            catch
            {
                CityTextBox.BackColor = Color.LightPink;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            StreetTextBox.BackColor = Color.White;
            try
            {
                Address.Street = StreetTextBox.Text;
            }
            catch
            {
                StreetTextBox.BackColor = Color.LightPink;
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            BuildingTextBox.BackColor = Color.White;
            try
            {
                Address.Building = BuildingTextBox.Text;
            }
            catch
            {
                BuildingTextBox.BackColor= Color.LightPink;
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            ApartmentTextBox.BackColor= Color.White;
            try
            {
                Address.Apartment = ApartmentTextBox.Text;
            }
            catch
            {
                ApartmentTextBox.BackColor = Color.LightPink;
            }
        }
        public void UpdateAddressInfo(Model.Customer customer)
        {
            PostIndexTextBox.Text=customer.Address.Index.ToString();
            CountryTextBox.Text = customer.Address.Country;
            CityTextBox.Text = customer.Address.City;
            StreetTextBox.Text = customer.Address.Street;
            BuildingTextBox.Text = customer.Address.Building;
            ApartmentTextBox.Text = customer.Address.Apartment;
        }
    }
}
