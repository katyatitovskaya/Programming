﻿using Programming.Model.Enums;
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
    public partial class EnumsControl : UserControl
    {
        public EnumsControl()
        {
            InitializeComponent();
            object[] enums = new object[] { typeof(Seasons),
            typeof(PhoneMakers),
            typeof(EducationForm),
            typeof(Colors),
            typeof(Genre),
            typeof(Weekday) };

            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.DisplayMember = nameof(Type.Name);
            EnumsListBox.SelectedIndex = 0;
            ValuesListBox.SelectedIndex = 0;
        }
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEnum = (Type)EnumsListBox.SelectedItem;
            var enumValues = Enum.GetValues(selectedEnum);
            ValuesListBox.Items.Clear();
            foreach (var enumValue in enumValues)
            {
                ValuesListBox.Items.Add(enumValue);
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var number = (int)(Enum.Parse((Type)(EnumsListBox.SelectedItem), ValuesListBox.Text));
            IntValueTextBox.Text = number.ToString();
        }
    }
}