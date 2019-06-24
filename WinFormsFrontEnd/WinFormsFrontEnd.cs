using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class WinFormsFrontEnd : Form
    {
        private UnitConverterProgram unitConverterProgram = new UnitConverterProgram();
        private int quantitySelected = 0;
        List<ToolStripMenuItem> roundOffMenuItems = new List<ToolStripMenuItem>();

        public WinFormsFrontEnd()
        {
            InitializeComponent();
            QuantityPicker.SelectedIndex = 0;
            UpdateComboBoxes();

            roundOffMenuItems.Add(noRoundingOffToolStripMenuItem);
            roundOffMenuItems.Add(wholeNumberToolStripMenuItem);
            roundOffMenuItems.Add(decimalPlacesToolStripMenuItem1);
            roundOffMenuItems.Add(decimalPlacesToolStripMenuItem2);
            roundOffMenuItems.Add(decimalPlacesToolStripMenuItem3);
            roundOffMenuItems.Add(decimalPlacesToolStripMenuItem4);
            roundOffMenuItems.Add(decimalPlacesToolStripMenuItem5);
            roundOffMenuItems.Add(decimalPlacesToolStripMenuItem6);
            roundOffMenuItems.Add(decimalPlacesToolStripMenuItem7);
            roundOffMenuItems.Add(decimalPlacesToolStripMenuItem8);
            roundOffMenuItems.Add(decimalPlacesToolStripMenuItem9);
            roundOffMenuItems.Add(decimalPlacesToolStripMenuItem10);
        }

        private void UntickAllRoundOffMenuItems()
        {
            foreach (ToolStripMenuItem menuItem in roundOffMenuItems)
                menuItem.Checked = false;
        }

        private int GetQuantitySelected()
        {
            return quantitySelected;
        }

        private void SetQuantitySelected(int value)
        {
            quantitySelected = value;
        }

        private void SetRoundOffValue(short value)
        {
            unitConverterProgram.SetRoundOffValue(value);
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

        private void noRoundingOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UntickAllRoundOffMenuItems();
            SetRoundOffValue(-1);
            noRoundingOffToolStripMenuItem.Checked = true;
            Calculate();
        }

        private void wholeNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UntickAllRoundOffMenuItems();
            SetRoundOffValue(0);
            wholeNumberToolStripMenuItem.Checked = true;
            Calculate();
        }

        private void decimalPlacesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UntickAllRoundOffMenuItems();
            SetRoundOffValue(1);
            decimalPlacesToolStripMenuItem1.Checked = true;
            Calculate();
        }

        private void decimalPlacesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UntickAllRoundOffMenuItems();
            SetRoundOffValue(2);
            decimalPlacesToolStripMenuItem2.Checked = true;
            Calculate();
        }

        private void decimalPlacesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            UntickAllRoundOffMenuItems();
            SetRoundOffValue(3);
            decimalPlacesToolStripMenuItem3.Checked = true;
            Calculate();
        }

        private void decimalPlacesToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            UntickAllRoundOffMenuItems();
            SetRoundOffValue(4);
            decimalPlacesToolStripMenuItem4.Checked = true;
            Calculate();
        }

        private void decimalPlacesToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            UntickAllRoundOffMenuItems();
            SetRoundOffValue(5);
            decimalPlacesToolStripMenuItem5.Checked = true;
            Calculate();
        }

        private void decimalPlacesToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            UntickAllRoundOffMenuItems();
            SetRoundOffValue(6);
            decimalPlacesToolStripMenuItem6.Checked = true;
            Calculate();
        }

        private void decimalPlacesToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            UntickAllRoundOffMenuItems();
            SetRoundOffValue(7);
            decimalPlacesToolStripMenuItem7.Checked = true;
            Calculate();
        }

        private void decimalPlacesToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            UntickAllRoundOffMenuItems();
            SetRoundOffValue(8);
            decimalPlacesToolStripMenuItem8.Checked = true;
            Calculate();
        }

        private void decimalPlacesToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            UntickAllRoundOffMenuItems();
            SetRoundOffValue(9);
            decimalPlacesToolStripMenuItem9.Checked = true;
            Calculate();
        }

        private void decimalPlacesToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            UntickAllRoundOffMenuItems();
            SetRoundOffValue(10);
            decimalPlacesToolStripMenuItem10.Checked = true;
            Calculate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
