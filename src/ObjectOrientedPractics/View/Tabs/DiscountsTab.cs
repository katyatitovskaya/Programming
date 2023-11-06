using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class DiscountsTab : UserControl
    {
        private List<Item> _items;
        
        public List<Item> Items 
        {
            get => _items;
            set
            {
                _items = value;
            }
        }

        PointsDiscount discount = new PointsDiscount();
        //PercentDiscount discount = new PercentDiscount();
        public DiscountsTab()
        {
            InitializeComponent();
            //discount.Category = Category.Clothes;
            
            DiscountAmountLabel.Text = discount.Points.ToString();
            //DiscountAmountLabel.Text = discount.Percent.ToString();
            InfoLabel.Text = discount.Info;
            

        }
        
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            discount.Calculate(Items);
            DiscountAmountLabel.Text = discount.Points.ToString();
            //DiscountAmountLabel.Text = discount.Percent.ToString();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            discount.Apply(Items);
            DiscountAmountLabel.Text = discount.Points.ToString();
            //DiscountAmountLabel.Text = discount.Percent.ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            discount.Update(Items);
            DiscountAmountLabel.Text = discount.Points.ToString();
            //DiscountAmountLabel.Text = discount.Percent.ToString();
            InfoLabel.Text = discount.Info;
        }

    }
}
