using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class WindowsFrontEnd : Form
    {
        UnitConverterProgram unitConverterProgram = new UnitConverterProgram();

        public WindowsFrontEnd()
        {
            InitializeComponent();
        }

        private void WindowsFrontEnd_Load(object sender, EventArgs e)
        {
            LoadUnitsToPickers(0);
            quantityPicker.SelectedIndex = 0;
        }

        private void LoadUnitsToPickers(int quantityIndex)
        {
            fromUnitPicker.Items.Clear();
            toUnitPicker.Items.Clear();

            List<string> unitNames = unitConverterProgram.GetUnitsNamesForQuantity(quantityIndex);
            foreach (string unitName in unitNames)
            {
                fromUnitPicker.Items.Add(unitName);
                toUnitPicker.Items.Add(unitName);
            }
        }

        private void quantityPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUnitsToPickers(quantityPicker.SelectedIndex);
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(inputBox.Text, result: out double inputValue);
            double result = unitConverterProgram.CalculateByUnitName(inputValue, (string)fromUnitPicker.SelectedItem, (string)toUnitPicker.SelectedItem, quantityPicker.SelectedIndex);

            outputBox.Text = result.ToString();
        }
    }
}
