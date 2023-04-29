using Programming.Model.Classes;
using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class RectanglesListBoxControl : UserControl
    {
        private Model.Classes.Geometry.Rectangle[] _rectangles = new Model.Classes.Geometry.Rectangle[5];
        private Model.Classes.Geometry.Rectangle _currentRectangle = new Model.Classes.Geometry.Rectangle();
        public RectanglesListBoxControl()
        {
            InitializeComponent();
            string[] colorsNames = Enum.GetNames(typeof(Colors));
            Random rand = new Random();
            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = new Model.Classes.Geometry.Rectangle(rand.Next(1, 200),
                    rand.Next(1, 200),
                    colorsNames[rand.Next(0, colorsNames.Length)], rand.Next(1, 100),
                    rand.Next(1, 100));
                RectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }
        }
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[value];
            RectWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectLengthTextBox.Text = _currentRectangle.Length.ToString();
            RectColorTextBox.Text = _currentRectangle.Color.ToString();
            RectXTextBox.Text = _currentRectangle.Centre.X.ToString();
            RectYTextBox.Text = _currentRectangle.Centre.Y.ToString();
            RectIDTextBox.Text = _currentRectangle.Id.ToString();
            
        }

        private void RectColorTextBox_TextChanged(object? sender, EventArgs e)
        {
            _currentRectangle.Color = RectColorTextBox.Text;
        }

        private void RectLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double newLength = Convert.ToDouble(RectLengthTextBox.Text);
                _currentRectangle.Length = newLength;
                RectLengthTextBox.BackColor = AppColors.White;
            }
            catch
            {
                RectLengthTextBox.BackColor = AppColors.LightPink;
            }
        }

        private void RectWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double newWidth = Convert.ToDouble(RectWidthTextBox.Text);
                _currentRectangle.Width = newWidth;
                RectWidthTextBox.BackColor = AppColors.White;
            }
            catch
            {
                RectWidthTextBox.BackColor = AppColors.LightPink;
            }
        }
        private int FindRectangleWithMaxWidth()
        {
            double maxWidth = _rectangles[0].Width;
            int maxWidthIndex = 0;

            for (int i = 0; i < _rectangles.Length; i++)
            {
                if (_rectangles[i].Width > maxWidth)
                {
                    maxWidth = _rectangles[i].Width;
                    maxWidthIndex = i;
                }
            }
            return maxWidthIndex;
        }

        private void FindMaxWidthButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth();
        }
    }
}
