using System;
using System.Collections.Generic;

namespace UnitConverter
{
    static class Program
    {
        static void Main() { }
    }

    public class UnitConverterProgram
    {
        private UnitManipulator unitManipulator = new UnitManipulator();
        private CalculationHandler calculationHandler = new CalculationHandler();

        public UnitConverterProgram()
        {
            PreDefinedUnitsLoader.LoadAllPreDefinedUnits(unitManipulator);
        }

        public double CalculateByUnitName(double value, string fromUnitString, string toUnitString, int quantityIndex)
        {
            Unit fromUnit = unitManipulator.GetUnitByName(quantityIndex, fromUnitString);
            Unit toUnit = unitManipulator.GetUnitByName(quantityIndex, toUnitString);

            return Calculate(value, fromUnit, toUnit);
        }

        public double Calculate(double value, Unit fromUnit, Unit toUnit)
        {
            return calculationHandler.Calculate(value, fromUnit, toUnit);
        }

        public void GetRoundOffValue()
        {
            calculationHandler.GetRoundOffValue();
        }

        public void SetRoundOffValue(short value)
        {
            calculationHandler.SetRoundOffValue(value);
        }

        public List<string> GetUnitsNamesForQuantity(int quantityIndex, short scope=-1)
        {
            List<string> resultList = new List<string>();
            List<Unit> unitList = GetUnitsForQuantity(quantityIndex, scope);

            foreach (Unit unit in unitList)
                resultList.Add(unit.GetName());

            return resultList;
        }

        public List<Unit> GetUnitsForQuantity(int quantityIndex, short scope=-1)
        {
            if (scope == 0)
                return unitManipulator.GetPreDefinedUnits(quantityIndex);
            if (scope == 1)
                return unitManipulator.GetCustomUnits(quantityIndex);
            return unitManipulator.GetAllUnits(quantityIndex);
        }

        public void CreateAndAddUnit(int quantityIndex, string name, double gradient, double intercept)
        {
            AddUnit(quantityIndex, CreateUnit(name, gradient, intercept));
        }

        public Unit CreateUnit(string name, double gradient, double intercept)
        {
            return new Unit(name, gradient, intercept);
        }

        public void AddUnit(int quantityIndex, Unit unit)
        {
            unitManipulator.AddUnit(quantityIndex, unit);
        }

        public void RemoveUnitByName(int quantityIndex, string unitName)
        {
            Unit unit = unitManipulator.GetUnitByName(quantityIndex, unitName);
            RemoveUnit(quantityIndex, unit);
        }

        public void RemoveUnit(int quantityIndex, Unit unit)
        {
            unitManipulator.RemoveUnit(quantityIndex, unit);
        }

        public void RemoveUnitsByName(int quantityIndex, List<string> unitNames)
        {
            List<Unit> unitList = new List<Unit>();

            foreach (string unitName in unitNames)
                unitList.Add(unitManipulator.GetUnitByName(quantityIndex, unitName));

            RemoveUnits(quantityIndex, unitList);
        }

        public void RemoveUnits(int quantityIndex, List<Unit> units)
        {
            unitManipulator.RemoveUnits(quantityIndex, units);
        }
    }
}
