using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class AddNewUnit : Form
    {
        private WinFormsFrontEnd winFormFrontEnd;
        private UnitConverterProgram unitConverterProgram;
        private int quantitySelected = 0;

        public AddNewUnit(WinFormsFrontEnd pWinFormsFrontEnd, UnitConverterProgram pUnitConverterProgram)
        {
            InitializeComponent();
            winFormFrontEnd = pWinFormsFrontEnd;
            unitConverterProgram = pUnitConverterProgram;
            UpdateComboBox();
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

        private void UpdateComboBox()
        {
            List<string> unitNames = unitConverterProgram.GetUnitsNamesForQuantity(GetQuantitySelected());
            BasedOnUnitDropDown.Items.Clear();
            foreach (string unitName in unitNames)
                BasedOnUnitDropDown.Items.Add(unitName);
            BasedOnUnitDropDown.SelectedIndex = 0;
        }

        private void QuantityPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetQuantitySelected(QuantityPicker.SelectedIndex);
            UpdateComboBox();
        }

        private void AddNewCustomUnit(string unitName, double gradient, double intercept, Unit unitBase)
        {
            unitConverterProgram.CreateAndAddUnitWithBase(
                GetQuantitySelected(),
                unitName,
                gradient,
                intercept,
                unitBase);
        }

        private bool UnitNameExists(string unitName)
        {
            List<string> unitNames = unitConverterProgram.GetUnitsNamesForQuantity(GetQuantitySelected());
            foreach (string existingUnitName in unitNames)
                if (existingUnitName == unitName)
                    return true;
            return false;
        }

        private bool CommonAddButton()
        {
            string unitName;
            double gradient;
            double intercept = 0;
            Unit unitBase;
            bool gradientIsValid;
            bool interceptIsValid;

            gradientIsValid = double.TryParse(GradientInput.Text, out gradient);
            interceptIsValid = double.TryParse(InterceptInput.Text, out intercept);

            if (!string.IsNullOrWhiteSpace(CustomUnitNameInput.Text) &&
                !UnitNameExists(CustomUnitNameInput.Text) &&
                gradientIsValid &&
                (interceptIsValid || string.IsNullOrWhiteSpace(InterceptInput.Text)))
            {
                unitName = CustomUnitNameInput.Text;
                unitBase = unitConverterProgram.GetUnitByName(GetQuantitySelected(), BasedOnUnitDropDown.Text);
                AddNewCustomUnit(unitName, gradient, intercept, unitBase);
                UpdateComboBox();
                winFormFrontEnd.UpdateComboBoxes();
                return true;
            }
            else if (UnitNameExists(CustomUnitNameInput.Text))
            {
                MessageBox.Show(
                    "The name you have chosen for the custom unit exists. " +
                    "Please enter a unique name.",
                    "Chosen Unit Name Exists",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                MessageBox.Show(
                    "You have entered one or more invalid inputs. Please " +
                    "check that they are valid before submitting again.",
                    "Invalid Input(s)",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CommonAddButton();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddAndCloseButton_Click(object sender, EventArgs e)
        {
            if(CommonAddButton())
                this.Close();
        }
    }
}
