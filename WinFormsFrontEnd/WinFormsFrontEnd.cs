using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class WinFormsFrontEnd : Form
    {
        private UnitConverterProgram unitConverterProgram = new UnitConverterProgram();
        private int quantitySelected = 0;

        public WinFormsFrontEnd()
        {
            InitializeComponent();
            QuantityPicker.SelectedIndex = 0;
            UpdateComboBoxes();
        }

        private int GetQuantitySelected()
        {
            return quantitySelected;
        }

        private void SetQuantitySelected(int value)
        {
            quantitySelected = value;
        }

        private void UpdateComboBoxes()
        {
            List<string> unitNames = unitConverterProgram.GetUnitsNamesForQuantity(GetQuantitySelected());

            FromUnitPicker.Items.Clear();
            ToUnitPicker.Items.Clear();

            foreach (string unitName in unitNames)
            {
                FromUnitPicker.Items.Add(unitName);
                ToUnitPicker.Items.Add(unitName);
            }

            FromUnitPicker.SelectedIndex = 0;
            ToUnitPicker.SelectedIndex = 1;
        }

        private void QuantityPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetQuantitySelected(QuantityPicker.SelectedIndex);
            UpdateComboBoxes();
        }

        private void Calculate()
        {
            string fromUnitName = (string)FromUnitPicker.SelectedItem;
            string toUnitName = (string)ToUnitPicker.SelectedItem;
            double.TryParse(InputBox.Text, out double inputValue);
            double result = unitConverterProgram.CalculateByUnitName(inputValue, fromUnitName, toUnitName, GetQuantitySelected());
            OutputBox.Text = result.ToString();
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void FromUnitPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void ToUnitPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            UpdateComboBoxes();
            InputBox.Text = "";
        }

        private void SwapButton_Click(object sender, EventArgs e)
        {
            int temp = FromUnitPicker.SelectedIndex;
            FromUnitPicker.SelectedIndex = ToUnitPicker.SelectedIndex;
            ToUnitPicker.SelectedIndex = temp;
        }
    }
}
