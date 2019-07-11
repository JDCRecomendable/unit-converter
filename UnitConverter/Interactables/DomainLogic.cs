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

        public Unit GetUnitByName(int quantityIndex, string unitName)
        {
            return unitManipulator.GetUnitByName(quantityIndex, unitName);
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

        public short GetRoundOffValue()
        {
            return calculationHandler.GetRoundOffValue();
        }

        public void SetRoundOffValue(short value)
        {
            calculationHandler.SetRoundOffValue(value);
        }

        /// <summary>
        /// <para>Pass in scope = 0 when only wanting to list pre-defined units.</para>
        /// <para>Pass in scope = 1 when only wanting to list custom units.</para>
        /// <para>Pass in scope = -1 or leave empty when wanting to get all units.</para>
        /// </summary>
        /// <param name="quantityIndex"></param>
        /// <param name="scope"></param>
        /// <returns></returns>
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

        public void CreateAndAddUnitWithBase(int quantityIndex, string name, double gradient, double intercept, Unit unitBase)
        {
            AddUnit(quantityIndex, CreateUnitWithBase(name, gradient, intercept, unitBase));
        }

        public Unit CreateUnitWithBase(string name, double gradient, double intercept, Unit unitBase)
        {
            double rGradient = unitBase.GetGradient();
            double rIntercept = unitBase.GetIntercept();
            return new Unit(name,
                gradient * rGradient,
                intercept * rGradient + rIntercept);
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
    }
}
