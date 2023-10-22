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
    /// <summary>
    /// Предоставляет методы для валидации и заполнения текстовых полей адреса.  
    /// </summary>
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Объект типа <see cref="Model.Address"/>. 
        /// </summary>
        private Model.Address _address;

        /// <summary>
        /// Возвращает и задает значение адреса. 
        /// </summary>
        public Model.Address Address
        {
            get => _address;
            set
            {
                _address = value;
                FillTextBoxes();
            }
        }
        public AddressControl()
        {
            InitializeComponent();
        }

        private void AddressControl_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Проверяет и сохраняет значение в тестовом поле при его изменении. 
        /// </summary>
        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            PostIndexTextBox.BackColor = Color.White;
            if (Address!= null)
            {
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
        }

        /// <summary>
        /// Проверяет и сохраняет значение в тестовом поле при его изменении. 
        /// </summary>
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            CountryTextBox.BackColor = Color.White;
            if(Address != null)
            {
                try
                {
                    Address.Country = CountryTextBox.Text;
                }
                catch
                {
                    CountryTextBox.BackColor = Color.LightPink;
                }
            }
            
        }

        /// <summary>
        /// Проверяет и сохраняет значение в тестовом поле при его изменении. 
        /// </summary>
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            CityTextBox.BackColor = Color.White;
            if(Address != null)
            {
                try
                {
                    Address.City = CityTextBox.Text;
                }
                catch
                {
                    CityTextBox.BackColor = Color.LightPink;
                }
            }
        }

        /// <summary>
        /// Проверяет и сохраняет значение в тестовом поле при его изменении. 
        /// </summary>
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            StreetTextBox.BackColor = Color.White;
            if(Address != null)
            {
                try
                {
                    Address.Street = StreetTextBox.Text;
                }
                catch
                {
                    StreetTextBox.BackColor = Color.LightPink;
                }
            }
        }

        /// <summary>
        /// Проверяет и сохраняет значение в тестовом поле при его изменении. 
        /// </summary>
        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            BuildingTextBox.BackColor = Color.White;
            if(Address != null)
            {
                try
                {
                    Address.Building = BuildingTextBox.Text;
                }
                catch
                {
                    BuildingTextBox.BackColor = Color.LightPink;
                }
            }
        }

        /// <summary>
        /// Проверяет и сохраняет значение в тестовом поле при его изменении. 
        /// </summary>
        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            ApartmentTextBox.BackColor= Color.White;
            if(Address != null)
            {
                try
                {
                    Address.Apartment = ApartmentTextBox.Text;
                }
                catch
                {
                    ApartmentTextBox.BackColor = Color.LightPink;
                }
            }
        }

        /// <summary>
        /// Заполняет текстовые поля. 
        /// </summary>
        private void FillTextBoxes()
        {
            if (Address == null)
            {
                ClearTextBoxes();
                return;
            }
            if (Address.Index != 0)
            {
                PostIndexTextBox.Text = Address.Index.ToString();
            }
            CountryTextBox.Text = Address.Country;
            CityTextBox.Text = Address.City;
            StreetTextBox.Text = Address.Street;
            BuildingTextBox.Text = Address.Building;
            ApartmentTextBox.Text = Address.Apartment;
        }

        /// <summary>
        /// Очищает текстовые поля. 
        /// </summary>
        public void ClearTextBoxes()
        {
            PostIndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();
        }
       
    }
}
