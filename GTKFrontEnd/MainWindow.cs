using System;
using System.Collections.Generic;
using Gtk;
using UnitConverter;

public partial class MainWindow : Gtk.Window
{
    private int selectedQuantityIndex = 0;
    private UnitConverterProgram unitConverterProgram = new UnitConverterProgram();

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        Initialise();
    }

    public void Initialise()
    {
        SetComboBoxText(QuantityIndex.length);
        SetSelectedQuantityIndex(QuantityIndex.length);
        ClearAll();
    }

    protected int GetSelectedQuantityIndex()
    {
        return selectedQuantityIndex;
    }

    protected void SetSelectedQuantityIndex(int value)
    {
        selectedQuantityIndex = value;
    }

    public void SetComboBoxText(int quantityIndex)
    {
        List<string> unitNames = unitConverterProgram.GetUnitsNamesForQuantity(quantityIndex);

        FromUnitPicker.Clear();
        ToUnitPicker.Clear();

        CellRendererText cell1 = new CellRendererText();
        FromUnitPicker.PackStart(cell1, false);
        FromUnitPicker.AddAttribute(cell1, "text", 0);
        ListStore store1 = new ListStore(typeof(string));
        FromUnitPicker.Model = store1;

        CellRendererText cell2 = new CellRendererText();
        ToUnitPicker.PackStart(cell2, false);
        ToUnitPicker.AddAttribute(cell2, "text", 0);
        ListStore store2 = new ListStore(typeof(string));
        ToUnitPicker.Model = store2;

        foreach (string unitName in unitNames)
        {
            store1.AppendValues(unitName);
            store2.AppendValues(unitName);
        }
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void LengthButtonClicked(object sender, System.EventArgs e)
    {
        SetSelectedQuantityIndex(QuantityIndex.length);
        SetComboBoxText(GetSelectedQuantityIndex());
        ClearAll();
    }

    protected void AreaButtonClicked(object sender, System.EventArgs e)
    {
        SetSelectedQuantityIndex(QuantityIndex.area);
        SetComboBoxText(GetSelectedQuantityIndex());
        ClearAll();
    }

    protected void VolumeButtonClicked(object sender, System.EventArgs e)
    {
        SetSelectedQuantityIndex(QuantityIndex.volume);
        SetComboBoxText(GetSelectedQuantityIndex());
        ClearAll();
    }

    protected void TimeButtonClicked(object sender, System.EventArgs e)
    {
        SetSelectedQuantityIndex(QuantityIndex.time);
        SetComboBoxText(GetSelectedQuantityIndex());
        ClearAll();
    }

    protected void SpeedButtonClicked(object sender, System.EventArgs e)
    {
        SetSelectedQuantityIndex(QuantityIndex.speed);
        SetComboBoxText(GetSelectedQuantityIndex());
        ClearAll();
    }

    protected void FlowAreaButtonClicked(object sender, System.EventArgs e)
    {
        SetSelectedQuantityIndex(QuantityIndex.flowArea);
        SetComboBoxText(GetSelectedQuantityIndex());
        ClearAll();
    }

    protected void FlowVolumeButtonClicked(object sender, System.EventArgs e)
    {
        SetSelectedQuantityIndex(QuantityIndex.flowVolume);
        SetComboBoxText(GetSelectedQuantityIndex());
        ClearAll();
    }

    protected void FlowMassButtonClicked(object sender, System.EventArgs e)
    {
        SetSelectedQuantityIndex(QuantityIndex.flowMass);
        SetComboBoxText(GetSelectedQuantityIndex());
        ClearAll();
    }

    protected void MassButtonClicked(object sender, System.EventArgs e)
    {
        SetSelectedQuantityIndex(QuantityIndex.mass);
        SetComboBoxText(GetSelectedQuantityIndex());
        ClearAll();
    }

    protected void EnergyButtonClicked(object sender, System.EventArgs e)
    {
        SetSelectedQuantityIndex(QuantityIndex.energy);
        SetComboBoxText(GetSelectedQuantityIndex());
        ClearAll();
    }

    protected void PressureButtonClicked(object sender, System.EventArgs e)
    {
        SetSelectedQuantityIndex(QuantityIndex.pressure);
        SetComboBoxText(GetSelectedQuantityIndex());
        ClearAll();
    }

    protected void TemperatureButtonClicked(object sender, System.EventArgs e)
    {
        SetSelectedQuantityIndex(QuantityIndex.temperature);
        SetComboBoxText(GetSelectedQuantityIndex());
        ClearAll();
    }

    protected void LuminanceButtonClicked(object sender, System.EventArgs e)
    {
        SetSelectedQuantityIndex(QuantityIndex.luminance);
        SetComboBoxText(GetSelectedQuantityIndex());
        ClearAll();
    }

    protected void IlluminanceButtonClicked(object sender, System.EventArgs e)
    {
        SetSelectedQuantityIndex(QuantityIndex.illuminance);
        SetComboBoxText(GetSelectedQuantityIndex());
        ClearAll();
    }

    protected void AngleButtonClicked(object sender, System.EventArgs e)
    {
        SetSelectedQuantityIndex(QuantityIndex.angle);
        SetComboBoxText(GetSelectedQuantityIndex());
        ClearAll();
    }

    protected void DataSizeClick(object sender, System.EventArgs e)
    {
        SetSelectedQuantityIndex(QuantityIndex.dataSize);
        SetComboBoxText(GetSelectedQuantityIndex());
        ClearAll();
    }

    protected void Calculate()
    {
        if ((string)InputBox.Text != "" && FromUnitPicker.Active > -1 && ToUnitPicker.Active > -1)
        {
            double.TryParse(InputBox.Text, out double inputValue);
            string fromUnitName = FromUnitPicker.ActiveText;
            string toUnitName = ToUnitPicker.ActiveText;
            double result = unitConverterProgram.CalculateByUnitName(inputValue, fromUnitName, toUnitName, GetSelectedQuantityIndex());
            OutputBox.Text = result.ToString();
        }
    }

    protected void InputTextInserted(object o, TextInsertedArgs args)
    {
        Calculate();
    }

    protected void InputTextDeleted(object o, TextDeletedArgs args)
    {
        Calculate();
    }

    protected void InputBoxSelectedChanged(object sender, System.EventArgs e)
    {
        Calculate();
    }

    protected void OutputBoxSelectedChanged(object sender, System.EventArgs e)
    {
        Calculate();
    }

    protected void QuitSelected(object sender, System.EventArgs e)
    {
        Environment.Exit(0);
    }

    protected void ClearAll()
    {
        InputBox.Text = "";
    }

    protected void ClearButtonClicked(object sender, EventArgs e)
    {
        ClearAll();
    }

    protected void SwapButtonClicked(object sender, EventArgs e)
    {
        int temp = FromUnitPicker.Active;
        FromUnitPicker.Active = ToUnitPicker.Active;
        ToUnitPicker.Active = temp;
    }

    protected void NoRoundingOffSelected(object sender, EventArgs e)
    {
        unitConverterProgram.SetRoundOffValue(-1);
        Calculate();
    }

    protected void WholeNumberSelected(object sender, EventArgs e)
    {
        unitConverterProgram.SetRoundOffValue(0);
        Calculate();
    }

    protected void DP1Selected(object sender, EventArgs e)
    {
        unitConverterProgram.SetRoundOffValue(1);
        Calculate();
    }

    protected void DP2Selected(object sender, EventArgs e)
    {
        unitConverterProgram.SetRoundOffValue(2);
        Calculate();
    }

    protected void DP3Selected(object sender, EventArgs e)
    {
        unitConverterProgram.SetRoundOffValue(3);
        Calculate();
    }

    protected void DP4Selected(object sender, EventArgs e)
    {
        unitConverterProgram.SetRoundOffValue(4);
        Calculate();
    }

    protected void DP5Selected(object sender, EventArgs e)
    {
        unitConverterProgram.SetRoundOffValue(5);
        Calculate();
    }

    protected void DP6Selected(object sender, EventArgs e)
    {
        unitConverterProgram.SetRoundOffValue(6);
        Calculate();
    }

    protected void DP7Selected(object sender, EventArgs e)
    {
        unitConverterProgram.SetRoundOffValue(7);
        Calculate();
    }

    protected void DP8Selected(object sender, EventArgs e)
    {
        unitConverterProgram.SetRoundOffValue(8);
        Calculate();
    }

    protected void DP9Selected(object sender, EventArgs e)
    {
        unitConverterProgram.SetRoundOffValue(9);
        Calculate();
    }

    protected void DP10Selected(object sender, EventArgs e)
    {
        unitConverterProgram.SetRoundOffValue(10);
        Calculate();
    }
}