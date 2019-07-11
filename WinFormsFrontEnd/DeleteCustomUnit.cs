using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class DeleteCustomUnit : Form
    {
        private WinFormsFrontEnd winFormsFrontEnd;
        private UnitConverterProgram unitConverterProgram;
        private int quantitySelected = 0;

        public DeleteCustomUnit(WinFormsFrontEnd pWinFormsFrontEnd, UnitConverterProgram pUnitConverterProgram)
        {
            InitializeComponent();
            winFormsFrontEnd = pWinFormsFrontEnd;
            unitConverterProgram = pUnitConverterProgram;
            UpdateListBox();
            QuantityPicker.SelectedIndex = 0;
        }

        private int GetQuantitySelected()
        {
            return quantitySelected;
        }

        private void SetQuantitySelected(int value)
        {
            quantitySelected = value;
        }

        private void UpdateListBox()
        {
            List<string> customUnitNames = unitConverterProgram.GetUnitsNamesForQuantity(GetQuantitySelected(), 1);
            CustomUnitsListBox.Items.Clear();
            foreach (string customUnitName in customUnitNames)
                CustomUnitsListBox.Items.Add(customUnitName);
        }

        private void QuantityPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetQuantitySelected(QuantityPicker.SelectedIndex);
            UpdateListBox();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveCustomUnit(string unitName)
        {
            unitConverterProgram.RemoveUnitByName(
                GetQuantitySelected(),
                unitName);
        }

        private void CommonDeleteButton()
        {
            foreach (string selectedUnit in CustomUnitsListBox.CheckedItems)
                RemoveCustomUnit(selectedUnit);
            UpdateListBox();
            winFormsFrontEnd.UpdateComboBoxes();
        }

        private void DeleteAndCloseButton_Click(object sender, EventArgs e)
        {
            CommonDeleteButton();
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            CommonDeleteButton();
        }
    }
}
