using System.Collections.Generic;

namespace UnitConverter
{
    static class Program
    {
        static void Main() { }
    }

    /// <summary>
    /// Class definition to link the domain logic of the program and the front-end.
    /// </summary>
    public class UnitConverterProgram
    {
        private UnitManipulator unitManipulator = new UnitManipulator();
        private CalculationHandler calculationHandler = new CalculationHandler();

        public UnitConverterProgram()
        {
            PreDefinedUnitsLoader.LoadAllPreDefinedUnits(unitManipulator);
        }

        /// <summary>
        /// Return a Unit object representing the unit that is wanted.
        /// <para>The user should input the quantity index (i.e. the physical
        /// quantity that the unit represents) and the exact name of the
        /// unit.</para>
        /// </summary>
        /// <param name="quantityIndex"></param>
        /// <param name="unitName"></param>
        public Unit GetUnitByName(int quantityIndex, string unitName)
        {
            return unitManipulator.GetUnitByName(quantityIndex, unitName);
        }

        /// <summary>
        /// Return a double containing the calculation result. (uses strings
        /// to identify the units for conversion)
        /// <para>The user should input the value to calculate, the exact name of the
        /// "from unit" and the "to unit" and the quantity index (i.e. the
        /// physical quantity that the unit represents).</para>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="fromUnitString"></param>
        /// <param name="toUnitString"></param>
        /// <param name="quantityIndex"></param>
        public double CalculateByUnitName(double value, string fromUnitString, string toUnitString, int quantityIndex)
        {
            Unit fromUnit = unitManipulator.GetUnitByName(quantityIndex, fromUnitString);
            Unit toUnit = unitManipulator.GetUnitByName(quantityIndex, toUnitString);

            return Calculate(value, fromUnit, toUnit);
        }

        /// <summary>
        /// Return a double containing the calculation result.
        /// <para>The user should input the value to calculate, the "from unit" and
        /// "to unit" objects and the quantity index (i.e. the physical
        /// quantity that the unit represents).</para>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="fromUnit"></param>
        /// <param name="toUnit"></param>
        public double Calculate(double value, Unit fromUnit, Unit toUnit)
        {
            return calculationHandler.Calculate(value, fromUnit, toUnit);
        }

        /// <summary>
        /// Return the current precision setting for calculations.
        /// <para>-1 for not rounding off. 0 for round off to nearest whole
        /// number. 1 onwards for the number of decimal places.</para>
        /// </summary>
        public short GetRoundOffValue()
        {
            return calculationHandler.GetRoundOffValue();
        }

        /// <summary>
        /// Set the precision setting for calculations.
        /// <para>-1 for not rounding off. 0 for round off to nearest whole
        /// number. 1 onwards for the number of decimal places.</para>
        /// </summary>
        /// <param name="value"></param>
        public void SetRoundOffValue(short value)
        {
            calculationHandler.SetRoundOffValue(value);
        }

        /// <summary>
        /// Return a list of strings containing the exact names of units.
        /// <para>Pass in scope = 0 when only wanting to list pre-defined units.</para>
        /// <para>Pass in scope = 1 when only wanting to list custom units.</para>
        /// <para>Pass in scope = -1 or leave empty when wanting to get all units.</para>
        /// </summary>
        /// <param name="quantityIndex"></param>
        /// <param name="scope"></param>
        public List<string> GetUnitsNamesForQuantity(int quantityIndex, short scope=-1)
        {
            List<string> resultList = new List<string>();
            List<Unit> unitList = GetUnitsForQuantity(quantityIndex, scope);

            foreach (Unit unit in unitList)
                resultList.Add(unit.GetName());

            return resultList;
        }

        /// <summary>
        /// Return a list of Unit objects containing the exact names of units.
        /// <para>Pass in scope = 0 when only wanting to list pre-defined units.</para>
        /// <para>Pass in scope = 1 when only wanting to list custom units.</para>
        /// <para>Pass in scope = -1 or leave empty when wanting to get all units.</para>
        /// </summary>
        /// <param name="quantityIndex"></param>
        /// <param name="scope"></param>
        public List<Unit> GetUnitsForQuantity(int quantityIndex, short scope=-1)
        {
            if (scope == 0)
                return unitManipulator.GetPreDefinedUnits(quantityIndex);
            if (scope == 1)
                return unitManipulator.GetCustomUnits(quantityIndex);
            return unitManipulator.GetAllUnits(quantityIndex);
        }

        /// <summary>
        /// Create and automatically add a unit to the program.
        /// <para>The user should pass in the quantity index (i.e. the
        /// physical quantity that the unit represents), the name of the unit,
        /// the gradient of the unit relative to the unit it is based on,
        /// the y-intercept of the unit relative to the unit it is based on,
        /// and the unit it is based on/modelled after.</para>
        /// </summary>
        /// <param name="quantityIndex"></param>
        /// <param name="name"></param>
        /// <param name="gradient"></param>
        /// <param name="intercept"></param>
        /// <param name="unitBase"></param>
        public void CreateAndAddUnitWithBase(int quantityIndex, string name, double gradient, double intercept, Unit unitBase)
        {
            AddUnit(quantityIndex, CreateUnitWithBase(name, gradient, intercept, unitBase));
        }

        /// <summary>
        /// Create a unit for adding to the program.
        /// <para>The user should pass in the name of the unit,
        /// the gradient of the unit relative to the unit it is based on,
        /// the y-intercept of the unit relative to the unit it is based on,
        /// and the unit it is based on/modelled after.</para>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="gradient"></param>
        /// <param name="intercept"></param>
        /// <param name="unitBase"></param>
        public Unit CreateUnitWithBase(string name, double gradient, double intercept, Unit unitBase)
        {
            double rGradient = unitBase.GetGradient();
            double rIntercept = unitBase.GetIntercept();
            return new Unit(name,
                gradient * rGradient,
                intercept * rGradient + rIntercept);
        }

        /// <summary>
        /// Add a unit to the program, to be included in the list of units
        /// for the physical quantity that it represents.
        /// <para>The user should pass in the quantity index (i.e. the
        /// physical quantity that the unit represents) and the Unit object
        /// to add.</para>
        /// </summary>
        /// <param name="quantityIndex"></param>
        /// <param name="unit"></param>
        public void AddUnit(int quantityIndex, Unit unit)
        {
            unitManipulator.AddUnit(quantityIndex, unit);
        }

        /// <summary>
        /// Remove a unit from the program, from the list of units
        /// for the physical quantity that it represents. (by name)
        /// <para>The user should pass in the quantity index (i.e. the
        /// physical quantity that the unit represents) and the Unit object
        /// to remove.</para>
        /// </summary>
        /// <param name="quantityIndex"></param>
        /// <param name="unitName"></param>
        public void RemoveUnitByName(int quantityIndex, string unitName)
        {
            Unit unit = unitManipulator.GetUnitByName(quantityIndex, unitName);
            RemoveUnit(quantityIndex, unit);
        }

        /// <summary>
        /// Remove a unit from the program, from the list of units
        /// for the physical quantity that it represents.
        /// <para>The user should pass in the quantity index (i.e. the
        /// physical quantity that the unit represents) and the Unit object
        /// to remove.</para>
        /// </summary>
        /// <param name="quantityIndex"></param>
        /// <param name="unitName"></param>
        public void RemoveUnit(int quantityIndex, Unit unit)
        {
            unitManipulator.RemoveUnit(quantityIndex, unit);
        }
    }
}
