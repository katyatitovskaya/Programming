using Programming.Model.Classes.Geometry;
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
    public partial class RectanglesCollisionControl : UserControl
    {
        private List<Model.Classes.Geometry.Rectangle> _rectangels = new List<Model.Classes.Geometry.Rectangle>();
        private List<Panel> _rectanglePanels = new List<Panel>();
        private Model.Classes.Geometry.Rectangle _currentRectangle = new Model.Classes.Geometry.Rectangle();
        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }
        private void AddRectButton_Click(object sender, EventArgs e)
        {
            int i = _rectangels.Count;
            Random rand = new Random();
            _rectangels.Add(new Model.Classes.Geometry.Rectangle(rand.Next(10, 200),
            rand.Next(10, 200),
            "Green", rand.Next(1, RectPanel.Size.Width - 5),
                    rand.Next(1, RectPanel.Size.Height - 5)));

            RectInfoListBox.Items.Add($"{_rectangels[i].Id}: (X={_rectangels[i].Centre.X} " +
                    $"Y={_rectangels[i].Centre.Y} W={_rectangels[i].Length} H={_rectangels[i].Width})");


            Panel panel = new Panel();
            int x = (int)(_rectangels[i].Centre.X - _rectangels[i].Length / 2);
            int y = (int)(_rectangels[i].Centre.Y - _rectangels[i].Width / 2);
            panel.Location = new Point(x, y);
            panel.Width = (int)_rectangels[i].Length;
            panel.Height = (int)_rectangels[i].Width;
            var panelsColor = Color.FromArgb(127, 127, 255, 127);
            panel.BackColor = panelsColor;
            _rectanglePanels.Add(panel);
            RectPanel.Controls.Add(panel);
            FindCollisions(_rectangels);

        }

        private void FindCollisions(List<Model.Classes.Geometry.Rectangle> _rectangels)
        {
            var colidingPanelsColor = Color.FromArgb(127, 255, 127, 127);
            var niceColor = Color.FromArgb(127, 127, 255, 127);

            for (int i = 0; i < _rectangels.Count; i++)
            {
                _rectanglePanels[i].BackColor = niceColor;
            }
            for (int i = 0; i < _rectangels.Count; i++)
            {
                for (int j = 0; j < _rectangels.Count; j++)
                {
                    if (i != j)
                    {
                        if (CollisionManager.IsCollision(_rectangels[i], _rectangels[j]))
                        {
                            _rectanglePanels[i].BackColor = colidingPanelsColor;
                            _rectanglePanels[j].BackColor = colidingPanelsColor;
                        }
                    }
                }
            }
        }

        private void RectInfoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int number = RectInfoListBox.SelectedIndex;
            if (number != -1)
            {
                _currentRectangle = _rectangels[number];
                UpdateRectangleInfo(_currentRectangle);
            }
            else
            {
                ClearRectangleInfo();
            }
        }

        private void YTextBox_TextChanged(object? sender, EventArgs e)
        {
            YTextBox.BackColor = Color.White;
            int value = RectInfoListBox.SelectedIndex;
            if (value == -1)
            {
                return;
            }
            if (YTextBox.Focused)
            {
                try
                {
                    int newY = Convert.ToInt32(YTextBox.Text);
                    _currentRectangle.Centre.Y = newY;
                    YTextBox.BackColor = Color.White;
                    int currentSelection = YTextBox.SelectionStart;
                    RectInfoListBox.Items[value] = $"{_currentRectangle.Id}: (X={_currentRectangle.Centre.X} " +
                        $"Y={_currentRectangle.Centre.Y} W={_currentRectangle.Length} H={_currentRectangle.Width})";
                    YTextBox.SelectionStart = currentSelection;
                    int x = (int)(_currentRectangle.Centre.X - _currentRectangle.Length / 2);
                    int y = (int)(_currentRectangle.Centre.Y - _currentRectangle.Width / 2);
                    _rectanglePanels[value].Location = new Point(x, y);
                    FindCollisions(_rectangels);
                }
                catch
                {
                    YTextBox.BackColor = Color.LightPink;
                }
            }

        }

        private void XTextBox_TextChanged(object? sender, EventArgs e)
        {
            XTextBox.BackColor = Color.White;
            int value = RectInfoListBox.SelectedIndex;
            if (value == -1)
            {
                return;
            }
            if (XTextBox.Focused)
            {
                try
                {
                    int newX = Convert.ToInt32(XTextBox.Text);
                    _currentRectangle.Centre.X = newX;
                    XTextBox.BackColor = Color.White;
                    int currentSelection = XTextBox.SelectionStart;
                    RectInfoListBox.Items[value] = $"{_currentRectangle.Id}: (X={_currentRectangle.Centre.X} " +
                        $"Y={_currentRectangle.Centre.Y} W={_currentRectangle.Length} H={_currentRectangle.Width})";
                    XTextBox.SelectionStart = currentSelection;
                    int x = (int)(_currentRectangle.Centre.X - _currentRectangle.Length / 2);
                    int y = (int)(_currentRectangle.Centre.Y - _currentRectangle.Width / 2);
                    _rectanglePanels[value].Location = new Point(x, y);
                    FindCollisions(_rectangels);
                }
                catch
                {
                    XTextBox.BackColor = Color.LightPink;
                }
            }

        }

        private void HeightTextBox_TextChanged(object? sender, EventArgs e)
        {
            HeightTextBox.BackColor = Color.White;
            int value = RectInfoListBox.SelectedIndex;
            if (value == -1)
            {
                return;
            }
            if (HeightTextBox.Focused)
            {
                try
                {
                    double newWidth = Convert.ToDouble(HeightTextBox.Text);
                    _currentRectangle.Width = newWidth;
                    HeightTextBox.BackColor = Color.White;
                    int currentSelection = HeightTextBox.SelectionStart;
                    RectInfoListBox.Items[value] = $"{_currentRectangle.Id}: (X={_currentRectangle.Centre.X} " +
                        $"Y={_currentRectangle.Centre.Y} W={_currentRectangle.Length} H={_currentRectangle.Width})";

                    HeightTextBox.SelectionStart = currentSelection;
                    _rectanglePanels[value].Height = (int)newWidth;
                    FindCollisions(_rectangels);

                }
                catch
                {
                    HeightTextBox.BackColor = Color.LightPink;
                }
            }

        }

        private void WidthTextBox_TextChanged(object? sender, EventArgs e)
        {
            WidthTextBox.BackColor = Color.White;
            int value = RectInfoListBox.SelectedIndex;
            if (value == -1)
            {
                return;
            }
            if (WidthTextBox.Focused)
            {
                try
                {
                    double newLength = Convert.ToDouble(WidthTextBox.Text);
                    _currentRectangle.Length = newLength;
                    WidthTextBox.BackColor = Color.White;
                    int currentSelection = WidthTextBox.SelectionStart;
                    RectInfoListBox.Items[value] = $"{_currentRectangle.Id}: (X={_currentRectangle.Centre.X} " +
                        $"Y={_currentRectangle.Centre.Y} W={_currentRectangle.Length} H={_currentRectangle.Width})";

                    WidthTextBox.SelectionStart = currentSelection;
                    _rectanglePanels[value].Width = (int)newLength;
                    FindCollisions(_rectangels);
                }
                catch
                {
                    WidthTextBox.BackColor = Color.LightPink;
                }
            }

        }
        private void DeleteRectButton_Click(object sender, EventArgs e)
        {
            int value = RectInfoListBox.SelectedIndex;
            if (value != -1)
            {
                _rectangels.RemoveAt(value);
                RectInfoListBox.Items.RemoveAt(value);
                _rectanglePanels.RemoveAt(value);
                RectPanel.Controls.RemoveAt(value);

                FindCollisions(_rectangels);
            }
        }
        private void UpdateRectangleInfo(Model.Classes.Geometry.Rectangle rectangle)
        {
            XTextBox.Text = rectangle.Centre.X.ToString();
            YTextBox.Text = rectangle.Centre.Y.ToString();
            IdTextBox.Text = rectangle.Id.ToString();
            WidthTextBox.Text = rectangle.Length.ToString();
            HeightTextBox.Text = rectangle.Width.ToString();
        }
        private void ClearRectangleInfo()
        {
            HeightTextBox.Clear();
            WidthTextBox.Clear();
            IdTextBox.Clear();
            XTextBox.Clear();
            YTextBox.Clear();
        }
    }
}
