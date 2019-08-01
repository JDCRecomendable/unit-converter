using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class WinFormsFrontEnd : Form
    {
        // Initialise Variables
        private UnitConverterProgram unitConverterProgram = new UnitConverterProgram();
        private StatusBarController statusBarController;
        private int quantitySelected = 0;
        List<ToolStripMenuItem> roundOffMenuItems = new List<ToolStripMenuItem>();

        // Initialise Object
        public WinFormsFrontEnd()
        {
            InitializeComponent();
            statusBarController = new StatusBarController(StatusBar, StatusLabel);
            QuantityPicker.SelectedIndex = 0;
            MainBoxMenuStrip.Renderer = new SelectorColourRenderer();
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

        // Main GUI-Calculation Function: Get quantity currently selected by user
        private int GetQuantitySelected()
        {
            return quantitySelected;
        }

        // Main GUI-Calculation Function: Set quantity newly selected by user
        private void SetQuantitySelected(int value)
        {
            quantitySelected = value;
        }

        // Main GUI-Calculation Function: Set round-off setting
        private void SetRoundOffValue(short value)
        {
            unitConverterProgram.SetRoundOffValue(value);
        }

        // Main GUI-Calculation Function: Perform unit conversion
        private void Calculate()
        {
            string fromUnitName = (string)FromUnitPicker.SelectedItem;
            string toUnitName = (string)ToUnitPicker.SelectedItem;
            bool canParse = double.TryParse(InputBox.Text, out double inputValue);

            if (canParse)
            {
                double result = unitConverterProgram.CalculateByUnitName(
                    inputValue,
                    fromUnitName,
                    toUnitName,
                    GetQuantitySelected()
                );
                OutputBox.Text = result.ToString();
                statusBarController.SetToDone();
            }
            else if (string.IsNullOrWhiteSpace(InputBox.Text))
            {
                OutputBox.Text = "0";
                statusBarController.SetToReady();
            }

            else
            {
                OutputBox.Text = "0";
                statusBarController.SetToInvalidInput();
            }
        }

        // Main GUI Function: Update combo boxes with units from the quantity selected
        public void UpdateComboBoxes()
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

        // Main GUI Function: Clear input box
        private void ClearAll()
        {
            InputBox.Text = "";
            statusBarController.SetToReady();
        }

        // Main GUI Function: Detect if selected quantity has changed
        private void QuantityPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetQuantitySelected(QuantityPicker.SelectedIndex);
            UpdateComboBoxes();
            ClearAll();
        }

        // Main GUI Function: Detect if input value has changed
        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        // Main GUI Function: Detect if selected toUnit has changed
        private void FromUnitPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        // Main GUI Function: Detect if selected fromUnit has changed
        private void ToUnitPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        // Button: Clear
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        // Button: Swap
        private void SwapButton_Click(object sender, EventArgs e)
        {
            int temp = FromUnitPicker.SelectedIndex;
            FromUnitPicker.SelectedIndex = ToUnitPicker.SelectedIndex;
            ToUnitPicker.SelectedIndex = temp;
        }

        // Main GUI Function: Toggle Keep Floating option & Tick/untick corresponding menu item
        private void ToggleKeepFloating()
        {
            if (this.TopMost)
            {
                this.TopMost = false;
                keepWindowFloatingToolStripMenuItem.Checked = false;
            }
            else
            {
                this.TopMost = true;
                keepWindowFloatingToolStripMenuItem.Checked = true;
            }

            statusBarController.SetToSettingUpdated();
        }

        // Helper Menu Item: Remove tick fro all round-off menu items
        private void UntickAllRoundOffMenuItems()
        {
            foreach (ToolStripMenuItem menuItem in roundOffMenuItems)
                menuItem.Checked = false;
        }

        // Helper Menu Item: Do when round-off menu item is clicked
        private void RoundOffMenuItemClicked(short roundOffValue)
        {
            UntickAllRoundOffMenuItems();
            SetRoundOffValue(roundOffValue);
            Calculate();
            statusBarController.SetToRoundOffValueSet();
        }

        // Menu Item: Options - Set Round-Off setting to none (i.e. do not round off)
        private void noRoundingOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoundOffMenuItemClicked(-1);
            noRoundingOffToolStripMenuItem.Checked = true;
        }

        // Menu Item: Options - Set Round-Off setting to whole number
        private void wholeNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoundOffMenuItemClicked(0);
            wholeNumberToolStripMenuItem.Checked = true;
        }

        // Menu Item: Options - Set Round-Off setting to 1 d.p.
        private void decimalPlacesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RoundOffMenuItemClicked(1);
            decimalPlacesToolStripMenuItem1.Checked = true;
        }

        // Menu Item: Options - Set Round-Off setting to 2 d.p.
        private void decimalPlacesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RoundOffMenuItemClicked(2);
            decimalPlacesToolStripMenuItem2.Checked = true;
        }

        // Menu Item: Options - Set Round-Off setting to 3 d.p.
        private void decimalPlacesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            RoundOffMenuItemClicked(3);
            decimalPlacesToolStripMenuItem3.Checked = true;
        }

        // Menu Item: Options - Set Round-Off setting to 4 d.p.
        private void decimalPlacesToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            RoundOffMenuItemClicked(4);
            decimalPlacesToolStripMenuItem4.Checked = true;
        }

        // Menu Item: Options - Set Round-Off setting to 5 d.p.
        private void decimalPlacesToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            RoundOffMenuItemClicked(5);
            decimalPlacesToolStripMenuItem5.Checked = true;
        }

        // Menu Item: Options - Set Round-Off setting to 6 d.p.
        private void decimalPlacesToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            RoundOffMenuItemClicked(6);
            decimalPlacesToolStripMenuItem6.Checked = true;
        }

        // Menu Item: Options - Set Round-Off setting to 7 d.p.
        private void decimalPlacesToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            RoundOffMenuItemClicked(7);
            decimalPlacesToolStripMenuItem7.Checked = true;
        }

        // Menu Item: Options - Set Round-Off setting to 8 d.p.
        private void decimalPlacesToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            RoundOffMenuItemClicked(8);
            decimalPlacesToolStripMenuItem8.Checked = true;
        }

        // Menu Item: Options - Set Round-Off setting to 9 d.p.
        private void decimalPlacesToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            RoundOffMenuItemClicked(9);
            decimalPlacesToolStripMenuItem9.Checked = true;
        }

        // Menu Item: Options - Set Round-Off setting to 10 d.p.
        private void decimalPlacesToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            RoundOffMenuItemClicked(10);
            decimalPlacesToolStripMenuItem10.Checked = true;
        }

        // Menu Item: Options - Kepp window floating
        private void keepWindowFloatingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleKeepFloating();
        }

        // Menu Item: File - Add new custom unit
        private void addNewUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewUnit addNewUnit = new AddNewUnit(this, unitConverterProgram);
            if (this.TopMost)
                addNewUnit.TopMost = true;
            addNewUnit.Show();
        }

        // Menu Item: File - Delete existing custom unit
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCustomUnit deleteCustomUnit = new DeleteCustomUnit(this, unitConverterProgram);
            if (this.TopMost)
                deleteCustomUnit.TopMost = true;
            deleteCustomUnit.Show();
        }

        // Menu Item: File - Exit the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Menu Item: About
        private void aboutUnitConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUnitConverter aboutUnitConverter = new AboutUnitConverter();
            if (this.TopMost)
                aboutUnitConverter.TopMost = true;
            aboutUnitConverter.Show();
        }

        // Miscellaneous: For menu bar rendering
        private class SelectorColourRenderer : ToolStripProfessionalRenderer
        {
            public SelectorColourRenderer() : base(new SelectorColours()) { }
        }

        private class SelectorColours : ProfessionalColorTable
        {
            public override System.Drawing.Color MenuItemSelected
            {
                get
                {
                    return System.Drawing.Color.Gray;
                }
            }

            public override System.Drawing.Color MenuItemBorder
            {
                get
                {
                    return System.Drawing.Color.Gray;
                }
            }

            public override System.Drawing.Color MenuBorder
            {
                get
                {
                    return System.Drawing.Color.Gray;
                }
            }

            public override System.Drawing.Color SeparatorDark
            {
                get
                {
                    return System.Drawing.Color.White;
                }
            }

            public override System.Drawing.Color CheckBackground
            {
                get
                {
                    return System.Drawing.Color.White;
                }
            }

            public override System.Drawing.Color CheckSelectedBackground
            {
                get
                {
                    return System.Drawing.Color.White;
                }
            }
        }
    }
}
